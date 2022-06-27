create database BDlogin;
use BDlogin;
create table Cadastro(
	codigo int not null auto_increment primary key,
    nome varchar(50) not null,
    telefone varchar(12) not null,
    email varchar(50) not null,
    senha varchar(30) not null
    )engine = InnoDB;
    
    
select * from Cadastro;

select*from Cadastro