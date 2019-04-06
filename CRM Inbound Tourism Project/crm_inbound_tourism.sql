-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 06, 2019 at 07:51 AM
-- Server version: 10.1.29-MariaDB
-- PHP Version: 7.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `crm_inbound_tourism`
--

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `name` varchar(60) NOT NULL,
  `phone_number` varchar(16) NOT NULL,
  `residence` varchar(28) NOT NULL,
  `email` varchar(80) NOT NULL,
  `nationality` varchar(25) NOT NULL,
  `c_language` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`name`, `phone_number`, `residence`, `email`, `nationality`, `c_language`) VALUES
('10', '10', '10', '10', '10', '10'),
('1112', '0786545345', 'Sri Lanka', '1112@gmail.com', 'Sri Lanka', 'English'),
('22', '089766756768', 'Sri Lanka', '212@gmail.com', 'Sri Lanka', 'Tamil'),
('22', '089766756768', 'Sri Lanka', '22@gmail.com', 'Sri Lanka', 'Tamil'),
('23', '089766756768', 'Sri Lanka', '23@gmail.com', 'Sri Lanka', 'Tamil'),
('24', '0876565567', 'India', '24@gmail.com', 'India', 'Tamil'),
('25', '098987897', 'Sri Lanka', '25@yahoo.com', 'Sri Lanka', 'Paali'),
('26', '09687765', 'Sri Lanka', '26@gmail.com', 'Sri Lanka', 'sinhala'),
('27', '78978798o', 'Sri Lanka', '27@gmail.com', 'Sri Lanka', 'English'),
('28', '7986798798', 'Sri Lanka', '28@gmail.com', 'Sri Lanka', 'Tamil'),
('29', '98767687', 'Sri Lanka', '29@gmail.com', 'Sri Lanka', 'English'),
('30', '687687687', 'Italy', '30@gmail.com', 'Sri Lanka', 'chinesse'),
('32', '798789', 'Sri Lanka', '32@gmail.com', 'India', 'eng'),
('8', '8', '8', '8', '8', '8'),
('9', '9', '9', '9', '9', '9'),
('Jhon', '07865746878', 'India', '953092158V', 'India', 'Tamil'),
('from builder2', 'from builder2', 'from builder2', 'from builder2', 'from builder2', 'from builder2'),
('FromBuilder', 'FromBuilder', 'FromBuilder', 'FromBuilder', 'FromBuilder', 'FromBuilder'),
('fromBuilder3', 'fromBuilder3', 'fromBuilder3', 'fromBuilder3', 'fromBuilder3', 'fromBuilder3'),
('fromBuilder4', 'fromBuilder4', 'fromBuilder4', 'fromBuilder4', 'fromBuilder4', 'fromBuilder4'),
('FromBuilder5', 'FromBuilder5', 'FromBuilder5', 'FromBuilder5', 'FromBuilder5', 'FromBuilder5'),
('new', '078-7867567', 'Sri Lanka', 'new@gmail.com', 'Sri Lanka', 'English'),
('newUser', '98798798', 'India', 'newUser@gmail.com', 'India', 'Hindi'),
('shan', '0787676876', 'Sri Lanka', 'shan@gmail.com', 'Sri Lanka', 'English'),
('test3', 'test3', 'test3', 'test3', 'test3', 'test3'),
('testDailyRoutin', 'testDailyRoutin', 'testDailyRoutin', 'testDailyRoutin', 'testDailyRoutin', 'testDailyRoutin'),
('testDailyRoutin1', 'testDailyRoutin1', 'testDailyRoutin1', 'testDailyRoutin1', 'testDailyRoutin1', 'testDailyRoutin1'),
('testName2', 'testNumber2', 'testResdence2', 'testEmail2', 'testNation2', 'testLang2'),
('testItenerary', 'testItenerary', 'testItenerary', 'testItenerary', 'testItenerary', 'testItenerary'),
('testItenery3', 'testItenery3', 'testItenery3', 'testItenery3', 'testItenery3', 'testItenery3'),
('testName', 'testPhone1', 'testResidence1', 'testMail1', 'testNationality1', 'testLanguage1'),
('testUserName', 'testUserNumber', 'testUserResidence', 'testUserEmail@gmail.com', 'Nationality', 'English');

-- --------------------------------------------------------

--
-- Table structure for table `districts`
--

CREATE TABLE `districts` (
  `districtName` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `districts`
--

INSERT INTO `districts` (`districtName`) VALUES
('Ampara'),
('Anuradhapura'),
('Badula'),
('Batticaloa'),
('Colombo'),
('Galle'),
('Gampaha'),
('Hambantota'),
('Jaffna'),
('Kalutara'),
('Kandy'),
('Kegalle'),
('Kilinochchi'),
('Kuruegala'),
('Mannar'),
('Matala'),
('Monaragala'),
('mullaitivu'),
('Nuwara Eliya'),
('Polonnaruwa'),
('Puttalam'),
('Rathnapura'),
('Trincomalee'),
('Vavuniya');

-- --------------------------------------------------------

--
-- Table structure for table `hotels`
--

CREATE TABLE `hotels` (
  `name` varchar(60) NOT NULL,
  `location` varchar(80) NOT NULL,
  `h_status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `hotels`
--

INSERT INTO `hotels` (`name`, `location`, `h_status`) VALUES
('Galadhari', 'Colombo', 5),
('Hiltonn', 'Colombo', 5),
('test1', 'test1', 0);

-- --------------------------------------------------------

--
-- Table structure for table `locations`
--

CREATE TABLE `locations` (
  `locationName` varchar(30) NOT NULL,
  `district` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `locations`
--

INSERT INTO `locations` (`locationName`, `district`) VALUES
('Dhaladha', 'Kandy'),
('Fort', 'Colombo'),
('GallFace', 'Colombo'),
('Marble Beach', 'Trincomalee'),
('Nikevereti ', 'Kurunegale '),
('Punji Borelle', 'Colombo'),
('Rajagiriya', 'System.Windows.Forms.ComboBox,'),
('Somawathi', 'Polonnaruwa'),
('Victoria park', 'Colombo');

-- --------------------------------------------------------

--
-- Table structure for table `meal_type`
--

CREATE TABLE `meal_type` (
  `meal_Type` varchar(30) NOT NULL,
  `hotel` varchar(60) NOT NULL,
  `price` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `plans`
--

CREATE TABLE `plans` (
  `id` int(11) NOT NULL,
  `tripId` varchar(130) NOT NULL,
  `startDate` varchar(15) NOT NULL,
  `startTime` varchar(8) NOT NULL,
  `endTime` varchar(8) NOT NULL,
  `location` varchar(30) NOT NULL,
  `area` varchar(30) NOT NULL,
  `hotel` varchar(40) DEFAULT NULL,
  `price` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `plans`
--

INSERT INTO `plans` (`id`, `tripId`, `startDate`, `startTime`, `endTime`, `location`, `area`, `hotel`, `price`) VALUES
(1, '1', 'test@gmail.com', '09032019', '7am', '9pm', 'colombo', 'any', '0'),
(2, 'System.Windows.Forms.DateTimePicker, Value: 3/29/2019 8:47:44 PM', 'System.Windows.', 'System.W', 'System.W', '27@gmail.com3/29/2019 8:47:00 ', 'System.Windows.Forms.ComboBox,', 'System.Windows.Forms.ComboBox, Items.Cou', '0'),
(3, 'System.Windows.Forms.DateTimePicker, Value: 3/29/2019 8:47:44 PM', 'System.Windows.', 'System.W', 'System.W', '27@gmail.com3/29/2019 8:47:00 ', 'System.Windows.Forms.ComboBox,', 'System.Windows.Forms.ComboBox, Items.Cou', '0'),
(4, 'System.Windows.Forms.DateTimePicker, Value: 3/29/2019 8:56:06 PM', 'System.Windows.', 'System.W', 'System.W', '29@gmail.com3/29/2019 8:55:33 ', 'System.Windows.Forms.ComboBox,', 'System.Windows.Forms.ComboBox, Items.Cou', '0'),
(5, 'System.Windows.Forms.DateTimePicker, Value: 3/29/2019 8:56:06 PM', 'System.Windows.', 'System.W', 'System.W', '29@gmail.com3/29/2019 8:55:33 ', 'System.Windows.Forms.ComboBox,', 'System.Windows.Forms.ComboBox, Items.Cou', '0'),
(6, '30@gmail.com3/29/2019 9:02:06 PM', 'Friday, March 2', '7.am', '8.pm', 'colombo', 'pettah', 'jkljjkh', '0'),
(7, '30@gmail.com3/29/2019 9:02:06 PM', 'Monday, April 1', '7.am', '8.pm', 'colombo', 'pettah', 'jkljjkh', '0'),
(8, '30@gmail.com3/29/2019 9:02:06 PM', 'Friday, May 3, ', '7.am', '8.pm', 'colombo', 'pettah', 'jkljjkh', '0'),
(9, '212@gmail.com3/29/2019 10:54:12 PM3/29/2019 10:56:28 PM', 'Friday, March 2', 'sampleEx', 'sampleEx', 'sampleExisting', 'sampleExisting', 'sampleExisting', '0'),
(10, '32@gmail.com3/30/2019 1:01:52 PM', 'Saturday, March', '7', '9', 'colo', 'colo', 'bkjbnk n', '0'),
(11, '212@gmail.com3/30/2019 2:14:53 PM3/30/2019 2:15:39 PM', 'Saturday, March', '1', '1', 'khkjhk', 'jhkjh', 'kjhkj', '0'),
(12, '4/1/2019 2:42:45 PM4/1/2019 2:42:51 PM', 'Monday, April 1', '6', '6', 'gj', 'ghj', 'jhg', '0'),
(13, '4/1/2019 2:42:45 PM4/1/2019 2:42:51 PM', 'Monday, April 1', '6', '6', 'gj', 'ghj', 'jhg', '0'),
(14, '4/1/2019 3:21:40 PM4/1/2019 3:21:44 PM', 'Monday, April 1', 'das', 'fdsf', 'sdf', 'fasdf', 'sadf', '0'),
(15, '4/1/2019 3:21:40 PM4/1/2019 3:21:44 PM', 'Wednesday, Apri', 'das', 'fdsf', 'sdf', 'fasdf', 'sadf', '0'),
(16, '4/1/2019 3:25:48 PM4/1/2019 3:25:52 PM', 'Wednesday, Apri', '1', '2', '3', '4', '5', '0'),
(17, '212@gmail.com4/1/2019 3:48:27 PM4/1/2019 3:48:49 PM', 'Monday, April 1', 'hkjh', 'kjhkjh', 'kjhkjh', 'kjhkjh', 'khkjhk', '0'),
(18, '4/1/2019 3:52:31 PM4/1/2019 3:52:35 PM', 'Monday, April 1', 'hkl', 'hkjhkj', 'kjhkjgugi', 'uiigig', 'bm', '0'),
(19, '4/1/2019 3:55:01 PM4/1/2019 3:55:04 PM', 'Monday, April 1', 'dfds', 'hkjh', 'kjhkj', 'kjhkj', 'hkjhkj', '0'),
(20, '4/1/2019 3:56:15 PM4/1/2019 3:56:19 PM', 'Monday, April 1', 'ssjlkj', 'ljlkjg', 'hkjhy', 'jhhnm', 'bbu', '0'),
(21, '4/1/2019 3:56:15 PM4/1/2019 3:56:19 PM', 'Monday, April 1', 'ssjlkj', 'ljlkjg', 'hkjhy', 'jhhnm', 'bbu', '0'),
(22, '4/1/2019 3:56:15 PM4/1/2019 3:56:19 PM', 'Monday, April 1', '1', '2', '3', '4', '5', '0'),
(23, '4/1/2019 4:49:12 PM4/1/2019 4:49:15 PM', 'Monday, April 1', '', '', '', '', '', '0'),
(24, '4/1/2019 5:02:03 PM4/1/2019 5:02:09 PM', 'Monday, April 1', '', '', '', '', '', '0'),
(25, '4/1/2019 5:03:52 PM4/1/2019 5:03:55 PM', 'Tuesday, April ', '7', '9', 'Kandy', 'Dhaladha', 'DontKnow', '0'),
(26, '4/1/2019 5:04:55 PM4/1/2019 5:04:59 PM', 'Monday, April 1', '7', '7', 'kandy', 'ddhaladha', 'DontKnow', '0'),
(27, '4/1/2019 5:06:51 PM4/1/2019 5:06:55 PM', 'Monday, April 1', '8', '12', 'kandy', 'dhaladha', 'Queens Hotel', '0'),
(28, '4/1/2019 5:09:24 PM4/1/2019 5:09:35 PM', 'Monday, April 1', '8', '12', 'kandy', 'dhaladha', 'Queens ', '0'),
(29, '4/1/2019 5:12:26 PM4/1/2019 5:12:30 PM', 'Monday, April 1', '7', '9', 'kandy', 'dhaladh', 'queens', '0'),
(30, '4/1/2019 5:14:25 PM4/1/2019 5:14:29 PM', 'Thursday, April', '7', '12', 'Kany', 'Dhaladha', 'Queens', '0'),
(31, '4/1/2019 5:15:17 PM4/1/2019 5:15:21 PM', 'Wednesday, Apri', '9', '16', 'Colombo', 'Fort', 'Hilton', '0'),
(32, '4/3/2019 10:59:43 AM4/3/2019 10:59:48 AM', 'Wednesday, Apri', '7`', '7', 'Colombo', 'GallFace', '', '0'),
(33, '4/3/2019 10:59:43 AM4/3/2019 10:59:48 AM', 'Wednesday, Apri', '7`', '8', 'Colombo', 'GallFace', '', '0'),
(34, '4/3/2019 10:59:43 AM4/3/2019 10:59:48 AM', 'Wednesday, Apri', '7`', '9', 'Colombo', 'Fort', '', '0'),
(35, '4/3/2019 11:08:12 AM4/3/2019 11:08:16 AM', 'Wednesday, Apri', '7', '7', 'Colombo', 'GallFace', '', '0'),
(36, '4/3/2019 11:08:12 AM4/3/2019 11:08:16 AM', 'Wednesday, Apri', '7', '7', 'Colombo', 'GallFace', '', '0'),
(37, '4/3/2019 11:08:12 AM4/3/2019 11:08:16 AM', 'Wednesday, Apri', '7', '7', 'Colombo', 'GallFace', '', '0'),
(38, '4/3/2019 11:08:12 AM4/3/2019 11:08:16 AM', 'Wednesday, Apri', '7', '7', 'Colombo', 'GallFace', '', '0'),
(39, '4/3/2019 11:11:06 AM4/3/2019 11:11:10 AM', 'Wednesday, Apri', '8', '8', '', '', '', '0'),
(40, '4/3/2019 11:11:06 AM4/3/2019 11:11:10 AM', 'Wednesday, Apri', '8', '8', '', '', '', '0'),
(41, '4/3/2019 11:11:06 AM4/3/2019 11:11:10 AM', 'Wednesday, Apri', '8', '8', '', '', '', '0'),
(42, '4/3/2019 11:11:06 AM4/3/2019 11:11:10 AM', 'Wednesday, Apri', '8', '8', '', '', '', '0'),
(43, '4/3/2019 11:11:06 AM4/3/2019 11:11:10 AM', 'Wednesday, Apri', '8', '8', '', '', '', '0'),
(44, '4/3/2019 11:11:06 AM4/3/2019 11:11:10 AM', 'Wednesday, Apri', '8', '8', '', '', '', '0'),
(45, '4/3/2019 11:11:06 AM4/3/2019 11:11:10 AM', 'Wednesday, Apri', '8', '8', '', '', '', '0'),
(46, '4/4/2019 12:40:52 AM4/4/2019 12:40:59 AM', 'Thursday, April', '', '', '', '', '', '0'),
(47, '4/4/2019 12:40:52 AM4/4/2019 12:40:59 AM', 'Thursday, April', '', '', '', '', '', '0'),
(48, '4/4/2019 12:40:52 AM4/4/2019 12:40:59 AM', 'Thursday, April', '', '', '', '', '', '0'),
(49, '4/4/2019 9:29:31 AM4/4/2019 9:29:48 AM', 'Thursday, April', '', '', '', '', '', '0'),
(50, '4/4/2019 9:31:19 AM4/4/2019 9:31:22 AM', 'Thursday, April', '', '', '', '', '', '0'),
(51, '4/4/2019 9:31:19 AM4/4/2019 9:31:22 AM', 'Thursday, April', '', '', '', '', '', '0'),
(52, '4/4/2019 9:31:19 AM4/4/2019 9:31:22 AM', 'Thursday, April', '', '', '', '', '', '0'),
(53, '4/4/2019 11:57:59 PM4/4/2019 11:58:36 PM', 'Wednesday, Apri', '', '', '', '', '', '0'),
(54, '4/4/2019 11:57:59 PM4/4/2019 11:58:36 PM', 'Wednesday, Apri', '7', '8', '', '', '', '0'),
(55, '4/5/2019 12:54:25 AM4/5/2019 12:54:30 AM', 'Friday, April 5', '', '', '', '', '', '0'),
(56, '4/5/2019 2:00:55 AM4/5/2019 2:01:00 AM', 'Friday, April 5', '', '', 'Colombo', 'Fort', 'Galadhari', '0'),
(57, '212@gmail.com4/5/2019 2:39:35 AM4/5/2019 2:39:55 AM', 'Friday, April 5', '', '', 'Colombo', 'GallFace', 'Galadhari', '50000'),
(58, '212@gmail.com4/5/2019 3:02:39 AM4/5/2019 3:02:57 AM', 'Friday, April 5', '7am', '7pm', 'Colombo', 'GallFace', 'Galadhari', '50000'),
(59, '212@gmail.com4/5/2019 3:05:50 AM4/5/2019 3:06:06 AM', 'Friday, April 5', '7am', '7pm', 'Colombo', 'GallFace', 'Galadhari', '50000'),
(60, '212@gmail.com4/5/2019 3:05:50 AM4/5/2019 3:06:06 AM', 'Friday, April 5', '7am', '7pm', 'Colombo', 'GallFace', 'Galadhari', '50000'),
(61, '212@gmail.com4/5/2019 3:05:50 AM4/5/2019 3:06:06 AM', 'Friday, April 5', '7am', '7pm', 'Colombo', 'GallFace', 'Galadhari', '50000'),
(62, '212@gmail.com4/5/2019 3:05:50 AM4/5/2019 3:06:06 AM', 'Friday, April 5', '7am', '7pm', 'Colombo', 'GallFace', 'Galadhari', '50000'),
(63, '212@gmail.com4/5/2019 3:05:50 AM4/5/2019 3:06:06 AM', 'Friday, April 5', '7am', '7pm', 'Colombo', 'GallFace', 'Galadhari', '50000'),
(64, '212@gmail.com4/5/2019 3:22:44 AM4/5/2019 3:22:59 AM', 'Friday, April 5', '7', '9', 'Colombo', 'GallFace', 'Galadhari', '50000'),
(65, '212@gmail.com4/5/2019 3:26:01 AM4/5/2019 3:26:13 AM', 'Friday, April 5', '7', '9', 'Colombo', 'GallFace', 'Galadhari', '100000'),
(66, '212@gmail.com4/5/2019 3:32:26 AM4/5/2019 3:32:42 AM', 'Friday, April 5', '7', '10', 'Colombo', 'GallFace', 'Galadhari', '0'),
(67, '212@gmail.com4/5/2019 3:32:26 AM4/5/2019 3:32:42 AM', 'Friday, April 5', '7', '10', 'Colombo', 'GallFace', 'Galadhari', '0'),
(68, '212@gmail.com4/5/2019 3:34:49 AM4/5/2019 3:35:05 AM', 'Friday, April 5', '7', '9', 'Colombo', 'GallFace', 'Galadhari', '50000'),
(69, '212@gmail.com4/5/2019 3:34:49 AM4/5/2019 3:35:05 AM', 'Friday, April 5', '7', '9', 'Colombo', 'GallFace', 'Galadhari', '50000'),
(70, '212@gmail.com4/5/2019 3:34:49 AM4/5/2019 3:35:05 AM', 'Friday, April 5', '7', '9', 'Colombo', 'GallFace', 'Galadhari', '50000'),
(71, '212@gmail.com4/5/2019 4:10:26 AM4/5/2019 4:10:43 AM', 'Friday, April 5', '7', '9', 'Colombo', 'GallFace', 'Galadhari', '50000'),
(72, '212@gmail.com4/5/2019 4:10:26 AM4/5/2019 4:10:43 AM', 'Friday, April 5', '7', '9', 'Colombo', 'GallFace', 'Galadhari', '50000'),
(73, '212@gmail.com4/5/2019 8:24:29 AM4/5/2019 8:24:48 AM', 'Friday, April 5', '7', '9', 'Colombo', 'GallFace', 'Galadhari', '50000'),
(74, '212@gmail.com4/5/2019 8:24:29 AM4/5/2019 8:24:48 AM', 'Wednesday, Apri', '7', '9', 'Colombo', 'GallFace', 'Galadhari', '50000'),
(75, '212@gmail.com4/5/2019 8:24:29 AM4/5/2019 8:24:48 AM', 'Wednesday, Apri', '7', '9', 'Colombo', 'GallFace', 'Galadhari', '50000'),
(76, '212@gmail.com4/5/2019 9:06:32 PM4/5/2019 9:06:44 PM', 'Friday, April 5', '7', '9', 'Colombo', 'GallFace', 'Galadhari', '0'),
(77, '212@gmail.com4/5/2019 9:13:26 PM4/5/2019 9:13:47 PM', 'Friday, April 5', '7', '9', 'Colombo', 'GallFace', 'Galadhari', '50000'),
(78, '1112@gmail.com4/6/2019 2:06:58 AM4/6/2019 2:07:09 AM', 'Saturday, April', '', '', '', '', '', '0'),
(79, '212@gmail.com4/6/2019 2:53:47 AM4/6/2019 2:54:00 AM', 'Saturday, April', '7', '9', 'Colombo', 'GallFace', 'Galadhari', '0'),
(80, '212@gmail.com4/6/2019 3:01:32 AM4/6/2019 3:01:47 AM', 'Saturday, April', '7', '9', 'Colombo', 'GallFace', 'Galadhari', '20000'),
(81, '212@gmail.com4/6/2019 3:01:32 AM4/6/2019 3:01:47 AM', 'Saturday, April', '7', '9', 'Colombo', 'GallFace', 'Galadhari', '20000'),
(82, '212@gmail.com4/6/2019 3:01:32 AM4/6/2019 3:01:47 AM', 'Saturday, April', '7', '9', 'Colombo', 'GallFace', 'Galadhari', '20000'),
(83, '212@gmail.com4/6/2019 3:01:32 AM4/6/2019 3:01:47 AM', 'Saturday, April', '7', '9', 'Colombo', 'GallFace', 'Galadhari', '20000'),
(84, '212@gmail.com4/6/2019 3:13:35 AM4/6/2019 3:13:54 AM', 'Tuesday, April ', '7 ', '9', 'Colombo', 'GallFace', 'Galadhari', '20000'),
(85, '212@gmail.com4/6/2019 3:13:35 AM4/6/2019 3:13:54 AM', 'Tuesday, April ', '7 ', '9', 'Colombo', 'GallFace', 'Galadhari', '20000'),
(86, '212@gmail.com4/6/2019 3:13:35 AM4/6/2019 3:13:54 AM', 'Tuesday, April ', '7 ', '9', 'Colombo', 'GallFace', 'Galadhari', '20000'),
(87, '212@gmail.com4/6/2019 3:13:35 AM4/6/2019 3:13:54 AM', 'Tuesday, April ', '7 ', '9', 'Colombo', 'GallFace', 'Galadhari', '20000'),
(88, '212@gmail.com4/6/2019 9:26:52 AM4/6/2019 9:27:07 AM', 'Saturday, April', '7', '9', 'Colombo', 'GallFace', 'Galadhari', '20000'),
(89, '212@gmail.com4/6/2019 9:26:52 AM4/6/2019 9:27:07 AM', 'Saturday, April', '7', '9', 'Colombo', 'GallFace', 'Galadhari', '20000'),
(90, '212@gmail.com4/6/2019 9:26:52 AM4/6/2019 9:27:07 AM', 'Saturday, April', '7', '9', 'Colombo', 'GallFace', 'Galadhari', '20000'),
(91, '212@gmail.com4/6/2019 9:26:52 AM4/6/2019 9:27:07 AM', 'Saturday, April', '7', '9', 'Colombo', 'GallFace', 'Galadhari', '20000'),
(92, '212@gmail.com4/6/2019 9:26:52 AM4/6/2019 9:27:07 AM', 'Saturday, April', '7', '9', 'Colombo', 'GallFace', 'Galadhari', '20000'),
(93, '212@gmail.com4/6/2019 9:26:52 AM4/6/2019 9:27:07 AM', 'Saturday, April', '7', '9', 'Colombo', 'GallFace', 'Galadhari', '20000'),
(94, 'shan@gmail.com4/6/2019 10:38:47 AM', 'Tuesday, April ', '7', '9', 'Colombo', 'Fort', 'Galadhari', '20000'),
(95, 'shan@gmail.com4/6/2019 10:38:47 AM', 'Tuesday, April ', '7', '9', 'Colombo', 'Fort', 'Galadhari', '20000'),
(96, 'shan@gmail.com4/6/2019 10:38:47 AM', 'Tuesday, April ', '7', '9', 'Colombo', 'Fort', 'Galadhari', '20000'),
(97, '212@gmail.com4/6/2019 10:48:07 AM4/6/2019 10:48:33 AM', 'Saturday, April', '7am', '9pm', 'Colombo', 'GallFace', 'Galadhari', '20000');

-- --------------------------------------------------------

--
-- Table structure for table `rooms`
--

CREATE TABLE `rooms` (
  `room_type` varchar(10) NOT NULL,
  `hotel` varchar(60) NOT NULL,
  `price` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `rooms`
--

INSERT INTO `rooms` (`room_type`, `hotel`, `price`) VALUES
('1', 'Galadhari', 10000),
('2', 'Galadhari', 20000),
('3', 'Galadhari', 30000);

-- --------------------------------------------------------

--
-- Table structure for table `touristplaces`
--

CREATE TABLE `touristplaces` (
  `name` varchar(50) NOT NULL,
  `locationName` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `trips`
--

CREATE TABLE `trips` (
  `tripId` varchar(130) NOT NULL,
  `arivalDate` varchar(10) NOT NULL,
  `depatureDate` varchar(10) NOT NULL,
  `adults` int(3) NOT NULL,
  `childrents` int(3) NOT NULL,
  `noOfDays` int(5) NOT NULL,
  `noOfRooms` int(5) NOT NULL,
  `singleRoom` int(5) NOT NULL,
  `doubleRoom` int(5) NOT NULL,
  `tripleRoom` int(5) NOT NULL,
  `meal` varchar(10) NOT NULL,
  `starGategory` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `trips`
--

INSERT INTO `trips` (`tripId`, `arivalDate`, `depatureDate`, `adults`, `childrents`, `noOfDays`, `noOfRooms`, `singleRoom`, `doubleRoom`, `tripleRoom`, `meal`, `starGategory`) VALUES
('1112@gmail.com4/6/2019 1:11:28 AM', '', '4/8/2019', 2, 0, 1, 1, 0, 1, 0, '', 0),
('1112@gmail.com4/6/2019 2:06:58 AM4/6/2019 2:07:09 AM', '', '4/8/2019', 2, 0, 2, 1, 0, 1, 0, 'Half Board', 5),
('212@gmail.com3/29/2019 10:54:12 PM3/29/2019 10:56:28 PM', 'fromExistr', 'fromExistr', 2, 2, 3, 3, 0, 3, 0, 'Half Board', 3),
('212@gmail.com3/30/2019 2:14:53 PM3/30/2019 2:15:39 PM', 'uljklkjl', 'lkjkl', 0, 0, 0, 0, 0, 0, 0, 'Bed and Br', 3),
('212@gmail.com4/1/2019 3:48:27 PM4/1/2019 3:48:49 PM', 'Monday, Ap', '4/10/2019', 0, 0, 9, 0, 0, 0, 0, 'Bed and Br', 3),
('212@gmail.com4/5/2019 2:32:30 AM4/5/2019 2:32:45 AM', '', '4/8/2019', 2, 0, 0, 1, 0, 2, 0, '', 5),
('212@gmail.com4/5/2019 2:36:50 AM4/5/2019 2:37:06 AM', '', '4/3/2019', 2, 0, 0, 1, 0, 1, 0, '', 5),
('212@gmail.com4/5/2019 2:39:35 AM4/5/2019 2:39:55 AM', '', '4/3/2019', 2, 0, 0, 1, 0, 1, 0, '', 5),
('212@gmail.com4/5/2019 2:41:22 AM4/5/2019 2:41:38 AM', '', '4/3/2019', 2, 0, 0, 1, 0, 1, 0, '', 5),
('212@gmail.com4/5/2019 3:02:39 AM4/5/2019 3:02:57 AM', '', '4/3/2019', 2, 0, 0, 1, 0, 1, 0, '', 5),
('212@gmail.com4/5/2019 3:05:50 AM4/5/2019 3:06:06 AM', '', '4/3/2019', 2, 0, 0, 1, 0, 1, 0, '', 5),
('212@gmail.com4/5/2019 3:14:42 AM4/5/2019 3:14:58 AM', '', '4/3/2019', 2, 0, 0, 1, 0, 1, 0, '', 5),
('212@gmail.com4/5/2019 3:17:53 AM4/5/2019 3:18:08 AM', '', '4/3/2019', 2, 0, 0, 1, 0, 1, 0, '', 5),
('212@gmail.com4/5/2019 3:22:44 AM4/5/2019 3:22:59 AM', '', '4/3/2019', 2, 0, 0, 1, 0, 1, 0, '', 5),
('212@gmail.com4/5/2019 3:26:01 AM4/5/2019 3:26:13 AM', '', '4/3/2019', 2, 0, 0, 1, 0, 2, 0, '', 5),
('212@gmail.com4/5/2019 3:32:26 AM4/5/2019 3:32:42 AM', '', '4/3/2019', 2, 0, 0, 1, 0, 1, 0, '', 5),
('212@gmail.com4/5/2019 3:34:49 AM4/5/2019 3:35:05 AM', '', '4/3/2019', 2, 0, 0, 1, 0, 1, 0, '', 5),
('212@gmail.com4/5/2019 4:10:26 AM4/5/2019 4:10:43 AM', '', '4/3/2019', 2, 0, 0, 1, 0, 1, 0, '', 5),
('212@gmail.com4/5/2019 8:24:29 AM4/5/2019 8:24:48 AM', '', '4/3/2019', 2, 0, 0, 1, 0, 1, 0, '', 5),
('212@gmail.com4/5/2019 9:04:51 PM4/5/2019 9:05:07 PM', 'Friday, Ap', '4/6/2019', 2, 0, 1, 1, 0, 1, 0, 'Bed and Br', 5),
('212@gmail.com4/5/2019 9:06:32 PM4/5/2019 9:06:44 PM', 'Friday, Ap', '4/12/2019', 0, 0, 7, 0, 0, 0, 0, 'Bed and Br', 5),
('212@gmail.com4/5/2019 9:13:26 PM4/5/2019 9:13:47 PM', 'Friday, Ap', '4/11/2019', 2, 0, 6, 1, 0, 1, 0, 'Full Board', 5),
('212@gmail.com4/6/2019 10:48:07 AM4/6/2019 10:48:33 AM', '', '4/17/2019', 2, 0, 10, 1, 0, 1, 0, 'Full Board', 5),
('212@gmail.com4/6/2019 11:02:56 AM4/6/2019 11:03:18 AM', '', '4/10/2019', 2, 1, 3, 1, 0, 0, 1, '', 0),
('212@gmail.com4/6/2019 11:13:31 AM4/6/2019 11:16:22 AM', '', '4/10/2019', 3, 3, 7, 3, 3, 3, 3, '', 5),
('212@gmail.com4/6/2019 1:03:04 AM4/6/2019 1:03:26 AM', '', '4/9/2019', 2, 0, 2, 1, 0, 1, 0, '', 0),
('212@gmail.com4/6/2019 2:04:44 AM4/6/2019 2:04:59 AM', '', '4/7/2019', 2, 0, 1, 1, 0, 1, 0, 'Half Board', 5),
('212@gmail.com4/6/2019 2:08:39 AM4/6/2019 2:08:52 AM', '', '4/7/2019', 2, 0, 1, 1, 0, 1, 0, 'Full Board', 5),
('212@gmail.com4/6/2019 2:16:03 AM4/6/2019 2:16:19 AM', '', '4/9/2019', 2, 0, 3, 1, 0, 1, 0, 'Half Board', 5),
('212@gmail.com4/6/2019 2:19:26 AM4/6/2019 2:19:38 AM', '', '4/8/2019', 2, 0, 1, 1, 0, 1, 0, 'Full Board', 5),
('212@gmail.com4/6/2019 2:51:00 AM4/6/2019 2:51:17 AM', '', '4/7/2019', 2, 0, 1, 1, 0, 1, 0, 'Half Board', 5),
('212@gmail.com4/6/2019 2:53:47 AM4/6/2019 2:54:00 AM', '', '4/9/2019', 2, 1, 1, 1, 0, 0, 1, 'Full Board', 5),
('212@gmail.com4/6/2019 3:01:32 AM4/6/2019 3:01:47 AM', '', '4/7/2019', 2, 0, 1, 1, 0, 1, 0, 'Full Board', 5),
('212@gmail.com4/6/2019 3:13:35 AM4/6/2019 3:13:54 AM', '', '4/10/2019', 2, 0, 4, 1, 0, 1, 0, 'Half Board', 5),
('212@gmail.com4/6/2019 9:26:52 AM4/6/2019 9:27:07 AM', '', '4/8/2019', 2, 0, 1, 1, 0, 1, 0, 'Full Board', 5),
('25@yahoo.com3/29/2019 8:27:48 PM', '29/03/2019', '30/03/2019', 1, 2, 1, 2, 1, 0, 1, 'Full Board', 5),
('26@gmail.com3/29/2019 8:37:05 PM', '29/03/2019', '30/03/2019', 1, 2, 1, 2, 1, 0, 1, 'Full Board', 5),
('27@gmail.com3/29/2019 8:47:00 PM', 'to', 'tom', 2, 2, 1, 3, 2, 2, 0, 'Bed and Br', 3),
('28@gmail.com3/29/2019 8:42:41 PM', 'to', 'to', 1, 2, 1, 2, 1, 0, 1, 'Bed and Br', 5),
('29@gmail.com3/29/2019 8:55:33 PM', 'today', 'tomorow', 0, 2, 2, 1, 0, 0, 1, 'Full Board', 5),
('3/29/2019 11:20:51 PM3/29/2019 11:24:08 PM', '', '', 0, 0, 0, 0, 0, 0, 0, '', 0),
('3/29/2019 8:14:36 PM', '', '', 0, 0, 0, 0, 0, 0, 0, '', 0),
('30@gmail.com3/29/2019 9:02:06 PM', 'now', 'tommorow', 0, 1, 1, 1, 0, 0, 1, 'Full Board', 4),
('32@gmail.com3/30/2019 1:01:52 PM', '30/03/2019', '5/04/2019', 1, 1, 4, 2, 2, 0, 0, 'Bed and Br', 3),
('4/1/2019 10:45:54 AM4/1/2019 10:45:57 AM', 'Monday, Ap', '4/1/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 11:32:31 AM4/1/2019 11:32:40 AM', 'Monday, Ap', '4/1/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 11:33:06 AM4/1/2019 11:33:15 AM', 'Monday, Ap', '4/5/2019', 0, 0, 4, 0, 0, 0, 0, '', 0),
('4/1/2019 2:42:45 PM4/1/2019 2:42:51 PM', 'Monday, Ap', '4/1/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 3:00:38 PM4/1/2019 3:00:43 PM', 'Monday, Ap', '4/1/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 3:21:40 PM4/1/2019 3:21:44 PM', 'Monday, Ap', '4/1/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 3:25:48 PM4/1/2019 3:25:52 PM', 'Monday, Ap', '4/17/2019', 0, 0, 16, 0, 0, 0, 0, '', 0),
('4/1/2019 3:52:31 PM4/1/2019 3:52:35 PM', 'Monday, Ap', '4/1/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 3:55:01 PM4/1/2019 3:55:04 PM', 'Monday, Ap', '4/1/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 3:56:15 PM4/1/2019 3:56:19 PM', 'Monday, Ap', '4/1/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 4:12:02 AM4/1/2019 4:12:08 AM', 'Monday, Ap', 'Thursday, ', 0, 0, 3, 0, 0, 0, 0, '', 0),
('4/1/2019 4:49:12 PM4/1/2019 4:49:15 PM', 'Monday, Ap', '4/1/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 5:02:03 PM4/1/2019 5:02:09 PM', 'Monday, Ap', '4/1/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 5:03:52 PM4/1/2019 5:03:55 PM', 'Monday, Ap', '4/9/2019', 0, 0, 8, 0, 0, 0, 0, '', 0),
('4/1/2019 5:04:55 PM4/1/2019 5:04:59 PM', 'Monday, Ap', '4/9/2019', 0, 0, 8, 0, 0, 0, 0, '', 0),
('4/1/2019 5:06:51 PM4/1/2019 5:06:55 PM', 'Monday, Ap', '4/1/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 5:09:24 PM4/1/2019 5:09:35 PM', 'Monday, Ap', '4/8/2019', 0, 0, 7, 0, 0, 0, 0, '', 0),
('4/1/2019 5:12:26 PM4/1/2019 5:12:30 PM', 'Monday, Ap', '4/1/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 5:14:25 PM4/1/2019 5:14:29 PM', 'Monday, Ap', '4/11/2019', 0, 0, 10, 0, 0, 0, 0, '', 0),
('4/1/2019 5:15:17 PM4/1/2019 5:15:21 PM', 'Monday, Ap', '4/1/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 5:22:15 PM4/1/2019 5:22:19 PM', 'Monday, Ap', '4/10/2019', 0, 0, 9, 0, 0, 0, 0, '', 0),
('4/1/2019 5:23:13 PM4/1/2019 5:23:18 PM', 'Monday, Ap', '4/9/2019', 0, 0, 8, 0, 0, 0, 0, '', 0),
('4/1/2019 5:24:40 PM4/1/2019 5:24:44 PM', 'Monday, Ap', '4/9/2019', 0, 0, 8, 0, 0, 0, 0, '', 0),
('4/1/2019 5:26:07 PM4/1/2019 5:26:12 PM', 'Monday, Ap', '4/3/2019', 0, 0, 2, 0, 0, 0, 0, '', 0),
('4/1/2019 6:04:31 PM4/1/2019 6:04:47 PM', 'Monday, Ap', '4/9/2019', 0, 0, 8, 0, 0, 0, 0, '', 0),
('4/1/2019 6:07:19 PM4/1/2019 6:07:22 PM', 'Monday, Ap', '4/1/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 6:43:48 PM4/1/2019 6:43:52 PM', 'Monday, Ap', '4/1/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 6:44:42 PM4/1/2019 6:44:46 PM', 'Monday, Ap', '4/1/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 6:49:50 PM4/1/2019 6:49:57 PM', 'Monday, Ap', '4/1/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 6:51:19 PM4/1/2019 6:51:25 PM', 'Monday, Ap', '4/1/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 6:53:14 PM4/1/2019 6:53:19 PM', 'Monday, Ap', '4/1/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 6:56:47 PM4/1/2019 6:56:52 PM', 'Monday, Ap', '4/1/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 6:57:57 PM4/1/2019 6:58:02 PM', 'Monday, Ap', '4/1/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 6:59:31 PM4/1/2019 6:59:36 PM', 'Monday, Ap', '4/1/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 7:01:53 PM4/1/2019 7:01:57 PM', 'Monday, Ap', '4/1/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 7:36:03 PM4/1/2019 7:36:12 PM', 'Monday, Ap', '4/1/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 7:39:13 PM4/1/2019 7:39:17 PM', 'Monday, Ap', '4/1/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 7:49:05 PM4/1/2019 7:49:17 PM', 'Monday, Ap', '4/1/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 7:49:51 PM4/1/2019 7:49:55 PM', 'Monday, Ap', '4/1/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 7:50:58 PM4/1/2019 7:51:02 PM', 'Monday, Ap', '4/1/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 7:51:30 PM4/1/2019 7:51:34 PM', 'Monday, Ap', '4/1/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 7:52:09 PM4/1/2019 7:52:22 PM', 'Monday, Ap', '4/1/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 7:53:22 PM4/1/2019 7:53:26 PM', 'Monday, Ap', '4/1/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 7:54:27 PM4/1/2019 7:54:31 PM', 'Monday, Ap', '4/1/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 7:55:40 PM4/1/2019 7:55:50 PM', 'Monday, Ap', '4/1/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 7:59:21 PM4/1/2019 7:59:26 PM', 'Monday, Ap', '4/1/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 8:31:05 PM4/1/2019 8:31:28 PM', 'Monday, Ap', '4/3/2019', 0, 0, 2, 3, 1, 1, 1, 'Bed and Br', 3),
('4/1/2019 9:11:50 AM4/1/2019 9:12:01 AM', 'Monday, Ap', 'Monday, Ap', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 9:12:24 PM4/1/2019 9:30:32 PM', 'Monday, Ap', '4/1/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 9:20:40 AM4/1/2019 9:20:44 AM', 'Monday, Ap', 'Monday, Ap', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 9:21:09 AM4/1/2019 9:21:12 AM', 'Monday, Ap', 'Monday, Ap', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/1/2019 9:49:39 AM4/1/2019 9:51:19 AM', 'Monday, Ap', 'Monday, Ap', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/3/2019 10:30:55 AM4/3/2019 10:31:30 AM', 'Wednesday,', '4/3/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/3/2019 10:32:16 AM4/3/2019 10:32:21 AM', 'Wednesday,', '4/3/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/3/2019 10:36:18 AM4/3/2019 10:36:22 AM', 'Wednesday,', '4/3/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/3/2019 10:37:41 AM4/3/2019 10:37:45 AM', 'Wednesday,', '4/3/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/3/2019 10:41:13 AM4/3/2019 10:41:17 AM', 'Wednesday,', '4/3/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/3/2019 10:53:24 AM4/3/2019 10:53:31 AM', 'Wednesday,', '4/3/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/3/2019 10:55:07 AM4/3/2019 10:55:12 AM', 'Wednesday,', '4/3/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/3/2019 10:58:38 AM4/3/2019 10:58:47 AM', 'Wednesday,', '4/3/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/3/2019 10:59:43 AM4/3/2019 10:59:48 AM', 'Wednesday,', '4/3/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/3/2019 11:08:12 AM4/3/2019 11:08:16 AM', 'Wednesday,', '4/3/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/3/2019 11:11:06 AM4/3/2019 11:11:10 AM', 'Wednesday,', '4/3/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/4/2019 11:57:59 PM4/4/2019 11:58:36 PM', '', '4/3/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/4/2019 12:40:52 AM4/4/2019 12:40:59 AM', 'Thursday, ', '4/4/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/4/2019 7:46:18 AM4/4/2019 7:47:05 AM', '', '4/3/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/4/2019 7:48:15 AM4/4/2019 7:48:19 AM', '', '4/3/2019', 0, 0, 0, 0, 1, 1, 1, '', 0),
('4/4/2019 7:49:27 AM4/4/2019 7:49:34 AM', '', '4/3/2019', 0, 0, 0, 0, 1, 1, 1, '', 0),
('4/4/2019 7:54:33 AM4/4/2019 7:54:39 AM', '', '4/3/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/4/2019 8:24:23 AM4/4/2019 8:24:29 AM', '', '4/3/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/4/2019 9:20:28 AM4/4/2019 9:24:17 AM', '', '4/3/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/4/2019 9:26:57 AM4/4/2019 9:27:03 AM', '', '4/3/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/4/2019 9:28:06 AM4/4/2019 9:28:12 AM', '', '4/3/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/4/2019 9:29:31 AM4/4/2019 9:29:48 AM', '', '4/3/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/4/2019 9:31:19 AM4/4/2019 9:31:22 AM', '', '4/3/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/5/2019 12:54:25 AM4/5/2019 12:54:30 AM', '', '4/3/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/5/2019 1:48:52 AM4/5/2019 1:48:57 AM', '', '4/11/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/5/2019 1:50:38 AM4/5/2019 1:50:43 AM', '', '4/3/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/5/2019 1:52:02 AM4/5/2019 1:52:07 AM', '', '4/3/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/5/2019 1:52:54 AM4/5/2019 1:53:00 AM', '', '4/3/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/5/2019 1:53:10 AM4/5/2019 1:53:16 AM', '', '4/3/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/5/2019 1:55:03 AM4/5/2019 1:55:06 AM', '', '4/3/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/5/2019 1:56:21 AM4/5/2019 1:56:26 AM', '', '4/3/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('4/5/2019 2:00:55 AM4/5/2019 2:01:00 AM', '', '4/3/2019', 0, 0, 0, 0, 0, 0, 0, '', 5),
('4/5/2019 2:18:53 AM4/5/2019 2:18:58 AM', '', '4/3/2019', 0, 0, 0, 0, 0, 0, 0, '', 5),
('4/5/2019 2:20:22 AM4/5/2019 2:20:27 AM', '', '4/3/2019', 0, 0, 0, 0, 0, 0, 0, '', 3),
('4/5/2019 2:20:44 AM4/5/2019 2:20:48 AM', '', '4/3/2019', 0, 0, 0, 0, 0, 0, 0, '', 5),
('4/5/2019 2:30:24 AM4/5/2019 2:30:28 AM', '', '4/3/2019', 0, 0, 0, 0, 0, 0, 0, '', 5),
('4/5/2019 2:31:02 AM4/5/2019 2:31:06 AM', '', '4/5/2019', 2, 0, 0, 1, 0, 1, 0, '', 5),
('4/6/2019 12:00:18 AM4/6/2019 12:04:30 AM', '', '4/3/2019', 0, 0, 0, 0, 0, 0, 0, '', 0),
('sample2@gmail.com3/29/2019 7:13:08 PM', 'toda', 'tommo', 1, 2, 2, 3, 1, 0, 1, 'Full Board', 3),
('sample3@gmail.com3/29/2019 7:39:02 PM', 'tomo', 'day after ', 3, 2, 3, 4, 3, 0, 1, 'Full Board', 5),
('sample4@gmail.com3/29/2019 7:42:09 PM', 'tod', 'tom', 2, 2, 1, 3, 2, 0, 1, 'Bed and Br', 4),
('sample53/29/2019 7:44:01 PM', '30/03/2019', '04/04/2019', 2, 2, 6, 3, 2, 0, 1, 'Bed and Br', 5),
('sample@gmail.com3/29/2019 5:04:41 AM', 'today', 'tommorow', 1, 1, 1, 1, 3, 0, 0, 'Full Board', 5),
('shan@gmail.com4/6/2019 10:38:47 AM', '', '4/9/2019', 2, 0, 3, 1, 0, 1, 0, 'Full Board', 5);

-- --------------------------------------------------------

--
-- Table structure for table `user_credentials`
--

CREATE TABLE `user_credentials` (
  `user_id` varchar(60) NOT NULL,
  `user_name` varchar(40) NOT NULL,
  `user_type` varchar(6) NOT NULL,
  `access_code` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user_credentials`
--

INSERT INTO `user_credentials` (`user_id`, `user_name`, `user_type`, `access_code`) VALUES
('1', '1', '1', '1'),
('admin@gmail.com', 'admin', 'admin', 'admin@123'),
('dev@gmail.com', 'developer', 'dev', 'dev@123'),
('user@gmail.com', 'user', 'user', 'user@123');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`email`),
  ADD UNIQUE KEY `email` (`email`);

--
-- Indexes for table `districts`
--
ALTER TABLE `districts`
  ADD PRIMARY KEY (`districtName`);

--
-- Indexes for table `hotels`
--
ALTER TABLE `hotels`
  ADD PRIMARY KEY (`name`),
  ADD UNIQUE KEY `name` (`name`);

--
-- Indexes for table `locations`
--
ALTER TABLE `locations`
  ADD PRIMARY KEY (`locationName`);

--
-- Indexes for table `plans`
--
ALTER TABLE `plans`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `touristplaces`
--
ALTER TABLE `touristplaces`
  ADD PRIMARY KEY (`name`),
  ADD UNIQUE KEY `name` (`name`);

--
-- Indexes for table `trips`
--
ALTER TABLE `trips`
  ADD PRIMARY KEY (`tripId`);

--
-- Indexes for table `user_credentials`
--
ALTER TABLE `user_credentials`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `plans`
--
ALTER TABLE `plans`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=98;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
