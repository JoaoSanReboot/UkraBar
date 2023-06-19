-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 19-Jun-2023 às 19:27
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
(1, 'Joazinho da Massa', '123', 'joaopedrosantanarosa@gmail.com'),
(2, 'Joao', '123', 'teste');

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
(1, 'UkraAdm', '8Z1dR5@7e0G3n2Q#9T6Y4mX8p1', NULL, NULL, NULL),
(4, 'UkraAdm', '8^#3xY@7c$S5p@2#9a4!g6R^@1f%T#', 2, NULL, NULL),
(9, 'UkraAdm', '8^#3xY@7c$S5p@2#9a4!g6R^@1f%T#', NULL, NULL, 2);

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
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cadastro_funcionario`
--
ALTER TABLE `cadastro_funcionario`
  MODIFY `id_cadastro` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de tabela `carrinho`
--
ALTER TABLE `carrinho`
  MODIFY `id_carrinho` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `cliente`
--
ALTER TABLE `cliente`
  MODIFY `id_cliente` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `login_adm`
--
ALTER TABLE `login_adm`
  MODIFY `id_adm` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

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
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
