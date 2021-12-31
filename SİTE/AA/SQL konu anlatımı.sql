-- tablo sılme drop
-- oluşturma crate 
--create table (sütün adı tipi gibi ozellıkler yazılır)
-- her koddan sonra go yazılır
-- create database
--use vt1
--create table table1(ID, İNT COLUMN1 varchar(50),pk)
-- create table table 2 (ıd int column2 varchar(50),pk,fk)


--VERİ İLE İLGİLİ İŞLEMLER
-- Select (Seçme)/ Insert(Ekleme) /Update (Güncelleme) / Delete (Silme)

-- Select (seçme)
-- select sütün1, sütün2,...
-- from tablo1 
-- where koşul
--group by sütün1
-- having count()>0
-- order by sütün1 (sıralama yapılır)


--Insert (Ekleme)
-- Insert tablo adı(Sutunları belırtıyoruz) values(değeler1),(degerler2)
-- otomatık artan degere ınsert kullnılmz 
-- Örnek Insert BolumId (Ad) values (1,"Biligseyar")
--2. ekleme yontemı

-- INSERT- SELECT YONTEMİ
--Inster Bolum(Ad) select "Bılgıseyar"
-- Insert Bolum (Ad) select "PC"
-- TEK TEK EL ILE EKLEME

--birinci anahtarı identity otomatik artan sayı tablosu
-- bolum bıglılerını gostter
-- select * from bolum

-- identity ile tanımlanıs sutunlara deger ekelem acık
-- set identity_insert Bolum on
-- insert Bolum(Id,Ad) values(3, "Pazarlama")



--seçilen kayıtların
--olmayan bır tablo oluşturup olusuturaln tabloya eklenmesi
-- tablonun onceden oluşturmaması gerekır
--create table insert select

-- selecet sutun adları into yeni tablo adı from mevcut tablo adı

-- uptade (Guncelleme)
-- uptade tabla ad 
--set sutun1= değer1

-- uptade edılen kısım yazılır update ....
--set ad zeyıntılcıkık
--
-- delete
-- from hangı bolum
--where Id = kac olursa 


-- OKUL DBD verı tabanını oluşturan 
-- bolum ogrencı tablosuu oluştumra
-- bolum tablosundakı elektırık bolumlu talboyu pazarlama olarak degıstırme 
--bolum tablosuna  bılgıseyar, makine , elektırı,bolumler ekleme 
-- ogrencı tablosuna bilgisryar bolumu: ali,veli  --
-- makıne icin :selami,ayşe 
-- elektırık ıcın :oya  tolga, ogrencıler ekleme
-- ogrenci tablosunda  
--bolum tablosundan  bolum sılme
-- ogrencı tablosundan ogrencı sılme 
-- bolum bılgılerını secme
-- ogrencı bılgılerını secme



--Select

--select *--sutunlar* tum sutunlar
--from Ogrenci -- tablolar
--where BolumId=1	--kosullar, and/or ile bırlestırır
--group by BolumId -- sutunlara gore gruplama, sayma  min max ıslemlerı yapılır

--where
--karşıaştırma operator = <> > >= <=
--mantıksal operator and , or(veya)  ,not(değil)
--aralık kontrolu between deger 1 an and deger 2
-- metinlerdekı benzerlık kontrolu lıke% kısmı benzerlık
--null kontrolu ıse null, is not null




-- bolum ıd 2 olan ve adı a veya e ıle başlayan ogrencıler
--select
--from ogrenci
-- where BolumId=2 and (Ad like 'A%' or and like 'E%')
-- order by BolumId, Id

--soyadı kac harflı olcagını belırleme '____'


--Adının ilk harfıne gore ogrencı sayıları
--left:soldan left(sutun,karakter sayısı)
--right: sağdan right ( sutun, karakter sayısı)
--substring(sutun, başlangıc indeksi, karakter sayısı)
--select
--from Ogrenci
--where substring(Ad,1,1,)l4


-- sql srogusunda bırden fazla tabloyu bırlestırme (join)
--select
--from Ogrenci,Sehir
--where Ogrenci.DogumYer=Sehir.Id
--group by Sehir.ad
--having count(*)>50
--order by OgrSay desc



-- Birleştirme sorgularında tablolanırın guncelleme ve silme
--uptade - join


--update o
--set o.Sube='E'


--select*
--from Ogrenci o join Bolum b on o.BolumId=b.Id
--where b.Ad='Bilgisayar'
--and Ogretim=2



--In, Exists

--In:herhangi bir değerin, degerler kumesınde bulunasını kontrolu
-- Exists: alt sorgunun sonuc kumesının olup olmadıgının kontrolu

--select*
--from Bolum b
--where b.Id in (select  distinct BolumId from Ogrenci o )

--select *
--from Ogrenci
--where Ad in('Ali')
--and Soyad in ('BOZKURT' , 'ASLAN')

--cross join
-- A* B 


-- inner join
-- AnB



--left join left ouder join
-- A\B u AnB



-- right join
-- B\A u AnB

-- full join 
-- A\B u AnB B\A



