create database TrabalhoEFBanco

create table Departamento(
	ID_Departamento  int identity primary key,
	Descricao varchar(50) not null
)
create table Categoria(
	ID_Categoria int identity primary key,
	Descricao varchar(50)not null,
	ID_departamento int foreign key references Departamento(ID_Departamento)
)
create table Subcategoria(
	ID_Subcategoria int identity primary key,
	Descricao varchar(50) not null,
	ID_categoria int foreign key references Categoria(ID_Categoria)
)
create table Marca(
	ID_Marca  int identity primary key,
	Descricao varchar(50) not null
)
create table UnidadeMedida(
	ID_UnidadeMedida int identity primary key,
	Descricao varchar(50) not null,
	ID_produto int foreign key references Produto(ID_Produto)
)
create table Produto(
	ID_Produto int identity primary key,
	Codigo int not null,
	Descricao varchar(50) not null,
	Id_subcategoria int foreign key references Subcategoria(ID_Subcategoria),
	ID_marca int foreign key references Marca(ID_Marca),
	Id_unidade_medida int foreign key references UnidadeMedida(ID_UnidadeMedida),
	EspecificacaoTecnica varchar(50) not null,
	Statous varchar(50) not null,
	PesoBruto float not null,
	PesoLiquido float not null,
	Qtd_Mult int not null,
	Qtd_Min int not null,
	Cod_Barras int not null
)
create table PrecoVenda(
	ID_PrecoVenda int identity primary key,
	ID_produto int foreign key references Produto(ID_Produto),
	preco_venda float not null,
	data_validade_inicial date not null,
	data_validade_final date not null
)
create table ProdutoSimilar(
	ID_Produto int identity primary key,
	ID_produto_similar int foreign key references Produto(ID_Produto)
)
alter table UnidadeMedida add ID_produto int foreign key references Produto(ID_Produto);