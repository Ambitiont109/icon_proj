-- MySQL dump 10.16  Distrib 10.1.26-MariaDB, for Win32 (AMD64)
--
-- Host: localhost    Database: test
-- ------------------------------------------------------
-- Server version	10.1.26-MariaDB

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
-- Table structure for table `admin_accounts`
--

DROP TABLE IF EXISTS `admin_accounts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `admin_accounts` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Username` varchar(150) DEFAULT NULL,
  `Password` varchar(64) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `admin_accounts`
--

LOCK TABLES `admin_accounts` WRITE;
/*!40000 ALTER TABLE `admin_accounts` DISABLE KEYS */;
INSERT INTO `admin_accounts` VALUES (1,'panda','panda'),(2,'sin','sin');
/*!40000 ALTER TABLE `admin_accounts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `attendance`
--

DROP TABLE IF EXISTS `attendance`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `attendance` (
  `Student_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Current_Date` date DEFAULT NULL,
  `Student_Name` varchar(150) DEFAULT NULL,
  `Student_Phone` varchar(15) DEFAULT NULL,
  `Case_Manager` varchar(255) DEFAULT NULL,
  `Logged_In` time DEFAULT NULL,
  `Logged_Out` time DEFAULT NULL,
  `Late` varchar(3) DEFAULT NULL,
  PRIMARY KEY (`Student_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `attendance`
--

LOCK TABLES `attendance` WRITE;
/*!40000 ALTER TABLE `attendance` DISABLE KEYS */;
INSERT INTO `attendance` VALUES (1,'2017-12-14','Joe Doe','(111) 222-3333','Lee Smith','06:46:00','15:30:00','No'),(2,'2017-12-14','Frank Smith','(333) 666-5544','Joe Dow','07:13:00','15:31:00','Yes');
/*!40000 ALTER TABLE `attendance` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `students_accounts`
--

DROP TABLE IF EXISTS `students_accounts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `students_accounts` (
  `Student_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Student_Name` varchar(255) DEFAULT NULL,
  `Student_Phone` varchar(255) DEFAULT NULL,
  `Student_Case_Manager` varchar(255) DEFAULT NULL,
  `Account_Status` varchar(255) DEFAULT NULL,
  `Student_Photo` varchar(255) DEFAULT NULL,
  `Student_FingerPrints` varchar(255) DEFAULT NULL,
  `Login_Days` varchar(255) DEFAULT NULL,
  `Created_On` date DEFAULT NULL,
  `Created_By` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`Student_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `students_accounts`
--

LOCK TABLES `students_accounts` WRITE;
/*!40000 ALTER TABLE `students_accounts` DISABLE KEYS */;
INSERT INTO `students_accounts` VALUES (1,'vadim','1111111111','admin','Active',NULL,'NULL',NULL,'0000-00-00','M,T,W,Th,F'),(2,'alex','1111111111','admin','Active','alex.jpg','NULL',NULL,'0000-00-00','M,T,W,Th,F');
/*!40000 ALTER TABLE `students_accounts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `test_table1`
--

DROP TABLE IF EXISTS `test_table1`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `test_table1` (
  `id` int(10) NOT NULL,
  `name` varchar(255) NOT NULL,
  `datetime` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `test_table1`
--

LOCK TABLES `test_table1` WRITE;
/*!40000 ALTER TABLE `test_table1` DISABLE KEYS */;
INSERT INTO `test_table1` VALUES (0,'panda','0000-00-00 00:00:00'),(3,'panda','2017-11-26 03:38:13');
/*!40000 ALTER TABLE `test_table1` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-12-20 13:22:21
