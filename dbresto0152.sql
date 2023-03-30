-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 30, 2021 at 05:57 AM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.4.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbresto0152`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_INSERTPENJUALAN` (`TOT` INT, `TJ` DATE, `IK` CHAR(5))  BEGIN
	DECLARE IJ CHAR(5);
    SET IJ = FC_IDJUAL();
    INSERT INTO MENU VALUES (IJ, TOT,TJ,IK);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `T_menu` (`id_menu` CHAR(5), `id_kategori` CHAR(5), `nama_menu` VARCHAR(50), `harga_menu` INT(11))  BEGIN
	INSERT INTO menu VALUES (id_menu, id_kategori, nama_menu, harga_menu);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `T_penjualan` (`id_jual` CHAR(5), `total` INT(11), `tgl_jual` DATE, `id_kasir` CHAR(5))  BEGIN
	INSERT INTO penjualan VALUES (id_jual, total, tgl_jual, id_kasir);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `T_updatePassKasir` (`id_kasir` CHAR(5), `pass` VARCHAR(10))  BEGIN
	UPDATE kasir
    SET pass = ''
    WHERE id_kasir = '';
END$$

--
-- Functions
--
CREATE DEFINER=`root`@`localhost` FUNCTION `FC_IDJUAL` () RETURNS CHAR(5) CHARSET utf8mb4 BEGIN
	DECLARE KODEBARU CHAR(5);
    DECLARE AKHIR INT;
    SET AKHIR = (SELECT MAX(RIGHT(ID_JUAL,2)) FROM penjualan);
    IF AKHIR IS NULL THEN
       SET AKHIR = 0;
       SET KODEBARU = 'PJ' + RIGHT('00'+ CAST(AKHIR+1 AS VARCHAR (3)), 3);
	END IF;
                                   
    RETURN (KODEBARU);
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `detail_jual`
--

CREATE TABLE `detail_jual` (
  `id_jual` char(5) NOT NULL,
  `id_menu` char(5) NOT NULL,
  `harga_jual` int(11) DEFAULT NULL,
  `qty` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `detail_jual`
--

INSERT INTO `detail_jual` (`id_jual`, `id_menu`, `harga_jual`, `qty`) VALUES
('PJ001', 'M0001', 46000, 1),
('PJ001', 'M0012', 4000, 1),
('PJ002', 'M0002', 46000, 1),
('PJ002', 'M0003', 12000, 1),
('PJ002', 'M0011', 3000, 1),
('PJ003', 'M0004', 33000, 3),
('PJ004', 'M0008', 46000, 2),
('PJ004', 'M0004', 33000, 2),
('PJ004', 'M0013', 3000, 2),
('PJ005', 'M0003', 12000, 1),
('PJ005', 'M0005', 35000, 1),
('PJ005', 'M0001', 4000, 2);

-- --------------------------------------------------------

--
-- Table structure for table `kasir`
--

CREATE TABLE `kasir` (
  `id_kasir` char(5) NOT NULL,
  `nama_kasir` varchar(50) NOT NULL,
  `userid` varchar(10) NOT NULL,
  `pass` varchar(10) NOT NULL,
  `level_kasir` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `kasir`
--

INSERT INTO `kasir` (`id_kasir`, `nama_kasir`, `userid`, `pass`, `level_kasir`) VALUES
('K0001', 'DWI APRILIA', 'APRIL', 'AprilAja', 'AK'),
('K0002', 'SRI ASTUTI', 'TUTI', 'tut123', 'AK'),
('K0003', 'MAEMUNAH', 'MAEMUN', '0109', 'SK'),
('K0004', 'Eka Pratiwi', 'EkaP', 'Siji2', 'SK'),
('K0005', 'TIKA ANDINI', 'TIKA', '001TA', 'SK'),
('K0006', 'Bram', 'bpp', '1111', 'SK');

-- --------------------------------------------------------

--
-- Table structure for table `kategori`
--

CREATE TABLE `kategori` (
  `id_kategori` char(5) NOT NULL,
  `nama_kategori` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `kategori`
--

INSERT INTO `kategori` (`id_kategori`, `nama_kategori`) VALUES
('', ''),
('KT001', 'MAKANAN'),
('KT002', 'MINUMAN');

-- --------------------------------------------------------

--
-- Table structure for table `menu`
--

CREATE TABLE `menu` (
  `id_menu` char(5) NOT NULL,
  `id_kategori` char(5) NOT NULL,
  `nama_menu` varchar(50) DEFAULT NULL,
  `harga_menu` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `menu`
--

INSERT INTO `menu` (`id_menu`, `id_kategori`, `nama_menu`, `harga_menu`) VALUES
('M0001', 'KT001', 'KEPITING SAOS PADANG', 46000),
('M0002', 'KT001', 'KEPITING SAOS TIRAM', 46000),
('M0003', 'KT001', 'KERANG HIJAU REBUS', 12000),
('M0004', 'KT001', 'CUMI CAH BROKOLI', 33000),
('M0005', 'KT001', 'CUMI GORENG TEPUNG', 35000),
('M0006', 'KT001', 'CUMI GORENG SAOS TIRAM', 38000),
('M0007', 'KT001', 'CUMI CAH KEMBANG KOL', 33000),
('M0008', 'KT001', 'IKAN GURAME ASAM MANIS', 46000),
('M0009', 'KT001', 'IKAN GURAME GORENG KERING', 15000),
('M0011', 'KT002', 'ES TEH/TEH HANGAT', 3000),
('M0012', 'KT002', 'ES JERUK/JERUK HANGAT', 4000),
('M0013', 'KT002', 'AIR MINERAL BOTOL', 5000),
('M0014', 'KT001', 'KEPITING ASAM MANIS', 46000),
('M0015', 'KT001', 'KEPITING SAOS LADA HITAM', 46000),
('M0016', 'KT001', 'KERANG HIJAU SAOS PADANG', 17000),
('M0017', 'KT001', 'KERANG HIJAU SAOS TIRAM', 17000),
('M0018', 'KT001', 'CUMI MASAKAN PADANG', 38000),
('M0019', 'KT001', 'CUMI CAH KANGKUNG', 24000),
('M0020', 'KT001', 'CUMI CAH JAMU', 33000),
('M0021', 'KT001', 'IKAN GURAME SAOS PADANG', 11000),
('M0022', 'KT001', 'IKAN GURAME TIM', 11000),
('M0023', 'KT002', 'JUS MANGGA', 8000),
('M0024', 'KT002', 'JUS JERUK', 5000),
('M0025', 'KT002', 'JUS WORTEL', 4000),
('M0026', 'KT001', 'MAGELANGAN JOGJA', 15000);

-- --------------------------------------------------------

--
-- Table structure for table `penjualan`
--

CREATE TABLE `penjualan` (
  `id_jual` char(5) NOT NULL,
  `total` int(11) DEFAULT NULL,
  `tgl_jual` date DEFAULT NULL,
  `id_kasir` char(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `penjualan`
--

INSERT INTO `penjualan` (`id_jual`, `total`, `tgl_jual`, `id_kasir`) VALUES
('PJ001', 50000, '2020-01-03', 'K0001'),
('PJ002', 61000, '2020-01-03', 'K0001'),
('PJ003', 99000, '2020-01-04', 'K0002'),
('PJ004', 164000, '2020-01-04', 'K0002'),
('PJ005', 55000, '2020-01-05', 'K0002');

-- --------------------------------------------------------

--
-- Stand-in structure for view `vdetailpenjualanmenu`
-- (See below for the actual view)
--
CREATE TABLE `vdetailpenjualanmenu` (
`id_jual` char(5)
,`tgl_jual` date
,`nama_menu` varchar(50)
,`harga_menu` int(11)
,`qty` int(11)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `vkasir`
-- (See below for the actual view)
--
CREATE TABLE `vkasir` (
`nama_kasir` varchar(50)
,`userid` varchar(10)
,`pass` varchar(10)
,`level_kasir` varchar(30)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `vtransaksikasir`
-- (See below for the actual view)
--
CREATE TABLE `vtransaksikasir` (
`id_kasir` char(5)
,`nama_kasir` varchar(50)
,`JumlahTransaksi` decimal(32,0)
);

-- --------------------------------------------------------

--
-- Structure for view `vdetailpenjualanmenu`
--
DROP TABLE IF EXISTS `vdetailpenjualanmenu`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vdetailpenjualanmenu`  AS  select `p`.`id_jual` AS `id_jual`,`p`.`tgl_jual` AS `tgl_jual`,`m`.`nama_menu` AS `nama_menu`,`m`.`harga_menu` AS `harga_menu`,`d`.`qty` AS `qty` from ((`penjualan` `p` join `detail_jual` `d` on(`p`.`id_jual` = `d`.`id_jual`)) join `menu` `m` on(`d`.`id_menu` = `m`.`id_menu`)) ;

-- --------------------------------------------------------

--
-- Structure for view `vkasir`
--
DROP TABLE IF EXISTS `vkasir`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vkasir`  AS  select `kasir`.`nama_kasir` AS `nama_kasir`,`kasir`.`userid` AS `userid`,`kasir`.`pass` AS `pass`,`kasir`.`level_kasir` AS `level_kasir` from `kasir` ;

-- --------------------------------------------------------

--
-- Structure for view `vtransaksikasir`
--
DROP TABLE IF EXISTS `vtransaksikasir`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vtransaksikasir`  AS  select `k`.`id_kasir` AS `id_kasir`,`k`.`nama_kasir` AS `nama_kasir`,sum(`d`.`qty`) AS `JumlahTransaksi` from ((`kasir` `k` left join `penjualan` `p` on(`p`.`id_kasir` = `k`.`id_kasir`)) left join `detail_jual` `d` on(`d`.`id_jual` = `p`.`id_jual`)) group by `k`.`id_kasir` ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `kasir`
--
ALTER TABLE `kasir`
  ADD PRIMARY KEY (`id_kasir`);

--
-- Indexes for table `kategori`
--
ALTER TABLE `kategori`
  ADD PRIMARY KEY (`id_kategori`);

--
-- Indexes for table `menu`
--
ALTER TABLE `menu`
  ADD PRIMARY KEY (`id_menu`);

--
-- Indexes for table `penjualan`
--
ALTER TABLE `penjualan`
  ADD PRIMARY KEY (`id_jual`),
  ADD KEY `FK_penjualan_kasir` (`id_kasir`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `penjualan`
--
ALTER TABLE `penjualan`
  ADD CONSTRAINT `FK_penjualan_kasir` FOREIGN KEY (`id_kasir`) REFERENCES `kasir` (`id_kasir`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
