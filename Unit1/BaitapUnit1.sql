create table Khoa (
makhoa  varchar(10) ,
tenkhoa varchar (30),
dienthoai varchar(10))

go
create table GiangVien (
maGV int ,
hotenGV varchar (30),
luong decimal (5,2),
makhoa varchar(10))
go
create table SinhVien(
maSV int,
hotenSV varchar(30),
makhoa varchar(10),
namsinh int,
quequan varchar(50),

)
go
create table Detai(
maDT varchar(10),
tenDT varchar(30),
kinhphi int,
noiThucTap varchar(30))
go
create table HuongDan(
maSv int,
maDT varchar (10),
maGV int,
ketqua decimal (5,2))
go
insert into GiangVien (maGV,hotenGV,makhoa) values (1,'NgVanA','Dia li');
insert into GiangVien (maGV,hotenGV,makhoa) values (2,'NgVanB','CNTT');
go
insert into SinhVien (maSV,hotenSV,makhoa,namsinh,quequan) values (1,'Sv1','Dia li',1996,'hue');
insert into SinhVien (maSV,hotenSV,makhoa,namsinh,quequan) values (2,'Sv1','CNTT',1997,'da nang');
go
insert into Khoa (makhoa,tenkhoa,dienthoai) values ('MK1','Dia li',0113);
insert into Khoa (makhoa,tenkhoa,dienthoai) values ('MK2','CNTT',0114);
go
insert into Detai (maDT,tenDT,kinhphi,noiThucTap) values ('DT1','DialiXH',10000,'Cty abc');
insert into Detai (maDT,tenDT,kinhphi,noiThucTap) values ('DT2','DialiXH',20000,'Cty def');
go
