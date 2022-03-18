-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: localhost    Database: filmography
-- ------------------------------------------------------
-- Server version	8.0.27

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
-- Table structure for table `__efmigrationshistory`
--

DROP TABLE IF EXISTS `__efmigrationshistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__efmigrationshistory`
--

LOCK TABLES `__efmigrationshistory` WRITE;
/*!40000 ALTER TABLE `__efmigrationshistory` DISABLE KEYS */;
INSERT INTO `__efmigrationshistory` VALUES ('20220317210325_Initial','5.0.0');
/*!40000 ALTER TABLE `__efmigrationshistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `actors`
--

DROP TABLE IF EXISTS `actors`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `actors` (
  `ActorId` int NOT NULL AUTO_INCREMENT,
  `ActorName` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  PRIMARY KEY (`ActorId`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `actors`
--

LOCK TABLES `actors` WRITE;
/*!40000 ALTER TABLE `actors` DISABLE KEYS */;
INSERT INTO `actors` VALUES (14,'Harrison Ford'),(15,'Sigourney Weaver'),(16,'Kurt Russel'),(17,'Mark Hamill');
/*!40000 ALTER TABLE `actors` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `composers`
--

DROP TABLE IF EXISTS `composers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `composers` (
  `ComposerId` int NOT NULL AUTO_INCREMENT,
  `ComposerName` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  PRIMARY KEY (`ComposerId`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `composers`
--

LOCK TABLES `composers` WRITE;
/*!40000 ALTER TABLE `composers` DISABLE KEYS */;
INSERT INTO `composers` VALUES (5,'John Williams'),(6,'Jerry Goldsmith'),(7,'Ennio Moricone');
/*!40000 ALTER TABLE `composers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `directors`
--

DROP TABLE IF EXISTS `directors`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `directors` (
  `DirectorId` int NOT NULL AUTO_INCREMENT,
  `DirectorName` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  PRIMARY KEY (`DirectorId`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `directors`
--

LOCK TABLES `directors` WRITE;
/*!40000 ALTER TABLE `directors` DISABLE KEYS */;
INSERT INTO `directors` VALUES (5,'Steven Spielburg'),(6,'George Lucas'),(7,'Ridley Scott'),(8,'John Carpenter');
/*!40000 ALTER TABLE `directors` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movies`
--

DROP TABLE IF EXISTS `movies`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `movies` (
  `MovieId` int NOT NULL AUTO_INCREMENT,
  `MovieName` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Description` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  PRIMARY KEY (`MovieId`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movies`
--

LOCK TABLES `movies` WRITE;
/*!40000 ALTER TABLE `movies` DISABLE KEYS */;
INSERT INTO `movies` VALUES (8,'Indiana Jones - Raiders of the Lost Ark','Indiana Jones travels to the middle east to find the legendary Ark of the Covenant'),(9,'Alien','A group of space miners visit an alien planet in response to a distress call. Soon they find themselves hunted by an unknown organism.'),(10,'The Thing','A group of researchers in the antartics discover a Russian outpost where some kind of strange creature is being researched.'),(11,'Star Wars','The rebel forces find plans for the Empire\'s new weapon. A ragtag group form an alliance to help the rebel army defeat the Empire and their menacing leader; Darth Vader.');
/*!40000 ALTER TABLE `movies` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `moviewiki`
--

DROP TABLE IF EXISTS `moviewiki`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `moviewiki` (
  `MovieWikiId` int NOT NULL AUTO_INCREMENT,
  `MovieId` int NOT NULL,
  `ActorId` int DEFAULT NULL,
  `DirectorId` int DEFAULT NULL,
  `ComposerId` int DEFAULT NULL,
  PRIMARY KEY (`MovieWikiId`),
  KEY `IX_MovieWiki_ActorId` (`ActorId`),
  KEY `IX_MovieWiki_ComposerId` (`ComposerId`),
  KEY `IX_MovieWiki_DirectorId` (`DirectorId`),
  KEY `IX_MovieWiki_MovieId` (`MovieId`),
  CONSTRAINT `FK_MovieWiki_Actors_ActorId` FOREIGN KEY (`ActorId`) REFERENCES `actors` (`ActorId`) ON DELETE RESTRICT,
  CONSTRAINT `FK_MovieWiki_Composers_ComposerId` FOREIGN KEY (`ComposerId`) REFERENCES `composers` (`ComposerId`) ON DELETE RESTRICT,
  CONSTRAINT `FK_MovieWiki_Directors_DirectorId` FOREIGN KEY (`DirectorId`) REFERENCES `directors` (`DirectorId`) ON DELETE RESTRICT,
  CONSTRAINT `FK_MovieWiki_Movies_MovieId` FOREIGN KEY (`MovieId`) REFERENCES `movies` (`MovieId`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=138 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `moviewiki`
--

LOCK TABLES `moviewiki` WRITE;
/*!40000 ALTER TABLE `moviewiki` DISABLE KEYS */;
INSERT INTO `moviewiki` VALUES (124,8,NULL,5,NULL),(125,8,NULL,6,NULL),(126,8,14,NULL,NULL),(127,8,NULL,NULL,5),(128,9,NULL,7,NULL),(129,9,NULL,NULL,6),(130,9,15,NULL,NULL),(131,10,NULL,8,NULL),(132,10,NULL,NULL,7),(133,10,16,NULL,NULL),(134,11,NULL,6,NULL),(135,11,NULL,NULL,5),(136,11,14,NULL,NULL),(137,11,17,NULL,NULL);
/*!40000 ALTER TABLE `moviewiki` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-03-17 19:31:03
