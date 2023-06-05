-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 15-Abr-2023 às 20:15
-- Versão do servidor: 10.4.19-MariaDB
-- versão do PHP: 8.0.6

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
use ukrasystem;
--
-- Estrutura da tabela `cadastro_funcionario`
--

CREATE TABLE `cadastro_funcionario` (
  `id_cadastro` int(11) NOT NULL  primary key auto_increment,
  `nome_funcionario` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `senha_funcionario` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
  `email_funcionario` varchar(60) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;



--
-- Estrutura da tabela `cliente`
--

CREATE TABLE `cliente` (
  `id_cliente` int(11) NOT NULL  primary key auto_increment,
  `cpf_cliente` varchar(11) COLLATE utf8_unicode_ci NOT NULL,
  `nome_cliente` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `carrinho` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

-- --------------------------------------------------------

--
-- Estrutura da tabela `carrinho`
--

 CREATE TABLE `carrinho` (
  `id_carrinho` int(11) NOT NULL primary key auto_increment ,
  `valor_final` decimal(6,2) NOT NULL,
  `pagamento` int(11) NOT NULL,
  `produto` int(11) NOT NULL,
  `desconto` int(11) NOT NULL,
  `numero_pedido` int(11) NOT NULL,
  `id_cliente` int(11) not null,
 constraint fk_cliente foreign key (id_cliente) references cliente(id_cliente)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------
 
-- Estrutura da tabela `desconto`
--

CREATE TABLE `desconto` (
  `id_desconto` int(11) NOT NULL,
  `nome_desconto` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `descricao` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `porcentagem` decimal(5,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionario_login`
--

CREATE TABLE `funcionario_login` (
  `id_login` int(11) NOT NULL,
  `nome_login_funcionario` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `senha_login_funcionario` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
  `cliente` int(11) NOT NULL,
  `produto` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `login_adm`
--

CREATE TABLE `login_adm` (
  `id_adm` int(11) NOT NULL,
  `nome_adm` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `senha_adm` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
  `cadastro` int(11) NOT NULL,
  `cliente` int(11) NOT NULL,
  `produto` int(11) NOT NULL,
  `desconto` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `pagamento`
--

CREATE TABLE `pagamento` (
  `id_pagamento` int(11) NOT NULL,
  `pix` tinyint(1) NOT NULL,
  `dinheiro` tinyint(4) NOT NULL,
  `pagamento_cartao` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `pagamento_cartao`
--

CREATE TABLE `pagamento_cartao` (
  `id_cartao` int(11) NOT NULL,
  `debito` tinyint(1) NOT NULL,
  `credito` tinyint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `produto`
--

CREATE TABLE `produto` (
  `id_produto` int(11) NOT NULL,
  `imagem_produto` blob NOT NULL,
  `nome_produto` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `descricao` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `valor_produto` decimal(3,2) NOT NULL,
  `quantidade` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `cadastro_funcionario`
--
--
-- Índices para tabela `carrinho`
--
ALTER TABLE `carrinho`
  ADD PRIMARY KEY (`id_carrinho`),
  ADD KEY `carrinho_ibfk_3` (`pagamento`),
  ADD KEY `carrinho_ibfk_4` (`produto`),
  ADD KEY `carrinho_ibfk_5` (`desconto`),
   ADD KEY `carrinho_ibfk_6` (`desconto`);

--
-- Índices para tabela `cliente`
--

-- Índices para tabela `desconto`
--
ALTER TABLE `desconto`
  ADD PRIMARY KEY (`id_desconto`);

--
-- Índices para tabela `funcionario_login`
--
ALTER TABLE `funcionario_login`
  ADD PRIMARY KEY (`id_login`),
  ADD KEY `funcionario_login_ibfk_1` (`cliente`),
  ADD KEY `funcionario_login_ibfk_3` (`produto`);

--
-- Índices para tabela `login_adm`
--
ALTER TABLE `login_adm`
  ADD PRIMARY KEY (`id_adm`),
  ADD KEY `login_adm_ibfk_3` (`produto`),
  ADD KEY `login_adm_ibfk_4` (`desconto`),
  ADD KEY `login_adm_ibfk_5` (`cliente`);

--
-- Índices para tabela `pagamento`
--
ALTER TABLE `pagamento`
  ADD PRIMARY KEY (`id_pagamento`),
  ADD KEY `pagamento_ibfk_1` (`pagamento_cartao`);

--
-- Índices para tabela `pagamento_cartao`
--
ALTER TABLE `pagamento_cartao`
  ADD PRIMARY KEY (`id_cartao`);

--
-- Índices para tabela `produto`
--
ALTER TABLE `produto`
  ADD PRIMARY KEY (`id_produto`);



--
-- AUTO_INCREMENT de tabela `cliente`
--
ALTER TABLE `cliente`
  MODIFY `id_cliente` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `desconto`
--
ALTER TABLE `desconto`
  MODIFY `id_desconto` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `funcionario_login`
--
ALTER TABLE `funcionario_login`
  MODIFY `id_login` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `login_adm`
--
ALTER TABLE `login_adm`
  MODIFY `id_adm` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `pagamento`
--
ALTER TABLE `pagamento`
  MODIFY `id_pagamento` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `pagamento_cartao`
--
ALTER TABLE `pagamento_cartao`
  MODIFY `id_cartao` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de tabela `produto`
--
ALTER TABLE `produto`
  MODIFY `id_produto` int(11) NOT NULL AUTO_INCREMENT;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `carrinho`
--
ALTER TABLE `carrinho`
  ADD CONSTRAINT `carrinho_ibfk_3` FOREIGN KEY (`pagamento`) REFERENCES `pagamento` (`id_pagamento`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `carrinho_ibfk_4` FOREIGN KEY (`produto`) REFERENCES `produto` (`id_produto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `carrinho_ibfk_5` FOREIGN KEY (`desconto`) REFERENCES `desconto` (`id_desconto`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `cliente`
--
ALTER TABLE `cliente`
  ADD CONSTRAINT `cliente_ibfk_2` FOREIGN KEY (`carrinho`) REFERENCES `carrinho` (`id_carrinho`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `funcionario_login`
--
ALTER TABLE `funcionario_login`
  ADD CONSTRAINT `funcionario_login_ibfk_1` FOREIGN KEY (`cliente`) REFERENCES `cliente` (`id_cliente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `funcionario_login_ibfk_3` FOREIGN KEY (`produto`) REFERENCES `produto` (`id_produto`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `login_adm`
--
ALTER TABLE `login_adm`
  ADD CONSTRAINT `login_adm_ibfk_3` FOREIGN KEY (`produto`) REFERENCES `produto` (`id_produto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `login_adm_ibfk_4` FOREIGN KEY (`desconto`) REFERENCES `desconto` (`id_desconto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `login_adm_ibfk_5` FOREIGN KEY (`cliente`) REFERENCES `cliente` (`id_cliente`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `pagamento`
--
ALTER TABLE `pagamento`
  ADD CONSTRAINT `pagamento_ibfk_1` FOREIGN KEY (`pagamento_cartao`) REFERENCES `pagamento_cartao` (`id_cartao`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
