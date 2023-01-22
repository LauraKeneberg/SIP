-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: sip
-- ------------------------------------------------------
-- Server version	8.0.28

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `ceh`
--

DROP TABLE IF EXISTS `ceh`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ceh` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ceh`
--

LOCK TABLES `ceh` WRITE;
/*!40000 ALTER TABLE `ceh` DISABLE KEYS */;
INSERT INTO `ceh` VALUES (1,'Упаковка'),(2,'Розлив'),(3,'Варка'),(4,'Скрабы'),(5,'Грязь');
/*!40000 ALTER TABLE `ceh` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `role`
--

DROP TABLE IF EXISTS `role`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `role` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `role`
--

LOCK TABLES `role` WRITE;
/*!40000 ALTER TABLE `role` DISABLE KEYS */;
INSERT INTO `role` VALUES (1,'Администратор'),(2,'Старший'),(3,'Руководитель'),(4,'Аналитик'),(5,'Кадровик');
/*!40000 ALTER TABLE `role` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sclad`
--

DROP TABLE IF EXISTS `sclad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sclad` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sclad`
--

LOCK TABLES `sclad` WRITE;
/*!40000 ALTER TABLE `sclad` DISABLE KEYS */;
INSERT INTO `sclad` VALUES (1,'Упаковка'),(3,'Сырья'),(4,'Продукции');
/*!40000 ALTER TABLE `sclad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sotrudniky`
--

DROP TABLE IF EXISTS `sotrudniky`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sotrudniky` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  `Surname` varchar(45) NOT NULL,
  `Otchestvo` varchar(45) NOT NULL,
  `ScR` varchar(45) NOT NULL,
  `Ceh_Id` int NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `fk_Sotrudniky_Ceh1_idx` (`Ceh_Id`),
  CONSTRAINT `fk_Sotrudniky_Ceh1` FOREIGN KEY (`Ceh_Id`) REFERENCES `ceh` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sotrudniky`
--

LOCK TABLES `sotrudniky` WRITE;
/*!40000 ALTER TABLE `sotrudniky` DISABLE KEYS */;
INSERT INTO `sotrudniky` VALUES (1,'Вера','Иванова','Георгиевна','',1),(2,'Роман','Колосов','Константинович','',2),(3,'Григорий','Маслов','Никитич','',3),(4,'Игорь','Наумов','Артёмович','',4),(7,'Анна','Гавриловна','Даниэльевна','',4),(8,'Давид','Тихонов','Маркович','',3),(9,'Александра','Назаровна','Максимовна','',2),(10,'Андрей','Кузнецов','Артёмович','',1);
/*!40000 ALTER TABLE `sotrudniky` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `spec`
--

DROP TABLE IF EXISTS `spec`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `spec` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Count` double NOT NULL,
  `Nomenclatura_Id` int NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `fk_Spec_Nomenclatura1_idx` (`Nomenclatura_Id`),
  CONSTRAINT `fk_Spec_Nomenclatura1` FOREIGN KEY (`Nomenclatura_Id`) REFERENCES `nomenclatura` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `spec`
--

LOCK TABLES `spec` WRITE;
/*!40000 ALTER TABLE `spec` DISABLE KEYS */;
/*!40000 ALTER TABLE `spec` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `typepf`
--

DROP TABLE IF EXISTS `typepf`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `typepf` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `typepf`
--

LOCK TABLES `typepf` WRITE;
/*!40000 ALTER TABLE `typepf` DISABLE KEYS */;
INSERT INTO `typepf` VALUES (1,'Ноги'),(2,'Руки'),(3,'Лицо'),(4,'Глаза'),(5,'Ногти'),(6,'Кожа'),(7,'Кутикула');
/*!40000 ALTER TABLE `typepf` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `types`
--

DROP TABLE IF EXISTS `types`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `types` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `types`
--

LOCK TABLES `types` WRITE;
/*!40000 ALTER TABLE `types` DISABLE KEYS */;
INSERT INTO `types` VALUES (1,'Масло'),(2,'Порошок'),(3,'Химия');
/*!40000 ALTER TABLE `types` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `typeu`
--

DROP TABLE IF EXISTS `typeu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `typeu` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `typeu`
--

LOCK TABLES `typeu` WRITE;
/*!40000 ALTER TABLE `typeu` DISABLE KEYS */;
/*!40000 ALTER TABLE `typeu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `F_name` varchar(45) NOT NULL,
  `L_name` varchar(45) NOT NULL,
  `M_name` varchar(45) NOT NULL,
  `Login` varchar(45) NOT NULL,
  `Password` varchar(45) NOT NULL,
  `Biography` varchar(500) NOT NULL,
  `Role_Id` int NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `fk_Users_Role1_idx` (`Role_Id`),
  CONSTRAINT `fk_Users_Role1` FOREIGN KEY (`Role_Id`) REFERENCES `role` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'Ольга','Демиденко','Олеговна','odo_1','odo_1','рабочий',2),(2,'Максим','Петрович','Сергеевич','mps_1','mps_1','рабочий',2),(3,'Маргарита','Мереминская','Феликсовна','Admin','Admin','Создатель программы',1),(4,'Андрей','Калинин','Максимович','kam_1','kam_1','рабочий',4),(5,'Максим','Васильев','Львович','vml_1','vml_1','рабочий',2),(6,'Ксения','Демидова','Васильевна','dkv_1','dkv_1','рабочий',3),(7,'Леонид','Жуков','Егорович','gle_1','gle_1','Помощник',1),(8,'Ульяна','Симоновна','Артёмовна','sua_1','sua_1','рабочий',2),(9,'Ира','Ламеро','Геналиевна','ilg_1','ilg_1','кадровик',5);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `v`
--

DROP TABLE IF EXISTS `v`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `v` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `v`
--

LOCK TABLES `v` WRITE;
/*!40000 ALTER TABLE `v` DISABLE KEYS */;
INSERT INTO `v` VALUES (1,'0.005'),(2,'0.09'),(3,'1'),(4,'0.025'),(5,'0.05'),(6,'0.1'),(7,'0.25');
/*!40000 ALTER TABLE `v` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `zadanie`
--

DROP TABLE IF EXISTS `zadanie`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `zadanie` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  `Count` varchar(45) NOT NULL,
  `Users_Id` int NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `fk_Zadanie_Users1_idx` (`Users_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `zadanie`
--

LOCK TABLES `zadanie` WRITE;
/*!40000 ALTER TABLE `zadanie` DISABLE KEYS */;
/*!40000 ALTER TABLE `zadanie` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `zayavki`
--

DROP TABLE IF EXISTS `zayavki`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `zayavki` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Nomenclatura_Id` int NOT NULL,
  `Users_Id` int NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `fk_Zayavki_Nomenclatura1_idx` (`Nomenclatura_Id`),
  KEY `fk_Zayavki_Users1_idx` (`Users_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `zayavki`
--

LOCK TABLES `zayavki` WRITE;
/*!40000 ALTER TABLE `zayavki` DISABLE KEYS */;
/*!40000 ALTER TABLE `zayavki` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-01-22 17:24:03
