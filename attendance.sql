/*
MySQL Data Transfer
Source Host: localhost
Source Database: attendance
Target Host: localhost
Target Database: attendance
Date: 12/14/2017 4:02:09 PM
*/

SET FOREIGN_KEY_CHECKS=0;
-- ----------------------------
-- Table structure for admin_accounts
-- ----------------------------
CREATE TABLE `admin_accounts` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Username` varchar(150) DEFAULT NULL,
  `Password` varchar(64) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Table structure for attendance
-- ----------------------------
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

-- ----------------------------
-- Table structure for students_accounts
-- ----------------------------
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
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records 
-- ----------------------------
INSERT INTO `attendance` VALUES ('1', '2017-12-14', 'Joe Doe', '(111) 222-3333', 'Lee Smith', '06:46:00', '15:30:00', 'No');
INSERT INTO `attendance` VALUES ('2', '2017-12-14', 'Frank Smith', '(333) 666-5544', 'Joe Dow', '07:13:00', '15:31:00', 'Yes');
