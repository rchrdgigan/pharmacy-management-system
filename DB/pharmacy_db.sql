-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 03, 2022 at 05:35 PM
-- Server version: 10.4.18-MariaDB
-- PHP Version: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pharmacy_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `categories`
--

CREATE TABLE `categories` (
  `id` int(11) NOT NULL,
  `cat_name` varchar(60) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `categories`
--

INSERT INTO `categories` (`id`, `cat_name`, `created_at`) VALUES
(2, 'Montelukast', '2022-10-21 11:28:38'),
(4, 'Ramipril', '2022-10-21 11:28:20'),
(5, 'Nexium', '2022-10-21 11:28:07'),
(21, 'Amlodipine', '2022-10-21 11:27:55'),
(22, 'Abilify', '2022-10-21 11:28:50'),
(23, 'Citalopram', '2022-10-21 11:29:05'),
(24, 'Naprelan', '2022-10-21 11:32:22');

-- --------------------------------------------------------

--
-- Table structure for table `inventories`
--

CREATE TABLE `inventories` (
  `id` int(11) NOT NULL,
  `transaction_in_id` int(11) DEFAULT NULL,
  `transaction_out_id` int(11) DEFAULT NULL,
  `medicine_id` int(11) NOT NULL,
  `qty_in` int(11) DEFAULT NULL,
  `qty_out` int(11) DEFAULT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `in_stocks`
--

CREATE TABLE `in_stocks` (
  `id` int(11) NOT NULL,
  `transaction_in_id` int(11) NOT NULL,
  `medicine_id` int(11) NOT NULL,
  `qty` int(11) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `medicines`
--

CREATE TABLE `medicines` (
  `id` int(11) NOT NULL,
  `sku` bigint(20) NOT NULL,
  `category_id` int(11) NOT NULL,
  `type_id` int(11) NOT NULL,
  `drug_name` varchar(60) NOT NULL,
  `measurement` varchar(60) NOT NULL,
  `description` text NOT NULL,
  `prescription` tinyint(1) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `medicines`
--

INSERT INTO `medicines` (`id`, `sku`, `category_id`, `type_id`, `drug_name`, `measurement`, `description`, `prescription`, `created_at`) VALUES
(12, 182811, 24, 10, 'Test', '10mg', 'N/a', 1, '2022-11-08 15:17:59'),
(13, 878012, 23, 8, 'Vaccc', '500mg', 'N/a', 0, '2022-11-08 16:58:59');

-- --------------------------------------------------------

--
-- Table structure for table `out_stocks`
--

CREATE TABLE `out_stocks` (
  `id` int(11) NOT NULL,
  `transaction_out_id` int(11) NOT NULL,
  `medicine_id` int(11) NOT NULL,
  `qty` int(11) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `patients`
--

CREATE TABLE `patients` (
  `id` int(11) NOT NULL,
  `name` varchar(60) NOT NULL,
  `birthdate` date NOT NULL,
  `address` text NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `suppliers`
--

CREATE TABLE `suppliers` (
  `id` int(11) NOT NULL,
  `supplier_name` varchar(60) NOT NULL,
  `supplier_contact` varchar(30) NOT NULL,
  `supplier_address` varchar(150) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `transaction_in`
--

CREATE TABLE `transaction_in` (
  `id` int(11) NOT NULL,
  `supplier_id` int(11) NOT NULL,
  `refno` varchar(60) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `transaction_out`
--

CREATE TABLE `transaction_out` (
  `id` int(11) NOT NULL,
  `patient_id` int(11) NOT NULL,
  `age` int(11) NOT NULL,
  `patient_state` varchar(20) NOT NULL,
  `war_number` int(11) DEFAULT NULL,
  `bed_number` int(11) DEFAULT NULL,
  `refno` varchar(60) NOT NULL,
  `pharmacist_name` varchar(60) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `types`
--

CREATE TABLE `types` (
  `id` int(11) NOT NULL,
  `type_name` varchar(60) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `types`
--

INSERT INTO `types` (`id`, `type_name`, `created_at`) VALUES
(1, 'Tablet', '2022-10-21 11:25:41'),
(7, 'Liquid', '2022-10-21 11:25:51'),
(8, 'Capsules', '2022-10-21 11:26:19'),
(9, 'Drops', '2022-10-21 11:26:26'),
(10, 'Inhalers', '2022-10-21 11:26:34'),
(11, 'Injections', '2022-10-21 11:26:53'),
(12, 'Suppositories', '2022-10-21 11:27:10');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `name` varchar(60) NOT NULL,
  `contact` varchar(15) NOT NULL,
  `address` varchar(60) NOT NULL,
  `username` varchar(30) NOT NULL,
  `password` varchar(20) NOT NULL,
  `role` varchar(20) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `name`, `contact`, `address`, `username`, `password`, `role`, `created_at`) VALUES
(1, 'deafault-pharmacist', '09321331122', 'Pawa, Bulan, Sorsogon', 'super_admin', 'admin12345', 'super-user', '2022-11-11 07:08:14');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `inventories`
--
ALTER TABLE `inventories`
  ADD PRIMARY KEY (`id`),
  ADD KEY `transaction_in_id` (`transaction_in_id`),
  ADD KEY `transaction_out_id` (`transaction_out_id`),
  ADD KEY `medicine_id` (`medicine_id`);

--
-- Indexes for table `in_stocks`
--
ALTER TABLE `in_stocks`
  ADD PRIMARY KEY (`id`),
  ADD KEY `medicine_id` (`medicine_id`),
  ADD KEY `transaction_in_id` (`transaction_in_id`);

--
-- Indexes for table `medicines`
--
ALTER TABLE `medicines`
  ADD PRIMARY KEY (`id`),
  ADD KEY `type_id` (`type_id`),
  ADD KEY `category_id` (`category_id`);

--
-- Indexes for table `out_stocks`
--
ALTER TABLE `out_stocks`
  ADD PRIMARY KEY (`id`),
  ADD KEY `transaction_out_id` (`transaction_out_id`),
  ADD KEY `medicine_id` (`medicine_id`);

--
-- Indexes for table `patients`
--
ALTER TABLE `patients`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `suppliers`
--
ALTER TABLE `suppliers`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `transaction_in`
--
ALTER TABLE `transaction_in`
  ADD PRIMARY KEY (`id`),
  ADD KEY `supplier_id` (`supplier_id`);

--
-- Indexes for table `transaction_out`
--
ALTER TABLE `transaction_out`
  ADD PRIMARY KEY (`id`),
  ADD KEY `patient_id` (`patient_id`);

--
-- Indexes for table `types`
--
ALTER TABLE `types`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `categories`
--
ALTER TABLE `categories`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT for table `inventories`
--
ALTER TABLE `inventories`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT for table `in_stocks`
--
ALTER TABLE `in_stocks`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=47;

--
-- AUTO_INCREMENT for table `medicines`
--
ALTER TABLE `medicines`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `out_stocks`
--
ALTER TABLE `out_stocks`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT for table `patients`
--
ALTER TABLE `patients`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `suppliers`
--
ALTER TABLE `suppliers`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `transaction_in`
--
ALTER TABLE `transaction_in`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT for table `transaction_out`
--
ALTER TABLE `transaction_out`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `types`
--
ALTER TABLE `types`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `inventories`
--
ALTER TABLE `inventories`
  ADD CONSTRAINT `inventories_ibfk_1` FOREIGN KEY (`transaction_in_id`) REFERENCES `transaction_in` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `inventories_ibfk_2` FOREIGN KEY (`transaction_out_id`) REFERENCES `transaction_out` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `inventories_ibfk_3` FOREIGN KEY (`medicine_id`) REFERENCES `medicines` (`id`) ON DELETE CASCADE;

--
-- Constraints for table `in_stocks`
--
ALTER TABLE `in_stocks`
  ADD CONSTRAINT `in_stocks_ibfk_1` FOREIGN KEY (`transaction_in_id`) REFERENCES `transaction_in` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `in_stocks_ibfk_2` FOREIGN KEY (`medicine_id`) REFERENCES `medicines` (`id`) ON DELETE CASCADE;

--
-- Constraints for table `medicines`
--
ALTER TABLE `medicines`
  ADD CONSTRAINT `medicines_ibfk_1` FOREIGN KEY (`category_id`) REFERENCES `categories` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `medicines_ibfk_2` FOREIGN KEY (`type_id`) REFERENCES `types` (`id`) ON DELETE CASCADE;

--
-- Constraints for table `out_stocks`
--
ALTER TABLE `out_stocks`
  ADD CONSTRAINT `out_stocks_ibfk_1` FOREIGN KEY (`medicine_id`) REFERENCES `medicines` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `out_stocks_ibfk_2` FOREIGN KEY (`transaction_out_id`) REFERENCES `transaction_out` (`id`) ON DELETE CASCADE;

--
-- Constraints for table `transaction_in`
--
ALTER TABLE `transaction_in`
  ADD CONSTRAINT `transaction_in_ibfk_1` FOREIGN KEY (`supplier_id`) REFERENCES `suppliers` (`id`) ON DELETE CASCADE;

--
-- Constraints for table `transaction_out`
--
ALTER TABLE `transaction_out`
  ADD CONSTRAINT `transaction_out_ibfk_2` FOREIGN KEY (`patient_id`) REFERENCES `patients` (`id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
