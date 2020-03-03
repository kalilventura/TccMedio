Create database usuario

go

use usuario

go

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

select * from dbusuario

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

select * from CEP
--drop table dbusuario