select 4+9 As MyAnswer;
GO
select 15-26 As Balance;
GO 
select 24*4 As MyResponse;
GO
select 48/4 As Result;
GO 
select 'Hello World' As ColumnName

 -- dbo:- Database Owner
-- create table tblSecond (mynumbers int);

 select * from INFORMATION_SCHEMA.COLUMNS
 select * from INFORMATION_SCHEMA.TABLES

 insert into tblSecond (mynumbers) values (123)
 insert into tblSecond (mynumbers) values (234)
 insert into tblSecond (mynumbers) values (345)
 insert into tblSecond (mynumbers) values (678)
 insert into tblSecond (mynumbers) values (789),(9101)
 insert into tblSecond (mynumbers) values (511),(611)

 select * from tblFirst
 select * from tblSecond

 select mynumbers from tblSecond

 select * from dbo.tblFirst
 select * from dbo.tblSecond
 select * from [tblFirst]
 select * from [tblSecond]

select * from dbo.tblSecond
TRUNCATE TABLE dbo.tblSecond

select * from dbo.tblFirst 

delete from tblFirst
truncate table tblFirst 
drop table tblFirst
delete from tblSecond
truncate table tblSecond 
drop table tblSecond

create table tblPrimeNumbers (intField int);

insert into tblPrimeNumbers values (2),(3),(5),(7);

select * from tblPrimeNumbers;

delete from tblPrimeNumbers;
drop table tblPrimeNumbers;

create table tblPrimeNumbers (intField int);

select * from tblPrimeNumbers;

insert into tblPrimeNumbers values (2);
insert into tblPrimeNumbers values (3);
insert into tblPrimeNumbers values (5);
insert into tblPrimeNumbers values (7);

select * from tblPrimeNumbers


insert into tblPrimeNumbers2 values (2),(3),(5),(7);

select * from tblPrimeNumbers2;

delete from tblPrimeNumbers2;
drop table tblPrimeNumbers2;

create table tblPrimeNumbers2 (intField int);

select * from tblPrimeNumbers;

insert into tblPrimeNumbers2 values (2);
insert into tblPrimeNumbers2 values (3);
insert into tblPrimeNumbers2 values (5);
insert into tblPrimeNumbers2 values (7);

select * from tblPrimeNumbers2;
select * from tblPrimeNumbers2;

delete from tblPrimeNumbers2;
drop table tblPrimeNumbers2 ;
select * from tblPrimeNumbers2;

select * from tblPrimeNumbers2;

use [70-461]
go

create table tblEmployee
(EmployeeNumber int, 
 EmployeeName varchar(50));

 select 1+1 as result
 select 1/1 as result
 select 1/0 as result
 select 1/1 as result

