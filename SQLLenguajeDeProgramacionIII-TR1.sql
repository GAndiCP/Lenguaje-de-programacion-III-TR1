set dateformat dmy
use master
if DB_ID ('IE_Carlos_Morales_Chimbote') is not null
   drop database IE_Carlos_Morales_Chimbote
go
create database IE_Carlos_Morales_Chimbote
go
use IE_Carlos_Morales_Chimbote

/*CREACION DE TABLAS*/
create table Estudiantes (
  id int primary key identity,
  Pnombre char(20)not null,
  Snombre char(20)not null,
  Papellido char(20)not null,
  Sapellido char(20)not null,
  Telefono char(9)not null,
  Celular char(9)not null,
  Direccion char(80)not null,
  Email char(30)not null,
  Fnacimiento char(20)not null,
  );

create table Estudiantes_cursos(
  idCursos int primary key identity,
  idEstudiantes int references Estudiantes(id),
  Matematicas int not null,
  Comunicacion int not null,
  Religion int not null,
  Historia int not null,
  Ciencias int not null,
  Civica int not null,
  Psicologia int not null,
  totalPorcentaje int not null,
  Observaciones char(20) not null,
  );

 /*INSERCION DE DATOS EN TABLAS*/
insert Estudiantes values 
('Manolo','Raul','Rojas','Mallqui','018574535','946372846','Av. Centurion lt A2','manolx@gmail.com','2003-05-13'),
('Allison','Maria','Pastor','Paredes','017746352','957463521','Av. Los lirios lt W2','marix@gmail.com','2003-08-12'),
('Josue','Damian','Alvarado','Correo','018573523','999364332','Av. Los brothers lt R02','damian@gmail.com','2002-06-23'),
('Cesar','Mauricio','Condori','Huerta','017466352','947735234','Av. Cerna F2','cesar@gmail.com','2002-04-11'),
('Hanna','Alexandra','Lavado','Martinez','017463554','947736221','Av. Peru lt T7','hanna@gmail.com','2002-03-17'),
('Ramiro','Otoniel','Chauca','Rivera','018476352','947736524','Av. Selda 4B','rambo@gmail.com','2003-12-22'),
('Marisol','Alva','Paredes','Marloon','018845324','997734210','Av. Hilda 9B','maryx@gmail.com','2003-06-03'),
('Cortana','Sisa','Monarca','Lapsus','018574444','946372233','Av. Pardos lt 2Q','cxrtxnx@gmail.com','2003-02-11');

insert Estudiantes_cursos values
(1,1,1,1,1,1,1,1,100,'Aprovado'),
(2,1,1,1,1,1,1,1,100,'Aprovado'),
(3,1,0,1,1,0,1,1,72,'Aprovado'),
(4,1,0,0,0,0,1,1,42,'Desaprobado'),
(5,1,0,0,1,1,1,1,72,'Aprovado'),
(6,0,0,0,0,0,0,0,0,'Desaprovado'),
(7,0,0,0,0,0,0,0,0,'Desaprovado'),
(8,0,0,0,0,0,0,0,0,'Desaprovado');
go

/*CREACION DEL PROCEDIMIENTO ALMACENADO*/
CREATE PROCEDURE SP_FUSION
   as select es.idEstudiantes,e.Pnombre,e.Papellido,e.Sapellido,es.Matematicas,es.Comunicacion,es.Religion, 
   es.Historia,es.Ciencias,es.Civica,es.Psicologia,es.totalPorcentaje,es.Observaciones from estudiantes e 
   inner join Estudiantes_cursos es on e.id = es.idEstudiantes;
go

/*EJECUCION DE PROCEDIMIENTOS ALMACENADOS*/
EXECUTE SP_FUSION