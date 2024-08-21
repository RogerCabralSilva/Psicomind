-- ========================================
-- Criação do banco de dados
-- ========================================

CREATE DATABASE psicomindDB;
USE psicomindDB;

-- drop database psicomindDB

-- ========================================
-- Criação das tabelas
-- ========================================


CREATE TABLE genero (
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    genero VARCHAR(25) NOT NULL
);

-- Tabela clientes
CREATE TABLE clientes (
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(60) NOT NULL UNIQUE,
    senha CHAR(32) NOT NULL,
    CPF CHAR(11) NOT NULL UNIQUE,
    data_cad TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    data_nasc DATE NOT NULL,
	genero_id INT NOT NULL,
    ativo BIT(1) NOT NULL,
    CONSTRAINT fk_generoCliente_id FOREIGN KEY (genero_id) REFERENCES genero(id)
);


-- Tabela telefone_tipo
CREATE TABLE telefone_tipo (
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    tipo VARCHAR(20) NOT NULL UNIQUE
);

-- Tabela telefone_cliente
CREATE TABLE telefone_cliente (
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    numero CHAR(11) NOT NULL UNIQUE,
    cliente_id INT NOT NULL,
    telefone_tipo_id INT NOT NULL,
    CONSTRAINT fk_telefone_cliente_cliente_id FOREIGN KEY (cliente_id) REFERENCES clientes(id),
    CONSTRAINT fk_telefone_cliente_tipo_id FOREIGN KEY (telefone_tipo_id) REFERENCES telefone_tipo(id)
);

-- Tabela tipo endereco
CREATE TABLE tipo_endereco (
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(50) NOT NULL,
    tipo_endereco CHAR(3) NOT NULL
);

-- Tabela enderecos
CREATE TABLE enderecos (
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    cliente_id INT NOT NULL,
    cep CHAR(8) NOT NULL,
    rua VARCHAR(100) NOT NULL,
    numero VARCHAR(20) NOT NULL,
    bairro VARCHAR(60) NOT NULL,
    cidade VARCHAR(60) NOT NULL,
    uf CHAR(2) NOT NULL,
    tipo_endereco_id INT NOT NULL,
    CONSTRAINT fk_enderecos_cliente_id FOREIGN KEY (cliente_id) REFERENCES clientes(id),
    CONSTRAINT fk_tipoEndereco_id FOREIGN KEY (tipo_endereco_id) REFERENCES tipo_endereco(id)
);

-- Tabela cargos
CREATE TABLE cargos (
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(50) NOT NULL,
    sigla CHAR(3) NOT NULL
);



-- Tabela usuarios
CREATE TABLE usuarios (
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    cargo_id INT NOT NULL,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(60) NOT NULL UNIQUE,
    senha CHAR(32) NOT NULL,
    ativo BIT(1) NOT NULL,
    CONSTRAINT fk_usuarioCargo_cargo_id FOREIGN KEY (cargo_id) REFERENCES cargos(id)
    
);



-- Tabela profissionais
CREATE TABLE profissionais (
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(60) NOT NULL UNIQUE,
    senha CHAR(32) NOT NULL,
    CPF CHAR(11) NOT NULL UNIQUE,
    especializacao VARCHAR(100) NOT NULL,
    data_contrato DATE NULL,
    data_cad TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    data_nasc DATE NOT NULL,
    genero_id INT NOT NULL,
    ativo BIT(1) NOT NULL,
    CONSTRAINT fk_generoProfissional_id FOREIGN KEY (genero_id) 
    REFERENCES genero(id)
);


-- Tabela telefone_profissional
CREATE TABLE telefone_profissional (
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    numero CHAR(11) NOT NULL UNIQUE,
    profissional_id INT NOT NULL,
    telefone_tipo_id INT NOT NULL,
    CONSTRAINT fk_telefone_profissional_profissional_id FOREIGN KEY (profissional_id) REFERENCES profissionais(id),
    CONSTRAINT fk_telefone_profissional_tipo_id FOREIGN KEY (telefone_tipo_id) REFERENCES telefone_tipo(id)
);

-- Tabela tipo_agendamento
CREATE TABLE tipo_agendamento (
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    tipo_agendamento VARCHAR(50) NOT NULL
);

-- Tabela grupo
CREATE TABLE grupo (
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    cliente_id INT NOT NULL,
    maximo_pessoas DECIMAL(10,2) NOT NULL,
    CONSTRAINT fk_cliente_id FOREIGN KEY (cliente_id) REFERENCES clientes(id)
);

CREATE TABLE escala (

    id INT AUTO_INCREMENT PRIMARY KEY,
    profissional_id INT NOT NULL,
    dia DATE NOT NULL,
    horario TIME NOT NULL,
    disponivel BIT NOT NULL,
    CONSTRAINT fk_profissional_escala FOREIGN KEY (profissional_id) REFERENCES profissionais(id),
    UNIQUE (profissional_id, dia, horario)  -- Evita duplicação de dia e horário

);

-- Tabela  preco
CREATE TABLE preco_consulta (
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    preco DECIMAL(10,2) NOT NULL,	
    tipo_agendamento_id INT NOT NULL,
    CONSTRAINT fk_preco_consulta_tipo_agendamento_id FOREIGN KEY (tipo_agendamento_id) REFERENCES tipo_agendamento(id)
);

-- Tabela agendamentos
CREATE TABLE agendamentos (
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    profissionais_id INT NOT NULL,
    usuarios_id INT NOT NULL,
    escala_id INT NOT NULL,
    tipo_agendamento_id INT NOT NULL,
    status_agendamento CHAR(1) NOT NULL,
    CONSTRAINT fk_agendamentos_profissionais_id FOREIGN KEY (profissionais_id) REFERENCES profissionais(id),
    CONSTRAINT fk_agendamentos_usuarios_id FOREIGN KEY (usuarios_id) REFERENCES usuarios(id),
    CONSTRAINT fk_agendamentos_escala_id FOREIGN KEY (escala_id) REFERENCES escala(id),
    CONSTRAINT fk_tipoAgendamento_id FOREIGN KEY (tipo_agendamento_id) REFERENCES tipo_agendamento(id)
);


-- Tabela Cliente Agendamento 
CREATE TABLE cliente_agendamento (
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    cliente_id INT NOT NULL,
    agendamento_id INT NOT NULL,
	CONSTRAINT fk_clienteAgendamento_id FOREIGN KEY (cliente_id) REFERENCES clientes(id),
    CONSTRAINT fk_agendamentoCliente_id FOREIGN KEY (agendamento_id) REFERENCES agendamentos(id)
);


-- Tabela consultas
CREATE TABLE consultas (
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    agendamento_id INT NOT NULL,
	observacoes_consulta VARCHAR(200) NULL,
    status_pagamento CHAR(1) NOT NULL,
    status_consulta ENUM("Concluída", "Não compareceu", "Em andamento"),
    CONSTRAINT fk_consultas_agendamento_id FOREIGN KEY (agendamento_id) REFERENCES agendamentos(id)
);


-- Inserir usuario ao cargo
-- INSERT INTO usuario_cargo (usuario_id, cargo_id) VALUES (1, 1);


-- ========================================
-- Procedures de inserção
-- ========================================

-- Inserir cliente
DELIMITER $$
CREATE PROCEDURE sp_clientes_insert(
    spnome VARCHAR(100),
    spemail VARCHAR(60),
    spsenha VARCHAR(20),
    spcpf CHAR(11),
    spdata_nasc DATE,
    spgenero_id INT
)
BEGIN
    INSERT INTO clientes 
    VALUES (0, spnome, spemail, MD5(spsenha), spcpf, CURRENT_TIMESTAMP, spdata_nasc, spgenero_id, 1);
    SELECT LAST_INSERT_ID() FROM clientes;
END $$
DELIMITER ;

-- Exemplo de chamada:
-- CALL sp_clientes_insert('Roger Cabral Silv', 'cabralroger15@gmail.com', '125', '46129420808', '2006-01-18');

-- Inserir telefone_cliente
DELIMITER $$
CREATE PROCEDURE sp_telefone_cliente_insert(
    spnumero CHAR(11),
    spcliente_id INT,
    sptelefone_tipo_id INT
)
BEGIN
    INSERT INTO telefone_cliente 
    VALUES (0,spnumero, spcliente_id, sptelefone_tipo_id);
    SELECT LAST_INSERT_ID() FROM telefone_cliente;
END $$
DELIMITER ;

-- Exemplo de chamada:
-- CALL sp_telefone_cliente_insert("119691140",1, 4);
-- Drop procedure sp_telefone_cliente_insert

-- Inserir endereço
DELIMITER $$
CREATE PROCEDURE sp_enderecos_insert(
    spcliente_id INT,
    spcep CHAR(8),
    sprua VARCHAR(100),
    spnumero VARCHAR(20),
    spbairro VARCHAR(60),
    spcidade VARCHAR(60),
    spuf CHAR(2),
    sptipo_endereco INT
)
BEGIN
    INSERT INTO enderecos
    VALUES (0, spcliente_id, spcep, sprua, spnumero, spbairro, spcidade, spuf, sptipo_endereco);
    SELECT LAST_INSERT_ID() FROM enderecos;
END $$
DELIMITER ;

-- Exemplo de chamada:
-- CALL sp_enderecos_insert(1, '08226001', 'Manoel dos Reis', '252', 'A.e Carvalho', 'SP');

-- Inserir usuário
DELIMITER $$
CREATE PROCEDURE sp_usuarios_insert(
    spnome VARCHAR(100),
    spemail VARCHAR(60),
    spsenha VARCHAR(20),
    spcargo_id INT
)
BEGIN
    INSERT INTO usuarios (nome, email, senha, ativo, cargo_id)
    VALUES (spnome, spemail, MD5(spsenha), 1, spcargo_id);
    SELECT LAST_INSERT_ID() FROM usuarios;
END $$
DELIMITER ;

-- Exemplo de chamada:
-- drop procedure sp_usuarios_insert;

-- Inserir profissional
DELIMITER $$
CREATE PROCEDURE sp_profissionais_insert(
    spnome VARCHAR(100),
    spemail VARCHAR(60),
    spsenha VARCHAR(20),
    spcpf CHAR(11),
    spespecializacao VARCHAR(100),
    spdata_contrato DATE,
    spdata_nasc DATE,
    spgenero_id INT
)
BEGIN
    INSERT INTO profissionais
    VALUES (0,spnome, spemail, MD5(spsenha), spcpf, spespecializacao, spdata_contrato, CURRENT_TIMESTAMP, spdata_nasc, spgenero_id,1);
    SELECT LAST_INSERT_ID() FROM profissionais;
END $$
DELIMITER ;



select * from genero
-- drop procedure sp_profissionais_insert

-- Inserir telefone_profissional
DELIMITER $$
CREATE PROCEDURE sp_telefone_profissional_insert(
    spnumero CHAR(11),
    spprofissional_id INT,
    sptelefone_tipo_id INT
)
BEGIN
    INSERT INTO telefone_profissional
    VALUES (0, spnumero, spprofissional_id, sptelefone_tipo_id);
    SELECT LAST_INSERT_ID() FROM telefone_profissional;
END $$
DELIMITER ;

-- Exemplo de chamada:
-- CALL sp_telefone_profissional_insert('11969531140', 1, 1);

-- Inserir agendamento com data_agendamento
DELIMITER $$
CREATE PROCEDURE sp_agendamentos_insert(
    spprofissional_id INT,
    spusuarios_id INT,
    spstatus_agendamento CHAR(1),
    spdata_agendamento DATETIME
)
BEGIN
    INSERT INTO agendamentos
    VALUES (0, spprofissional_id, spusuarios_id, spdata_agendamento, spstatus_agendamento);
    
    SELECT LAST_INSERT_ID() AS id;
END $$
DELIMITER ;

-- Exemplo de chamada com data_agendamento
-- CALL sp_agendamentos_insert(1, 1, 'A', '2024-06-07 14:00:00');

-- Inserir consulta
DELIMITER $$
CREATE PROCEDURE sp_consultas_insert(
    spagendamento_id INT,
    sphora_consulta TIME,
    spdata_consulta DATE,
    spstatus_pagamento CHAR(1)
)
BEGIN
    INSERT INTO consultas 
    VALUES (0, spagendamento_id, sphora_consulta, spdata_consulta, spstatus_pagamento);
    
    SELECT LAST_INSERT_ID() AS id;
END $$
DELIMITER ;

-- CALL sp_consultas_insert(1,"14:30", "2025/01/19", "N")

-- Inserir tipo_agendamento

DELIMITER $$
CREATE PROCEDURE sp_tipo_agendamento_insert(
    spcliente_id INT,
    spagendamento_id INT,
    sptypeAgend VARCHAR(50)
)
BEGIN
    INSERT INTO tipo_agendamento 
    VALUES (spcliente_id, spagendamento_id, sptypeAgend);
    
    SELECT LAST_INSERT_ID() AS id;
END $$
DELIMITER ;

-- Exemplo de chamada:
-- CALL sp_tipo_agendamento_insert(1, 1, 'Consulta inicial');
-- drop procedure sp_tipo_agendamento_insert

-- ========================================
-- Procedures de delete
-- =====================================

-- Deletar telefone_cliente
DELIMITER $$
CREATE PROCEDURE sp_telefone_cliente_delete(
    spid INT
)
BEGIN
    DELETE FROM telefone_cliente
    WHERE id = spid;
END $$
DELIMITER ;

-- Exemplo de chamada:
-- CALL sp_telefone_cliente_delete(1);

-- Deletar telefone_profissional
DELIMITER $$
CREATE PROCEDURE sp_telefone_profissional_delete(
    spid INT
)
BEGIN
    DELETE FROM telefone_profissional
    WHERE id = spid;
END $$
DELIMITER ;

-- Exemplo de chamada:
-- CALL sp_telefone_profissional_delete(1);

-- Deletar enderecos
DELIMITER $$
CREATE PROCEDURE sp_enderecos_delete(
    spid INT
)
BEGIN
    DELETE FROM enderecos
    WHERE id = spid;
END $$
DELIMITER ;

-- Exemplo de chamada:
-- CALL sp_enderecos_delete(1);

-- ========================================
-- Procedures de update
-- ========================================

-- Atualizar cliente
DELIMITER $$
CREATE PROCEDURE sp_clientes_update(
    spid INT,
    spnome VARCHAR(100),
    spsenha VARCHAR(20),
    spdata_nasc DATE,
	spgenero_id INT,
    spativo BIT
)
BEGIN
    UPDATE clientes
    SET 
    nome = spnome, 
    senha = MD5(spsenha),
    data_nasc = spdata_nasc,
	genero_id = spgenero_id,
    ativo = spativo
    WHERE id = spid;
END $$
DELIMITER ;

-- Exemplo de chamada:
-- CALL sp_clientes_update(1, 'Roger Santos', '987', '2006-01-24',1, 0);

-- Atualizar telefone_cliente
DELIMITER $$
CREATE PROCEDURE sp_telefone_cliente_update(
    spcliente_id INT,
    spnumero CHAR(11),
    sptelefone_tipo_id INT
)
BEGIN
    UPDATE telefone_cliente
    SET numero = spnumero, telefone_tipo_id = sptelefone_tipo_id
    WHERE cliente_id = spcliente_id;
END $$
DELIMITER ;

-- Exemplo de chamada:
-- CALL sp_telefone_cliente_update(1, '11969531141', 2);

-- Atualizar telefone_profissional
DELIMITER $$
CREATE PROCEDURE sp_telefone_profissional_update(
    spprofissional_id INT,
    spnumero CHAR(11),
    sptelefone_tipo_id INT
)
BEGIN
    UPDATE telefone_profissional
    SET numero = spnumero, telefone_tipo_id = sptelefone_tipo_id
    WHERE profissional_id = spprofissional_id;
END $$
DELIMITER ;

-- Exemplo de chamada:
-- CALL sp_telefone_profissional_update(1, '11969531141', 2);

-- Atualizar enderecos
DELIMITER $$
CREATE PROCEDURE sp_enderecos_update(
    spcliente_id INT,
    spcep CHAR(8),
    sprua VARCHAR(100),
    spnumero VARCHAR(20),
    spbairro VARCHAR(60),
    spcidade VARCHAR(60),
    spuf CHAR(2),
    sptipo_endereco INT
)
BEGIN
    UPDATE enderecos
    SET  cep = spcep, rua = sprua, numero = spnumero, bairro = spbairro, cidade = spcidade, uf = spuf, tipo_endereco_id = sptipo_endereco
    WHERE cliente_id = spcliente_id;
END $$
DELIMITER ;

-- Exemplo de chamada:
-- CALL sp_enderecos_update(1, '12345678', 'Nova Rua', '123', 'Novo Bairro', 'SP');
-- drop procedure sp_enderecos_update;

-- Atualizar usuarios
DELIMITER $$
CREATE PROCEDURE sp_usuarios_update(
    spid INT,
    spnome VARCHAR(100),
    spsenha VARCHAR(20),
    spativo BIT
)
BEGIN
    UPDATE usuarios
    SET nome = spnome, senha = MD5(spsenha), ativo = spativo
    WHERE id = spid;
END $$
DELIMITER ;

-- Exemplo de chamada:
-- CALL sp_usuarios_update(1, 'AANNIE', '345', 1);

-- Atualizar profissionais
DELIMITER $$
CREATE PROCEDURE sp_profissionais_update(
    spid INT,
    spnome VARCHAR(100),
    spsenha VARCHAR(20),
    spespecializacao VARCHAR(100),
    spdata_contrato DATE,
    spdata_nasc DATE,
    spgenero_id INT,
    spativo BIT
)
BEGIN
    UPDATE profissionais
    SET nome = spnome, senha = MD5(spsenha), especializacao = spespecializacao, data_contrato = spdata_contrato, data_nasc = spdata_nasc, genero_id = spgenero_id, ativo = spativo
    WHERE id = spid;
END $$
DELIMITER ;

-- Exemplo de chamada:
-- CALL sp_profissionais_update(1, 'Dr. Marcos Silva', 'novasenha', 'Psicologia Clínica', '2024-01-01', 1);

-- Atualizar agendamentos
DELIMITER $$
CREATE PROCEDURE sp_agendamentos_update(
    spid INT,
    spstatus_agendamento CHAR(1)
)
BEGIN
    UPDATE agendamentos
    SET status_agendamento = spstatus_agendamento
    WHERE id = spid;
END $$
DELIMITER ;

-- Exemplo de chamada:
-- CALL sp_agendamentos_update(1, 'C');

-- Atualizar consultas
DELIMITER $$
CREATE PROCEDURE sp_consultas_update(
    spid INT,
    sphora_consulta TIME,
    spdata_consulta DATE,
    spstatus_pagamento CHAR(1)
)
BEGIN
    UPDATE consultas
    SET hora_consulta = sphora_consulta, data_consulta = spdata_consulta, status_pagamento = spstatus_pagamento
    WHERE id = spid;
END $$
DELIMITER ;

-- Exemplo de chamada:
-- CALL sp_consultas_update(1, '15:00:00', '2024-06-01', 'P');

select * from clientes;

-- Inserir generos
INSERT INTO genero VALUES (0, "Feminino");
INSERT INTO genero VALUES (0, "Masculino");
INSERT INTO genero VALUES (0, "Prefiro não informar");

-- Inserir tipos de telefone
INSERT INTO telefone_tipo (id, tipo) VALUES (0, 'Residêncial');
INSERT INTO telefone_tipo (id, tipo) VALUES (0, 'Comercial');
INSERT INTO telefone_tipo (id, tipo) VALUES (0, 'Celular');
INSERT INTO telefone_tipo (id, tipo) VALUES (0, 'Telefone');

-- Inserir cargos
INSERT INTO cargos (id, nome, sigla) VALUES (0, 'Gerente', 'GRT');
INSERT INTO cargos (id, nome, sigla) VALUES (0, 'Recepcionista', 'RCP');
INSERT INTO cargos (id, nome, sigla) VALUES (0, 'Psicólogo', 'PSI');
INSERT INTO cargos (id, nome, sigla) VALUES (0,'Cliente','CLI');

-- Inserir tipos de endereço
INSERT INTO tipo_endereco (id, nome, tipo_endereco) VALUES (0, "Residencial","RES");
INSERT INTO tipo_endereco (id, nome, tipo_endereco) VALUES (0, "Comercial","COM");
INSERT INTO tipo_endereco (id, nome, tipo_endereco) VALUES (0, "Postal","POS");
INSERT INTO tipo_endereco (id, nome, tipo_endereco) VALUES (0, "Temporário","TEM");

-- Exemplo de chamada:
CALL sp_profissionais_insert('Dr. Marcos', 'marcos@gmail.com', '123', '12345678901', 'Psicologia', '2024-01-01', "2024-01-01",1);
CALL sp_telefone_profissional_insert("11969531140", 1, 1);

CREATE VIEW cliente_info AS
SELECT 
    c.id, 
    c.nome, 
    c.email, 
    c.CPF, 
    c.senha, 
    c.data_nasc, 
    c.data_cad, 
    c.ativo, 
    c.genero_id, 
    e.id AS enderecos_id, 
    tc.id AS telefone_id
FROM 
    clientes c
LEFT JOIN 
    telefone_cliente tc ON c.id = tc.cliente_id
LEFT JOIN 
    enderecos e ON c.id = e.cliente_id;

-- DROP VIEW cliente_info;

CREATE VIEW profissional_info AS
SELECT 
    p.id, 
    p.nome, 
    p.email, 
    p.senha, 
    p.CPF, 
    p.especializacao, 
    p.data_contrato, 
    p.data_cad,
    p.data_nasc,
    p.genero_id, 
    tp.id as id_telefone_profissional,
	p.ativo
FROM 
    profissionais p
LEFT JOIN 
    telefone_profissional tp ON p.id = tp.profissional_id;

-- DROP VIEW profissional_info;

select * from profissional_info;

USE psicominddb;
 
-- Criando a tabela calendario


 
-- Criando o procedimento armazenado para inserir horários personalizados

DELIMITER $$

CREATE PROCEDURE InserirHorariosSemana(
    IN data_inicio DATE,
    IN data_fim DATE,
    IN horario_inicio TIME,
    IN horario_fim TIME,
    IN intervalo_minutos INT,
    IN id_profissional INT  -- Renomeado para evitar ambiguidade
)
BEGIN
    DECLARE data_atual DATE;
    DECLARE horario_atual TIME;

    SET data_atual = data_inicio;

    WHILE data_atual <= data_fim DO
        SET horario_atual = horario_inicio;

        WHILE horario_atual <= horario_fim DO
            -- Verificação de duplicidade
            IF NOT EXISTS (
                SELECT 1 FROM escala
                WHERE dia = data_atual
                AND horario = horario_atual
                AND profissional_id = id_profissional  -- Verifica duplicidade com base no profissional
            ) THEN
                INSERT INTO escala (dia, horario, disponivel, profissional_id) 
                VALUES (data_atual, horario_atual, 1, id_profissional);  -- Adiciona o id do profissional
            END IF;

            SET horario_atual = ADDTIME(horario_atual, SEC_TO_TIME(intervalo_minutos * 60));
        END WHILE;

        SET data_atual = ADDDATE(data_atual, 1);
    END WHILE;
END $$

DELIMITER ;

 
-- Chamando o procedimento para inserir horários de 19/08/2024 até 25/08/2024

CALL InserirHorariosSemana('2024-08-26', '2024-08-27', '12:00:00', '18:00:00', 30, 1);

CALL sp_usuarios_insert('Annie', 'annie@gmail.com', '123', 1);

SELECT * FROM escala;
SELECT * FROM usuarios;
select * from cargos;


INSERT INTO tipo_agendamento VALUES (0,'Particular');
INSERT INTO tipo_agendamento VALUES (0,'Grupo');
select * from tipo_agendamento;

INSERT INTO preco_consulta VALUES (0, '250.00', 1);
INSERT INTO preco_consulta VALUES (0, '80.00', 2);
select * from preco_consulta;
 
-- drop procedure InserirHorariosSemana;
-- drop table escala;