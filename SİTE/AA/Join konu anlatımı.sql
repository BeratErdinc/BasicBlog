use [202516044]
go

--create table A 
--(
--	Id int primary key,
--	Ad varchar(20),
	
--)
--go
--create table B
--(
--	Id int primary key,
--	Ad varchar(20),
	
--)
--go
--insert A values (1,'Ali'),(2,'Veli'),(3,'Selami'),(4,'Tolga'),(5,'Murat'),(6,'Hasan')
--insert B values (1,'Ayse'),(2,'Oya'),(3,'Zeynep'),(4,'Yasemin'),(5,'Emel'),(6,'Filiz')

--cross
select * from A,B

--inner join
select * from A inner join B on A.Id=B.Id

--left join
select * from A left join B on A.Id=B.Id where B.Id is null

--right join
select * from A right join B on A.Id=B.Id where A.Id is null

--full join
select * from A full join B on A.Id=B.Id

--union
select * from A union select * from B

--except
select * from A except select * from B
select * from B except select * from A

--AnB  in
select * from A where A.Id in (select Id from B)

--A\B not in
select * from A where A.Id not in (select Id from B)

--AnB  exists
select * from A where exists(select*from B where A.Id=B.Id)

--A\B not exists
select * from A where not exists(select*from B where A.Id=B.Id)
