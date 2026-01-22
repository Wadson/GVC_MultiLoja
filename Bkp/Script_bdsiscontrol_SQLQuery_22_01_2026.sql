USE [master]
GO
/****** Object:  Database [bdsiscontrol]    Script Date: 22/01/2026 14:04:45 ******/
CREATE DATABASE [bdsiscontrol]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'bdsiscontrol_Data', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL17.SQLEXPRESS\MSSQL\DATA\bdsiscontrol.mdf' , SIZE = 204800KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'bdsiscontrol_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL17.SQLEXPRESS\MSSQL\DATA\bdsiscontrol_log.ldf' , SIZE = 2560KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [bdsiscontrol] SET COMPATIBILITY_LEVEL = 170
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [bdsiscontrol].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [bdsiscontrol] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [bdsiscontrol] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [bdsiscontrol] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [bdsiscontrol] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [bdsiscontrol] SET ARITHABORT OFF 
GO
ALTER DATABASE [bdsiscontrol] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [bdsiscontrol] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [bdsiscontrol] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [bdsiscontrol] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [bdsiscontrol] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [bdsiscontrol] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [bdsiscontrol] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [bdsiscontrol] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [bdsiscontrol] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [bdsiscontrol] SET  DISABLE_BROKER 
GO
ALTER DATABASE [bdsiscontrol] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [bdsiscontrol] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [bdsiscontrol] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [bdsiscontrol] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [bdsiscontrol] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [bdsiscontrol] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [bdsiscontrol] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [bdsiscontrol] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [bdsiscontrol] SET  MULTI_USER 
GO
ALTER DATABASE [bdsiscontrol] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [bdsiscontrol] SET DB_CHAINING OFF 
GO
ALTER DATABASE [bdsiscontrol] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [bdsiscontrol] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [bdsiscontrol] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [bdsiscontrol] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [bdsiscontrol] SET OPTIMIZED_LOCKING = OFF 
GO
ALTER DATABASE [bdsiscontrol] SET QUERY_STORE = ON
GO
ALTER DATABASE [bdsiscontrol] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [bdsiscontrol]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_calcular_dias_atraso]    Script Date: 22/01/2026 14:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Função para calcular dias em atraso
CREATE   FUNCTION [dbo].[fn_calcular_dias_atraso]
    (@DataVencimento DATE)
RETURNS INT
AS
BEGIN
    DECLARE @DiasAtraso INT;
    
    SET @DiasAtraso = DATEDIFF(DAY, @DataVencimento, GETDATE());
    
    IF @DiasAtraso < 0
        SET @DiasAtraso = 0;
    
    RETURN @DiasAtraso;
END;
GO
/****** Object:  UserDefinedFunction [dbo].[fn_calcular_idade]    Script Date: 22/01/2026 14:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- 8. FUNÇÕES
-- =============================================

-- Função para calcular idade
CREATE   FUNCTION [dbo].[fn_calcular_idade]
    (@DataNascimento DATE)
RETURNS INT
AS
BEGIN
    RETURN DATEDIFF(YEAR, @DataNascimento, GETDATE()) - 
           CASE WHEN DATEADD(YEAR, DATEDIFF(YEAR, @DataNascimento, GETDATE()), @DataNascimento) > GETDATE() 
                THEN 1 
                ELSE 0 
           END;
END;
GO
/****** Object:  UserDefinedFunction [dbo].[fn_formatar_documento]    Script Date: 22/01/2026 14:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Função para formatar CPF/CNPJ
CREATE   FUNCTION [dbo].[fn_formatar_documento]
    (@Documento NVARCHAR(20))
RETURNS NVARCHAR(20)
AS
BEGIN
    DECLARE @Resultado NVARCHAR(20);
    
    IF LEN(@Documento) = 11 -- CPF
    BEGIN
        SET @Resultado = SUBSTRING(@Documento, 1, 3) + '.' +
                        SUBSTRING(@Documento, 4, 3) + '.' +
                        SUBSTRING(@Documento, 7, 3) + '-' +
                        SUBSTRING(@Documento, 10, 2);
    END
    ELSE IF LEN(@Documento) = 14 -- CNPJ
    BEGIN
        SET @Resultado = SUBSTRING(@Documento, 1, 2) + '.' +
                        SUBSTRING(@Documento, 3, 3) + '.' +
                        SUBSTRING(@Documento, 6, 3) + '/' +
                        SUBSTRING(@Documento, 9, 4) + '-' +
                        SUBSTRING(@Documento, 13, 2);
    END
    ELSE
    BEGIN
        SET @Resultado = @Documento;
    END
    
    RETURN @Resultado;
END;
GO
/****** Object:  Table [dbo].[FormaPagamento]    Script Date: 22/01/2026 14:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FormaPagamento](
	[FormaPgtoID] [int] IDENTITY(1,1) NOT NULL,
	[NomeFormaPagamento] [nvarchar](50) NOT NULL,
	[Ativo] [bit] NOT NULL,
 CONSTRAINT [PK_FormaPgto] PRIMARY KEY CLUSTERED 
(
	[FormaPgtoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PagamentosParciais]    Script Date: 22/01/2026 14:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PagamentosParciais](
	[PagamentoID] [int] IDENTITY(1,1) NOT NULL,
	[ParcelaID] [int] NOT NULL,
	[ValorPago] [decimal](18, 2) NOT NULL,
	[DataPagamento] [date] NOT NULL,
	[FormaPgtoID] [int] NULL,
	[Observacao] [nvarchar](max) NULL,
 CONSTRAINT [PK_PagamentosParciais] PRIMARY KEY CLUSTERED 
(
	[PagamentoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_fluxo_caixa]    Script Date: 22/01/2026 14:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[vw_fluxo_caixa] AS
SELECT 
    CAST(pp.DataPagamento AS DATE) AS Data,
    COALESCE(fp.NomeFormaPagamento, 'Sem Forma') AS FormaPagamento,
    COUNT(DISTINCT pp.ParcelaID) AS ParcelasRecebidas,
    COUNT(pp.PagamentoID) AS PagamentosRealizados,
    SUM(pp.ValorPago) AS TotalRecebido,
    AVG(pp.ValorPago) AS ValorMedioPagamento
FROM PagamentosParciais pp 
LEFT JOIN FormaPagamento fp ON pp.FormaPgtoID = fp.FormaPgtoID
GROUP BY CAST(pp.DataPagamento AS DATE), fp.FormaPgtoID, fp.NomeFormaPagamento;
GO
/****** Object:  Table [dbo].[ItemVenda]    Script Date: 22/01/2026 14:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemVenda](
	[ItemVendaID] [int] IDENTITY(1,1) NOT NULL,
	[VendaID] [int] NOT NULL,
	[ProdutoID] [int] NOT NULL,
	[Quantidade] [int] NOT NULL,
	[PrecoUnitario] [decimal](18, 2) NOT NULL,
	[Subtotal] [decimal](18, 2) NOT NULL,
	[DescontoItem] [decimal](18, 2) NULL,
 CONSTRAINT [PK_ItemVenda] PRIMARY KEY CLUSTERED 
(
	[ItemVendaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 22/01/2026 14:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[ClienteID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](100) NOT NULL,
	[Cpf] [nvarchar](11) NULL,
	[RG] [nvarchar](20) NULL,
	[Cnpj] [nvarchar](14) NULL,
	[IE] [nvarchar](20) NULL,
	[Telefone] [nvarchar](20) NULL,
	[Email] [nvarchar](100) NULL,
	[CidadeID] [int] NULL,
	[Logradouro] [nvarchar](150) NULL,
	[Numero] [nvarchar](10) NULL,
	[Bairro] [nvarchar](100) NULL,
	[Cep] [nvarchar](10) NULL,
	[DataNascimento] [date] NULL,
	[TipoCliente] [nvarchar](20) NULL,
	[Status] [int] NOT NULL,
	[Observacoes] [nvarchar](max) NULL,
	[DataUltimaCompra] [datetime2](7) NULL,
	[LimiteCredito] [decimal](18, 2) NULL,
	[DataCriacao] [datetime2](7) NOT NULL,
	[DataAtualizacao] [datetime2](7) NULL,
	[UsuarioCriacao] [nvarchar](50) NULL,
	[UsuarioAtualizacao] [nvarchar](50) NULL,
	[OrgaoExpedidorRG] [nvarchar](20) NULL,
	[IsVendedor] [bit] NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[ClienteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venda]    Script Date: 22/01/2026 14:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venda](
	[VendaID] [int] IDENTITY(1,1) NOT NULL,
	[ClienteID] [int] NOT NULL,
	[FormaPgtoID] [int] NULL,
	[DataVenda] [datetime2](7) NOT NULL,
	[ValorTotal] [decimal](18, 2) NOT NULL,
	[Desconto] [decimal](18, 2) NULL,
	[Observacoes] [nvarchar](max) NULL,
	[StatusVenda] [nvarchar](20) NOT NULL,
	[VendedorID] [int] NULL,
 CONSTRAINT [PK_Venda] PRIMARY KEY CLUSTERED 
(
	[VendaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_relatorio_vendas]    Script Date: 22/01/2026 14:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[vw_relatorio_vendas] AS
SELECT 
    v.VendaID,
    v.DataVenda,
    c.Nome AS Cliente,
    c.Cpf,
    c.Telefone,
    v.ValorTotal,
    v.Desconto,
    v.ValorTotal - v.Desconto AS ValorLiquido,
    v.StatusVenda,
    fp.NomeFormaPagamento AS FormaPagamento,
    COUNT(iv.ItemVendaID) AS TotalItens,
    SUM(iv.Quantidade) AS QuantidadeTotal
FROM Venda v
INNER JOIN Clientes c ON v.ClienteID = c.ClienteID
LEFT JOIN FormaPagamento fp ON v.FormaPgtoID = fp.FormaPgtoID
LEFT JOIN ItemVenda iv ON v.VendaID = iv.VendaID
GROUP BY 
    v.VendaID, v.DataVenda, c.Nome, c.Cpf, c.Telefone, 
    v.ValorTotal, v.Desconto, v.StatusVenda, fp.NomeFormaPagamento;
GO
/****** Object:  Table [dbo].[Fornecedor]    Script Date: 22/01/2026 14:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fornecedor](
	[FornecedorID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](100) NOT NULL,
	[Cnpj] [nvarchar](14) NULL,
	[IE] [nvarchar](20) NULL,
	[Telefone] [nvarchar](20) NULL,
	[Email] [nvarchar](100) NULL,
	[CidadeID] [int] NOT NULL,
	[Logradouro] [nvarchar](150) NULL,
	[Numero] [nvarchar](10) NULL,
	[Bairro] [nvarchar](100) NULL,
	[Cep] [nvarchar](10) NULL,
	[DataCriacao] [datetime2](7) NULL,
	[Observacoes] [nvarchar](max) NULL,
 CONSTRAINT [PK_Fornecedor] PRIMARY KEY CLUSTERED 
(
	[FornecedorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produtos]    Script Date: 22/01/2026 14:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produtos](
	[ProdutoID] [int] IDENTITY(1,1) NOT NULL,
	[NomeProduto] [nvarchar](100) NOT NULL,
	[Referencia] [nvarchar](15) NULL,
	[PrecoCusto] [decimal](18, 2) NOT NULL,
	[Lucro] [decimal](18, 2) NOT NULL,
	[PrecoDeVenda] [decimal](18, 2) NOT NULL,
	[Estoque] [int] NOT NULL,
	[DataDeEntrada] [datetime2](7) NOT NULL,
	[Status] [nvarchar](20) NOT NULL,
	[Situacao] [nvarchar](50) NULL,
	[Unidade] [nvarchar](20) NULL,
	[Marca] [nvarchar](50) NULL,
	[DataValidade] [datetime2](7) NULL,
	[GtinEan] [nvarchar](20) NULL,
	[Imagem] [nvarchar](255) NULL,
	[FornecedorID] [int] NULL,
 CONSTRAINT [PK_Produtos] PRIMARY KEY CLUSTERED 
(
	[ProdutoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_produtos_estoque_baixo]    Script Date: 22/01/2026 14:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- 3. RECRIAÇÃO DAS VIEWS (Removendo ORDER BY proibido)

CREATE   VIEW [dbo].[vw_produtos_estoque_baixo] AS
SELECT TOP 100 PERCENT -- Truque para permitir ORDER BY se necessário, mas idealmente removemos
    p.ProdutoID, p.NomeProduto, p.Referencia, p.Estoque, p.PrecoDeVenda, p.Status,
    f.Nome AS Fornecedor,
    CASE WHEN p.Estoque = 0 THEN 'ESGOTADO' WHEN p.Estoque <= 10 THEN 'BAIXO' ELSE 'NORMAL' END AS NivelEstoque
FROM Produtos p
LEFT JOIN Fornecedor f ON p.FornecedorID = f.FornecedorID
WHERE p.Estoque <= 10;
GO
/****** Object:  Table [dbo].[Parcela]    Script Date: 22/01/2026 14:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parcela](
	[ParcelaID] [int] IDENTITY(1,1) NOT NULL,
	[VendaID] [int] NOT NULL,
	[NumeroParcela] [int] NOT NULL,
	[DataVencimento] [date] NOT NULL,
	[ValorParcela] [decimal](18, 2) NOT NULL,
	[ValorRecebido] [decimal](18, 2) NULL,
	[Status] [nvarchar](20) NOT NULL,
	[DataPagamento] [date] NULL,
	[Juros] [decimal](18, 2) NULL,
	[Multa] [decimal](18, 2) NULL,
	[Observacao] [nvarchar](max) NULL,
 CONSTRAINT [PK_Parcela] PRIMARY KEY CLUSTERED 
(
	[ParcelaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_parcelas_em_aberto]    Script Date: 22/01/2026 14:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   VIEW [dbo].[vw_parcelas_em_aberto] AS
SELECT 
    p.ParcelaID, p.NumeroParcela, p.DataVencimento,
    DATEDIFF(DAY, GETDATE(), p.DataVencimento) AS DiasParaVencer,
    p.ValorParcela, p.ValorRecebido,
    p.ValorParcela + p.Juros + p.Multa - p.ValorRecebido AS ValorPendente,
    p.Status, v.VendaID, c.Nome AS Cliente
FROM Parcela p
INNER JOIN Venda v ON p.VendaID = v.VendaID
INNER JOIN Clientes c ON v.ClienteID = c.ClienteID
WHERE p.Status IN ('Pendente', 'Parcialmente Paga');
GO
/****** Object:  View [dbo].[vw_dashboard_financeiro]    Script Date: 22/01/2026 14:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- 4. VIEW DASHBOARD (Agora que a view dependente foi criada, esta funcionará)
CREATE   VIEW [dbo].[vw_dashboard_financeiro] AS
SELECT 
    (SELECT SUM(ValorTotal) FROM Venda WHERE MONTH(DataVenda) = MONTH(GETDATE())) AS TotalVendasMes,
    (SELECT SUM(ValorPago) FROM PagamentosParciais WHERE MONTH(DataPagamento) = MONTH(GETDATE())) AS TotalRecebidoMes,
    (SELECT SUM(ValorParcela + Juros + Multa - ValorRecebido) FROM Parcela WHERE Status IN ('Pendente', 'Parcialmente Paga')) AS TotalPendente,
    (SELECT COUNT(*) FROM Clientes WHERE Status = 1) AS TotalClientesAtivos,
    (SELECT COUNT(*) FROM vw_produtos_estoque_baixo) AS ProdutosEstoqueBaixo,
    (SELECT COUNT(*) FROM Venda WHERE CAST(DataVenda AS DATE) = CAST(GETDATE() AS DATE)) AS VendasHoje;
GO
/****** Object:  View [dbo].[vw_status_descricao]    Script Date: 22/01/2026 14:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- View para status descritivo
CREATE   VIEW [dbo].[vw_status_descricao] AS 
SELECT 0 as Codigo, 'Pendente' as Descricao UNION ALL 
SELECT 1, 'Parcial' UNION ALL 
SELECT 2, 'Pago' UNION ALL 
SELECT 3, 'Atrasado' UNION ALL 
SELECT 4, 'Cancelado';
GO
/****** Object:  Table [dbo].[__DatabaseScriptLog]    Script Date: 22/01/2026 14:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__DatabaseScriptLog](
	[ScriptName] [nvarchar](255) NOT NULL,
	[ExecutedAt] [datetime2](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ScriptName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[__ScriptLog]    Script Date: 22/01/2026 14:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__ScriptLog](
	[ScriptName] [nvarchar](200) NOT NULL,
	[ExecutedAt] [datetime2](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ScriptName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cidade]    Script Date: 22/01/2026 14:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cidade](
	[CidadeID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](100) NOT NULL,
	[EstadoID] [int] NOT NULL,
	[codigoIbge] [nvarchar](10) NULL,
 CONSTRAINT [PK_Cidade] PRIMARY KEY CLUSTERED 
(
	[CidadeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empresa]    Script Date: 22/01/2026 14:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empresa](
	[EmpresaID] [int] IDENTITY(1,1) NOT NULL,
	[RazaoSocial] [nvarchar](150) NOT NULL,
	[NomeFantasia] [nvarchar](150) NULL,
	[CNPJ] [nvarchar](14) NOT NULL,
	[InscricaoEstadual] [nvarchar](20) NULL,
	[InscricaoMunicipal] [nvarchar](20) NULL,
	[CNAE] [nvarchar](10) NULL,
	[Logradouro] [nvarchar](150) NOT NULL,
	[Numero] [nvarchar](10) NULL,
	[Bairro] [nvarchar](100) NOT NULL,
	[Cep] [nvarchar](10) NOT NULL,
	[Cidade] [nvarchar](100) NOT NULL,
	[UF] [nvarchar](2) NOT NULL,
	[Telefone] [nvarchar](20) NULL,
	[Email] [nvarchar](100) NULL,
	[Site] [nvarchar](100) NULL,
	[Responsavel] [nvarchar](100) NULL,
	[CertificadoDigital] [nvarchar](200) NULL,
	[DataCriacao] [datetime2](7) NOT NULL,
	[DataAtualizacao] [datetime2](7) NULL,
	[UsuarioCriacao] [nvarchar](50) NULL,
	[UsuarioAtualizacao] [nvarchar](50) NULL,
	[Logo] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[EmpresaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado]    Script Date: 22/01/2026 14:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado](
	[EstadoID] [int] NOT NULL,
	[Nome] [nvarchar](100) NOT NULL,
	[Uf] [nvarchar](2) NOT NULL,
	[ibge] [int] NULL,
	[pais] [int] NULL,
	[ddd] [nvarchar](100) NULL,
 CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED 
(
	[EstadoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItensPedido]    Script Date: 22/01/2026 14:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItensPedido](
	[ItensPedidoID] [int] IDENTITY(1,1) NOT NULL,
	[PedidoID] [int] NOT NULL,
	[Referencia] [nvarchar](15) NULL,
	[Quantidade] [int] NOT NULL,
 CONSTRAINT [PK_ItensPedido] PRIMARY KEY CLUSTERED 
(
	[ItensPedidoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MovimentacaoEstoque]    Script Date: 22/01/2026 14:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovimentacaoEstoque](
	[MovimentacaoID] [int] IDENTITY(1,1) NOT NULL,
	[ProdutoID] [int] NOT NULL,
	[TipoMovimentacao] [nvarchar](20) NOT NULL,
	[Quantidade] [int] NOT NULL,
	[EstoqueAnterior] [int] NOT NULL,
	[EstoqueAtual] [int] NOT NULL,
	[Origem] [nvarchar](30) NOT NULL,
	[Documento] [nvarchar](50) NULL,
	[Observacao] [nvarchar](255) NULL,
	[DataMovimentacao] [datetime] NOT NULL,
	[Usuario] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MovimentacaoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedidos]    Script Date: 22/01/2026 14:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedidos](
	[PedidoID] [int] IDENTITY(1,1) NOT NULL,
	[FornecedorID] [int] NOT NULL,
	[DataPedido] [date] NOT NULL,
	[ValorTotalPedido] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Pedidos] PRIMARY KEY CLUSTERED 
(
	[PedidoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TokensRedefinicao]    Script Date: 22/01/2026 14:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TokensRedefinicao](
	[TokenID] [int] IDENTITY(1,1) NOT NULL,
	[UsuarioID] [int] NOT NULL,
	[Token] [nvarchar](500) NOT NULL,
	[DataExpiracao] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_TokensRedefinicao] PRIMARY KEY CLUSTERED 
(
	[TokenID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 22/01/2026 14:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[UsuarioID] [int] IDENTITY(1,1) NOT NULL,
	[TipoUsuario] [nvarchar](20) NOT NULL,
	[NomeCompleto] [nvarchar](200) NOT NULL,
	[Cpf] [nvarchar](14) NOT NULL,
	[DataNascimento] [date] NOT NULL,
	[NomeUsuario] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Senha] [nvarchar](255) NOT NULL,
	[DataCriacao] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[UsuarioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[__DatabaseScriptLog] ADD  DEFAULT (sysdatetime()) FOR [ExecutedAt]
GO
ALTER TABLE [dbo].[Clientes] ADD  CONSTRAINT [DF_Clientes_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Clientes] ADD  CONSTRAINT [DF_Clientes_DataCriacao]  DEFAULT (getdate()) FOR [DataCriacao]
GO
ALTER TABLE [dbo].[Clientes] ADD  DEFAULT ((0)) FOR [IsVendedor]
GO
ALTER TABLE [dbo].[Empresa] ADD  DEFAULT (getdate()) FOR [DataCriacao]
GO
ALTER TABLE [dbo].[FormaPagamento] ADD  DEFAULT ((1)) FOR [Ativo]
GO
ALTER TABLE [dbo].[Fornecedor] ADD  CONSTRAINT [DF_Fornecedor_DataCriacao]  DEFAULT (getdate()) FOR [DataCriacao]
GO
ALTER TABLE [dbo].[ItemVenda] ADD  DEFAULT ((0)) FOR [Subtotal]
GO
ALTER TABLE [dbo].[ItemVenda] ADD  CONSTRAINT [DF_ItemVenda_DescontoItem]  DEFAULT ((0)) FOR [DescontoItem]
GO
ALTER TABLE [dbo].[MovimentacaoEstoque] ADD  DEFAULT (getdate()) FOR [DataMovimentacao]
GO
ALTER TABLE [dbo].[PagamentosParciais] ADD  CONSTRAINT [DF_PagamentosParciais_DataPagamento]  DEFAULT (getdate()) FOR [DataPagamento]
GO
ALTER TABLE [dbo].[Parcela] ADD  CONSTRAINT [DF_Parcela_ValorRecebido]  DEFAULT ((0)) FOR [ValorRecebido]
GO
ALTER TABLE [dbo].[Parcela] ADD  CONSTRAINT [DF_Parcela_Status]  DEFAULT ('Pendente') FOR [Status]
GO
ALTER TABLE [dbo].[Parcela] ADD  CONSTRAINT [DF_Parcela_Juros]  DEFAULT ((0)) FOR [Juros]
GO
ALTER TABLE [dbo].[Parcela] ADD  CONSTRAINT [DF_Parcela_Multa]  DEFAULT ((0)) FOR [Multa]
GO
ALTER TABLE [dbo].[Produtos] ADD  CONSTRAINT [DF_Produtos_DataDeEntrada]  DEFAULT (getdate()) FOR [DataDeEntrada]
GO
ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [DF_Usuarios_TipoUsuario]  DEFAULT ('Normal') FOR [TipoUsuario]
GO
ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [DF_Usuarios_NomeCompleto]  DEFAULT ('') FOR [NomeCompleto]
GO
ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [DF_Usuarios_DataCriacao]  DEFAULT (getdate()) FOR [DataCriacao]
GO
ALTER TABLE [dbo].[Venda] ADD  CONSTRAINT [DF_Venda_DataVenda]  DEFAULT (getdate()) FOR [DataVenda]
GO
ALTER TABLE [dbo].[Venda] ADD  CONSTRAINT [DF_Venda_Desconto]  DEFAULT ((0)) FOR [Desconto]
GO
ALTER TABLE [dbo].[Venda] ADD  CONSTRAINT [DF_Venda_StatusVenda]  DEFAULT ('Aberta') FOR [StatusVenda]
GO
ALTER TABLE [dbo].[Cidade]  WITH CHECK ADD  CONSTRAINT [FK_Cidade_EstadoID] FOREIGN KEY([EstadoID])
REFERENCES [dbo].[Estado] ([EstadoID])
GO
ALTER TABLE [dbo].[Cidade] CHECK CONSTRAINT [FK_Cidade_EstadoID]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_CidadeID] FOREIGN KEY([CidadeID])
REFERENCES [dbo].[Cidade] ([CidadeID])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_CidadeID]
GO
ALTER TABLE [dbo].[Fornecedor]  WITH CHECK ADD  CONSTRAINT [FK_Fornecedor_CidadeID] FOREIGN KEY([CidadeID])
REFERENCES [dbo].[Cidade] ([CidadeID])
GO
ALTER TABLE [dbo].[Fornecedor] CHECK CONSTRAINT [FK_Fornecedor_CidadeID]
GO
ALTER TABLE [dbo].[ItemVenda]  WITH CHECK ADD  CONSTRAINT [FK_ItemVenda_ProdutoID] FOREIGN KEY([ProdutoID])
REFERENCES [dbo].[Produtos] ([ProdutoID])
GO
ALTER TABLE [dbo].[ItemVenda] CHECK CONSTRAINT [FK_ItemVenda_ProdutoID]
GO
ALTER TABLE [dbo].[ItemVenda]  WITH CHECK ADD  CONSTRAINT [FK_ItemVenda_VendaID] FOREIGN KEY([VendaID])
REFERENCES [dbo].[Venda] ([VendaID])
GO
ALTER TABLE [dbo].[ItemVenda] CHECK CONSTRAINT [FK_ItemVenda_VendaID]
GO
ALTER TABLE [dbo].[ItensPedido]  WITH CHECK ADD  CONSTRAINT [FK_ItensPedido_PedidoID] FOREIGN KEY([PedidoID])
REFERENCES [dbo].[Pedidos] ([PedidoID])
GO
ALTER TABLE [dbo].[ItensPedido] CHECK CONSTRAINT [FK_ItensPedido_PedidoID]
GO
ALTER TABLE [dbo].[MovimentacaoEstoque]  WITH CHECK ADD  CONSTRAINT [FK_MovEstoque_Produto] FOREIGN KEY([ProdutoID])
REFERENCES [dbo].[Produtos] ([ProdutoID])
GO
ALTER TABLE [dbo].[MovimentacaoEstoque] CHECK CONSTRAINT [FK_MovEstoque_Produto]
GO
ALTER TABLE [dbo].[PagamentosParciais]  WITH CHECK ADD  CONSTRAINT [FK_PagamentosParciais_FormaPgtoID] FOREIGN KEY([FormaPgtoID])
REFERENCES [dbo].[FormaPagamento] ([FormaPgtoID])
GO
ALTER TABLE [dbo].[PagamentosParciais] CHECK CONSTRAINT [FK_PagamentosParciais_FormaPgtoID]
GO
ALTER TABLE [dbo].[PagamentosParciais]  WITH CHECK ADD  CONSTRAINT [FK_PagamentosParciais_ParcelaID] FOREIGN KEY([ParcelaID])
REFERENCES [dbo].[Parcela] ([ParcelaID])
GO
ALTER TABLE [dbo].[PagamentosParciais] CHECK CONSTRAINT [FK_PagamentosParciais_ParcelaID]
GO
ALTER TABLE [dbo].[Parcela]  WITH CHECK ADD  CONSTRAINT [FK_Parcela_VendaID] FOREIGN KEY([VendaID])
REFERENCES [dbo].[Venda] ([VendaID])
GO
ALTER TABLE [dbo].[Parcela] CHECK CONSTRAINT [FK_Parcela_VendaID]
GO
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_FornecedorID] FOREIGN KEY([FornecedorID])
REFERENCES [dbo].[Fornecedor] ([FornecedorID])
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedidos_FornecedorID]
GO
ALTER TABLE [dbo].[Produtos]  WITH CHECK ADD  CONSTRAINT [FK_Produtos_FornecedorID] FOREIGN KEY([FornecedorID])
REFERENCES [dbo].[Fornecedor] ([FornecedorID])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Produtos] CHECK CONSTRAINT [FK_Produtos_FornecedorID]
GO
ALTER TABLE [dbo].[TokensRedefinicao]  WITH CHECK ADD  CONSTRAINT [FK_TokensRedefinicao_UsuarioID] FOREIGN KEY([UsuarioID])
REFERENCES [dbo].[Usuarios] ([UsuarioID])
GO
ALTER TABLE [dbo].[TokensRedefinicao] CHECK CONSTRAINT [FK_TokensRedefinicao_UsuarioID]
GO
ALTER TABLE [dbo].[Venda]  WITH CHECK ADD FOREIGN KEY([VendedorID])
REFERENCES [dbo].[Clientes] ([ClienteID])
GO
ALTER TABLE [dbo].[Venda]  WITH CHECK ADD  CONSTRAINT [FK_Venda_ClienteID] FOREIGN KEY([ClienteID])
REFERENCES [dbo].[Clientes] ([ClienteID])
GO
ALTER TABLE [dbo].[Venda] CHECK CONSTRAINT [FK_Venda_ClienteID]
GO
ALTER TABLE [dbo].[Venda]  WITH CHECK ADD  CONSTRAINT [FK_Venda_FormaPgtoID] FOREIGN KEY([FormaPgtoID])
REFERENCES [dbo].[FormaPagamento] ([FormaPgtoID])
GO
ALTER TABLE [dbo].[Venda] CHECK CONSTRAINT [FK_Venda_FormaPgtoID]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [CHK_Clientes_Cnpj_Length] CHECK  (([Cnpj] IS NULL OR len([Cnpj])=(14)))
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [CHK_Clientes_Cnpj_Length]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [CHK_Clientes_Cpf_Length] CHECK  (([Cpf] IS NULL OR len([Cpf])=(11)))
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [CHK_Clientes_Cpf_Length]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [CHK_Clientes_DataNascimento] CHECK  (([DataNascimento] IS NULL OR [DataNascimento]<=getdate()))
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [CHK_Clientes_DataNascimento]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [CHK_Clientes_Email_Format] CHECK  (([Email] IS NULL OR [Email] like '%_@_%._%'))
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [CHK_Clientes_Email_Format]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [CHK_Clientes_Telefone_Length] CHECK  (([Telefone] IS NULL OR len([Telefone])>=(10)))
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [CHK_Clientes_Telefone_Length]
GO
ALTER TABLE [dbo].[Fornecedor]  WITH CHECK ADD  CONSTRAINT [CHK_Fornecedor_Telefone_Length] CHECK  (([Telefone] IS NULL OR len([Telefone])>=(8) AND len([Telefone])<=(15)))
GO
ALTER TABLE [dbo].[Fornecedor] CHECK CONSTRAINT [CHK_Fornecedor_Telefone_Length]
GO
ALTER TABLE [dbo].[ItemVenda]  WITH CHECK ADD  CONSTRAINT [CHK_ItemVenda_Quantidade_Positivo] CHECK  (([Quantidade]>(0)))
GO
ALTER TABLE [dbo].[ItemVenda] CHECK CONSTRAINT [CHK_ItemVenda_Quantidade_Positivo]
GO
ALTER TABLE [dbo].[ItensPedido]  WITH CHECK ADD  CONSTRAINT [CHK_ItensPedido_Quantidade_Positivo] CHECK  (([Quantidade]>(0)))
GO
ALTER TABLE [dbo].[ItensPedido] CHECK CONSTRAINT [CHK_ItensPedido_Quantidade_Positivo]
GO
ALTER TABLE [dbo].[Parcela]  WITH CHECK ADD  CONSTRAINT [CHK_Parcela_Juros_Positivo] CHECK  (([Juros]>=(0)))
GO
ALTER TABLE [dbo].[Parcela] CHECK CONSTRAINT [CHK_Parcela_Juros_Positivo]
GO
ALTER TABLE [dbo].[Parcela]  WITH CHECK ADD  CONSTRAINT [CHK_Parcela_Multa_Positivo] CHECK  (([Multa]>=(0)))
GO
ALTER TABLE [dbo].[Parcela] CHECK CONSTRAINT [CHK_Parcela_Multa_Positivo]
GO
ALTER TABLE [dbo].[Parcela]  WITH CHECK ADD  CONSTRAINT [CHK_Parcela_ValorParcela_Positivo] CHECK  (([ValorParcela]>=(0)))
GO
ALTER TABLE [dbo].[Parcela] CHECK CONSTRAINT [CHK_Parcela_ValorParcela_Positivo]
GO
ALTER TABLE [dbo].[Parcela]  WITH CHECK ADD  CONSTRAINT [CK_Parcela_Status] CHECK  (([Status]='Cancelada' OR [Status]='Atrasada' OR [Status]='Pago' OR [Status]='ParcialmentePago' OR [Status]='Pendente'))
GO
ALTER TABLE [dbo].[Parcela] CHECK CONSTRAINT [CK_Parcela_Status]
GO
ALTER TABLE [dbo].[Produtos]  WITH CHECK ADD  CONSTRAINT [CHK_Produtos_Estoque_Positivo] CHECK  (([Estoque]>=(0)))
GO
ALTER TABLE [dbo].[Produtos] CHECK CONSTRAINT [CHK_Produtos_Estoque_Positivo]
GO
ALTER TABLE [dbo].[Produtos]  WITH CHECK ADD  CONSTRAINT [CHK_Produtos_Lucro_Positivo] CHECK  (([Lucro]>=(0)))
GO
ALTER TABLE [dbo].[Produtos] CHECK CONSTRAINT [CHK_Produtos_Lucro_Positivo]
GO
ALTER TABLE [dbo].[Produtos]  WITH CHECK ADD  CONSTRAINT [CHK_Produtos_PrecoCusto_Positivo] CHECK  (([PrecoCusto]>=(0)))
GO
ALTER TABLE [dbo].[Produtos] CHECK CONSTRAINT [CHK_Produtos_PrecoCusto_Positivo]
GO
ALTER TABLE [dbo].[Produtos]  WITH CHECK ADD  CONSTRAINT [CHK_Produtos_PrecoVenda_Positivo] CHECK  (([PrecoDeVenda]>=(0)))
GO
ALTER TABLE [dbo].[Produtos] CHECK CONSTRAINT [CHK_Produtos_PrecoVenda_Positivo]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [CHK_Usuarios_Cpf_Length] CHECK  ((len([Cpf])>=(11) AND len([Cpf])<=(14)))
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [CHK_Usuarios_Cpf_Length]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [CHK_Usuarios_DataNascimento] CHECK  (([DataNascimento]<=getdate() AND datediff(year,[DataNascimento],getdate())<=(150)))
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [CHK_Usuarios_DataNascimento]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [CHK_Usuarios_Email_Format] CHECK  (([Email] like '%_@_%._%'))
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [CHK_Usuarios_Email_Format]
GO
ALTER TABLE [dbo].[Venda]  WITH CHECK ADD  CONSTRAINT [CHK_Venda_Desconto_Positivo] CHECK  (([Desconto]>=(0)))
GO
ALTER TABLE [dbo].[Venda] CHECK CONSTRAINT [CHK_Venda_Desconto_Positivo]
GO
ALTER TABLE [dbo].[Venda]  WITH CHECK ADD  CONSTRAINT [CHK_Venda_ValorTotal_Positivo] CHECK  (([ValorTotal]>=(0)))
GO
ALTER TABLE [dbo].[Venda] CHECK CONSTRAINT [CHK_Venda_ValorTotal_Positivo]
GO
/****** Object:  StoredProcedure [dbo].[sp_backup_diario]    Script Date: 22/01/2026 14:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedure para backup diário automático (executar como job)
CREATE   PROCEDURE [dbo].[sp_backup_diario]
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @CaminhoBackup NVARCHAR(500);
    DECLARE @NomeArquivo NVARCHAR(500);
    
    SET @CaminhoBackup = 'C:\BackupSQL\';
    SET @NomeArquivo = @CaminhoBackup + 'bdsiscontrol_' + 
                       CONVERT(NVARCHAR(8), GETDATE(), 112) + '_' +
                       REPLACE(CONVERT(NVARCHAR(8), GETDATE(), 108), ':', '') + 
                       '.bak';
    
    -- Criar diretório se não existir
    EXEC xp_create_subdir @CaminhoBackup;
    
    -- Executar backup
    BACKUP DATABASE bdsiscontrol 
    TO DISK = @NomeArquivo
    WITH INIT, STATS = 10;
    
    PRINT 'Backup realizado com sucesso: ' + @NomeArquivo;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_gerar_parcelas]    Script Date: 22/01/2026 14:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedure para gerar parcelas de uma venda
CREATE   PROCEDURE [dbo].[sp_gerar_parcelas]
    @VendaID INT,
    @NumeroParcelas INT,
    @DataPrimeiroVencimento DATE,
    @FormaPgtoID INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        BEGIN TRANSACTION;
        
        DECLARE @ValorTotal DECIMAL(18,2);
        DECLARE @ValorParcela DECIMAL(18,2);
        DECLARE @Contador INT = 1;
        
        -- Obter valor total da venda
        SELECT @ValorTotal = ValorTotal FROM Venda WHERE VendaID = @VendaID;
        
        IF @ValorTotal IS NULL
        BEGIN
            RAISERROR('Venda não encontrada.', 16, 1);
            RETURN;
        END
        
        -- Calcular valor da parcela
        SET @ValorParcela = @ValorTotal / @NumeroParcelas;
        
        -- Gerar parcelas
        WHILE @Contador <= @NumeroParcelas
        BEGIN
            INSERT INTO Parcela (VendaID, NumeroParcela, DataVencimento, ValorParcela)
            VALUES (
                @VendaID,
                @Contador,
                DATEADD(MONTH, @Contador - 1, @DataPrimeiroVencimento),
                @ValorParcela
            );
            
            SET @Contador = @Contador + 1;
        END
        
        -- Atualizar forma de pagamento da venda
        IF @FormaPgtoID IS NOT NULL
        BEGIN
            UPDATE Venda SET FormaPgtoID = @FormaPgtoID WHERE VendaID = @VendaID;
        END
        
        COMMIT TRANSACTION;
        
        SELECT 'Parcelas geradas com sucesso' AS Mensagem;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_registrar_pagamento]    Script Date: 22/01/2026 14:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedure para registrar pagamento
CREATE   PROCEDURE [dbo].[sp_registrar_pagamento]
    @ParcelaID INT,
    @ValorPago DECIMAL(18,2),
    @FormaPgtoID INT = NULL,
    @Observacao NVARCHAR(MAX) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        BEGIN TRANSACTION;
        
        -- Verificar se a parcela existe
        IF NOT EXISTS (SELECT 1 FROM Parcela WHERE ParcelaID = @ParcelaID)
        BEGIN
            RAISERROR('Parcela não encontrada.', 16, 1);
            RETURN;
        END
        
        -- Registrar pagamento parcial
        INSERT INTO PagamentosParciais (ParcelaID, ValorPago, FormaPgtoID, Observacao)
        VALUES (@ParcelaID, @ValorPago, @FormaPgtoID, @Observacao);
        
        -- Atualizar status da venda se todas as parcelas estiverem pagas
        UPDATE v
        SET v.StatusVenda = 'Finalizada'
        FROM Venda v
        INNER JOIN Parcela p ON v.VendaID = p.VendaID
        WHERE v.VendaID = (SELECT VendaID FROM Parcela WHERE ParcelaID = @ParcelaID)
        AND NOT EXISTS (
            SELECT 1 FROM Parcela p2 
            WHERE p2.VendaID = v.VendaID 
            AND p2.Status NOT IN ('Paga')
        );
        
        COMMIT TRANSACTION;
        
        SELECT 'Pagamento registrado com sucesso' AS Mensagem;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_registrar_venda]    Script Date: 22/01/2026 14:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- 7. STORED PROCEDURES
-- =============================================

-- Procedure para registrar nova venda
CREATE   PROCEDURE [dbo].[sp_registrar_venda]
    @ClienteID INT,
    @FormaPgtoID INT = NULL,
    @Observacoes NVARCHAR(MAX) = NULL,
    @Itens NVARCHAR(MAX) -- JSON array: [{"ProdutoID":1,"Quantidade":2,"PrecoUnitario":10.50}]
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        BEGIN TRANSACTION;
        
        DECLARE @ValorTotal DECIMAL(18,2) = 0;
        DECLARE @VendaID INT;
        
        -- Calcular valor total a partir dos itens
        SELECT @ValorTotal = SUM(
            CAST(JSON_VALUE(item.value, '$.Quantidade') AS INT) * 
            CAST(JSON_VALUE(item.value, '$.PrecoUnitario') AS DECIMAL(18,2))
        )
        FROM OPENJSON(@Itens) AS item;
        
        -- Inserir venda
        INSERT INTO Venda (ClienteID, FormaPgtoID, ValorTotal, Observacoes)
        VALUES (@ClienteID, @FormaPgtoID, @ValorTotal, @Observacoes);
        
        SET @VendaID = SCOPE_IDENTITY();
        
        -- Inserir itens da venda
        INSERT INTO ItemVenda (VendaID, ProdutoID, Quantidade, PrecoUnitario)
        SELECT 
            @VendaID,
            CAST(JSON_VALUE(item.value, '$.ProdutoID') AS INT),
            CAST(JSON_VALUE(item.value, '$.Quantidade') AS INT),
            CAST(JSON_VALUE(item.value, '$.PrecoUnitario') AS DECIMAL(18,2))
        FROM OPENJSON(@Itens) AS item;
        
        COMMIT TRANSACTION;
        
        SELECT @VendaID AS VendaID, 'Venda registrada com sucesso' AS Mensagem;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_relatorio_vendas_periodo]    Script Date: 22/01/2026 14:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_relatorio_vendas_periodo]
    @DataInicio DATE,
    @DataFim DATE
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        v.DataVenda,
        c.Nome AS Cliente,
        fp.NomeFormaPagamento AS FormaPagamento,
        v.ValorTotal,
        v.Desconto,
        v.ValorTotal - v.Desconto AS ValorLiquido,
        v.StatusVenda,
        COUNT(iv.ItemVendaID) AS QuantidadeItens,
        STRING_AGG(p.NomeProduto, ', ') WITHIN GROUP (ORDER BY p.NomeProduto) AS Produtos
    FROM Venda v
    INNER JOIN Clientes c ON v.ClienteID = c.ClienteID
    LEFT JOIN FormaPagamento fp ON v.FormaPgtoID = fp.FormaPgtoID
    LEFT JOIN ItemVenda iv ON v.VendaID = iv.VendaID
    LEFT JOIN Produtos p ON iv.ProdutoID = p.ProdutoID
    WHERE CAST(v.DataVenda AS DATE) BETWEEN @DataInicio AND @DataFim
    GROUP BY 
        v.DataVenda, c.Nome, fp.NomeFormaPagamento, 
        v.ValorTotal, v.Desconto, v.StatusVenda
    ORDER BY v.DataVenda DESC;
END;
GO
USE [master]
GO
ALTER DATABASE [bdsiscontrol] SET  READ_WRITE 
GO
