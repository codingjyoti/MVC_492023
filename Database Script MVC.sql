create  database MVC_492023
use MVC_492023

create table tblemployee
(empid int primary key identity,
name  varchar(50),
salary int,
age int
)
select * from 

create proc employeeInsert
@name varchar(50),
@salary int,
@age int
as
begin
insert into tblemployee(name,salary,age)values(@name,@salary,@age)
end