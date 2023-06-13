import datetime
import pandas as pd
from sklearn.linear_model import LinearRegression
from sqlalchemy import create_engine, Column, Integer, DateTime, Float, func
from sqlalchemy.orm import sessionmaker
from sqlalchemy.orm import declarative_base


def tahmin():
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


    # MaliyetZarari tablosu modeli
    class MaliyetZarari(Base):
        __tablename__ = 'maliyetzarari'

        Id = Column(Integer, primary_key=True)
        PersonID = Column(Integer)
        Yil = Column(Integer)
        Durum = Column(Integer)
        GunlukUcret = Column(Float)
        DevamsizGun = Column(Integer)
        Zarar = Column(Float)

        CreatedDate = Column(DateTime, default=func.now())
        UpdatedDate = Column(DateTime, onupdate=func.now())

    # ZararTahmini tablosu modeli
    class ZararTahmini(Base):
        __tablename__ = 'zarartahmini'

        Id = Column(Integer, primary_key=True)
        PersonID = Column(Integer)
        Yil = Column(Integer)
        TahminiZarar = Column(Float)

        CreatedDate = Column(DateTime, default=func.now())
        UpdatedDate = Column(DateTime, onupdate=func.now())

    # Veritabanından veri okuma
    query = "SELECT * FROM maliyetzarari"
    maliyet_zararlari = pd.read_sql_query(query, engine)

    if not maliyet_zararlari.empty:
        df = pd.read_sql_query(query, engine)

        # Sütunları int türüne dönüştürme
        df['PersonID'] = df['PersonID'].astype(int)
        df['Yil'] = df['Yil'].astype(int)
        df['DevamsizGun'] = df['DevamsizGun'].astype(int)

        # Veriyi işleme ve model eğitme
        X = df[['PersonID', 'Yil']]
        y = df['DevamsizGun']

        model = LinearRegression()
        model.fit(X, y)

        # Devamsızlık tahminleri
        calisanlar = df['PersonID'].unique()
        yil = datetime.datetime.now().year + 1

        for calisanid in calisanlar:
            # Tahmin yapma
            tahmin = model.predict([[calisanid, yil]])[0]

            # İlgili PersonID ve Yil için kaydın olup olmadığını kontrol etme
            existing_record = session.query(ZararTahmini).filter_by(PersonID=int(calisanid), Yil=int(yil)).first()

            if existing_record:
                # Kayıt güncelleme
                existing_record.TahminiZarar = tahmin
                existing_record.UpdatedDate = datetime.datetime.now()

            else:
                # Kayıt mevcut değilse yeni kayıt ekleme
                up_date = datetime.datetime.now()
                cre_date = datetime.datetime.now()
                new_record = ZararTahmini(PersonID=int(calisanid), Yil=int(yil), TahminiZarar=tahmin,
                                          CreatedDate=cre_date, UpdatedDate=up_date)
                session.add(new_record)

    session.commit()
    session.close()