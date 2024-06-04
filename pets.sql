-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 03, 2024 at 09:41 AM
-- Server version: 5.7.14
-- PHP Version: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pets`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `admin_id` int(11) NOT NULL,
  `first_name` varchar(255) DEFAULT NULL,
  `last_name` varchar(255) DEFAULT NULL,
  `role_id` int(11) DEFAULT NULL,
  `login_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`admin_id`, `first_name`, `last_name`, `role_id`, `login_id`) VALUES
(1, 'admin', 'admin', 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `adresas`
--

CREATE TABLE `adresas` (
  `adreso_id` int(11) NOT NULL,
  `adresas` varchar(255) DEFAULT NULL,
  `miesto_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `adresas`
--

INSERT INTO `adresas` (`adreso_id`, `adresas`, `miesto_id`) VALUES
(1, 'Ukmerges g. 206-92', 1);

-- --------------------------------------------------------

--
-- Table structure for table `cipas`
--

CREATE TABLE `cipas` (
  `chip_id` int(11) NOT NULL,
  `klinikos_id` int(11) DEFAULT NULL,
  `vet_id` int(11) DEFAULT NULL,
  `data` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `cipas`
--

INSERT INTO `cipas` (`chip_id`, `klinikos_id`, `vet_id`, `data`) VALUES
(1, 1, 1, '2024-02-02');

-- --------------------------------------------------------

--
-- Table structure for table `gyvunas`
--

CREATE TABLE `gyvunas` (
  `gyvuno_id` int(11) NOT NULL,
  `gyv_veisle` varchar(255) DEFAULT NULL,
  `lytis` varchar(255) DEFAULT NULL,
  `amzius` int(11) DEFAULT NULL,
  `svoris` int(11) DEFAULT NULL,
  `chip_id` int(11) DEFAULT NULL,
  `user_id` int(11) DEFAULT NULL,
  `skiepo_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `gyvunas`
--

INSERT INTO `gyvunas` (`gyvuno_id`, `gyv_veisle`, `lytis`, `amzius`, `svoris`, `chip_id`, `user_id`, `skiepo_id`) VALUES
(1, 'Kate', 'M', 7, 5, 1, 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `gyvuno_rusys`
--

CREATE TABLE `gyvuno_rusys` (
  `rusies_id` int(11) NOT NULL,
  `rusis` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `gyvuno_rusys`
--

INSERT INTO `gyvuno_rusys` (`rusies_id`, `rusis`) VALUES
(1, 'Ilgaplauke kate');

-- --------------------------------------------------------

--
-- Table structure for table `klinikos`
--

CREATE TABLE `klinikos` (
  `klinikos_id` int(11) NOT NULL,
  `pavadinimas` varchar(255) DEFAULT NULL,
  `adresas` varchar(255) DEFAULT NULL,
  `miesto_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `klinikos`
--

INSERT INTO `klinikos` (`klinikos_id`, `pavadinimas`, `adresas`, `miesto_id`) VALUES
(1, 'Seskines klinika', 'Seskines g. 10-20', 1),
(2, 'Kauno klinika', 'Kauno g. 17-19', 2);

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `login_id` int(11) NOT NULL,
  `email_address` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`login_id`, `email_address`, `password`) VALUES
(1, 'admin', 'admin'),
(2, 'test@gmail.com', 'test123'),
(3, 'supervisor@test.com', 'super');

-- --------------------------------------------------------

--
-- Table structure for table `miestai`
--

CREATE TABLE `miestai` (
  `miesto_id` int(11) NOT NULL,
  `pavadinimas` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `miestai`
--

INSERT INTO `miestai` (`miesto_id`, `pavadinimas`) VALUES
(1, 'Vilnius'),
(2, 'Kaunas'),
(3, 'Panevezys'),
(4, 'Siauliai'),
(5, 'Klaipeda');

-- --------------------------------------------------------

--
-- Table structure for table `role`
--

CREATE TABLE `role` (
  `role_id` int(11) NOT NULL,
  `role_name` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `role`
--

INSERT INTO `role` (`role_id`, `role_name`) VALUES
(1, 'admin'),
(2, 'supervisor');

-- --------------------------------------------------------

--
-- Table structure for table `skiepas`
--

CREATE TABLE `skiepas` (
  `skiepo_id` int(11) NOT NULL,
  `pavadinimas` varchar(255) DEFAULT NULL,
  `skiepo_data` date DEFAULT NULL,
  `kitas_skiepas` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `skiepas`
--

INSERT INTO `skiepas` (`skiepo_id`, `pavadinimas`, `skiepo_data`, `kitas_skiepas`) VALUES
(1, 'Nuo kirminu', '2024-02-02', '2025-02-02');

-- --------------------------------------------------------

--
-- Table structure for table `supervisor`
--

CREATE TABLE `supervisor` (
  `supervisor_id` int(11) NOT NULL,
  `name` varchar(255) DEFAULT NULL,
  `surname` varchar(255) DEFAULT NULL,
  `phone_nmb` int(15) DEFAULT NULL,
  `login_id` int(11) DEFAULT NULL,
  `role_id` int(11) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `supervisor`
--

INSERT INTO `supervisor` (`supervisor_id`, `name`, `surname`, `phone_nmb`, `login_id`, `role_id`, `password`, `email`) VALUES
(1, 'Mangirdas', 'Taugirdas', 867367891, 3, 2, 'super', 'supervisor@test.com');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `user_id` int(11) NOT NULL,
  `el_pastas` varchar(255) DEFAULT NULL,
  `vardas` varchar(255) DEFAULT NULL,
  `pavarde` varchar(255) DEFAULT NULL,
  `adreso_id` int(11) DEFAULT NULL,
  `gyvuno_id` int(11) DEFAULT NULL,
  `login_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`user_id`, `el_pastas`, `vardas`, `pavarde`, `adreso_id`, `gyvuno_id`, `login_id`) VALUES
(1, 'test@gmail.com', 'Robis', 'Kask', 1, 1, 2);

-- --------------------------------------------------------

--
-- Table structure for table `veterinaras`
--

CREATE TABLE `veterinaras` (
  `vet_id` int(11) NOT NULL,
  `vardas` varchar(255) DEFAULT NULL,
  `pavarde` varchar(255) DEFAULT NULL,
  `klinikos_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `veterinaras`
--

INSERT INTO `veterinaras` (`vet_id`, `vardas`, `pavarde`, `klinikos_id`) VALUES
(1, 'Romanas', 'Zibute', 1),
(2, 'Kauno', 'Gudrocius', 2);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`admin_id`),
  ADD KEY `FK_admin_role_role_id` (`role_id`),
  ADD KEY `FK_admin_login_login_id` (`login_id`);

--
-- Indexes for table `adresas`
--
ALTER TABLE `adresas`
  ADD PRIMARY KEY (`adreso_id`),
  ADD KEY `FK_adresas_miestai_miesto_id` (`miesto_id`);

--
-- Indexes for table `cipas`
--
ALTER TABLE `cipas`
  ADD PRIMARY KEY (`chip_id`),
  ADD KEY `FK_cipas_veterinaras_vet_id` (`vet_id`);

--
-- Indexes for table `gyvunas`
--
ALTER TABLE `gyvunas`
  ADD PRIMARY KEY (`gyvuno_id`),
  ADD KEY `FK_gyvunas_klientas_kliento_id` (`user_id`),
  ADD KEY `FK_gyvunas_cipas_chip_id` (`chip_id`),
  ADD KEY `FK_gyvunas_skiepas_skiepo_id` (`skiepo_id`);

--
-- Indexes for table `gyvuno_rusys`
--
ALTER TABLE `gyvuno_rusys`
  ADD PRIMARY KEY (`rusies_id`);

--
-- Indexes for table `klinikos`
--
ALTER TABLE `klinikos`
  ADD PRIMARY KEY (`klinikos_id`),
  ADD KEY `FK_klinikos_miestai_miesto_id` (`miesto_id`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`login_id`);

--
-- Indexes for table `miestai`
--
ALTER TABLE `miestai`
  ADD PRIMARY KEY (`miesto_id`);

--
-- Indexes for table `role`
--
ALTER TABLE `role`
  ADD PRIMARY KEY (`role_id`);

--
-- Indexes for table `skiepas`
--
ALTER TABLE `skiepas`
  ADD PRIMARY KEY (`skiepo_id`);

--
-- Indexes for table `supervisor`
--
ALTER TABLE `supervisor`
  ADD PRIMARY KEY (`supervisor_id`),
  ADD KEY `FK_supervisor_login_login_id` (`login_id`),
  ADD KEY `FK_supervisor_role_role_id` (`role_id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`user_id`),
  ADD KEY `FK_klientas_prisijungimas_el.pastas` (`el_pastas`),
  ADD KEY `FK_user_login_login_id` (`login_id`),
  ADD KEY `FK_user_gyvunas_gyvuno_id` (`gyvuno_id`),
  ADD KEY `FK_user_adresas_adreso_id` (`adreso_id`);

--
-- Indexes for table `veterinaras`
--
ALTER TABLE `veterinaras`
  ADD PRIMARY KEY (`vet_id`),
  ADD KEY `FK_veterinaras_klinikos_klinikos_id` (`klinikos_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `admin_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `adresas`
--
ALTER TABLE `adresas`
  MODIFY `adreso_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `cipas`
--
ALTER TABLE `cipas`
  MODIFY `chip_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `gyvunas`
--
ALTER TABLE `gyvunas`
  MODIFY `gyvuno_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `gyvuno_rusys`
--
ALTER TABLE `gyvuno_rusys`
  MODIFY `rusies_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `klinikos`
--
ALTER TABLE `klinikos`
  MODIFY `klinikos_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `login`
--
ALTER TABLE `login`
  MODIFY `login_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `miestai`
--
ALTER TABLE `miestai`
  MODIFY `miesto_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `role`
--
ALTER TABLE `role`
  MODIFY `role_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `skiepas`
--
ALTER TABLE `skiepas`
  MODIFY `skiepo_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `supervisor`
--
ALTER TABLE `supervisor`
  MODIFY `supervisor_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `veterinaras`
--
ALTER TABLE `veterinaras`
  MODIFY `vet_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `admin`
--
ALTER TABLE `admin`
  ADD CONSTRAINT `FK_admin_login_login_id` FOREIGN KEY (`login_id`) REFERENCES `login` (`login_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `FK_admin_role_role_id` FOREIGN KEY (`role_id`) REFERENCES `role` (`role_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `adresas`
--
ALTER TABLE `adresas`
  ADD CONSTRAINT `FK_adresas_miestai_miesto_id` FOREIGN KEY (`miesto_id`) REFERENCES `miestai` (`miesto_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `cipas`
--
ALTER TABLE `cipas`
  ADD CONSTRAINT `FK_cipas_veterinaras_vet_id` FOREIGN KEY (`vet_id`) REFERENCES `veterinaras` (`vet_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `gyvunas`
--
ALTER TABLE `gyvunas`
  ADD CONSTRAINT `FK_gyvunas_cipas_chip_id` FOREIGN KEY (`chip_id`) REFERENCES `cipas` (`chip_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `FK_gyvunas_user_user_id` FOREIGN KEY (`user_id`) REFERENCES `user` (`user_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `klinikos`
--
ALTER TABLE `klinikos`
  ADD CONSTRAINT `FK_klinikos_miestai_miesto_id` FOREIGN KEY (`miesto_id`) REFERENCES `miestai` (`miesto_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `skiepas`
--
ALTER TABLE `skiepas`
  ADD CONSTRAINT `FK_skiepas_gyvunas_gyvuno_id` FOREIGN KEY (`skiepo_id`) REFERENCES `gyvunas` (`gyvuno_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `supervisor`
--
ALTER TABLE `supervisor`
  ADD CONSTRAINT `FK_supervisor_login_login_id` FOREIGN KEY (`login_id`) REFERENCES `login` (`login_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `FK_supervisor_role_role_id` FOREIGN KEY (`role_id`) REFERENCES `role` (`role_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `user`
--
ALTER TABLE `user`
  ADD CONSTRAINT `FK_user_adresas_adreso_id` FOREIGN KEY (`adreso_id`) REFERENCES `adresas` (`adreso_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `FK_user_gyvunas_gyvuno_id` FOREIGN KEY (`gyvuno_id`) REFERENCES `gyvunas` (`gyvuno_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `FK_user_login_login_id` FOREIGN KEY (`login_id`) REFERENCES `login` (`login_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `veterinaras`
--
ALTER TABLE `veterinaras`
  ADD CONSTRAINT `FK_veterinaras_klinikos_klinikos_id` FOREIGN KEY (`klinikos_id`) REFERENCES `klinikos` (`klinikos_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
