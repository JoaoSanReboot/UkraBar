-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 11-Jun-2023 às 04:13
-- Versão do servidor: 10.4.25-MariaDB
-- versão do PHP: 8.0.23

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `ukrasystem`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `cadastro_funcionario`
--

CREATE TABLE `cadastro_funcionario` (
  `id_cadastro` int(11) NOT NULL,
  `nome_funcionario` varchar(50) NOT NULL,
  `senha_funcionario` varchar(30) NOT NULL,
  `email_funcionario` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cadastro_funcionario`
--

INSERT INTO `cadastro_funcionario` (`id_cadastro`, `nome_funcionario`, `senha_funcionario`, `email_funcionario`) VALUES
(1, 'Joazin', 'tcc é dificil viu', 'joaozin@gmail.com');

-- --------------------------------------------------------

--
-- Estrutura da tabela `carrinho`
--

CREATE TABLE `carrinho` (
  `id_carrinho` int(11) NOT NULL,
  `id_cliente` int(11) NOT NULL,
  `valor_final` decimal(10,2) NOT NULL,
  `id_pedido_cliente` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `carrinho`
--

INSERT INTO `carrinho` (`id_carrinho`, `id_cliente`, `valor_final`, `id_pedido_cliente`) VALUES
(1, 1, '58.00', 3),
(2, 23, '685.00', 59);

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
--

CREATE TABLE `cliente` (
  `id_cliente` int(11) NOT NULL,
  `cpf_cliente` varchar(11) NOT NULL,
  `nome_cliente` varchar(50) DEFAULT NULL,
  `forma_pagamento` varchar(8) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cliente`
--

INSERT INTO `cliente` (`id_cliente`, `cpf_cliente`, `nome_cliente`, `forma_pagamento`) VALUES
(1, 'Sem Cpf', 'Joao', 'Pix'),
(2, '11261778901', NULL, NULL),
(3, '11261778901', NULL, NULL),
(4, '11261778901', NULL, NULL),
(5, 'Sem Cpf', NULL, NULL),
(6, 'Sem Cpf', NULL, NULL),
(7, 'Sem Cpf', NULL, NULL),
(8, 'Sem Cpf', NULL, NULL),
(9, 'Sem Cpf', NULL, NULL),
(10, '11111111111', NULL, NULL),
(11, 'Sem Cpf', NULL, NULL),
(12, 'Sem Cpf', NULL, NULL),
(13, '11111111111', NULL, NULL),
(14, 'Sem Cpf', NULL, NULL),
(15, 'Sem Cpf', NULL, NULL),
(16, 'Sem Cpf', NULL, NULL),
(17, '11111111111', NULL, NULL),
(18, '11111111111', NULL, NULL),
(19, 'Sem Cpf', NULL, NULL),
(20, 'Sem Cpf', NULL, NULL),
(21, '11111111111', NULL, NULL),
(22, 'Sem Cpf', NULL, NULL),
(23, 'Sem Cpf', 'Luis', 'Pix'),
(24, 'Sem Cpf', NULL, NULL),
(25, 'Sem Cpf', NULL, NULL),
(26, 'Sem Cpf', NULL, NULL),
(27, 'Sem Cpf', NULL, NULL),
(28, 'Sem Cpf', NULL, NULL);

-- --------------------------------------------------------

--
-- Estrutura da tabela `login_adm`
--

CREATE TABLE `login_adm` (
  `id_adm` int(11) NOT NULL,
  `nome_adm` varchar(50) NOT NULL,
  `senha_adm` varchar(30) NOT NULL,
  `id_cadastro` int(11) DEFAULT NULL,
  `id_cliente` int(11) DEFAULT NULL,
  `id_produto` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `login_adm`
--

INSERT INTO `login_adm` (`id_adm`, `nome_adm`, `senha_adm`, `id_cadastro`, `id_cliente`, `id_produto`) VALUES
(2, 'UkraAdm', 'Rmz@91Bk3t$2fTmYp7qJN9dx6Lp4e', NULL, NULL, NULL),
(3, 'UkraAdm', '8^#3xY@7c$S5p@2#9a4!g6R^@1f%T#', NULL, NULL, 1),
(4, 'UkraAdm', '8^#3xY@7c$S5p@2#9a4!g6R^@1f%T#', NULL, NULL, 2),
(5, 'UkraAdm', '8^#3xY@7c$S5p@2#9a4!g6R^@1f%T#', NULL, NULL, 3),
(6, 'UkraAdm', '8^#3xY@7c$S5p@2#9a4!g6R^@1f%T#', 1, NULL, NULL);

-- --------------------------------------------------------

--
-- Estrutura da tabela `login_func`
--

CREATE TABLE `login_func` (
  `id_funcionario` int(11) NOT NULL,
  `nome_login_funcionario` varchar(50) NOT NULL,
  `senha_login_funcionario` varchar(30) NOT NULL,
  `id_cliente` int(11) NOT NULL,
  `id_produto` int(11) NOT NULL,
  `id_pedido_cliente` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `pedido_cliente`
--

CREATE TABLE `pedido_cliente` (
  `id_pedido_cliente` int(11) NOT NULL,
  `nome_produto` varchar(50) NOT NULL,
  `quantidade` int(10) NOT NULL,
  `valor_produto` decimal(10,2) NOT NULL,
  `id_cliente` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `pedido_cliente`
--

INSERT INTO `pedido_cliente` (`id_pedido_cliente`, `nome_produto`, `quantidade`, `valor_produto`, `id_cliente`) VALUES
(2, 'Moniche', 1, '23.00', 1),
(3, 'SandubaIberico', 1, '27.00', 1),
(4, 'Frango a kyiv', 1, '45.00', 2),
(6, 'Maça do Amor', 1, '18.00', 2),
(7, 'Slava', 1, '18.00', 2),
(8, 'Hulubsti', 1, '0.00', 3),
(9, 'Borscht', 1, '28.00', 4),
(10, 'Banosh', 1, '25.00', 4),
(11, 'Hulubsti', 1, '20.00', 4),
(12, 'Batata com Cheddar', 1, '23.00', 4),
(13, 'Frango a kyiv', 1, '45.00', 4),
(14, 'Perohe', 1, '32.00', 4),
(15, 'Banosh', 1, '25.00', 5),
(16, 'Perohe', 1, '32.00', 5),
(17, 'Chá Matte', 1, '8.00', 5),
(18, 'Moniche', 1, '23.00', 5),
(19, 'SandubaItaliano', 1, '24.00', 6),
(20, 'SandubaIberico', 1, '27.00', 6),
(21, 'SandubaPolones', 1, '24.00', 6),
(22, 'KatsuSando', 1, '24.00', 6),
(23, 'SandubaVegetariano', 1, '22.00', 6),
(24, 'SandubaAlemão', 1, '25.00', 6),
(25, 'Caipirinha', 1, '16.00', 7),
(26, 'Caipirinha', 1, '16.00', 8),
(27, 'Moniche', 1, '23.00', 8),
(28, 'Caipirinha', 1, '16.00', 9),
(29, 'Moniche', 1, '23.00', 9),
(30, 'Chá Matte', 1, '8.00', 10),
(31, 'Maça do Amor', 1, '18.00', 10),
(32, 'Chá Matte', 1, '8.00', 11),
(33, 'Maça do Amor', 1, '18.00', 11),
(34, 'Moniche', 1, '23.00', 11),
(35, 'Slava', 1, '18.00', 11),
(36, 'Caipirinha', 1, '16.00', 11),
(37, 'Polaka', 1, '26.00', 11),
(38, 'Maça do Amor', 1, '18.00', 12),
(39, 'SandubaItaliano', 1, '24.00', 12),
(40, 'SandubaIberico', 1, '27.00', 12),
(41, 'SandubaPolones', 1, '24.00', 12),
(42, 'KatsuSando', 1, '24.00', 12),
(43, 'SandubaVegetariano', 1, '22.00', 12),
(44, 'SandubaAlemão', 1, '25.00', 12),
(45, 'Chá Matte', 1, '8.00', 13),
(46, 'Borscht', 1, '28.00', 13),
(47, 'Perohe', 1, '32.00', 13),
(48, 'Caipirinha', 1, '16.00', 14),
(49, 'Maça do Amor', 1, '18.00', 14),
(50, 'Caipirinha', 1, '16.00', 15),
(51, 'KatsuSando', 1, '24.00', 16),
(52, 'SandubaVegetariano', 1, '22.00', 16),
(53, 'Banosh', 5, '125.00', 17),
(54, 'Chá Matte', 6, '48.00', 18),
(55, 'Caipirinha', 1, '16.00', 19),
(56, 'Maça do Amor', 1, '18.00', 21),
(57, 'Caipirinha', 8, '128.00', 21),
(58, 'Caipirinha', 40, '640.00', 23),
(59, 'Frango a kyiv', 1, '45.00', 23),
(60, 'Hulubsti', 1, '20.00', 27);

-- --------------------------------------------------------

--
-- Estrutura da tabela `produto_loja`
--

CREATE TABLE `produto_loja` (
  `id_produto` int(11) NOT NULL,
  `nome_produto` varchar(50) NOT NULL,
  `descricao` varchar(100) NOT NULL,
  `valor_produto` decimal(10,2) NOT NULL,
  `quantidade` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `produto_loja`
--

INSERT INTO `produto_loja` (`id_produto`, `nome_produto`, `descricao`, `valor_produto`, `quantidade`) VALUES
(1, 'Pão na Mateiga', 'Muito saboroso', '9.99', 1),
(2, 'Pão na Mateiga', 'Muito saboroso', '9.99', 1),
(3, 'Rocambole ', 'É gostoso', '4.99', 1);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `cadastro_funcionario`
--
ALTER TABLE `cadastro_funcionario`
  ADD PRIMARY KEY (`id_cadastro`);

--
-- Índices para tabela `carrinho`
--
ALTER TABLE `carrinho`
  ADD PRIMARY KEY (`id_carrinho`),
  ADD KEY `id_pedido_cliente` (`id_pedido_cliente`);

--
-- Índices para tabela `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`id_cliente`);

--
-- Índices para tabela `login_adm`
--
ALTER TABLE `login_adm`
  ADD PRIMARY KEY (`id_adm`),
  ADD KEY `fki_cadastro` (`id_cadastro`),
  ADD KEY `fki_cliente` (`id_cliente`),
  ADD KEY `fki_produto` (`id_produto`);

--
-- Índices para tabela `login_func`
--
ALTER TABLE `login_func`
  ADD PRIMARY KEY (`id_funcionario`),
  ADD KEY `fk_cliente` (`id_cliente`),
  ADD KEY `fk_produto` (`id_produto`),
  ADD KEY `fk_pedido_cliente` (`id_pedido_cliente`);

--
-- Índices para tabela `pedido_cliente`
--
ALTER TABLE `pedido_cliente`
  ADD PRIMARY KEY (`id_pedido_cliente`),
  ADD KEY `id_cliente` (`id_cliente`);

--
-- Índices para tabela `produto_loja`
--
ALTER TABLE `produto_loja`
  ADD PRIMARY KEY (`id_produto`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cadastro_funcionario`
--
ALTER TABLE `cadastro_funcionario`
  MODIFY `id_cadastro` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `carrinho`
--
ALTER TABLE `carrinho`
  MODIFY `id_carrinho` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `cliente`
--
ALTER TABLE `cliente`
  MODIFY `id_cliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT de tabela `login_adm`
--
ALTER TABLE `login_adm`
  MODIFY `id_adm` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de tabela `login_func`
--
ALTER TABLE `login_func`
  MODIFY `id_funcionario` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `pedido_cliente`
--
ALTER TABLE `pedido_cliente`
  MODIFY `id_pedido_cliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=61;

--
-- AUTO_INCREMENT de tabela `produto_loja`
--
ALTER TABLE `produto_loja`
  MODIFY `id_produto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `carrinho`
--
ALTER TABLE `carrinho`
  ADD CONSTRAINT `id_pedido_cliente` FOREIGN KEY (`id_pedido_cliente`) REFERENCES `pedido_cliente` (`id_pedido_cliente`);

--
-- Limitadores para a tabela `login_adm`
--
ALTER TABLE `login_adm`
  ADD CONSTRAINT `fki_cadastro` FOREIGN KEY (`id_cadastro`) REFERENCES `cadastro_funcionario` (`id_cadastro`),
  ADD CONSTRAINT `fki_cliente` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`id_cliente`),
  ADD CONSTRAINT `fki_produto` FOREIGN KEY (`id_produto`) REFERENCES `produto_loja` (`id_produto`);

--
-- Limitadores para a tabela `login_func`
--
ALTER TABLE `login_func`
  ADD CONSTRAINT `fk_cliente` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`id_cliente`),
  ADD CONSTRAINT `fk_pedido_cliente` FOREIGN KEY (`id_pedido_cliente`) REFERENCES `pedido_cliente` (`id_pedido_cliente`),
  ADD CONSTRAINT `fk_produto` FOREIGN KEY (`id_produto`) REFERENCES `produto_loja` (`id_produto`);

--
-- Limitadores para a tabela `pedido_cliente`
--
ALTER TABLE `pedido_cliente`
  ADD CONSTRAINT `id_cliente` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`id_cliente`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
