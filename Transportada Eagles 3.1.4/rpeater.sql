create database teste
USE teste
GO

/****** Object:  Table [dbo].[Products]    Script Date: 04/18/2011 12:29:42 ******/
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
values('Ve�culos totalmente dispon�veis para efetuar entregas rapidas e seguras para todo o territ�rio Brasileiro .','~\imagens\Transporte-e-distribuicao-de-mercadoria.jpg')
insert into Products(ProductName,ProductImage)
values('Trabalho perfeito, equipe totalmente treinada para atende-lo com rapidez e efici�ncia no prazo proposto.','~\imagens\301.jpg')
insert into Products(ProductName,ProductImage)
values('Com a equipe da Transportadora, quem ganha s�o nossos clientes com a seguran�a de suas mercadorias e armazenamento delas.','~\imagens\armazenagem-de-cargas-perador-logistico-1.jpg')




select * from Products
--use master
--drop database teste
--drop table Products