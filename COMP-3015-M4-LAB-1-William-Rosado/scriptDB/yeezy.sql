-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 02, 2022 at 11:32 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `shoe`
--

-- --------------------------------------------------------

--
-- Table structure for table `yeezy`
--

CREATE TABLE `yeezy` (
  `id` int(6) NOT NULL,
  `apellido` varchar(55) NOT NULL,
  `email` varchar(55) NOT NULL,
  `genero` varchar(55) NOT NULL,
  `marca` varchar(55) NOT NULL,
  `id_key` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `yeezy`
--

INSERT INTO `yeezy` (`id`, `apellido`, `email`, `genero`, `marca`, `id_key`) VALUES
(1, 'Rosado', 'williamarosado@gmail.com', 'Hombre', 'Nike', 1),
(2, 'Romero', 'oscarlito@gmail.com', 'Hombre', 'Jordan', 2),
(3, 'Padilla', 'Viejo@gmail.com', 'Hombre', 'NIke', 3),
(4, 'Bryant', 'kobeblackmamba@gmail.com', 'Hombre', 'Nike', 4),
(5, 'Jordan', 'goat23@gmail.com', 'Hombre', 'Jordan', 5);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `yeezy`
--
ALTER TABLE `yeezy`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_key` (`id_key`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `yeezy`
--
ALTER TABLE `yeezy`
  ADD CONSTRAINT `yeezy_ibfk_1` FOREIGN KEY (`id_key`) REFERENCES `shoe` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
