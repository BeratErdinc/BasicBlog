use OkulDb
go


--iif(kosul,dogru,yanlış)
--case degısken when durum1 then.... when durum2 then... else ... end
--select Cinsiyet,
--iif(cinsiyet='e','Erkek','Kadın'),
-- case Cinsiyet
-- when 'e' then 'Erkek'
-- when 'k' then 'Kadın'
-- end
-- from Ogrenci




-- declare , set , if-else , goto, while, cursor, try-catch

-- declare: değişken tanımlamak için kullanılır
-- değişken adları @ ile başlatılır
-- declare kullandıktan sonra deger vermek ıcın set veya select kullanılır
--print yazdırmak ıcın kullanılır print concat ....
-- concat ifadeleri birleştırmede kullanılır

--declare @b int, @f float=12.34
--set @b = 2 
--select @b = 2
--print concat ('toplam:',@f * @b)
-- se @a = cast(a@ as float) /@b
-- cast ve as float kalıbı tam sayı degerıne cevırır

--Makine Bolumundekı ERKEK OGRENCILER
--select * from Ogrenci o join Bolum b on o.BolumId=b.Id
--where b.Ad='Makine' and o.Cinsiyet='E'


--Geçiçi tablo oluşturma
--declare @bid int
--select @bid=Id from Bolum where Ad='Makine'
--declare @table1 table(Id int, Ad varchar(50))
--insert @table1(Id,Ad)
--select Id,Ad from Ogrenci where BolumId=@bid and Cinsiyet='E'
--select * from @table1

-- olan bolumu sorgulama
--declare @yeni_bolum_ad varchar(50)='Makine'
--if not exists(select*from Bolum where Ad='Makine')
--begin
--insert Bolum(Ad) values(@yeni_bolum_ad)
--print 'Bolum eklendi'
--end
--else 
--print 'BOLUM VAR'


-- bolum ekleme 
--declare @yeni_bolum_ad varchar(50)='Pazarlama'
--if not exists(select*from Bolum where Ad='Makine')
--begin
--insert Bolum(Ad) values(@yeni_bolum_ad)
--print 'Bolum eklendi'
--end
--else 
--print 'BOLUM VAR'




-- goto : belirtilen etikete yonlendırme yapılır

--declare @a int=0
--etiket:
--	   set @a+=1
--	   if @a=5 goto etiket
--	   print @a
--	   if @a<10
--	   goto etiket

-- while : döngü işlemi yapar begin .... end
--declare @b int = 0

--while @b< 10
--begin
--set @b+=1
--if @b= 5 continue -- 5 ı yazdırmaz 
--print @b
--end

-- cursor, try .. catch


--cursor (imlec):kayıtlar arasında satır satır dolaşmak

--cursor ile ilgili satırdakı verılerın tutucagı değişkenleri tanımlanması
--declare @id  int, @ad varchar (50)
---- cursorun tanımlanması ve uzerınde hareket edecegı sorgunun belırlenmesı
--declare imlec cursor for select Id,Ad from Bolum
----cursorun acılması
--open imlec


---- cursor ile satırlar arasında dolaşma
--while 1=1
--begin

---- satırlardaki degerlerin alınması
--fetch next from imlec into @id,@ad 
----@@FETCH_STATUS: kayit varsa 0 yoksa -1 
--if @@FETCH_STATUS<0 break
----cursorun bulundugu satırdaki verilen gosterılmesi
--print concat(@id,"-",@ad)


---- cursorun kapatılması
--close imlec
---- cursorun bellekten atılması
--deallocate imlec

-- XYZ ile başlayan verıtabanlarında tablo oluşturma

--declare @vt varchar (max)

--declare imlec cursor
--select name from sys.databases where name like 'XYZ'

--open imlec
--while 1=1
--begin 
--    fetch next from imlec into @vt
--	if @@FETCH_STATUS<0 break

--	declare @sql varchar(max) = 'use'+@vt+' '
--	set @sql += ' create table Table(id int ad varchar (10))'
--	set ---- cursorun kapatılması
----close imlec
------ cursorun bellekten atılması
----deallocate imlec@sql += 'insert into tablo (id,ad) values("1 ''deger'')'

--ÖĞRENCİSİ OLMAYAN BOLUMLERE RASTGELE 10 OGRENCININ EKLENMESİ

--declare @id int

--declare imlec cursor for select Id from Bolum
--open imlec

--while 1=1
--begin
--     fetch next from imlec into @id
--	 if	@@FETCH_STATUS<0 break
	  
--	  declare @ogrsay int =0

--	  select @ogrsay=count(*) from Ogrenci where BolumId=@id

--	  if @ogrsay=0
--	  begin

--	  declare @i int= 0
--	  while @i<10
--	  begin
--	            insert into Ogrenci(Ad,Numara) values ('ali',concat('0',@i))
--				set @i+=1

--	     end
--	  end
--end

--close imlec
--deallocate imlec

-- try... catch : hata ayıklama

declare @a int=5, @b int=0, @c int

begin try

set @c = @a/@b
print concat('Sonuc:',@c)
end try
begin catch
print @@error
print 'hata........'

end catch