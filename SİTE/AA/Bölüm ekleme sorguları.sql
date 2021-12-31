
use [202516044]
go

create table Bolum
    (Id int identity primary key, Ad varchar(50))

create table Ogrenci 
(    Id int identity primary key , Ad varchar(50), BolumId int,
    constraint FK_Ogernci_Bolum foreign key(BolumId)
            references Bolum(Id) on delete cascade 
)

go

insert Bolum(Ad) values ('Bilgisayar'),('Makine'), ('Elektirik')
insert Ogrenci(Ad, BolumId)
values ('Ali',1) , ('Veli' ,2) ,('Selami' ,2) , ('Ayşe' ,2 ) , ('Oya',3 ), ('Tolga' , 3)

update Bolum set Ad='Pazarlama' where Ad='Elektirik'
update Ogrenci set Ad='Sevgi' where Ad= 'Oya'

delete from Bolum where Ad='Makine'
delete from Ogrenci where Ad='Tolga'