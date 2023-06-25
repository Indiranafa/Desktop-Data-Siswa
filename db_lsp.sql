-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Jun 25, 2023 at 04:09 AM
-- Server version: 8.0.30
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_lsp`
--

-- --------------------------------------------------------

--
-- Table structure for table `guru`
--

CREATE TABLE `guru` (
  `id` int NOT NULL,
  `nama` varchar(100) NOT NULL,
  `nip` varchar(25) NOT NULL,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `guru`
--

INSERT INTO `guru` (`id`, `nama`, `nip`, `created_at`, `updated_at`) VALUES
(1, 'Moh. Shobirin', '19910810 2022122 1 013', NULL, NULL),
(2, 'Lilik Sujayanti Djajadi S.T.', '19740428 201406 2 002', '2023-03-14 15:51:14', '2023-03-14 15:53:25'),
(3, 'Mohammad Wildam, S.Pd.', '0', '2023-03-15 02:16:11', NULL),
(4, 'Dra. Rohmah', '19660101 200701 2 042', '2023-03-15 02:47:13', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `mapel`
--

CREATE TABLE `mapel` (
  `id` int NOT NULL,
  `nama_mapel` varchar(50) NOT NULL,
  `kode_mapel` varchar(10) NOT NULL,
  `guru_id` int NOT NULL,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `mapel`
--

INSERT INTO `mapel` (`id`, `nama_mapel`, `kode_mapel`, `guru_id`, `created_at`, `updated_at`) VALUES
(1, 'Pemrograman Web', '001', 1, NULL, '2023-03-15 02:54:06'),
(2, 'Fisika', '002', 2, '2023-03-14 15:58:55', NULL),
(3, 'Basis Data', '003', 3, '2023-03-15 02:48:35', '2023-03-15 02:53:53'),
(4, 'Matematika', '004', 2, '2023-03-15 04:50:01', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `nilai`
--

CREATE TABLE `nilai` (
  `id` int NOT NULL,
  `siswa_id` int NOT NULL,
  `mapel_id` int NOT NULL,
  `nilai` int NOT NULL DEFAULT '0',
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `nilai`
--

INSERT INTO `nilai` (`id`, `siswa_id`, `mapel_id`, `nilai`, `created_at`, `updated_at`) VALUES
(1, 3, 3, 88, '2023-03-12 03:23:09', '2023-03-15 04:50:51'),
(2, 2, 1, 88, '2023-03-14 15:58:14', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `siswa`
--

CREATE TABLE `siswa` (
  `id` int NOT NULL,
  `nama` varchar(150) NOT NULL,
  `jenkel` varchar(10) NOT NULL,
  `alamat` varchar(255) NOT NULL,
  `nohp` varchar(18) NOT NULL,
  `jurusan` varchar(15) NOT NULL,
  `email` varchar(20) NOT NULL,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `siswa`
--

INSERT INTO `siswa` (`id`, `nama`, `jenkel`, `alamat`, `nohp`, `jurusan`, `email`, `created_at`, `updated_at`) VALUES
(1, 'Ahmad Halim', 'Laki-Laki', 'Lajuk Porong', '081389273664', 'RPL', 'halim@gmail.com', '2023-03-12 03:22:03', '2023-03-15 02:42:04'),
(2, 'Indira', 'Perempuan', 'Jl. Cangkringmalang', '085764543312', 'RPL', 'indira@gmail.com', '2023-03-14 13:07:20', '2023-03-15 02:43:12'),
(3, 'Erlin Indah', 'Perempuan', 'Jl Mangga', '08136274762', 'RPL', 'erlin@gmail.com', '2023-03-15 02:44:03', NULL),
(4, 'Muhammad Yudi', 'Laki-Laki', 'Lowokwaru', '01372852652', 'RPL', 'yudi@gmail.com', '2023-03-15 02:45:25', NULL),
(5, 'Ahmad Zufri', 'Laki-Laki', 'Jl. Manggis', '0186274422', 'RPL', 'zufri@gmail.com', '2023-03-15 04:48:19', '2023-03-15 04:48:57');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int NOT NULL,
  `name` varchar(150) NOT NULL,
  `email` varchar(25) NOT NULL,
  `email_verified_at` timestamp NULL DEFAULT NULL,
  `password` varchar(255) NOT NULL,
  `level` varchar(15) NOT NULL,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `name`, `email`, `email_verified_at`, `password`, `level`, `created_at`, `updated_at`) VALUES
(1, 'Admin', 'admin@gmail.com', '2023-03-11 10:00:00', 'Admin', 'admin', '2023-03-12 03:17:27', '2023-03-12 03:19:04');

-- --------------------------------------------------------

--
-- Stand-in structure for view `vmapel`
-- (See below for the actual view)
--
CREATE TABLE `vmapel` (
`id` int
,`nama_mapel` varchar(50)
,`kode_mapel` varchar(10)
,`nama` varchar(100)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `vnilai`
-- (See below for the actual view)
--
CREATE TABLE `vnilai` (
`id` int
,`nama` varchar(150)
,`jurusan` varchar(15)
,`nama_mapel` varchar(50)
,`guru` varchar(100)
,`nilai` int
);

-- --------------------------------------------------------

--
-- Structure for view `vmapel`
--
DROP TABLE IF EXISTS `vmapel`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vmapel`  AS SELECT `mapel`.`id` AS `id`, `mapel`.`nama_mapel` AS `nama_mapel`, `mapel`.`kode_mapel` AS `kode_mapel`, `guru`.`nama` AS `nama` FROM (`mapel` join `guru` on((`mapel`.`guru_id` = `guru`.`id`)))  ;

-- --------------------------------------------------------

--
-- Structure for view `vnilai`
--
DROP TABLE IF EXISTS `vnilai`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vnilai`  AS SELECT `nilai`.`id` AS `id`, `siswa`.`nama` AS `nama`, `siswa`.`jurusan` AS `jurusan`, `mapel`.`nama_mapel` AS `nama_mapel`, `guru`.`nama` AS `guru`, `nilai`.`nilai` AS `nilai` FROM (((`nilai` join `mapel` on((`mapel`.`id` = `nilai`.`mapel_id`))) join `siswa` on((`siswa`.`id` = `nilai`.`siswa_id`))) join `guru` on((`guru`.`id` = `mapel`.`id`)))  ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `guru`
--
ALTER TABLE `guru`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `mapel`
--
ALTER TABLE `mapel`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `nilai`
--
ALTER TABLE `nilai`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `siswa`
--
ALTER TABLE `siswa`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `users_email_unique` (`email`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `guru`
--
ALTER TABLE `guru`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `mapel`
--
ALTER TABLE `mapel`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `nilai`
--
ALTER TABLE `nilai`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `siswa`
--
ALTER TABLE `siswa`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
