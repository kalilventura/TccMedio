--Drop database Transportadora_Eagles
--use master
Create database Transportadora_Eagles

go 

Use Transportadora_Eagles

go
-----------------IMPORTAR TABELA DO CEP ANTES DE CONTINUAR!----------------------
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_CEP
	(
	CEP varchar(8) NOT NULL,
	UF char(2) NOT NULL,
	Descricao varchar(50) NOT NULL,
	Cidade varchar(30) NOT NULL,
	Bairro varchar(30) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_CEP SET (LOCK_ESCALATION = TABLE)
GO
IF EXISTS(SELECT * FROM dbo.tblLogradouros$)
	 EXEC('INSERT INTO dbo.Tmp_CEP (CEP, UF, Descricao, Cidade, Bairro)
		SELECT CONVERT(varchar(8), CEP), CONVERT(char(2), UF), CONVERT(varchar(50), Descricao), CONVERT(varchar(30), Cidade), CONVERT(varchar(30), Bairro) FROM dbo.tblLogradouros$ WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.tblLogradouros$
GO
EXECUTE sp_rename N'dbo.Tmp_CEP', N'CEP', 'OBJECT' 
GO
ALTER TABLE dbo.CEP ADD CONSTRAINT
	PK_CEP PRIMARY KEY CLUSTERED 
	(
	CEP
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
select Has_Perms_By_Name(N'dbo.CEP', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.CEP', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.CEP', 'Object', 'CONTROL') as Contr_Per 

go

------------------------------CORPORATIVO-----------------------------

Create table Sexo(
Codigo_sexo int identity(0,1),
Sexo varchar(9)null unique,
Primary key(Codigo_sexo))

go

insert into Sexo values (''),
('Feminino'),
('Masculino')

go

Create table Estado_civil
(Codigo_estado_civil int identity(0,1),
Estado_civil varchar(10) null unique,
Primary key(Codigo_estado_civil))

go

insert into Estado_civil values(''),
('Amasiado'),
('Casado'),
('Divorciado'),
('Solteiro'),
('Viuvo')

Create table Cargo(
Codigo_cargo int identity (0,1),
Cargo char(15) null unique,
Primary Key (Codigo_cargo))

go
insert into Cargo values (''),
('Recepcionista'),--1
('Gerente'),--4
('Motorista'),--1
('Contador'),--3
('Vendedor'),--2
('Diretor'),--4
('Serviços Gerais'),--1
('Segurança'),--1
('Encarregado'),--1
('Supervisor'),--4
('Técnico TI'),--5
('Limpeza')--5

go

create table Nacionalidade(
Codigo_nacionalidade int identity (0,1),
Pais varchar(20) null,
Nacionalidade varchar (15) null,
Primary key(Codigo_nacionalidade))

go

Insert into Nacionalidade values('','')
Insert into Nacionalidade values('Brasil','Brasileiro')
Insert into Nacionalidade values('Outro','Outro')

go

Create table Escolaridade(
Codigo_escolaridade int identity(0,1),
Escolaridade varchar(26) null unique,
Primary key(Codigo_escolaridade))

go

insert into Escolaridade values(''),
('Ensino Fundamental'),
('Ensino Fundamental/Técnico'),
('Ensino Médio'),
('Ensino Médio/Técnico'),
('Ensino Superior'),
('Especialização'),
('Mestrado'),
('Doutorado'),
('Pós-Doutorado')

go

Create table Funcionario(
Codigo_funcionario int identity (1,1),
Nome_Funcionario varchar(10) not null,
Sobreome_Funcionario varchar(40) not null,
Codigo_cargo int foreign key references Cargo(Codigo_cargo),
Logradouro varchar(50) not null,
Num int not null,
Complemento varchar(50) null,
Bairro varchar(30) not null,
Cidade varchar (20),
UF varchar(2),
CEP varchar(8) foreign key references CEP(CEP),
NIT_PIS_PASEP varchar(11) not null, ---XXX.XXXXX.XX-X
RG varchar(9) not null unique,--XX.XXX.XXX-X
Titulo_Eleitor varchar(12) not null unique, --XXXX.XXXX.XXXX
Carteira_Habilitacao varchar(11) null unique,---XXXXXXXXXXX
CPF varchar(11) not null unique, ---XXX.XXX.XXX-XX
Grau_Escolaridade int foreign key references Escolaridade(Codigo_escolaridade),
Sexo int foreign key references Sexo(Codigo_sexo),
Nacionalidade int foreign key references Nacionalidade(Codigo_nacionalidade),
EstadoCivil int foreign key references Estado_civil(Codigo_estado_civil),
Data_Nascimento date not null,
Email varchar(35) not null unique,
Atividade bit default 1,
Primary key(Codigo_funcionario)) 

go 

insert into Funcionario values('Alfredo','Silva', 11, 'Rua Marília', 123,'' , 'Jardim Paulista', 'Barueri', 'SP', '06447260', '12094617884', '403289440', '543275360116', '12344656789', '36374584031', 2, 2, 1, 4, '17-08-1986', 'alfredo@provedor.com',1),
('João','Oliveira', 2, 'Rua Princesa Isabel', 321,'' , 'Jardim Belval', 'Barueri', 'SP', '06420450', '12049323397', '448733109', '452083221724', '12345466780', '43354606940', 3, 2, 1, 3, '26-05-1972', 'joao@provedor.com',1),
('José','Augusto', 3, 'Rua Ruy Coelho', 91,'' , 'Pq. do 3º Lago', 'São Paulo', 'SP', '04870100', '12039252616', '429434121', '826082200035', '76098765476', '64712549467', 3, 2, 1, 3, '30-07-1972', 'jose@provedor.com',1),
('Marcos','Andrade',4,'Rua Aquario',11,'','Jd. São Silvestre','Barueri','SP','06408010', '12041598340', '911225341', '253346440540', '46098965476', '28263857554',3,2,1,3,'08-03-1986','Marcos@provedor.com',1),
('Paulo','Silva',5,'Rua Pinheiro',23,'','Chácaras Marco','Barueri','SP','06419120', '12027559169', '274206912', '553505611201', '22345656604','85345618690',3,2,1,3,'09-09-1994','Paulo@provedor.com.br',1),
('Felipe','Silva',6,'Rua Caracas',98,'','Vale do Sol','Barueri','SP','06437120','12069311831', '418757896', '884328631058', '45223843719', '87561626185',3,2,1,3,'08-04-1996','Felipe@provedor.com',1),
('Paulo','Amorim',7,'Rua São João',76,'','Vila Engenho Novo','Barueri','SP','06416280','12020544760', '151004511', '163131721740', '45243238719', '45844745329', 3,2,1,3,'18-09-1993','Paulo@provedor.com',1),
('Jorge','Willian',8,'Rua Almeida',08,'','Vila São Silvestre','Barueri','SP','06417020','12072288160', '111688644', '232884070124','09863969976', '12434284221',3,2,1,3,'08-09-1994','Jorge@provedor.com',1),
('Samuel','Domingues',9,'Alameda Antares',88,'','Residencial das Estrelas','Barueri','SP','06429060','12089832950', '219506127', '525708331120','83608294673', '83464613720',3,2,1,3,'08-09-1994','Samuel@provedor.com',1),
('Wilson','Soares',10,'Rua Dinamarca',187,'','Vila Engenho Novo','Barueri','SP','06416100','12086864541', '291239389', '226611680507', '52273433879', '51325220337',3,2,1,3,'08-09-1994','Wilson@provedor.com',1),
('Alessandra','Araújo',1,'Rua das Flores',100,'','Parque Viana','Barueri','SP','06449110','12037163390', '500209431', '607282521651', '45223837719', '97812146278',3,2,1,3,'08-09-1990','Alessandra@provedor.com',1),
('Andressa','Ferreira',12,'Rua Maria Adélia',97,'','Vila Universal','Barueri','SP','06407120','12091222153', '201239346', '061068160400', '45228254219', '47835014670',3,2,1,3,'08-09-1989','Andressa@provedor.com',1)
go

Create table Telefone_funcionario
(Codigo_funcionario int foreign key
references Funcionario(Codigo_funcionario),
Numero varchar(15) not null,
Operadora varchar(10),
Primary key(Numero))


go

insert into Telefone_funcionario values (1, '(011)92657-6789', 'Tim')
insert into Telefone_funcionario values (2, '(011)92398-5312', 'Vivo')
insert into Telefone_funcionario values (3, '(011)94568-6889', 'Oi')
insert into Telefone_funcionario values (4, '(011)99668-1256', 'Claro')
insert into Telefone_funcionario values (5, '(011)90562-8458', 'Oi')
insert into Telefone_funcionario values (6, '(011)95633-1899', 'Vivo')
insert into Telefone_funcionario values (7, '(011)95531-2899', 'Nextel')
insert into Telefone_funcionario values (8, '(011)95221-8896', 'Oi')
insert into Telefone_funcionario values (9, '(011)96522-1233', 'Tim')
insert into Telefone_funcionario values (10, '(011)95423-6698', 'Claro')
insert into Telefone_funcionario values (11, '(011)97896-7789', 'Claro')
insert into Telefone_funcionario values (12, '(011)94523-3641', 'Oi')

go

--Create table Empresa_terc

go

Create table Cliente(
Codigo_cliente int identity (1,1),
Razao_Social varchar(50) not null,
Nome_Fantasia varchar(30) null,
CNPJ varchar(14) not null unique,
Logradouro varchar(50) null, 
Num int null,
Complemento varchar(50) null,
Bairro varchar(25) null,
Cidade varchar(20),
UF varchar(2),
CEP varchar(8) foreign key references CEP(CEP),
Email varchar(50) null,
Atividade bit default 1,
Primary key(Codigo_cliente))

go

insert into Cliente values('Coca-Cola Indústrias Ltda', 'Coca Cola', '45997418000153', 'Praia de Botafogo','', 'ANDAR 12', 'Botafogo', 'Rio de Janeiro','RJ', '22250040', 'cocacolabrasil@cocacola.com',1),
('Pepsico do Brasil Ltda', 'Pepsico', '31565104027610', 'Rodovia Presidente Dutra','', 'KM 219,6','São Roque','Guarulhos','SP','07034000', 'pepsicobrasil@pepsico.com',1),
('Nestlé Brasil Ltda', 'Nestlé', '60409075000152', 'Av. Dr. Chucri Zaidan',246 , '','Vila Cordeiro','São Paulo','SP','04583110', 'homero.gadbem@br.nestle.com',1),
('Arcos Dourados Comercio de Alimentos Ltda','MacDonalds','42591651000143','Alameda Amazonas',253,'','Alphaville Industrial','Barueri','SP','06454070','leandro.jesus@br.mcd.com',1),
('Venbo Comércio de alimentos Ltda','Bobs','71833552016718','Rua Voluntarios da Pátria',89,'Sala 703,704,804,901,902','Botafogo','Rio de Janeiro','RJ','22270000','eduardoduarte@edconsultores.com.br',1)
go

Create table Telefone_cliente
(Codigo_cliente int foreign key
references Cliente(Codigo_cliente),
Numero varchar(15) not null,
Operadora varchar(10),
Primary key (Numero))

go

insert into Telefone_cliente values (1,'78551026','Tim')
insert into Telefone_cliente values (2,'58976311','Vivo')
insert into Telefone_cliente values (3,'45663201','Oi')
insert into Telefone_cliente values (4,'55641005','Claro')
insert into Telefone_cliente values (5,'65994251','Oi')


go

Create table Marca(
Codigo_marca int identity(1,1),
Marca varchar(15) not null unique,
Primary key(Codigo_marca))

go

insert into Marca values('Agrale'),
('Ford'),
('Foton Motors'),
('Hyundai'),
('Iveco'),
('Mercedes-Benz'),
('Scania'),
('Sinotruk'),
('Volkswagen'),
('Volvo')

go

Create table Veiculo(
Placa varchar(7) not null,
Modelo varchar(30) null,
Marca int foreign key references Marca(Codigo_marca),
Ano_fabricacao char(4) null,
Cor varchar(20) null,
RENAVAM varchar(11) null,
Seguro varchar(9) null,
[Status] int not null default 0,
Atividade bit default 1,
Primary key(Placa))

go

insert into Veiculo values('ASD5310', '800S56TZ', 5, '2014', 'Laranja', '30507010703', '040701060', 1,1),
('BDO5520', '800S56TZ', 5, '2014', 'Cinza', '00000000000', '000000000', 0,1),
('QOF0738', 'Constellation 26.390 Tractor', 9, '2014', 'Azul', '00900070000', '022603030', 0,1),
('AAE5542', 'Constellation 26.390 Tractor', 9, '2014', 'Preto', '00503007020', '002203900', 0,1),
('GOE0184', 'Constellation 26.390 Tractor', 9, '2014', 'Cinza', '90100405010', '062303501', 0,1),
('LKK5448', 'Actros 2655', 6, '2014', 'Amarelo', '09080500877', '597630000', 1,1),
('VAJ2074', 'Actros 2655', 6, '2014', 'Preto', '00040000877', '897734900', 0,1),
('PLK9642', 'Axor 2644', 6, '2014', 'Preto', '00004880000', '099630100', 0,1),
('JJG9975', 'Streamline R730', 7, '2014', 'Branco', '00009661000', '785330000', 2,1)

go 

Create table Composicao(
Codigo_composicao int identity (1,1),
Comprimento decimal (5,2) not null,
Eixos int not null,
Capacidade decimal (5,2) not null,
Veiculo varchar(7) foreign key references Veiculo(Placa),
Atividade bit default 1,
Primary key (Codigo_composicao))

go

Insert into Composicao values (12.8,18,25.0,'ASD5310',1)
Insert into Composicao values (12.8,18,25.0,'AAE5542',1)
Insert into Composicao values (12.8,18,25.0,'LKK5448',1)
Insert into Composicao values (12.8,18,25.0,'PLK9642',1)
Insert into Composicao values (12.8,18,25.0,'JJG9975',1)


go

Create table Usuario(
Id_usuario varchar(15)not null unique,
Id_senha varchar(10) not null,
Nivel_acesso int not null,
SenhaAtv int not null,
Codigo_funcionario int foreign key references Funcionario(Codigo_funcionario)
Primary key(Id_usuario))

go

Insert into Usuario values('Nivel1_1000','1234',1,1,1)
Insert into Usuario values('Nivel2_1001','1234',2,1,2)
Insert into Usuario values('Nivel3_1002','1234',3,1,3)
Insert into Usuario values('Nivel4_1003','1234',4,1,4)
Insert into Usuario values('Nivel5_1004','1234',5,1,5)

go
Create table Tipo_carga(
Codigo_Tipo_carga int identity (1,1),
Descricao varchar(20) not null unique,
Primary key (Codigo_Tipo_Carga))

go

Insert into Tipo_carga values ('Granel'),
('Pallets'),
('Refrigerado')

go

Create table Carga(
Codigo_carga int identity (1,1),
Peso varchar(9) not null,
MedidaA varchar(4) not null,
MedidaL varchar(4) not null,
MedidaC varchar(4) not null,
Volumes int not null,
Cubagem varchar(8) null,
Valor varchar(9) not null,
Tipo_carga int foreign key
references Tipo_carga(Codigo_Tipo_carga),
Codigo_cliente int foreign key
references Cliente(Codigo_cliente),
Atividade bit default 1,
Primary key(Codigo_carga))

go
insert into Carga values (4.650,0.50,0.95,0.75,30,3206.25,3.000,2,1,1),
(12.840,0.90,0.50,0.60,20,1620,1.250,2,2,1)

go

Create table Tipo_conta(
Codigo_tipoConta int identity (1,1),
Tipo varchar(7)
Primary key(Codigo_tipoConta))

go

Insert into Tipo_conta values('Pagar'),
('Receber')

go

Create table Estado_conta(
Codigo_estadoConta int identity (1,1),
Estado char(8)
Primary key(Codigo_estadoConta))

Insert into Estado_conta values('Pago'),
('Pendente')

go

Create table Contas(
Codigo_conta int identity (1,1),
DataPgto date null,
DataReceb date null,
Valor varchar(9) not null ,
DataVenc date null,
Descricao text null ,
Estado int foreign key references Estado_conta(Codigo_estadoConta),
Tipo int foreign key references Tipo_conta(Codigo_tipoConta),
Codigo_funcionario int foreign key references Funcionario(Codigo_funcionario),
Primary key(Codigo_conta))

go

insert into Contas values ('16/03/2015',null,-3.000, '26/03/2015', 'Reparos na frota',2,1, 4)
insert into Contas values ('27/03/2015',null, -5.670,'07/04/2015', 'Energia',1,1, 4)
insert into Contas values ('07/03/2015',null,-1.230, '17/03/2015', 'Água',1,1, 4)
insert into Contas values (null,'15/04/2015',4.750, null, 'Venda',1,2, 5)
insert into Contas values ('20/03/2015',null,-8.090, '30/03/2015', 'Telefone',2,1, 4)
insert into Contas values ('18/11/2014',null,-1.200, '28/11/2014', 'Segurança',2,1, 4)
insert into Contas values ('20/02/2015',null,-8.200, '02/03/2015', 'Telefone',2,1, 4)
insert into Contas values (null,'15/04/2015',6.500, null, 'Venda',1,2, 5)

go

Create table Estado_armazem(
Codigo_estadoarmazem int identity (1,1),
Estado char(12)
Primary key(Codigo_estadoarmazem))

go

Insert into Estado_armazem values('Disponível'),
('Indisponível')

go

Create table Armazem(
Codigo_armazenamento int identity (1,1),
Codigo_carga int foreign key
References Carga(Codigo_carga),
Setor char(50) not null unique,
Estado int foreign key references Estado_armazem(Codigo_estadoarmazem),
Primary Key (Codigo_armazenamento))

go

Insert into Armazem values(1,'A1',2),
(2,'A2',2),
(null,'A3',1),
(null,'A4',1),
(null,'A5',1),
(null,'A6',1),
(null,'A7',1),
(null,'A8',1),
(null,'B1',1),
(null,'B2',1),
(null,'B3',1),
(null,'B4',1),
(null,'B5',1),
(null,'B6',1),
(null,'B7',1),
(null,'B8',1),
(null,'C1',1),
(null,'C2',1),
(null,'C3',1),
(null,'C4',1),
(null,'C5',1),
(null,'C6',1),
(null,'C7',1),
(null,'C8',1),
(null,'D1',1),
(null,'D2',1),
(null,'D3',1),
(null,'D4',1),
(null,'D5',1),
(null,'D6',1),
(null,'D7',1),
(null,'D8',1)

go

Create table Entrega(
Codigo_entrega int identity (1,1),
Logradouro varchar(30) null, 
Num int null,
Complemento varchar(30) null,
Bairro varchar(20) null,
Cidade varchar(20),
UF varchar(2),
CEP varchar(8) foreign key references CEP(CEP),
Veiculo varchar(7) foreign key references Veiculo(Placa),
Codigo_cliente int foreign key references Cliente(Codigo_cliente),
Primary key(Codigo_entrega))
go

Insert into Entrega values('Rua Joaquim Coelho Freitas',248,'','Santo Agostinho',3,25,'14401360','ASD5310',1),
('Rua Doutor Cardoso de Almeida',1350,'','Centro',4,25,'18600005','LKK5448',2)

go

--Create table Fretamento(
--Codigo_fretamento int identity (1,1),
--Distancia_tot decimal(7,2) not null,
--Data_saida date null,
--Data_entrega date null,
--Codigo_funcionario int foreign key references Funcionario(Codigo_funcionario),
--Codigo_carga int foreign key
--references Carga(Codigo_carga)
--Primary key(Codigo_fretamento))

go

--Insert into Fretamento values(393.000,'','',2,1),
--(467.572,'','',2,2)

go

--Create table Fretamento_entrega(
--Codigo_fretEntre int identity (1,1),
--Codigo_entrega int foreign key references Entrega(Codigo_entrega),
--Codigo_fretamento int foreign key references Fretamento(Codigo_fretamento),
--Primary key (Codigo_fretEntre))

go

--insert into Fretamento_entrega values(1,1)
--insert into Fretamento_entrega values(2,2)

go

Create table Forma_pagamento(
Codigo_forma_pagamento int identity (0,1),
Forma_pagamento varchar(13)null,
primary key(Codigo_forma_pagamento))

go

insert into Forma_pagamento values('Dinheiro'),
('Cheque'),
('Transferência')

go

create table Venda(
Codigo_venda int identity (1,1),
Forma_Pagamento int foreign key references Forma_pagamento(Codigo_forma_pagamento),
Valor_Venda varchar(9) not null,
Data date not null,
Distancia_tot decimal(7,2) not null,
Data_entrega date null,
Veiculo varchar(7) foreign key references Veiculo(Placa),
Codigo_cliente int foreign key
references Cliente(Codigo_cliente),
Codigo_funcionario int foreign key
references Funcionario(Codigo_funcionario),
--Codigo_fretamento int foreign key
--references Fretamento(Codigo_fretamento),
Codigo_carga int foreign key
References Carga(Codigo_carga),
Primary Key(Codigo_venda))


go

Insert into Venda values(2,2548468.9,'26/03/2015',1,'26/03/2015','PLK9642',2,5,1)

go

create table Orcamento(
Codigo_orcamento int identity (1,1),
Cliente_Orc int foreign key references Cliente(Codigo_cliente),
Telefone_orc varchar(15) not null unique,
Email char(50) not null unique,
Valor_Venda varchar(9) not null,
Data date not null,
Data_exp date not null,
Codigo_funcionario int foreign key
references Funcionario(Codigo_funcionario),
Veiculo varchar(7) foreign key references Veiculo(Placa),
Distancia_tot decimal(7,2)null,
--Codigo_fretamento int foreign key
--references Fretamento(Codigo_fretamento),
Codigo_carga int foreign key
References Carga(Codigo_carga),
Primary Key(Codigo_orcamento))

go

insert into Orcamento values (2,'1164642400','pepsicobrasil@pepsico.com',2073457.4,'26/03/2015','05/08/2015',2,'LKK5448',12,2)

go

Create table Reparo(
Codigo_reparo int identity (1,1),
Descricao text not null,
Primary key(Codigo_reparo))

go

insert into Reparo values ('Troca de óleo'),
('Troca de pneus'),
('Funilaria e pintura'),
('Mecânica geral')

go

Create table Manutencao(
Codigo_manutencao int identity (1,1),
Placa varchar(7) foreign key references Veiculo(Placa),
Codigo_reparo int foreign key references Reparo(Codigo_reparo)
Primary key(Codigo_manutencao))

go

insert into Manutencao values ('JJG9975',1)






----------------------------------SELECT's CORPORATIVO------------------------------
Select * from Armazem
Select * from Carga
Select * from Cargo
select * from CEP
Select * from Cliente
Select * from Composicao
Select * from Contas
Select * from Entrega
Select * from Escolaridade
Select * from Estado_civil
Select * from Forma_pagamento
--Select * from Fretamento
--Select * from Fretamento_entrega
select * from Funcionario
select * from Manutencao
select * from Marca
Select * from Nacionalidade
Select * from Orcamento
Select * from Reparo
Select * from Sexo
Select * from Telefone_cliente
Select * from Telefone_funcionario
Select * from Tipo_carga
Select * from Usuario
Select * from Veiculo
Select * from Venda




--------------------------------------REPEATER----------------------------

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Products](
	[ProductName] [nchar](500) NOT NULL,
	[ProductImage] [nchar](100) NOT NULL,
 )

GO


insert into Products(ProductName,ProductImage)
values('Veículos totalmente disponíveis para efetuar entregas rapidas e seguras para todo o território Brasileiro .','~\imagens\Transporte-e-distribuicao-de-mercadoria.jpg')
insert into Products(ProductName,ProductImage)
values('Trabalho perfeito, equipe totalmente treinada para atende-lo com rapidez e eficiência no prazo proposto.','~\imagens\301.jpg')
insert into Products(ProductName,ProductImage)
values('Com a equipe da Transportadora, quem ganha são nossos clientes com a segurança de suas mercadorias e armazenamento delas.','~\imagens\armazenagem-de-cargas-perador-logistico-1.jpg')


-------------------------------SELECT REPEATER---------------------------------

select * from Products



---------------------------------------SITE USUARIO---------------------------------

create table dbusuario(Email varchar(50) not null,
senha varchar(20) not null,
usuario varchar (15) unique,
Email2 varchar(50) unique,
senha2 varchar (20) not null,
razao_social varchar(20) not null,
nome_fantasia varchar (25) not null,
CNPJ varchar(18) unique,
endereco varchar(50) not null,
n varchar(10) not null,
complemento varchar(20),
bairro varchar (20) not null,
cidade varchar(50) not null,
UF varchar(2) not null,
cep varchar(8) not null,
primary key (usuario))


-------------------------------------SELECT SITE USUARIO-------------------------------

select * from dbusuario