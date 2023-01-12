use master
go

create database ManageStudent
go

use ManageStudent
go

create table tblStudent (
	stuId varchar(50) primary key,
	stuPass varchar(50),
	stuName nvarchar(255),
	stuGender varchar(3),
	stuAddress nvarchar(255),
	stuPhone varchar(10),
	stuEmail varchar(255),
)

drop table if exists tblSubject
create table tblSubject (
	subjectId int primary key identity,
	subjectName nvarchar(255),
	semeter int,
)	

drop table if exists tblExam
create table tblExam(
	subjectId int,
	stuId varchar(50),
	examName varchar(50),
	mark1st int,
	mark2nd int default null,
	"status" ntext default null,
	primary key (subjectId, stuId)
)

drop table if exists tblDept
create table tblDept (
	deptId varchar(50) primary key,
	deptName varchar(255),
	deptAddress nvarchar(255),
	deptPhone varchar(10) unique
)

create table tblTot (
	totId int identity primary key,
	totName nvarchar(255)
)

drop table if exists tblCource
create table tblCource (
	couId varchar(50) primary key,
	couName varchar(255),
	couSemeter int
)

drop table if exists tblClass
create table tblClass (
	classId varchar(50) primary key,
	className varchar(255),
	deptId varchar(50),
	totId int,
	couId varchar(50)
)

create table tblClassDetail (
	stuId varchar(50),
	classId varchar(50),
	primary key (stuId,classId)
)

-- insert cource
insert into tblCource ( couId, couName, couSemeter) values ( 'K030', 'Khoa 030', 1)
insert into tblCource ( couId, couName, couSemeter) values ( 'K031', 'Khoa 031', 1)
insert into tblCource ( couId, couName, couSemeter) values ( 'K040', 'Khoa 040', 2)
insert into tblCource ( couId, couName, couSemeter) values ( 'K041', 'Khoa 041', 2)
insert into tblCource ( couId, couName, couSemeter) values ( 'K050', 'Khoa 050', 3)
insert into tblCource ( couId, couName, couSemeter) values ( 'K051', 'Khoa 051', 3)
-- insert type of training
insert into tblTot ( totName) values (N'Hệ Chính Quy')
insert into tblTot ( totName) values (N'Hệ Cao Đẳng')
insert into tblTot ( totName) values (N'Hệ Liên Thong')
-- insert department
insert into tblDept (deptId, deptName, deptAddress, deptPhone) values ( 'CNTT', 'Cong Nghe Thong Tin', 'Quận 6, TP HCM', '01234556')
insert into tblDept (deptId, deptName, deptAddress, deptPhone) values ( 'MKT', 'Marketing', 'Quận 7, TP HCM', '01234590')
insert into tblDept (deptId, deptName, deptAddress, deptPhone) values ( 'SKDA', 'San Khau Dien Anh', 'Quận 1, TP HCM', '01234599')
insert into tblDept (deptId, deptName, deptAddress, deptPhone) values ( 'YD', 'Y Duoc', 'Quận 7, TP HCM', '012345911')
-- insert subject
insert into tblSubject(subjectName, semeter) values (N'Triết Học', 1)
insert into tblSubject(subjectName, semeter) values (N'Tin Học Văn Phòng', 1)
insert into tblSubject(subjectName, semeter) values (N'Tin Học Nâng Cao', 2)
insert into tblSubject(subjectName, semeter) values (N'Cơ Sở Dữ Liệu', 2)
insert into tblSubject(subjectName, semeter) values (N'Cấu Trúc Dữ Liệu và Giải Thuật', 2)
insert into tblSubject(subjectName, semeter) values (N'Lập Trình Căn Bản', 3)
insert into tblSubject(subjectName, semeter) values (N'Lập Trình OOP', 3)
insert into tblSubject(subjectName, semeter) values (N'Thiết Kế Web', 3)
insert into tblSubject(subjectName, semeter) values (N'Lập Trình Window App', 4)
insert into tblSubject(subjectName, semeter) values (N'Lập Trình AI', 4)
-- insert student
insert into tblStudent (stuId, stuPass, stuName, stuGender, stuAddress, stuPhone, stuEmail) values ('Stu101203', '01234567', N'Quách Thị Diệu Hiền', 'Nu', N'Hiệp An, Bình Thuận', '01212132', 'dhien@gmail.com')
insert into tblStudent (stuId, stuPass, stuName, stuGender, stuAddress, stuPhone, stuEmail) values ('Stu050203', '0335167226a', N'Đoàn Tuấn Anh', 'Nam', N'Quận 6, TP HCM', '0335167226', 'dta@gmail.com')
insert into tblStudent (stuId, stuPass, stuName, stuGender, stuAddress, stuPhone, stuEmail) values ('Stu010103', '01234567aa', N'Nguyễn Hoàng Khải', 'Nam', N'Quận 1, TP HCM', '0121213221', 'nhk@gmail.com')
-- insert class
insert into tblClass ( classId, className, deptId, totId, couId) values ( 'C01', 'Class 01', 'CNTT', 1, 'K030')
insert into tblClass ( classId, className, deptId, totId, couId) values ( 'C02', 'Class 02', 'MKT', 1, 'K030')
insert into tblClass ( classId, className, deptId, totId, couId) values ( 'C03', 'Class 03', 'CNTT', 1, 'K030')
insert into tblClass ( classId, className, deptId, totId, couId) values ( 'C04', 'Class 04', 'SKDA', 1, 'K030')
insert into tblClass ( classId, className, deptId, totId, couId) values ( 'C05', 'Class 05', 'CNTT', 1, 'K030')
insert into tblClass ( classId, className, deptId, totId, couId) values ( 'C06', 'Class 06', 'CNTT', 1, 'K030')
-- insert exam
insert into tblExam ( subjectId, stuId, examName, mark1st, "status") values ( 1, 'Stu101203', N'kiểm tra hết môn', 8,'')
insert into tblExam ( subjectId, stuId, examName, mark1st, "status") values ( 1, 'Stu050203', N'kiểm tra hết môn', 7, '')
insert into tblExam ( subjectId, stuId, examName, mark1st, mark2nd, "status") values ( 1, 'Stu010103', N'kiểm tra hết môn', 3, 7, '')
-- insert classDetail
insert into tblClassDetail(stuId, classId) values ('Stu050203', 'C01')
insert into tblClassDetail(stuId, classId) values ('Stu050203', 'C02')
insert into tblClassDetail(stuId, classId) values ('Stu050203', 'C03')
insert into tblClassDetail(stuId, classId) values ('Stu050203', 'C06')
insert into tblClassDetail(stuId, classId) values ('Stu101203', 'C01')
insert into tblClassDetail(stuId, classId) values ('Stu101203', 'C02')
insert into tblClassDetail(stuId, classId) values ('Stu101203', 'C03')
insert into tblClassDetail(stuId, classId) values ('Stu101203', 'C06')
insert into tblClassDetail(stuId, classId) values ('Stu010103', 'C01')
insert into tblClassDetail(stuId, classId) values ('Stu010103', 'C03')
insert into tblClassDetail(stuId, classId) values ('Stu010103', 'C03')

alter table tblClassDetail
add constraint fk_Class_Student_1
foreign key (classId) references tblClass(classId)

alter table tblClassDetail
add constraint fk_Class_Student_2
foreign key (stuId) references tblStudent(stuId)

alter table tblExam
add constraint fk_Exam_1
foreign key (subjectId) references tblSubject(subjectId)

alter table tblExam
add constraint fk_Exam_2
foreign key (stuId) references tblStudent(stuId)

alter table tblClass
add constraint fk_tot_class
foreign key (totId) references tblTot(totId)

alter table tblClass
add constraint fk_dept_class
foreign key (deptId) references tblDept(deptId)

alter table tblClass
add constraint fk_cource_class
foreign key (couId) references tblCource(couId)