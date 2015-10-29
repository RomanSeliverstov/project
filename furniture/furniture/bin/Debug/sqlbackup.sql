-- MySqlBackup.NET 2.0.9.2
-- Dump Time: 2015-10-23 22:33:01
-- --------------------------------------
-- Server version 5.6.24 MySQL Community Server (GPL)


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of clients
-- 

DROP TABLE IF EXISTS `clients`;
CREATE TABLE IF NOT EXISTS `clients` (
  `client_id` int(11) NOT NULL AUTO_INCREMENT,
  `first_name` text NOT NULL,
  `Second_name` text NOT NULL,
  `client_address` text NOT NULL,
  `client_email` text,
  PRIMARY KEY (`client_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf32;

-- 
-- Dumping data for table clients
-- 

/*!40000 ALTER TABLE `clients` DISABLE KEYS */;

/*!40000 ALTER TABLE `clients` ENABLE KEYS */;

-- 
-- Definition of firm_contact
-- 

DROP TABLE IF EXISTS `firm_contact`;
CREATE TABLE IF NOT EXISTS `firm_contact` (
  `firm_id` int(11) NOT NULL AUTO_INCREMENT,
  `firm_title` text NOT NULL,
  `firm_city` text NOT NULL,
  `firm_address` text NOT NULL,
  `firm_phone` text NOT NULL,
  `firm_email` text NOT NULL,
  PRIMARY KEY (`firm_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table firm_contact
-- 

/*!40000 ALTER TABLE `firm_contact` DISABLE KEYS */;
INSERT INTO `firm_contact`(`firm_id`,`firm_title`,`firm_city`,`firm_address`,`firm_phone`,`firm_email`) VALUES
(1,'РОНИКОН','Самара','ул. Дзержинского, 8','8-903-314-41-14','ronikon@mail.ru'),
(2,'Миасс Мебель','Миасс','ул.Новаторов, 18а','89193334145','mebel-d@gmail.com'),
(3,'MiassMobili','Миасс','Ленина 56в','+7 (351) 241245','military_s@mail.ru'),
(4,'Элегия','Ульяновск','Энтузиастов, 8б','8919341451','propro@mail.ru');
/*!40000 ALTER TABLE `firm_contact` ENABLE KEYS */;

-- 
-- Definition of orders
-- 

DROP TABLE IF EXISTS `orders`;
CREATE TABLE IF NOT EXISTS `orders` (
  `order_id` int(11) NOT NULL AUTO_INCREMENT,
  `article` text NOT NULL,
  `type` text NOT NULL,
  `title` text NOT NULL,
  `quantity` text NOT NULL,
  `information` text NOT NULL,
  PRIMARY KEY (`order_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table orders
-- 

/*!40000 ALTER TABLE `orders` DISABLE KEYS */;

/*!40000 ALTER TABLE `orders` ENABLE KEYS */;

-- 
-- Definition of place
-- 

DROP TABLE IF EXISTS `place`;
CREATE TABLE IF NOT EXISTS `place` (
  `n_place` int(11) NOT NULL,
  `c_place` text NOT NULL,
  PRIMARY KEY (`n_place`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table place
-- 

/*!40000 ALTER TABLE `place` DISABLE KEYS */;
INSERT INTO `place`(`n_place`,`c_place`) VALUES
(1,'Магазин'),
(2,'Склад');
/*!40000 ALTER TABLE `place` ENABLE KEYS */;

-- 
-- Definition of products
-- 

DROP TABLE IF EXISTS `products`;
CREATE TABLE IF NOT EXISTS `products` (
  `product_id` int(11) NOT NULL AUTO_INCREMENT,
  `type` text NOT NULL,
  `title` text NOT NULL,
  `place` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  `firm` int(11) NOT NULL,
  `information` text NOT NULL,
  PRIMARY KEY (`product_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table products
-- 

/*!40000 ALTER TABLE `products` DISABLE KEYS */;
INSERT INTO `products`(`product_id`,`type`,`title`,`place`,`quantity`,`firm`,`information`) VALUES
(1,'Кресло-Кровать','Снежинка',1,4,1,'Ткань Калибри\r\nподлокотники цвет Венге\r\nжелезный каркас'),
(2,'Диван','Техас - МД5',2,2,3,'Металлокаркас. Цвет снежная королева. Черный подлоконтики'),
(5,'Стол-компьютерный','Атлант',2,1,3,'Черный.'),
(6,'Диван','Волна',1,3,3,'Голубой. Деревянный каркас.');
/*!40000 ALTER TABLE `products` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2015-10-23 22:33:03
-- Total time: 0:0:0:2:342 (d:h:m:s:ms)
