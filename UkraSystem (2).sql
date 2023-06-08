-- MariaDB dump 10.19  Distrib 10.4.25-MariaDB, for Win64 (AMD64)
--
-- Host: 127.0.0.1    Database: ukrasystem
-- ------------------------------------------------------
-- Server version	10.4.25-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `cadastro_funcionario`
--

DROP TABLE IF EXISTS `cadastro_funcionario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cadastro_funcionario` (
  `id_cadastro` int(11) NOT NULL AUTO_INCREMENT,
  `nome_funcionario` varchar(50) NOT NULL,
  `senha_funcionario` varchar(30) NOT NULL,
  `email_funcionario` varchar(60) NOT NULL,
  PRIMARY KEY (`id_cadastro`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cadastro_funcionario`
--

LOCK TABLES `cadastro_funcionario` WRITE;
/*!40000 ALTER TABLE `cadastro_funcionario` DISABLE KEYS */;
/*!40000 ALTER TABLE `cadastro_funcionario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `carrinho`
--

DROP TABLE IF EXISTS `carrinho`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `carrinho` (
  `id_carrinho` int(11) NOT NULL AUTO_INCREMENT,
  `id_cliente` int(11) NOT NULL,
  `valor_final` double NOT NULL,
  `id_pedido_cliente` int(11) NOT NULL,
  `id_desconto` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_carrinho`),
  KEY `id_pedido_cliente` (`id_pedido_cliente`),
  KEY `id_desconto` (`id_desconto`),
  CONSTRAINT `id_desconto` FOREIGN KEY (`id_desconto`) REFERENCES `desconto` (`id_desconto`),
  CONSTRAINT `id_pedido_cliente` FOREIGN KEY (`id_pedido_cliente`) REFERENCES `pedido_cliente` (`id_pedido_cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `carrinho`
--

LOCK TABLES `carrinho` WRITE;
/*!40000 ALTER TABLE `carrinho` DISABLE KEYS */;
INSERT INTO `carrinho` VALUES (3,17,0,0,NULL),(4,18,0,30,NULL),(5,19,0,33,NULL),(6,20,0,36,NULL),(7,21,0,37,NULL),(8,22,0,38,NULL),(9,23,0,39,NULL),(10,24,0,41,NULL),(11,25,0,42,NULL),(12,26,0,43,NULL),(13,27,0,44,NULL),(14,29,0,49,NULL),(15,30,210,53,NULL),(16,31,150,55,NULL),(17,33,96,59,NULL),(18,35,156,61,NULL),(19,36,96,63,NULL),(20,37,94,65,NULL),(21,38,27,67,NULL);
/*!40000 ALTER TABLE `carrinho` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cliente` (
  `id_cliente` int(11) NOT NULL AUTO_INCREMENT,
  `cpf_cliente` varchar(11) NOT NULL,
  `nome_cliente` varchar(50) DEFAULT NULL,
  `forma_pagamento` varchar(8) DEFAULT NULL,
  PRIMARY KEY (`id_cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=49 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (1,'11261778901',NULL,NULL),(2,'19677867806',NULL,NULL),(3,'11111111111',NULL,NULL),(4,'11261778901',NULL,NULL),(5,'11261778901',NULL,NULL),(6,'11261778901',NULL,NULL),(7,'19677867806','João',NULL),(8,'44444444444',NULL,NULL),(9,'66666666666',NULL,NULL),(10,'99999999999',NULL,NULL),(11,'12121212121',NULL,NULL),(12,'33333333333','João','Pix'),(13,'19777867806','Joao Pedro','Pix'),(14,'44444444444','João','Pix'),(15,'77777777777','Joaozin','Pix'),(16,'88888888888','pao','Pix'),(17,'88888888888','João','Pix'),(18,'11261778901','João','Pix'),(19,'11111111111','Jao','Pix'),(20,'44444444444','Jaozin','Pix'),(21,'11111111111','aaaa','Pix'),(22,'11111111111','aaaa','Pix'),(23,'11111111111','aaaaa','Pix'),(24,'11261778901','João','Pix'),(25,'11111111111','a','Pix'),(26,'33333333333','aaaa','Pix'),(27,'11261778901','aaaaa','Pix'),(28,'11111111111','Joao','Pix'),(29,'33333333333','peu','Pix'),(30,'22222222222','PAO','Pix'),(31,'11261778901','jao','Pix'),(32,'77777777777',NULL,NULL),(33,'11111111111','aaa','Pix'),(34,'44444444444',NULL,NULL),(35,'11111111111','aa','Pix'),(36,'21212121212','aaaaa','Pix'),(37,'11261778901','aaaaaaa','Pix'),(38,'19677867806','jo','Pix'),(39,'11111111111',NULL,NULL),(40,'11111111111',NULL,NULL),(41,'11261778901',NULL,NULL),(42,'11261778901',NULL,NULL),(43,'11111111111',NULL,NULL),(44,'11111111111',NULL,NULL),(45,'11111111111',NULL,NULL),(46,'11111111111',NULL,NULL),(47,'11111111111',NULL,NULL),(48,'11111111111',NULL,NULL);
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `desconto`
--

DROP TABLE IF EXISTS `desconto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `desconto` (
  `id_desconto` int(11) NOT NULL AUTO_INCREMENT,
  `nome_desconto` varchar(40) NOT NULL,
  `descricao` varchar(100) NOT NULL,
  `porcentagem` decimal(5,2) NOT NULL,
  PRIMARY KEY (`id_desconto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `desconto`
--

LOCK TABLES `desconto` WRITE;
/*!40000 ALTER TABLE `desconto` DISABLE KEYS */;
/*!40000 ALTER TABLE `desconto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `login_adm`
--

DROP TABLE IF EXISTS `login_adm`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `login_adm` (
  `id_adm` int(11) NOT NULL AUTO_INCREMENT,
  `nome_adm` varchar(50) NOT NULL,
  `senha_adm` varchar(30) NOT NULL,
  `id_cadastro` int(11) NOT NULL,
  `id_cliente` int(11) NOT NULL,
  `id_produto` int(11) NOT NULL,
  `id_desconto` int(11) NOT NULL,
  PRIMARY KEY (`id_adm`),
  KEY `fki_cadastro` (`id_cadastro`),
  KEY `fki_cliente` (`id_cliente`),
  KEY `fki_produto` (`id_produto`),
  KEY `fki_desconto` (`id_desconto`),
  CONSTRAINT `fki_cadastro` FOREIGN KEY (`id_cadastro`) REFERENCES `cadastro_funcionario` (`id_cadastro`),
  CONSTRAINT `fki_cliente` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`id_cliente`),
  CONSTRAINT `fki_desconto` FOREIGN KEY (`id_desconto`) REFERENCES `desconto` (`id_desconto`),
  CONSTRAINT `fki_produto` FOREIGN KEY (`id_produto`) REFERENCES `produto_loja` (`id_produto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `login_adm`
--

LOCK TABLES `login_adm` WRITE;
/*!40000 ALTER TABLE `login_adm` DISABLE KEYS */;
/*!40000 ALTER TABLE `login_adm` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `login_func`
--

DROP TABLE IF EXISTS `login_func`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `login_func` (
  `id_funcionario` int(11) NOT NULL AUTO_INCREMENT,
  `nome_login_funcionario` varchar(50) NOT NULL,
  `senha_login_funcionario` varchar(30) NOT NULL,
  `id_cliente` int(11) NOT NULL,
  `id_produto` int(11) NOT NULL,
  `id_pedido_cliente` int(11) NOT NULL,
  PRIMARY KEY (`id_funcionario`),
  KEY `fk_cliente` (`id_cliente`),
  KEY `fk_produto` (`id_produto`),
  KEY `fk_pedido_cliente` (`id_pedido_cliente`),
  CONSTRAINT `fk_cliente` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`id_cliente`),
  CONSTRAINT `fk_pedido_cliente` FOREIGN KEY (`id_pedido_cliente`) REFERENCES `pedido_cliente` (`id_pedido_cliente`),
  CONSTRAINT `fk_produto` FOREIGN KEY (`id_produto`) REFERENCES `produto_loja` (`id_produto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `login_func`
--

LOCK TABLES `login_func` WRITE;
/*!40000 ALTER TABLE `login_func` DISABLE KEYS */;
/*!40000 ALTER TABLE `login_func` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pedido_cliente`
--

DROP TABLE IF EXISTS `pedido_cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pedido_cliente` (
  `id_pedido_cliente` int(11) NOT NULL AUTO_INCREMENT,
  `nome_produto` varchar(50) NOT NULL,
  `quantidade` int(10) NOT NULL,
  `valor_produto` decimal(10,2) NOT NULL,
  `id_cliente` int(11) NOT NULL,
  PRIMARY KEY (`id_pedido_cliente`),
  KEY `id_cliente` (`id_cliente`),
  CONSTRAINT `id_cliente` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`id_cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=79 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedido_cliente`
--

LOCK TABLES `pedido_cliente` WRITE;
/*!40000 ALTER TABLE `pedido_cliente` DISABLE KEYS */;
INSERT INTO `pedido_cliente` VALUES (2,'SandubaItaliano',4,96.00,3),(3,'SandubaItaliano',3,72.00,4),(4,'SandubaIberico',2,54.00,4),(5,'KatsuSando',2,48.00,4),(6,'SandubaItaliano',3,72.00,7),(7,'KatsuSando',2,48.00,7),(8,'SandubaIberico',1,27.00,7),(9,'SandubaItaliano',3,72.00,8),(10,'SandubaVegetariano',1,22.00,9),(11,'SandubaVegetariano',4,88.00,10),(12,'SandubaVegetariano',1,22.00,11),(13,'SandubaAlemão',2,50.00,11),(14,'SandubaItaliano',1,24.00,12),(15,'SandubaPolones',2,48.00,12),(16,'SandubaIberico',1,27.00,12),(17,'KatsuSando',1,24.00,12),(18,'SandubaItaliano',3,72.00,13),(19,'SandubaAlemão',1,25.00,13),(20,'SandubaItaliano',3,72.00,14),(21,'SandubaIberico',1,27.00,14),(22,'SandubaItaliano',2,48.00,15),(23,'KatsuSando',2,48.00,15),(24,'SandubaPolones',1,24.00,15),(25,'SandubaIberico',7,189.00,16),(26,'SandubaVegetariano',1,22.00,16),(27,'SandubaItaliano',3,72.00,17),(28,'SandubaVegetariano',1,22.00,17),(29,'SandubaItaliano',4,96.00,18),(30,'SandubaVegetariano',2,44.00,18),(31,'SandubaItaliano',10,240.00,19),(32,'SandubaIberico',5,135.00,19),(33,'KatsuSando',1,24.00,19),(34,'KatsuSando',2,48.00,20),(35,'SandubaItaliano',1,24.00,20),(36,'SandubaIberico',1,27.00,20),(37,'SandubaItaliano',1,24.00,21),(38,'SandubaItaliano',3,72.00,22),(39,'SandubaItaliano',3,72.00,23),(40,'SandubaItaliano',4,96.00,24),(41,'SandubaIberico',2,54.00,24),(42,'SandubaItaliano',2,48.00,25),(43,'SandubaIberico',2,54.00,26),(44,'SandubaItaliano',3,72.00,27),(45,'SandubaItaliano',3,72.00,28),(46,'SandubaIberico',2,54.00,28),(47,'SandubaItaliano',3,72.00,29),(48,'KatsuSando',1,24.00,29),(49,'SandubaIberico',1,27.00,29),(50,'SandubaItaliano',2,48.00,30),(51,'SandubaVegetariano',3,66.00,30),(52,'KatsuSando',2,48.00,30),(53,'SandubaPolones',2,48.00,30),(54,'SandubaItaliano',4,96.00,31),(55,'SandubaIberico',2,54.00,31),(56,'SandubaIberico',3,81.00,32),(57,'KatsuSando',3,72.00,32),(58,'SandubaItaliano',3,72.00,33),(59,'KatsuSando',1,24.00,33),(60,'SandubaIberico',4,108.00,35),(61,'SandubaPolones',2,48.00,35),(62,'SandubaItaliano',3,72.00,36),(63,'KatsuSando',1,24.00,36),(64,'SandubaItaliano',3,72.00,37),(65,'SandubaVegetariano',1,22.00,37),(66,'SandubaIberico',1,27.00,38),(67,'SandubaIberico',1,27.00,38),(69,'SandubaItaliano',3,72.00,40),(70,'SandubaItaliano',25,600.00,41),(71,'SandubaItaliano',33,792.00,42),(72,'SandubaItaliano',2,48.00,43),(73,'SandubaItaliano',4,96.00,45),(74,'SandubaItaliano',4,96.00,46),(75,'SandubaItaliano',4,96.00,47),(76,'SandubaItaliano',0,96.00,47),(77,'SandubaItaliano',4,96.00,48);
/*!40000 ALTER TABLE `pedido_cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `produto_loja`
--

DROP TABLE IF EXISTS `produto_loja`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `produto_loja` (
  `id_produto` int(11) NOT NULL AUTO_INCREMENT,
  `nome_produto` varchar(50) NOT NULL,
  `descricao` varchar(100) NOT NULL,
  `valor_produto` decimal(3,2) NOT NULL,
  `quantidade` int(10) NOT NULL,
  PRIMARY KEY (`id_produto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produto_loja`
--

LOCK TABLES `produto_loja` WRITE;
/*!40000 ALTER TABLE `produto_loja` DISABLE KEYS */;
/*!40000 ALTER TABLE `produto_loja` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-05-26 15:22:34
