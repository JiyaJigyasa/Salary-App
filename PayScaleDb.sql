create database PayScaleDb
use PayScaleDb




create table Salary(PayBand varchar(10) primary key not null,
BasicSalary float not null,
HRA as BasicSalary*0.10 persisted,
TA as BasicSalary*0.05 persisted,
DA as BasicSalary*0.05 persisted,
TDS as BasicSalary*0.10 persisted
)


insert into Salary(PayBand,BasicSalary) values
('Grade-A',40000.90),
('Grade-B',30000.50),
('Grade-C',20000.60)

select * from Salary





