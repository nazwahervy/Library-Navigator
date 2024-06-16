-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 14, 2024 at 07:55 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `library_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin_dt`
--

CREATE TABLE `admin_dt` (
  `id_admin` int(10) NOT NULL,
  `username` varchar(10) NOT NULL,
  `password` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admin_dt`
--

INSERT INTO `admin_dt` (`id_admin`, `username`, `password`) VALUES
(10201, 'nanaz', 'n1234'),
(10202, 'miftaa', 'hae123') ;

-- --------------------------------------------------------

--
-- Table structure for table `buku_dt`
--

CREATE TABLE `buku_dt` (
  `nomor_buku` int(10) NOT NULL,
  `judul_buku` varchar(100) NOT NULL,
  `penulis` varchar(50) NOT NULL,
  `kategori_buku` varchar(30) NOT NULL,
  `lokasi_rak` varchar(2) NOT NULL,
  `stok_buku` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `buku_dt`
--

INSERT INTO `buku_dt` (`nomor_buku`, `judul_buku`, `penulis`, `kategori_buku`, `lokasi_rak`, `stok_buku`) VALUES
(1001, 'ILY', 'Tere Liye', 'Novel', 'D2', 10),
(1002, 'Mariposa', 'Luluk', 'Novel', 'D2', 5),
(1005, 'Membangun Startup Teknologi di Indonesia', 'Pandu Sjahrir', 'Teknologi', 'A6', 20),
(1009, 'Azzamine', 'Sophie Aulia', 'Novel', 'D6', 15),
(1012, 'Harry Potter and The Secret Chamber', 'J.K Rowling', 'Novel', 'F4', 3),
(1013, 'Harry Potter and The Deathly Hollows', 'J.K Rowling', 'Novel', 'D2', 8),
(1014, 'Gerbang Dialog Danur', 'Risa Saraswati', 'Horror', 'A2', 8),
(1015, 'Bumi Manusia', 'Pramoedya Ananta Toer', 'Sejarah', 'B5', 6),
(1017, 'Ketika Mas Gagah Pergi & Kembali', 'Helvy Tiana Rosa', 'Romance', 'E6', 4),
(1018, 'Hutan Sutera yang Hilang', 'Pramoedya Ananta Toer', 'Sastra Anak', 'A5', 2),
(1019, 'Surat Kecil untuk Tuhan', 'Agnes Davonar', 'Agama', 'B4', 6),
(1020, 'Dari Sabang Sampai Merauke: Kisah Petualangan di Pulau Terluar', 'Teguh Harahap', 'Petualangan', 'C5', 12),
(1021, 'Cerita Rakyat Dari Nusantara', 'Tim Balai Kajian dan Pengembangan Budaya Melayu', 'Cerita Rakyat', 'D4', 5),
(1024, 'Bulan', 'Tere Liye', 'Novel', 'F7', 8),
(1027, 'Bumi', 'Tere Liye', 'Novel', 'C4', 9);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin_dt`
--
ALTER TABLE `admin_dt`
  ADD PRIMARY KEY (`id_admin`);

--
-- Indexes for table `buku_dt`
--
ALTER TABLE `buku_dt`
  ADD PRIMARY KEY (`nomor_buku`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin_dt`
--
ALTER TABLE `admin_dt`
  MODIFY `id_admin` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10203;

--
-- AUTO_INCREMENT for table `buku_dt`
--
ALTER TABLE `buku_dt`
  MODIFY `nomor_buku` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1028;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
