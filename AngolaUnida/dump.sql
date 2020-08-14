CREATE DATABASE  IF NOT EXISTS `angolaunida` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `angolaunida`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: angolaunida
-- ------------------------------------------------------
-- Server version	5.7.19

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
-- Table structure for table `comentario`
--

DROP TABLE IF EXISTS `comentario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `comentario` (
  `idsms` int(11) NOT NULL,
  `corpo` text,
  PRIMARY KEY (`idsms`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `enviar`
--

DROP TABLE IF EXISTS `enviar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `enviar` (
  `idenvio` bigint(11) NOT NULL AUTO_INCREMENT,
  `idsms` int(11) DEFAULT NULL,
  `idpessoa` int(11) NOT NULL,
  `data_envio` date NOT NULL,
  `hora_envio` time NOT NULL,
  `idreceptor` int(11) NOT NULL,
  `idGrupo` int(11) DEFAULT NULL,
  PRIMARY KEY (`idenvio`),
  KEY `idsms` (`idsms`),
  KEY `idpessoa` (`idpessoa`)
) ENGINE=InnoDB AUTO_INCREMENT=190 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `enviarcomentario`
--

DROP TABLE IF EXISTS `enviarcomentario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `enviarcomentario` (
  `idenvio` bigint(11) NOT NULL AUTO_INCREMENT,
  `idsms` int(11) DEFAULT NULL,
  `idpessoa` int(11) NOT NULL,
  `data_envio` date NOT NULL,
  `hora_envio` time NOT NULL,
  PRIMARY KEY (`idenvio`),
  KEY `idsms` (`idsms`),
  KEY `idpessoa` (`idpessoa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `mensagem`
--

DROP TABLE IF EXISTS `mensagem`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mensagem` (
  `idsms` int(11) NOT NULL,
  `corpo` text,
  `arquivo` longblob,
  `tipo` enum('MP','IN','AN') NOT NULL,
  PRIMARY KEY (`idsms`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `pessoa`
--

DROP TABLE IF EXISTS `pessoa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pessoa` (
  `idpessoa` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `sobrenome` varchar(50) NOT NULL,
  `nascimento` date DEFAULT NULL,
  `morada` varchar(50) DEFAULT 'Não informado',
  `nacionalidade` varchar(50) DEFAULT 'Não informado',
  `naturalidade` varchar(50) DEFAULT 'Não informado',
  `email` varchar(50) DEFAULT 'Não informado',
  `telefone` varchar(20) DEFAULT NULL,
  `login` varchar(50) NOT NULL,
  `senha` varchar(15) NOT NULL,
  `who` enum('1','2','3') NOT NULL,
  `sexo` enum('M','F') DEFAULT NULL,
  `idcargo` int(11) DEFAULT NULL,
  `foto` longblob,
  PRIMARY KEY (`idpessoa`),
  UNIQUE KEY `login` (`login`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `publicacao`
--

DROP TABLE IF EXISTS `publicacao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `publicacao` (
  `idpub` int(11) NOT NULL AUTO_INCREMENT,
  `corpo` text,
  `idpessoa` int(11) NOT NULL,
  `data_envio` date NOT NULL,
  `hora_envio` time NOT NULL,
  `foto` longblob,
  PRIMARY KEY (`idpub`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-08-14  0:24:21
