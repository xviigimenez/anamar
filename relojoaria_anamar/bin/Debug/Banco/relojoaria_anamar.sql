-- Cada linha representa um item do estoque
create table estoque (
	id int primary_key auto_increment,
	nome varchar(64) not null,
	quantia int not null,
	preco int not null,
	-- Data da última alteração
	data date
);

-- Cada linha representa um item do estoque
create table compras (
	id int primary_key auto_increment,
	data date not null,
	nome varchar(64) not null,
	-- Onde foi realizada a compra
	fornecedor varchar(64) not null,
	quantia int not null,
	valor float(6,2) not null,
	pagamento enum("vista", "prazo") not null
);

-- Cada linha representa um item da venda
create table vendas (
	id int primary_key auto_increment,
	data date not null,
	-- Nome do produto/serviço
	nome varchar(64) not null,
	cliente varchar(64) not null,
	pagamento enum("dinheiro", "pix", "debito", "credito") not null
);

--create table relatorios (
--);