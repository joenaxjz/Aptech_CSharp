use master
go

drop database if exists WFC2109I2
create database WFC2109I2
go

use WFC2109I2
go

create table student (
	Id int primary key identity,
	FirstName nvarchar(50),
	LastName nvarchar(50),
	Gender bit,
	DoB date
	)
go

insert into student (FirstName, LastName, Gender, DoB)
values (N'Đoàn', N'Tuấn Anh', 1, '2003-02-05')
go 4
insert into student (FirstName, LastName, Gender, DoB)
values (N'Nguyễn', N'Hoàng Khải', 1, '2003-01-01')
go 3
insert into student (FirstName, LastName, Gender, DoB)
values (N'Quách Thị', N'Diệu Hiền', 0, '2003-12-10')
go 3


create proc updateStu
@FirstName nvarchar(50), @LastName nvarchar(50), @Gender bit, @DoB date, @Id int
as
begin
	update Student set FirstName = @FirstName, LastName = @LastName, Gender = @Gender, DoB = @DoB
	where Id = @Id
end
go

create proc delStu
@Id int
as
begin
	delete  from Student where Id = @Id
end
go

create proc addStu
@FirstName nvarchar(50), @LastName nvarchar(50), @Gender bit, @DoB date
as
begin
	insert into student (FirstName, LastName, Gender, DoB) values ( @FirstName, @LastName, @Gender, @DoB)
end
go