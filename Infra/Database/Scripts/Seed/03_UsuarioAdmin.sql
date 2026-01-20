IF NOT EXISTS (SELECT 1 FROM dbo.Usuarios WHERE NomeUsuario = 'admin')
BEGIN
    INSERT INTO dbo.Usuarios
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