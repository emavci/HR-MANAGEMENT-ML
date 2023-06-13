import datetime
import pandas as pd
from sqlalchemy import create_engine, Column, Integer, DateTime, func, Float
from sqlalchemy.orm import sessionmaker
from sqlalchemy.orm import declarative_base


def devamsizlik():
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

    # PersonLeaves tablosu modeli
    class PersonLeaves(Base):
        __tablename__ = 'personleaves'

        Id = Column(Integer, primary_key=True)
        PersonID = Column(Integer)
        StartAt = Column(DateTime)
        EndAt = Column(DateTime)
        Status = Column(Integer)

        CreatedDate = Column(DateTime, default=func.now())
        UpdatedDate = Column(DateTime, onupdate=func.now())

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

    query = "SELECT * FROM personleaves"
    person_leaves = pd.read_sql_query(query, engine)

    if not person_leaves.empty:
        # PersonLeaves tablosundan verileri çekme ve devamsız günleri toplama
        devamsiz_gunler = session.query(
            PersonLeaves.PersonID,
            func.sum(func.date_part('day', PersonLeaves.EndAt - PersonLeaves.StartAt)).label('toplam_devamsizgun'),
            func.date_part('year', PersonLeaves.StartAt).label('Yil')
        ).group_by(PersonLeaves.PersonID, func.date_part('year', PersonLeaves.StartAt))

        # Her bir veri için işlemleri gerçekleştirme
        for row in devamsiz_gunler:
            person_id = row.PersonID
            toplam_devamsizgun = row.toplam_devamsizgun
            yil = row.Yil
            durum = 1
            ucret = 1

            # İlgili PersonID ve Yil için kaydın olup olmadığını kontrol etme
            existing_record = session.query(MaliyetZarari).filter_by(PersonID=person_id, Yil=yil).first()

            if existing_record:
                # Kayıt mevcut ise güncelleme
                zarar = durum * ucret * toplam_devamsizgun
                existing_record.Zarar = zarar
                existing_record.DevamsizGun = toplam_devamsizgun
                existing_record.UpdatedDate = datetime.datetime.now()
            else:
                # Kayıt mevcut değilse yeni kayıt ekleme
                up_date = datetime.datetime.now()
                cre_date = datetime.datetime.now()
                zarar = durum * ucret * toplam_devamsizgun
                new_record = MaliyetZarari(PersonID=person_id, Yil=yil, Durum=durum, GunlukUcret=ucret,
                                           DevamsizGun=toplam_devamsizgun,
                                           Zarar=zarar, CreatedDate=cre_date, UpdatedDate=up_date)
                session.add(new_record)

    session.commit()
    session.close()