-- ========================================
-- Criação do banco de dados
-- ========================================

CREATE DATABASE psicomindDB;
USE psicomindDB;

-- drop database psicomindDB

-- ========================================
-- Criação das tabelas
-- ========================================

-- Tabela clientes
CREATE TABLE clientes (
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(60) NOT NULL UNIQUE,
    senha CHAR(32) NOT NULL,
    CPF CHAR(11) NOT NULL UNIQUE,
    data_cad TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    data_nasc DATE NOT NULL,
    ativo BIT(1) NOT NULL
);

-- Tabela telefone_tipo
CREATE TABLE telefone_tipo (
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    tipo CHAR(3) NOT NULL UNIQUE
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

-- Tabela enderecos
CREATE TABLE enderecos (
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    cliente_id INT NOT NULL,
    cep CHAR(8) NOT NULL,
    rua VARCHAR(100) NOT NULL,
    numero VARCHAR(20) NOT NULL,
    bairro VARCHAR(60) NOT NULL,
    uf CHAR(2) NOT NULL,
    CONSTRAINT fk_enderecos_cliente_id FOREIGN KEY (cliente_id) REFERENCES clientes(id)
);

-- Tabela usuarios
CREATE TABLE usuarios (
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(60) NOT NULL UNIQUE,
    senha CHAR(32) NOT NULL,
    ativo BIT(1) NOT NULL
);

-- Tabela cargos
CREATE TABLE cargos (
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(50) NOT NULL,
    sigla CHAR(3) NOT NULL
);

-- Tabela usuario_cargo
CREATE TABLE usuario_cargo (
    usuario_id INT NOT NULL,
    cargo_id INT NOT NULL,
    CONSTRAINT fk_usuarioCargo_usuario_id FOREIGN KEY (usuario_id) REFERENCES usuarios(id),
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
    ativo BIT(1) NOT NULL
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


-- Tabela agendamentos
CREATE TABLE agendamentos (
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    profissional_id INT NOT NULL,
    usuarios_id INT NOT NULL,
    data_agendamento DATETIME NOT NULL,
    status_agendamento CHAR(1) NOT NULL,
    CONSTRAINT fk_agendamentos_profissional_id FOREIGN KEY (profissional_id) REFERENCES profissionais(id),
    CONSTRAINT fk_agendamentos_usuarios_id FOREIGN KEY (usuarios_id) REFERENCES usuarios(id)
);

-- Tabela consultas
CREATE TABLE consultas (
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    agendamento_id INT NOT NULL,
    hora_consulta TIME NOT NULL,
    data_consulta DATE NOT NULL,
    status_pagamento CHAR(1) NOT NULL,
    CONSTRAINT fk_consultas_agendamento_id FOREIGN KEY (agendamento_id) REFERENCES agendamentos(id)
);

-- Tabela TipoAgendamento
CREATE TABLE tipo_agendamento (
    cliente_id INT NOT NULL,
    agendamento_id INT NOT NULL,
    typeAgend VARCHAR(50) NOT NULL,
    PRIMARY KEY (cliente_id, agendamento_id),
    CONSTRAINT fk_tipoAgendamento_cliente_id FOREIGN KEY (cliente_id) REFERENCES clientes(id),
    CONSTRAINT fk_tipoAgendamento_agendamento_id FOREIGN KEY (agendamento_id) REFERENCES agendamentos(id)
);

-- Inserir tipos de telefone
INSERT INTO telefone_tipo (id, tipo) VALUES (0, 'RES');
INSERT INTO telefone_tipo (id, tipo) VALUES (0, 'COM');
INSERT INTO telefone_tipo (id, tipo) VALUES (0, 'CEL');
INSERT INTO telefone_tipo (id, tipo) VALUES (0, 'TEL');

-- Inserir cargos
INSERT INTO cargos (id, nome, sigla) VALUES (0, 'Gerente', 'GRT');

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
    spdata_nasc DATE
)
BEGIN
    INSERT INTO clientes 
    VALUES (0, spnome, spemail, MD5(spsenha), spcpf, CURRENT_TIMESTAMP, spdata_nasc, 1);
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
-- CALL sp_telefone_cliente_insert("11969531140",1, 1);
-- Drop procedure sp_telefone_cliente_insert

-- Inserir endereço
DELIMITER $$
CREATE PROCEDURE sp_enderecos_insert(
    spcliente_id INT,
    spcep CHAR(8),
    sprua VARCHAR(100),
    spnumero VARCHAR(20),
    spbairro VARCHAR(60),
    spuf CHAR(2)
)
BEGIN
    INSERT INTO enderecos
    VALUES (0, spcliente_id, spcep, sprua, spnumero, spbairro, spuf);
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
    spsenha VARCHAR(20)
)
BEGIN
    INSERT INTO usuarios (nome, email, senha, ativo)
    VALUES (spnome, spemail, MD5(spsenha), 1);
    SELECT LAST_INSERT_ID() FROM usuarios;
END $$
DELIMITER ;

-- Exemplo de chamada:
-- CALL sp_usuarios_insert('Annie', 'annie@gmail.com', '123');

-- Inserir profissional
DELIMITER $$
CREATE PROCEDURE sp_profissionais_insert(
    spnome VARCHAR(100),
    spemail VARCHAR(60),
    spsenha VARCHAR(20),
    spcpf CHAR(11),
    spespecializacao VARCHAR(100),
    spdata_contrato DATE
)
BEGIN
    INSERT INTO profissionais
    VALUES (0,spnome, spemail, MD5(spsenha), spcpf, spespecializacao, spdata_contrato, CURRENT_TIMESTAMP,1);
    SELECT LAST_INSERT_ID() FROM profissionais;
END $$
DELIMITER ;

-- Exemplo de chamada:
-- CALL sp_profissionais_insert('Dr. Marcos', 'marcos@gmail.com', '123', '12345678901', 'Psicologia', '2024-01-01');
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
    spativo BIT
)
BEGIN
    UPDATE clientes
    SET nome = spnome, senha = MD5(spsenha), data_nasc = spdata_nasc, ativo = spativo
    WHERE id = spid;
END $$
DELIMITER ;

-- Exemplo de chamada:
-- CALL sp_clientes_update(1, 'Roger Santos', '987', '2006-01-24', 0);

-- Atualizar telefone_cliente
DELIMITER $$
CREATE PROCEDURE sp_telefone_cliente_update(
    spid INT,
    spnumero CHAR(11),
    sptelefone_tipo_id INT
)
BEGIN
    UPDATE telefone_cliente
    SET numero = spnumero, telefone_tipo_id = sptelefone_tipo_id
    WHERE id = spid;
END $$
DELIMITER ;

-- Exemplo de chamada:
-- CALL sp_telefone_cliente_update(1, '11969531141', 2);

-- Atualizar telefone_profissional
DELIMITER $$
CREATE PROCEDURE sp_telefone_profissional_update(
    spid INT,
    spnumero CHAR(11),
    sptelefone_tipo_id INT
)
BEGIN
    UPDATE telefone_profissional
    SET numero = spnumero, telefone_tipo_id = sptelefone_tipo_id
    WHERE id = spid;
END $$
DELIMITER ;

-- Exemplo de chamada:
-- CALL sp_telefone_profissional_update(1, '11969531141', 2);

-- Atualizar enderecos
DELIMITER $$
CREATE PROCEDURE sp_enderecos_update(
    spid INT,
    spcep CHAR(8),
    sprua VARCHAR(100),
    spnumero VARCHAR(20),
    spbairro VARCHAR(60),
    spuf CHAR(2)
)
BEGIN
    UPDATE enderecos
    SET CEP = spcep, rua = sprua, numero = spnumero, bairro = spbairro, UF = spuf
    WHERE id = spid;
END $$
DELIMITER ;

-- Exemplo de chamada:
-- CALL sp_enderecos_update(1, '12345678', 'Nova Rua', '123', 'Novo Bairro', 'SP');

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
    spativo BIT
)
BEGIN
    UPDATE profissionais
    SET nome = spnome, senha = MD5(spsenha), especializacao = spespecializacao, data_contrato = spdata_contrato, ativo = spativo
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