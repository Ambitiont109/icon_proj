/*
SQLyog Enterprise Trial - MySQL GUI v7.11 
MySQL - 5.5.5-10.1.25-MariaDB : Database - test
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

CREATE DATABASE /*!32312 IF NOT EXISTS*/`test` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `test`;

/*Table structure for table `admin_accounts` */

DROP TABLE IF EXISTS `admin_accounts`;

CREATE TABLE `admin_accounts` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Username` varchar(150) DEFAULT NULL,
  `Password` varchar(64) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

/*Data for the table `admin_accounts` */

insert  into `admin_accounts`(`ID`,`Username`,`Password`) values (1,'panda','panda'),(2,'sin','sin');

/*Table structure for table `attendance` */

DROP TABLE IF EXISTS `attendance`;

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

/*Data for the table `attendance` */

insert  into `attendance`(`Student_ID`,`Current_Date`,`Student_Name`,`Student_Phone`,`Case_Manager`,`Logged_In`,`Logged_Out`,`Late`) values (1,'2017-12-14','Joe Doe','(111) 222-3333','Lee Smith','06:46:00','15:30:00','No'),(2,'2017-12-14','Frank Smith','(333) 666-5544','Joe Dow','07:13:00','15:31:00','Yes');

/*Table structure for table `students_accounts` */

DROP TABLE IF EXISTS `students_accounts`;

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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Data for the table `students_accounts` */

insert  into `students_accounts`(`Student_ID`,`Student_Name`,`Student_Phone`,`Student_Case_Manager`,`Account_Status`,`Student_Photo`,`Student_FingerPrints`,`Login_Days`,`Created_On`,`Created_By`) values (1,'vadim','1111111111','admin','Active',NULL,NULL,NULL,'0000-00-00','M,T,W,Th,F');

/*Table structure for table `test_table1` */

DROP TABLE IF EXISTS `test_table1`;

CREATE TABLE `test_table1` (
  `id` int(10) NOT NULL,
  `name` varchar(255) NOT NULL,
  `datetime` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `test_table1` */

insert  into `test_table1`(`id`,`name`,`datetime`) values (0,'panda','0000-00-00 00:00:00'),(3,'panda','2017-11-26 03:38:13');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
