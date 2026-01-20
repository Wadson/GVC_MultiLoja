IF NOT EXISTS (SELECT 1 FROM dbo.Empresa)
BEGIN
    INSERT INTO dbo.Empresa
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
        'EMPRESA N�O CONFIGURADA',
        'CONFIGURE SUA EMPRESA',
        '00000000000000',
        'N�O INFORMADO',
        'N�O INFORMADO',
        '00000-000',
        'N�O INFORMADO',
        'SP'
    );
END;