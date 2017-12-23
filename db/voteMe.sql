-- MySQL dump 10.13  Distrib 5.7.16, for osx10.11 (x86_64)
--
-- Host: localhost    Database: votedb
-- ------------------------------------------------------
-- Server version	5.7.16

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
-- Table structure for table `candidates`
--

DROP TABLE IF EXISTS `candidates`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `candidates` (
  `eventId` int(11) DEFAULT NULL,
  `aadharCandidate` varchar(13) DEFAULT NULL,
  `name` varchar(50) DEFAULT NULL,
  `party` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `candidates`
--

LOCK TABLES `candidates` WRITE;
/*!40000 ALTER TABLE `candidates` DISABLE KEYS */;
INSERT INTO `candidates` VALUES (34,'423648234762','Ram R','BJP India'),(34,'347423754782','Navya BG','Congress India'),(35,'467523763465','Sachin Tendulaker','BJP India'),(35,'623547257424','Anil Kumble','Congress India'),(35,'342424245726','Rahul Dravid','AAM'),(36,'839483783483','anuradha','jdsindia'),(36,'276278237438','pavithra','bjpindia'),(37,'123467788905','indira','congress'),(37,'167273638383','rajiv','bjpindia'),(38,'123456789900','Anusha','BJP India'),(38,'123456789009','Manu','congress'),(39,'676564564364','Ram Parsad Yadav','Bjp India'),(39,'563543754643','Navina Chauhan','Congress'),(39,'554512457164','S Narayan Parsad','Aam Adami Party'),(40,'385247754732','Yuvraj S','ABVP Bangalore'),(40,'376255123548','Naveen Raj','NCU Banglaore'),(40,'326745542653','Shushma Raja','Congress India'),(40,'547326456873','Kush K','NHCE Party'),(41,'378236423768','Saniya Nehwal','BJP India'),(41,'248723645237','Rahul Dravid','Congress India'),(41,'234782364778','Anil Kumble','BCCi India'),(42,'645327457325','Bil gates','Bjp India'),(42,'786472478652','Mark Zukerbarg','Congress India'),(43,'423874623458','S. Gowda','Congress India'),(43,'436247528457','S.R. Reddy','BJP India'),(44,'378452376472','Charvi Reddy','BJP India'),(44,'364765248354','Sangeetha S','JDU India'),(44,'467354783547','Summit Soni','Aam Aadmi Party'),(44,'849758936597','Rahul S','Congress India'),(44,'483683656975','Sony R','Bangalore National P'),(45,'763567358765','Sourav Ganguly','Bengal Cricket'),(45,'247523745273','R Rahul','Karnataka Cricket'),(46,'478364357347','Bi Ching Bhutia','BJP India'),(47,'348284623846','Rahul Gandhi','Congress India'),(47,'324786286423','N Modi','BJP India'),(46,'456435334232','Nithin Raj','Cangress'),(52,'465782154875','Pinkey Reddy','BJP India'),(52,'452378458234','Girija Reddy','Congress India'),(53,'654535646576','Suresh Prabhu','BJP India'),(53,'746554324325','Piyush Goyal','Congress India'),(54,'767647647456','Sitashree','Mca party'),(54,'776564546754','Abdul','Bca party');
/*!40000 ALTER TABLE `candidates` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `events`
--

DROP TABLE IF EXISTS `events`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `events` (
  `eventId` int(11) NOT NULL AUTO_INCREMENT,
  `eventName` varchar(50) DEFAULT NULL,
  `eventDate` date DEFAULT NULL,
  `country` varchar(50) DEFAULT NULL,
  `location` varchar(50) DEFAULT NULL,
  `state` varchar(50) DEFAULT NULL,
  `city` varchar(50) DEFAULT NULL,
  `username` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`eventId`)
) ENGINE=InnoDB AUTO_INCREMENT=55 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `events`
--

LOCK TABLES `events` WRITE;
/*!40000 ALTER TABLE `events` DISABLE KEYS */;
INSERT INTO `events` VALUES (34,'Sport Club Bangalore','2017-11-02','India','Brookfield','Karnataka','Bangalore','lalitvchau'),(35,'Cricket Club Ele','2017-11-02','India','All Localities','Karnataka','All Cities','lalitvchau'),(36,'pm election','2017-12-04','India','All Localities','All States','All Cities','aksha'),(37,'president','2017-11-04','India','All Localities','Karnataka','All Cities','aksha'),(38,'Cm election','2017-11-11','India','All Localities','Karnataka','All Cities','aksha'),(39,'College Election','2017-11-11','India','All Localities','All States','All Cities','lalitvchau'),(40,'College Election','2017-11-22','India','All Localities','Karnataka','Bangalore','lalitvchau'),(41,'Sport Election','2017-11-22','India','All Localities','All States','All Cities','lalitvchau'),(42,'IIT Camp','2017-11-22','India','All Localities','All States','All Cities','lalitvchau'),(43,'BBMC Election','2017-11-22','India','All Localities','Karnataka','Bangalore','aksha'),(44,'Bangalore Election','2017-11-22','India','Muthanallur Village','Karnataka','Bangalore','lalitvchau'),(45,'Cricket Election','2017-11-22','India','All Localities','Karnataka','Bangalore','dips.av'),(46,'Football Cl ELection','2017-11-23','India','All Localities','All States','All Cities','lalitvchau'),(47,'Indian Election','2017-12-08','India','All Localities','All States','All Cities','aksha'),(52,'NHCE Election','2017-11-22','India','All Localities','All States','All Cities','charviR'),(53,'Railway Election','2017-11-26','India','All Localities','All States','All Cities','lalitvchau'),(54,'class election','2017-11-23','India','All Localities','Karnataka','Bangalore','aksha');
/*!40000 ALTER TABLE `events` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `feedback`
--

DROP TABLE IF EXISTS `feedback`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `feedback` (
  `name` varchar(100) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `msg` varchar(300) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `feedback`
--

LOCK TABLES `feedback` WRITE;
/*!40000 ALTER TABLE `feedback` DISABLE KEYS */;
INSERT INTO `feedback` VALUES ('dsfdsbjf','dbsfbd','dfgsg'),('Lalit','lalit@gmail.com','I am laid\r\nkumasi\r\nfsdf\r\nf\r\ns'),('Lalit','a@gmail.com','sdks\r\npdf\r\ndxfs\r\ndfsdf\r\nsdffs\r\nfssdf\r\nsff'),('Lalit','a@gmail.com','sdks\r\npdf\r\ndxfs\r\ndfsdf\r\nsdffs\r\nfssdf\r\nsff'),('Akshatha R','aksh@gmail.com','jkdsjbsjbjf'),('dxfsdf','ffsf','fdgdrgdgdffc');
/*!40000 ALTER TABLE `feedback` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `peoples`
--

DROP TABLE IF EXISTS `peoples`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `peoples` (
  `aadhar` varchar(13) NOT NULL,
  `mobile` varchar(12) DEFAULT NULL,
  `firstName` varchar(50) DEFAULT NULL,
  `lastname` varchar(50) DEFAULT NULL,
  `gender` varchar(10) DEFAULT NULL,
  `locality` varchar(50) DEFAULT NULL,
  `city` varchar(150) DEFAULT NULL,
  `state` varchar(50) DEFAULT NULL,
  `country` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`aadhar`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `peoples`
--

LOCK TABLES `peoples` WRITE;
/*!40000 ALTER TABLE `peoples` DISABLE KEYS */;
INSERT INTO `peoples` VALUES ('123456789010','7090358216','Lalit','Kumar','Male','Brookfield','Bangalore','Karnataka','India'),('123456789011','7090358216','Akshatha','R','Female','Brookfield','Bangalore','Karnataka','India'),('123456789012','7090358216','Charvi','AL','Female','Brookfield','Bangalore','Karnataka','India'),('123456789013','7090358216','Sony','AL','Female','Brookfield','Bangalore','Karnataka','India'),('123456789014','7090358216','Aksh','Reddy','Female','Muthanallur Village','Bangalore','Karnataka','India'),('123456789015','7090358216','Pinky','Reddy','Female','Muthanallur Village','Bangalore','Karnataka','India');
/*!40000 ALTER TABLE `peoples` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `stu`
--

DROP TABLE IF EXISTS `stu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `stu` (
  `id` int(11) DEFAULT NULL,
  `name` varchar(23) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stu`
--

LOCK TABLES `stu` WRITE;
/*!40000 ALTER TABLE `stu` DISABLE KEYS */;
INSERT INTO `stu` VALUES (1,'kaka');
/*!40000 ALTER TABLE `stu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `userElection`
--

DROP TABLE IF EXISTS `userElection`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `userElection` (
  `username` varchar(40) NOT NULL,
  `password` varchar(50) DEFAULT NULL,
  `mobile` varchar(12) DEFAULT NULL,
  `firstName` varchar(50) DEFAULT NULL,
  `lastname` varchar(50) DEFAULT NULL,
  `gender` varchar(10) DEFAULT NULL,
  `addr` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `userElection`
--

LOCK TABLES `userElection` WRITE;
/*!40000 ALTER TABLE `userElection` DISABLE KEYS */;
INSERT INTO `userElection` VALUES ('aksha','akshareddy','97312456777','aksha','reddy','Female','marathalli'),('akshu','EzZ-vT3-yUD-yzU','70903582166','Aksha','R','Female','Bangalore'),('ashaa','Y9a-Td8-CEY-UsY','9877556344','a','a','Female','a'),('charviR','rCJ-WMp-9z6-are','7675872482','Charvi','Kumari','Female','Indian Colony\r\nBangalore'),('dips.av','8vk-CEm-vMw-Ugn','7890123456','Deepak','Kumar','Male','#456\r\n5th main Road,\r\nBangalore'),('lalitvchau','lalitvchau','7619417237','Lalit','Kumar','Male','#466,\r\n11th Main Road,\r\nBEML Layout,\r\nBangalore 56006'),('vivaan','vivaan','9876543210','Vivaan','Choudhary','Male','Bangalore'),('vivaan009','scH-GX5-gEQ-zbf','13454656363','Vivaan','Chaudhary','Male','Bangalore');
/*!40000 ALTER TABLE `userElection` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `voters`
--

DROP TABLE IF EXISTS `voters`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `voters` (
  `eventId` int(11) DEFAULT NULL,
  `aadhar` varchar(13) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `voters`
--

LOCK TABLES `voters` WRITE;
/*!40000 ALTER TABLE `voters` DISABLE KEYS */;
INSERT INTO `voters` VALUES (34,'123456789010'),(34,'123456789011'),(34,'123456789012'),(34,'123456789013'),(35,'123456789010'),(35,'123456789011'),(35,'123456789012'),(35,'123456789013'),(35,'123456789014'),(35,'123456789015'),(36,'123456789010'),(36,'123456789011'),(36,'123456789012'),(36,'123456789013'),(36,'123456789014'),(36,'123456789015'),(37,'123456789010'),(37,'123456789011'),(37,'123456789012'),(37,'123456789013'),(37,'123456789014'),(37,'123456789015'),(38,'123456789010'),(38,'123456789011'),(38,'123456789012'),(38,'123456789013'),(38,'123456789014'),(38,'123456789015'),(39,'123456789010'),(39,'123456789011'),(39,'123456789012'),(39,'123456789013'),(39,'123456789014'),(39,'123456789015'),(40,'123456789010'),(40,'123456789011'),(40,'123456789012'),(40,'123456789013'),(40,'123456789014'),(40,'123456789015'),(41,'123456789010'),(41,'123456789011'),(41,'123456789012'),(41,'123456789013'),(41,'123456789014'),(41,'123456789015'),(42,'123456789010'),(42,'123456789011'),(42,'123456789012'),(42,'123456789013'),(42,'123456789014'),(42,'123456789015'),(43,'123456789010'),(43,'123456789011'),(43,'123456789012'),(43,'123456789013'),(43,'123456789014'),(43,'123456789015'),(44,'123456789014'),(44,'123456789015'),(45,'123456789010'),(45,'123456789011'),(45,'123456789012'),(45,'123456789013'),(45,'123456789014'),(45,'123456789015'),(46,'123456789010'),(46,'123456789011'),(46,'123456789012'),(46,'123456789013'),(46,'123456789014'),(46,'123456789015'),(47,'123456789010'),(47,'123456789011'),(47,'123456789012'),(47,'123456789013'),(47,'123456789014'),(47,'123456789015'),(52,'123456789010'),(52,'123456789011'),(52,'123456789012'),(52,'123456789013'),(52,'123456789014'),(52,'123456789015'),(53,'123456789010'),(53,'123456789011'),(53,'123456789012'),(53,'123456789013'),(53,'123456789014'),(53,'123456789015'),(54,'123456789010'),(54,'123456789011'),(54,'123456789012'),(54,'123456789013'),(54,'123456789014'),(54,'123456789015');
/*!40000 ALTER TABLE `voters` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `voting`
--

DROP TABLE IF EXISTS `voting`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `voting` (
  `eventId` int(11) DEFAULT NULL,
  `aadhar` varchar(13) DEFAULT NULL,
  `aadharCandidate` varchar(13) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `voting`
--

LOCK TABLES `voting` WRITE;
/*!40000 ALTER TABLE `voting` DISABLE KEYS */;
INSERT INTO `voting` VALUES (34,'123456789011','423648234762'),(35,'123456789011','342424245726'),(34,'123456789012','423648234762'),(37,'123456789012','167273638383'),(38,'123456789012','123456789009'),(38,'123456789011','123456789009'),(38,'123456789010','123456789900'),(38,'123456789015','123456789900'),(38,'123456789014','123456789900'),(38,'123456789013','123456789900'),(39,'123456789010','676564564364'),(39,'123456789011','676564564364'),(39,'123456789012','563543754643'),(39,'123456789014','676564564364'),(39,'123456789015','676564564364'),(34,'123456789010','423648234762'),(35,'123456789010','623547257424'),(52,'123456789010','465782154875'),(35,'123456789015','467523763465'),(35,'123456789014','467523763465'),(35,'123456789013','467523763465'),(34,'123456789013','423648234762'),(35,'123456789012','467523763465'),(40,'123456789010','385247754732'),(40,'123456789011','326745542653'),(45,'123456789010','247523745273');
/*!40000 ALTER TABLE `voting` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-12-23 14:51:47
