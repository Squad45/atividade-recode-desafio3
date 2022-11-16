CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(150) CHARACTER SET utf8mb4 NOT NULL,
    `ProductVersion` varchar(32) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
) CHARACTER SET=utf8mb4;

START TRANSACTION;

ALTER DATABASE CHARACTER SET utf8mb4;

CREATE TABLE `assistencia_tecnica` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `loja` VARCHAR(80) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_assistencia_tecnica` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `clientes` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `nome` VARCHAR(70) CHARACTER SET utf8mb4 NOT NULL,
    `cpf` VARCHAR(11) CHARACTER SET utf8mb4 NULL,
    `cnpj` VARCHAR(14) CHARACTER SET utf8mb4 NULL,
    `cargo` VARCHAR(50) CHARACTER SET utf8mb4 NULL,
    `instituicao` VARCHAR(50) CHARACTER SET utf8mb4 NULL,
    `email` VARCHAR(100) CHARACTER SET utf8mb4 NOT NULL,
    `telefone` VARCHAR(11) CHARACTER SET utf8mb4 NOT NULL,
    `escolha` VARCHAR(14) CHARACTER SET utf8mb4 NOT NULL,
    `equipamento_doado` VARCHAR(10) CHARACTER SET utf8mb4 NULL,
    `texto_explicativo` VARCHAR(255) CHARACTER SET utf8mb4 NOT NULL,
    `uf` VARCHAR(2) CHARACTER SET utf8mb4 NOT NULL,
    `cep` VARCHAR(8) CHARACTER SET utf8mb4 NOT NULL,
    `endereco` VARCHAR(150) CHARACTER SET utf8mb4 NOT NULL,
    `ponto_referencia` VARCHAR(70) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_clientes` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `avaliacoes` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `ClienteId` int NOT NULL,
    `avaliacao` VARCHAR(3) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_avaliacoes` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_avaliacoes_clientes_ClienteId` FOREIGN KEY (`ClienteId`) REFERENCES `clientes` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `equipamentos` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `AvaliacaoId` int NOT NULL,
    `TecId` int NOT NULL,
    `pecas` VARCHAR(80) CHARACTER SET utf8mb4 NOT NULL,
    `valor` DECIMAL(10,2) NOT NULL,
    CONSTRAINT `PK_equipamentos` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_equipamentos_assistencia_tecnica_TecId` FOREIGN KEY (`TecId`) REFERENCES `assistencia_tecnica` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_equipamentos_avaliacoes_AvaliacaoId` FOREIGN KEY (`AvaliacaoId`) REFERENCES `avaliacoes` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `pedido` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `AvaliacaoId` int NOT NULL,
    CONSTRAINT `PK_pedido` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_pedido_avaliacoes_AvaliacaoId` FOREIGN KEY (`AvaliacaoId`) REFERENCES `avaliacoes` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `equipamentos_disponiveis` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `EquipamentoId` int NOT NULL,
    CONSTRAINT `PK_equipamentos_disponiveis` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_equipamentos_disponiveis_equipamentos_EquipamentoId` FOREIGN KEY (`EquipamentoId`) REFERENCES `equipamentos` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `doacoes` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `PedidoId` int NOT NULL,
    `EquipamentoId` int NOT NULL,
    CONSTRAINT `PK_doacoes` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_doacoes_equipamentos_disponiveis_EquipamentoId` FOREIGN KEY (`EquipamentoId`) REFERENCES `equipamentos_disponiveis` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_doacoes_pedido_PedidoId` FOREIGN KEY (`PedidoId`) REFERENCES `pedido` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

INSERT INTO `assistencia_tecnica` (`Id`, `loja`)
VALUES (1, 'Remakker');
INSERT INTO `assistencia_tecnica` (`Id`, `loja`)
VALUES (2, 'Recuperador Tecnologia');
INSERT INTO `assistencia_tecnica` (`Id`, `loja`)
VALUES (3, 'Cell Week');

INSERT INTO `clientes` (`Id`, `cargo`, `cep`, `cnpj`, `cpf`, `email`, `equipamento_doado`, `escolha`, `texto_explicativo`, `instituicao`, `nome`, `ponto_referencia`, `endereco`, `telefone`, `uf`)
VALUES (1, NULL, '23430654', NULL, '33344433321', 'robertSil@gmail.com', NULL, 'beneficio', 'preciso porque sou estudante', NULL, 'Roberto Silva', 'mercearia do Jorge', 'Rua das Flores', '11987435467', 'SP');
INSERT INTO `clientes` (`Id`, `cargo`, `cep`, `cnpj`, `cpf`, `email`, `equipamento_doado`, `escolha`, `texto_explicativo`, `instituicao`, `nome`, `ponto_referencia`, `endereco`, `telefone`, `uf`)
VALUES (2, 'Gerente', '41264100', '11222111222133', NULL, 'wallacetrab@hotmail.com', 'Computador', 'doador', 'estou aqui para doar 2 computadores que não usamos mais', 'Hospital Nogueira', 'Fracisco Wallace', 'Terminal Alfaiate', 'Av dos Alfaiates', '21987224351', 'RJ');

CREATE UNIQUE INDEX `IX_avaliacoes_ClienteId` ON `avaliacoes` (`ClienteId`);

CREATE UNIQUE INDEX `IX_doacoes_EquipamentoId` ON `doacoes` (`EquipamentoId`);

CREATE UNIQUE INDEX `IX_doacoes_PedidoId` ON `doacoes` (`PedidoId`);

CREATE INDEX `IX_equipamentos_AvaliacaoId` ON `equipamentos` (`AvaliacaoId`);

CREATE INDEX `IX_equipamentos_TecId` ON `equipamentos` (`TecId`);

CREATE INDEX `IX_equipamentos_disponiveis_EquipamentoId` ON `equipamentos_disponiveis` (`EquipamentoId`);

CREATE INDEX `IX_pedido_AvaliacaoId` ON `pedido` (`AvaliacaoId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20221115234107_QuintaMigracao', '6.0.10');

COMMIT;

