--- Consulta SQL que retorna o código, a razão social e o(s) telefone(s) de todos os clientes do estado de São Paulo (código “SP”) ---

SELECT 
    c.id_cliente AS codigo_cliente, 
    c.razao_social, 
    t.numero AS telefone
FROM 
    Clientes c
INNER JOIN 
    Telefone t ON c.id_cliente = t.cliente_id
INNER JOIN 
    Estado e ON c.estado_id = e.id_estado
WHERE 
    e.sigla = 'SP';

---------------------------------------------------------------------------
----- Valores aleatorios para popular as tabelas e testar a consulta ------

INSERT INTO Estado
        (sigla, nome)
    VALUES
        ('SP', 'São Paulo'),
        ('RJ', 'Rio de Janeiro'),
        ('MG', 'Minas Gerais'),
        ('BA', 'Bahia'),
        ('RS', 'Rio Grande do Sul');

INSERT INTO Clientes
        (razao_social, estado_id)
    VALUES
        ('Empresa A', 1),
        ('Empresa B', 2),
        ('Empresa C', 3),
        ('Empresa D', 4),
        ('Empresa E', 5);

INSERT INTO Tipos_Telefone
        (tipo)
    VALUES
        ('Comercial'),
        ('Residencial'),
        ('Celular');

INSERT INTO Telefone
        (numero, cliente_id, tipo_telefone_id)
    VALUES
        ('(11) 1111-1111', 1, 1),
        ('(21) 2121-2121', 1, 2),
        ('(31) 3131-3131', 2, 3),
        ('(71) 7171-7171', 3, 1),
        ('(51) 7171-7171', 4, 2);