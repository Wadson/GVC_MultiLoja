/* ===============================
   02 - TABLES
   =============================== */


CREATE TABLE dbo.Estado (
    EstadoID INT IDENTITY PRIMARY KEY,
    Nome NVARCHAR(100) NOT NULL,
    Uf NVARCHAR(2) NOT NULL,
    ibge INT NULL,
    pais INT NULL,
    ddd NVARCHAR(100) NULL
);


CREATE TABLE Cidade (
    CidadeID INT IDENTITY PRIMARY KEY,
    Nome NVARCHAR(100) NOT NULL,
    EstadoID INT NOT NULL,
    codigoIbge NVARCHAR(10) NULL
);

CREATE TABLE Clientes (
    ClienteID INT IDENTITY PRIMARY KEY,
    Nome NVARCHAR(100) NOT NULL,
    Cpf NVARCHAR(11) NULL,
    RG NVARCHAR(20) NULL,
    Cnpj NVARCHAR(14) NULL,
    IE NVARCHAR(20) NULL,
    Telefone NVARCHAR(20) NULL,
    Email NVARCHAR(100) NULL,
    CidadeID INT NULL,
    Logradouro NVARCHAR(150) NULL,
    Numero NVARCHAR(10) NULL,
    Bairro NVARCHAR(100) NULL,
    Cep NVARCHAR(10) NULL,
    DataNascimento DATE NULL,
    TipoCliente NVARCHAR(20) NULL,
    Status INT NOT NULL DEFAULT (1),
    Observacoes NVARCHAR(MAX) NULL,
    DataUltimaCompra DATETIME2 NULL,
    LimiteCredito DECIMAL(18,2) NULL,
    DataCriacao DATETIME2 NOT NULL DEFAULT (GETDATE()),
    DataAtualizacao DATETIME2 NULL,
    UsuarioCriacao NVARCHAR(50) NULL,
    UsuarioAtualizacao NVARCHAR(50) NULL,
    OrgaoExpedidorRG NVARCHAR(20) NULL,
    IsVendedor BIT NOT NULL DEFAULT (0)
);

CREATE TABLE Empresa (
    EmpresaID INT IDENTITY PRIMARY KEY,
    RazaoSocial NVARCHAR(150) NOT NULL,
    NomeFantasia NVARCHAR(150) NULL,
    CNPJ NVARCHAR(14) NOT NULL,
    InscricaoEstadual NVARCHAR(20) NULL,
    InscricaoMunicipal NVARCHAR(20) NULL,
    CNAE NVARCHAR(10) NULL,
    Logradouro NVARCHAR(150) NOT NULL,
    Numero NVARCHAR(10) NULL,
    Bairro NVARCHAR(100) NOT NULL,
    Cep NVARCHAR(10) NOT NULL,
    Cidade NVARCHAR(100) NOT NULL,
    UF NVARCHAR(2) NOT NULL,
    Telefone NVARCHAR(20) NULL,
    Email NVARCHAR(100) NULL,
    Site NVARCHAR(100) NULL,
    Responsavel NVARCHAR(100) NULL,
    CertificadoDigital NVARCHAR(200) NULL,
    DataCriacao DATETIME2 NOT NULL DEFAULT (GETDATE()),
    DataAtualizacao DATETIME2 NULL,
    UsuarioCriacao NVARCHAR(50) NULL,
    UsuarioAtualizacao NVARCHAR(50) NULL,
    Logo VARBINARY(MAX) NULL
);

CREATE TABLE FormaPagamento (
    FormaPgtoID INT IDENTITY PRIMARY KEY,
    NomeFormaPagamento NVARCHAR(50) NOT NULL,
    Ativo BIT NOT NULL DEFAULT (1)
);

CREATE TABLE Fornecedor (
    FornecedorID INT IDENTITY PRIMARY KEY,
    Nome NVARCHAR(100) NOT NULL,
    Cnpj NVARCHAR(14) NULL,
    IE NVARCHAR(20) NULL,
    Telefone NVARCHAR(20) NULL,
    Email NVARCHAR(100) NULL,
    CidadeID INT NOT NULL,
    Logradouro NVARCHAR(150) NULL,
    Numero NVARCHAR(10) NULL,
    Bairro NVARCHAR(100) NULL,
    Cep NVARCHAR(10) NULL,
    DataCriacao DATETIME2 NOT NULL DEFAULT (GETDATE()),
    Observacoes NVARCHAR(MAX) NULL
);

CREATE TABLE Produtos (
    ProdutoID INT IDENTITY PRIMARY KEY,
    NomeProduto NVARCHAR(100) NOT NULL,
    Referencia NVARCHAR(15) NULL,
    PrecoCusto DECIMAL(18,2) NOT NULL,
    Lucro DECIMAL(18,2) NOT NULL,
    PrecoDeVenda DECIMAL(18,2) NOT NULL,
    Estoque INT NOT NULL,
    DataDeEntrada DATETIME2 NOT NULL DEFAULT (GETDATE()),
    Status NVARCHAR(20) NOT NULL,
    Situacao NVARCHAR(50) NULL,
    Unidade NVARCHAR(20) NULL,
    Marca NVARCHAR(50) NULL,
    DataValidade DATETIME2 NULL,
    GtinEan NVARCHAR(20) NULL,
    Imagem NVARCHAR(255) NULL,
    FornecedorID INT NULL
);

CREATE TABLE Venda (
    VendaID INT IDENTITY PRIMARY KEY,
    ClienteID INT NOT NULL,
    FormaPgtoID INT NULL,
    DataVenda DATETIME2 NOT NULL DEFAULT (GETDATE()),
    ValorTotal DECIMAL(18,2) NOT NULL,
    Desconto DECIMAL(18,2) NULL DEFAULT (0),
    Observacoes NVARCHAR(MAX) NULL,
    StatusVenda NVARCHAR(20) NOT NULL DEFAULT ('Aberta'),
    VendedorID INT NULL
);

CREATE TABLE ItemVenda (
    ItemVendaID INT IDENTITY PRIMARY KEY,
    VendaID INT NOT NULL,
    ProdutoID INT NOT NULL,
    Quantidade INT NOT NULL,
    PrecoUnitario DECIMAL(18,2) NOT NULL,
    Subtotal DECIMAL(18,2) NOT NULL DEFAULT (0),
    DescontoItem DECIMAL(18,2) NOT NULL DEFAULT (0)
);

CREATE TABLE Parcela (
    ParcelaID INT IDENTITY PRIMARY KEY,
    VendaID INT NOT NULL,
    NumeroParcela INT NOT NULL,
    DataVencimento DATE NOT NULL,
    ValorParcela DECIMAL(18,2) NOT NULL,
    ValorRecebido DECIMAL(18,2) NOT NULL DEFAULT (0),
    Status NVARCHAR(20) NOT NULL DEFAULT ('Pendente'),
    DataPagamento DATE NULL,
    Juros DECIMAL(18,2) NOT NULL DEFAULT (0),
    Multa DECIMAL(18,2) NOT NULL DEFAULT (0),
    Observacao NVARCHAR(MAX) NULL
);

CREATE TABLE PagamentosParciais (
    PagamentoID INT IDENTITY PRIMARY KEY,
    ParcelaID INT NOT NULL,
    ValorPago DECIMAL(18,2) NOT NULL,
    DataPagamento DATE NOT NULL DEFAULT (GETDATE()),
    FormaPgtoID INT NULL,
    Observacao NVARCHAR(MAX) NULL
);

CREATE TABLE MovimentacaoEstoque (
    MovimentacaoID INT IDENTITY PRIMARY KEY,
    ProdutoID INT NOT NULL,
    TipoMovimentacao NVARCHAR(20) NOT NULL,
    Quantidade INT NOT NULL,
    EstoqueAnterior INT NOT NULL,
    EstoqueAtual INT NOT NULL,
    Origem NVARCHAR(30) NOT NULL,
    Documento NVARCHAR(50) NULL,
    Observacao NVARCHAR(255) NULL,
    DataMovimentacao DATETIME2 NOT NULL DEFAULT (GETDATE()),
    Usuario NVARCHAR(50) NULL
);

CREATE TABLE Pedidos (
    PedidoID INT IDENTITY PRIMARY KEY,
    FornecedorID INT NOT NULL,
    DataPedido DATE NOT NULL,
    ValorTotalPedido DECIMAL(18,2) NOT NULL
);

CREATE TABLE ItensPedido (
    ItensPedidoID INT IDENTITY PRIMARY KEY,
    PedidoID INT NOT NULL,
    Referencia NVARCHAR(15) NULL,
    Quantidade INT NOT NULL
);

CREATE TABLE Usuarios (
    UsuarioID INT IDENTITY PRIMARY KEY,
    TipoUsuario NVARCHAR(20) NOT NULL DEFAULT ('Normal'),
    NomeCompleto NVARCHAR(200) NOT NULL DEFAULT (''),
    Cpf NVARCHAR(14) NOT NULL,
    DataNascimento DATE NOT NULL,
    NomeUsuario NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    Senha NVARCHAR(255) NOT NULL,
    DataCriacao DATETIME2 NOT NULL DEFAULT (GETDATE())
);

CREATE TABLE TokensRedefinicao (
    TokenID INT IDENTITY PRIMARY KEY,
    UsuarioID INT NOT NULL,
    Token NVARCHAR(500) NOT NULL,
    DataExpiracao DATETIME2 NOT NULL
);

