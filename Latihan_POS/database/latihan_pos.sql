-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Dec 27, 2016 at 01:27 PM
-- Server version: 10.1.19-MariaDB
-- PHP Version: 7.0.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `latihan_pos`
--

-- --------------------------------------------------------

--
-- Table structure for table `barang`
--

CREATE TABLE `barang` (
  `ID` int(10) NOT NULL,
  `Kode` varchar(20) NOT NULL,
  `Nama` varchar(100) NOT NULL,
  `JumlahAwal` int(10) NOT NULL,
  `HargaHPP` decimal(16,2) NOT NULL,
  `HargaJual` decimal(16,2) NOT NULL,
  `created_At` datetime NOT NULL,
  `updated_At` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `barang`
--

INSERT INTO `barang` (`ID`, `Kode`, `Nama`, `JumlahAwal`, `HargaHPP`, `HargaJual`, `created_At`, `updated_At`) VALUES
(1, '123', 'Buku Gambar', 50, '10000.00', '12000.00', '2016-12-02 23:45:16', '2016-12-27 19:25:05'),
(2, '124', 'Baju Jersey', 66, '100000.00', '150000.00', '2016-12-02 23:53:03', '2016-12-27 18:25:34'),
(3, '125', 'Mouse', 53, '50000.00', '55000.00', '2016-12-22 20:15:44', '2016-12-27 14:04:31');

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `ID` int(11) NOT NULL,
  `Nama` varchar(100) NOT NULL,
  `Alamat` varchar(200) NOT NULL,
  `Zip_code` varchar(20) NOT NULL,
  `Phone_number` varchar(20) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`ID`, `Nama`, `Alamat`, `Zip_code`, `Phone_number`, `Email`, `created_at`, `updated_at`) VALUES
(1, 'Adrian Hartanto', 'Jl Japaris', '20215', '081265173108', 'adrian.shenzryu@gmail.com', '2016-12-16 14:03:31', '2016-12-23 00:36:02');

-- --------------------------------------------------------

--
-- Table structure for table `pembelian`
--

CREATE TABLE `pembelian` (
  `id` int(11) NOT NULL,
  `kode` varchar(10) NOT NULL,
  `id_supplier` int(11) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pembelian`
--

INSERT INTO `pembelian` (`id`, `kode`, `id_supplier`, `created_at`, `updated_at`) VALUES
(1, 'beli-001', 2, '2016-12-26 22:00:00', '2016-12-27 19:14:04'),
(2, 'beli-002', 1, '2016-12-27 12:40:37', '2016-12-27 13:55:27'),
(3, 'beli-003', 1, '2016-12-27 12:45:34', '2016-12-27 12:49:11');

-- --------------------------------------------------------

--
-- Table structure for table `pembelian_detail`
--

CREATE TABLE `pembelian_detail` (
  `id` int(11) NOT NULL,
  `Id_pembelian` int(11) NOT NULL,
  `id_barang` int(11) NOT NULL,
  `harga_barang` decimal(11,0) NOT NULL,
  `kuantitas` int(11) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pembelian_detail`
--

INSERT INTO `pembelian_detail` (`id`, `Id_pembelian`, `id_barang`, `harga_barang`, `kuantitas`, `created_at`, `updated_at`) VALUES
(3, 1, 1, '10000', 11, '2016-12-27 13:35:46', '2016-12-27 19:14:05'),
(4, 1, 2, '100000', 12, '2016-12-27 13:53:44', '2016-12-27 13:54:31'),
(5, 2, 1, '10000', 9, '2016-12-27 13:55:29', '2016-12-27 13:55:29'),
(6, 1, 3, '50000', 3, '2016-12-27 14:04:31', '2016-12-27 14:04:31');

-- --------------------------------------------------------

--
-- Table structure for table `penjualan`
--

CREATE TABLE `penjualan` (
  `id` int(11) NOT NULL,
  `kode` varchar(10) NOT NULL,
  `id_customer` int(11) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `penjualan`
--

INSERT INTO `penjualan` (`id`, `kode`, `id_customer`, `created_at`, `updated_at`) VALUES
(1, 'jual-001', 1, '2016-12-27 18:21:42', '2016-12-27 19:25:03');

-- --------------------------------------------------------

--
-- Table structure for table `penjualan_detail`
--

CREATE TABLE `penjualan_detail` (
  `id` int(11) NOT NULL,
  `id_penjualan` int(11) NOT NULL,
  `id_barang` int(11) NOT NULL,
  `harga_barang` decimal(10,2) NOT NULL,
  `kuantitas` int(11) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `penjualan_detail`
--

INSERT INTO `penjualan_detail` (`id`, `id_penjualan`, `id_barang`, `harga_barang`, `kuantitas`, `created_at`, `updated_at`) VALUES
(1, 1, 1, '12000.00', 20, '2016-12-27 18:23:39', '2016-12-27 19:25:05'),
(2, 1, 2, '150000.00', 1, '2016-12-27 18:25:34', '2016-12-27 18:25:34');

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `ID` int(11) NOT NULL,
  `Nama` varchar(100) NOT NULL,
  `Alamat` varchar(200) NOT NULL,
  `Zip_code` varchar(20) NOT NULL,
  `Phone_Number` varchar(20) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`ID`, `Nama`, `Alamat`, `Zip_code`, `Phone_Number`, `Email`, `created_at`, `updated_at`) VALUES
(1, 'Adrian Hartanto', 'Jl Rahmadsyah', '20215', '081265173108', 'adrian.shenzryu@gmail.com', '2016-12-17 00:13:16', '2016-12-23 11:05:28'),
(2, 'William', 'Gg Kemala', '20215', '88888888', 'ws@gmail.com', '2016-12-27 12:45:16', '2016-12-27 12:45:16');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `barang`
--
ALTER TABLE `barang`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `pembelian`
--
ALTER TABLE `pembelian`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `pembelian_detail`
--
ALTER TABLE `pembelian_detail`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `penjualan`
--
ALTER TABLE `penjualan`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `penjualan_detail`
--
ALTER TABLE `penjualan_detail`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `barang`
--
ALTER TABLE `barang`
  MODIFY `ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `pembelian`
--
ALTER TABLE `pembelian`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `pembelian_detail`
--
ALTER TABLE `pembelian_detail`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT for table `penjualan`
--
ALTER TABLE `penjualan`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `penjualan_detail`
--
ALTER TABLE `penjualan_detail`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `supplier`
--
ALTER TABLE `supplier`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
