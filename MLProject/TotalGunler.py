import datetime
import pandas as pd
from hijridate import Hijri
from sqlalchemy import create_engine, Column, Integer, DateTime, Float, func, select
from sqlalchemy.orm import sessionmaker
from sqlalchemy.orm import declarative_base

# Veritabanına bağlantı kurma
db_username = 'postgres'
db_password = '1234'
db_host = 'localhost'
db_port = '5432'
db_name = 'IK'

db_url = f'postgresql://{db_username}:{db_password}@{db_host}:{db_port}/{db_name}'
engine = create_engine(db_url)

Base = declarative_base()
Session = sessionmaker(bind=engine)
session = Session()


def hafta_sonu_gunleri(yil):
    baslangic_tarihi = datetime.date(yil, 1, 1)  # Yılın başlangıç tarihi
    bitis_tarihi = datetime.date(yil, 12, 31)  # Yılın bitiş tarihi
    gun_sayisi = (bitis_tarihi - baslangic_tarihi).days + 1  # Yılın toplam gün sayısı
    hafta_sonu_sayisi = 0

    for i in range(gun_sayisi):
        gun = baslangic_tarihi + datetime.timedelta(days=i)
        if gun.weekday() >= 5:  # Cumartesi veya Pazar
            hafta_sonu_sayisi += 1

    return hafta_sonu_sayisi


def hafta_ici_resmi_tatiller(yil):
    # Türkiye'deki resmi tatillerin listesi
    resmi_tatiller = [
        datetime.date(yil, 1, 1),   # Yılbaşı
        datetime.date(yil, 4, 23),  # Ulusal Egemenlik ve Çocuk Bayramı
        datetime.date(yil, 5, 1),   # Emek ve Dayanışma Günü
        datetime.date(yil, 5, 19),  # Atatürk'ü Anma, Gençlik ve Spor Bayramı
        datetime.date(yil, 7, 15),  # Demokrasi ve Milli Birlik Günü
        datetime.date(yil, 8, 30),  # Zafer Bayramı
        datetime.date(yil, 10, 29)  # Cumhuriyet Bayramı
    ]

    hafta_ici_tatil_sayisi = 0
    for tatil in resmi_tatiller:
        if tatil.weekday() < 5:
            hafta_ici_tatil_sayisi += 1

    return hafta_ici_tatil_sayisi


def hafta_ici_bayram_gunleri(yil):
    year = 2 + int((yil-622) * 0.97023)
    # Hicri yılı Gregoryan yıla çevirme ve Ramazan Bayramı başlangıcı: Hicri yılın 10. ayının 1. günü
    baslangic_gregoryan_ramazan = Hijri(year, 10, 1)
    baslangic_gregoryan_ramazan = baslangic_gregoryan_ramazan.to_gregorian()
    ramazan_bayrami_baslangic = datetime.date(baslangic_gregoryan_ramazan.year, baslangic_gregoryan_ramazan.month,
                                              baslangic_gregoryan_ramazan.day)

    # Hicri yılı Gregoryan yıla çevirme ve Kurban Bayramı başlangıcı: Hicri yılın 12. ayının 10. günü
    baslangic_gregoryan_kurban = Hijri(year, 12, 10).to_gregorian()
    kurban_bayrami_baslangic = datetime.date(baslangic_gregoryan_kurban.year, baslangic_gregoryan_kurban.month,
                                             baslangic_gregoryan_kurban.day)

    hafta_ici_bayram_gunleri_sayisi = 0
    # Hafta içine denk gelen Ramazan Bayramı günlerini bulma
    ramazan_bayrami = ramazan_bayrami_baslangic
    for i in range(0, 2):
        if(ramazan_bayrami.weekday()+i) < 5:
            hafta_ici_bayram_gunleri_sayisi += 1

    # Hafta içine denk gelen Kurban Bayramı günlerini bulma
    kurban_bayrami = kurban_bayrami_baslangic
    for j in range(0, 3):
        if (kurban_bayrami.weekday()+j) < 5:
            hafta_ici_bayram_gunleri_sayisi += 1

    return hafta_ici_bayram_gunleri_sayisi


def total(gelecek_yil):
    # gelecek_yil = datetime.datetime.now().year + 1
    hafta_sonu_sayisi = hafta_sonu_gunleri(gelecek_yil)
    resmi_tatil_sayisi = hafta_ici_resmi_tatiller(gelecek_yil)
    bayram_gunleri_sayisi = hafta_ici_bayram_gunleri(gelecek_yil)

    kesin_gun = hafta_sonu_sayisi + resmi_tatil_sayisi + bayram_gunleri_sayisi
    return kesin_gun


class ZararTahmini(Base):
    __tablename__ = 'zarartahmini'

    Id = Column(Integer, primary_key=True)
    PersonID = Column(Integer)
    Yil = Column(Integer)
    TahminiZarar = Column(Float)

    CreatedDate = Column(DateTime, default=func.now())
    UpdatedDate = Column(DateTime, onupdate=func.now())


class TotalTahmin(Base):
    __tablename__ = 'totaltahmin'

    Id = Column(Integer, primary_key=True, autoincrement=True)
    Yil = Column(Integer, primary_key=True)
    CalisilmayanGunler = Column(Integer)
    TotalTahmin = Column(Float)

    CreatedDate = Column(DateTime, default=func.now())
    UpdatedDate = Column(DateTime, onupdate=func.now())


def totalkayitlar():
    # Kayıtları yıl bazında toplama ve kaydetme
    query = "SELECT * FROM zarartahmini"
    zarar_tahminleri = pd.read_sql_query(query, engine)

    if not zarar_tahminleri.empty:
        devamsiz_tahmin = session.query(
            ZararTahmini.Yil,
            func.sum(ZararTahmini.TahminiZarar).label('toplam_tahmin'),
        ).group_by(ZararTahmini.Yil)

        for tahmin in devamsiz_tahmin:
            # Yıl bazında toplama işlemini gerçekleştirme
            yil = tahmin.Yil
            toplam_tahmin = tahmin.toplam_tahmin

            existing_record = session.query(TotalTahmin).filter_by(Yil=yil).first()
            if existing_record:
                existing_record.TotalTahmin = toplam_tahmin
                existing_record.CalisilmayanGunler = total(yil)
                existing_record.UpdatedDate = datetime.datetime.now()
            else:
                up_date = datetime.datetime.now()
                cre_date = datetime.datetime.now()
                new_record = TotalTahmin(Yil=yil, CalisilmayanGunler=total(yil), TotalTahmin=toplam_tahmin,
                                         CreatedDate=cre_date, UpdatedDate=up_date)
                session.add(new_record)

    session.commit()
    session.close()