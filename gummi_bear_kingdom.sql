-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost:8889
-- Generation Time: Oct 14, 2017 at 03:12 AM
-- Server version: 5.6.35
-- PHP Version: 7.0.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `gummi_bear_kingdom`
--
CREATE DATABASE IF NOT EXISTS `gummi_bear_kingdom` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `gummi_bear_kingdom`;

-- --------------------------------------------------------

--
-- Table structure for table `Countries`
--

CREATE TABLE `Countries` (
  `CountryId` int(11) NOT NULL,
  `Name` longtext
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `Countries`
--

INSERT INTO `Countries` (`CountryId`, `Name`) VALUES
(1, 'Germany'),
(2, 'USA'),
(4, 'France');

-- --------------------------------------------------------

--
-- Table structure for table `Products`
--

CREATE TABLE `Products` (
  `ProductId` int(11) NOT NULL,
  `Cost` double NOT NULL,
  `CountryId` int(11) NOT NULL,
  `Description` longtext,
  `Name` longtext
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `Products`
--

INSERT INTO `Products` (`ProductId`, `Cost`, `CountryId`, `Description`, `Name`) VALUES
(1, 8.5, 1, 'Champagne Bears with a sour twist. \r\nOur classic Champagne-infused gummy bears are dusted in sweet and tart sugar crystals for a sophisticated taste that really \"pops.\" Made with Dom Pérignon Vintage Champagne.', 'Bubbly Bears'),
(2, 7, 2, 'Delicate, sweet and chic, Champagne Bubbles are one of our all-time favorite gummies.\r\nDressed up in tiny white nonpareils, each juicy little bite bursts with the flavors of the finest champagne. Sophisticated yet playful, you\'ll love each bubbly \"sip.\"\r\n\r\nChampagne Bubbles are perfect for favors and gifts. Visit our Custom page for more information about creating beautiful personalized favors in your colors and theme.\r\n', 'Champagne Bubbles'),
(4, 7, 4, 'Fruity, sweet & long-lasting, these adorable French hard candies will make you swoon in aquatic shapes of fish and seashells. With the bright, all-natural flavor of fresh lemon, strawberry, raspberry, orange and cassis, these are one of the most delicious hard candies we\'ve ever tasted.\r\n\r\nWe fished these delightful candies from a boutique confectioner in Paris, who has been making them since the turn of the century.', 'Fruits De Mer');

-- --------------------------------------------------------

--
-- Table structure for table `__EFMigrationsHistory`
--

CREATE TABLE `__EFMigrationsHistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `__EFMigrationsHistory`
--

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`) VALUES
('20171013223946_Initial', '1.1.2');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `Countries`
--
ALTER TABLE `Countries`
  ADD PRIMARY KEY (`CountryId`);

--
-- Indexes for table `Products`
--
ALTER TABLE `Products`
  ADD PRIMARY KEY (`ProductId`),
  ADD KEY `IX_Products_CountryId` (`CountryId`);

--
-- Indexes for table `__EFMigrationsHistory`
--
ALTER TABLE `__EFMigrationsHistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `Countries`
--
ALTER TABLE `Countries`
  MODIFY `CountryId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `Products`
--
ALTER TABLE `Products`
  MODIFY `ProductId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `Products`
--
ALTER TABLE `Products`
  ADD CONSTRAINT `FK_Products_Countries_CountryId` FOREIGN KEY (`CountryId`) REFERENCES `Countries` (`CountryId`) ON DELETE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
