create	table student(
student_id int primary key,
student_name nvarchar(50),
student_address nvarchar(255),
student_age int)
go
insert into student (student_name,student_address,student_age) values ('nhan','hue',18)
insert into student (student_name,student_address,student_age) values ('my','quang dien',19)
insert into student (student_name,student_address,student_age) values ('tri','phu loc', 20)

go
select*from student
delete  student where student_age >18 and  student_age<20
go
select*from student
update student
set student_name='abc',student_address='quang tri',student_age=22
where student_id=3;
go
select*from student
