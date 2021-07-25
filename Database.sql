-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: 25-Jul-2021 às 08:43
-- Versão do servidor: 8.0.13-4
-- versão do PHP: 7.2.24-0ubuntu0.18.04.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `WIgv2llECn`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `closedsche`
--

CREATE TABLE `closedsche` (
  `id` int(11) NOT NULL,
  `idperson` int(11) DEFAULT NULL,
  `isPago` tinyint(1) DEFAULT NULL,
  `DtaAbertura` date DEFAULT NULL,
  `DtaEntrega` date DEFAULT NULL,
  `DataFechamento` date DEFAULT NULL,
  `State` varchar(60) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Descricao` varchar(400) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `opensche`
--

CREATE TABLE `opensche` (
  `id` int(11) NOT NULL,
  `idperson` int(11) DEFAULT NULL,
  `DtaAbertura` date DEFAULT NULL,
  `DtaEntrega` date DEFAULT NULL,
  `State` varchar(60) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Descricao` varchar(400) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Extraindo dados da tabela `opensche`
--

INSERT INTO `opensche` (`id`, `idperson`, `DtaAbertura`, `DtaEntrega`, `State`, `Descricao`) VALUES
(1, 1, '2021-07-25', '2021-07-25', 'Em pausa', '3');

-- --------------------------------------------------------

--
-- Estrutura da tabela `person`
--

CREATE TABLE `person` (
  `id` int(11) NOT NULL,
  `name` varchar(300) COLLATE utf8_unicode_ci DEFAULT NULL,
  `phone` varchar(60) COLLATE utf8_unicode_ci DEFAULT NULL,
  `cellphone` varchar(60) COLLATE utf8_unicode_ci DEFAULT NULL,
  `address` varchar(300) COLLATE utf8_unicode_ci DEFAULT NULL,
  `complement` varchar(300) COLLATE utf8_unicode_ci DEFAULT NULL,
  `city` varchar(60) COLLATE utf8_unicode_ci DEFAULT NULL,
  `state` varchar(60) COLLATE utf8_unicode_ci DEFAULT NULL,
  `houseid` varchar(60) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Extraindo dados da tabela `person`
--

INSERT INTO `person` (`id`, `name`, `phone`, `cellphone`, `address`, `complement`, `city`, `state`, `houseid`) VALUES
(1, 'Gustalbo', '1498818387', '', NULL, NULL, NULL, NULL, NULL);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `closedsche`
--
ALTER TABLE `closedsche`
  ADD PRIMARY KEY (`id`),
  ADD KEY `closedidperson` (`idperson`);

--
-- Indexes for table `opensche`
--
ALTER TABLE `opensche`
  ADD PRIMARY KEY (`id`),
  ADD KEY `openidperson` (`idperson`);

--
-- Indexes for table `person`
--
ALTER TABLE `person`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `closedsche`
--
ALTER TABLE `closedsche`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `opensche`
--
ALTER TABLE `opensche`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `person`
--
ALTER TABLE `person`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `closedsche`
--
ALTER TABLE `closedsche`
  ADD CONSTRAINT `closedidperson` FOREIGN KEY (`idperson`) REFERENCES `person` (`id`);

--
-- Limitadores para a tabela `opensche`
--
ALTER TABLE `opensche`
  ADD CONSTRAINT `openidperson` FOREIGN KEY (`idperson`) REFERENCES `person` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
