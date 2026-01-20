


IF NOT EXISTS (SELECT 1 FROM FormaPagamento)
BEGIN
    INSERT INTO FormaPagamento (NomeFormaPagamento, Ativo)
    VALUES
    ('Dinheiro', 1),
    ('Cartão de Crédito', 1),
    ('Cartão de Débito', 1),
    ('PIX', 1),    
    ('Boleto', 1),
    ('Transferência',1),
    ('Cheque',1),
    ('Crediário', 1);
END;

IF NOT EXISTS (SELECT 1 FROM Empresa)
BEGIN
    INSERT INTO Empresa
    (
        RazaoSocial,
        NomeFantasia,
        CNPJ,
        Logradouro,
        Bairro,
        Cep,
        Cidade,
        UF
    )
    VALUES
    (
        'EMPRESA NÃO CONFIGURADA',
        'CONFIGURE SUA EMPRESA',
        '00000000000000',
        'NÃO INFORMADO',
        'NÃO INFORMADO',
        '00000-000',
        'NÃO INFORMADO',
        'SP'
    );
END;

IF NOT EXISTS (SELECT 1 FROM Usuarios)
BEGIN
    INSERT INTO Usuarios
    (
        TipoUsuario,
        NomeCompleto,
        Cpf,
        DataNascimento,
        NomeUsuario,
        Email,
        Senha
    )
    VALUES
    (
        'Administrador',
        'Administrador do Sistema',
        '00000000000',
        '1980-01-01',
        'admin',
        'admin@sistema.local',
        'admin'
    );
END;

IF NOT EXISTS (SELECT 1 FROM VersaoSistema)
BEGIN
    INSERT INTO VersaoSistema (Id, Versao, DataAtualizacao)
    VALUES (1, '1.0.0', GETDATE());
END;


