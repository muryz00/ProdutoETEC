create database produtos;
use produtos;

create table Produto(
CodProd int,
Descricao varchar(80),
Valor decimal(5,2),
Vencto date);

create table Movto(
CodProd int,
Obs varchar(120),
DtMovto date,
Tipo varchar(60),
Quant decimal(5,2),
CodMovto int);
