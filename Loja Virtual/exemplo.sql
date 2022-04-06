CREATE TABLE Cliente(
    Cpf       INT     primary key  NOT NULL,
    Nome      VARCHAR (50) NOT NULL,
    Endereco  VARCHAR (50) NOT NULL,
	Bairro   VARCHAR (50) NOT NULL,
    Estado      VARCHAR (50) NOT NULL,
    Cidade      VARCHAR (50) NOT NULL,
    Cep         VARCHAR (50) NOT NULL,
    Email       VARCHAR (50) NOT NULL,
    Senha       VARCHAR (50) NOT NULL,
    Telefone    VARCHAR (50) NOT NULL,
    Nascimento  VARCHAR (50) NOT NULL,
    Cartao      VARCHAR (50) NOT NULL
);

CREATE TABLE Carrinho (
    idPProduto  VARCHAR (50) NOT NULL,
    Valor   FLOAT NOT NULL,
    Total float not null,
    Id_Cliente INT,
	foreign key(id_Cliente) references Cliente(Cpf)
);

create table produto(
idProduto varchar(50) not null,
valor float not null
);

insert into produto values('1','40');

select valor from produto;

drop table carrinho;

insert into Cliente Values('40900001','mig','travessa','fazenda','sp','sp','039','mig@mig','senha','12901290','21','03193109');
insert into Carrinho values('10','30','30','40900001');



select * from cliente;
select * from carrinho;

select cliente.cpf,cliente.Nome,carrinho.idPProduto,carrinho.Valor,carrinho.total from cliente
 inner join carrinho on Cliente.cpf=carrinho.ID_Cliente;



create table pessoa(
pessoa varchar(30) not null,
nascimento datetime
);


insert into pessoa values('eu',1222-20-1);


select * from pessoa;