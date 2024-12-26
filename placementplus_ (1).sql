-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 26, 2024 at 05:35 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `placementplus_`
--

-- --------------------------------------------------------

--
-- Table structure for table `jobs`
--

CREATE TABLE `jobs` (
  `Id` int(11) NOT NULL,
  `Company_Name` varchar(100) NOT NULL,
  `Company_URL` varchar(255) NOT NULL,
  `Job_Profile` varchar(100) NOT NULL,
  `CTC` varchar(100) NOT NULL,
  `Internship` varchar(100) NOT NULL,
  `Stipend` varchar(100) NOT NULL,
  `Job_Location` varchar(200) NOT NULL,
  `Batch` varchar(100) NOT NULL,
  `Course` varchar(100) NOT NULL,
  `Drive_Date` varchar(50) DEFAULT NULL,
  `Drive_Location` varchar(50) DEFAULT NULL,
  `Due_Date` varchar(50) DEFAULT NULL,
  `PersonName` varchar(50) DEFAULT NULL,
  `PersonNumber` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `jobs`
--

INSERT INTO `jobs` (`Id`, `Company_Name`, `Company_URL`, `Job_Profile`, `CTC`, `Internship`, `Stipend`, `Job_Location`, `Batch`, `Course`, `Drive_Date`, `Drive_Location`, `Due_Date`, `PersonName`, `PersonNumber`) VALUES
(3, 'Version', 'www.god.com', 'QA', '5 LPA', '6 Month', '12000 Per Month', 'Rajkot', '2024, 2025', 'MCA, BCA, MBA', '12 Dec, 2024', 'Rajkot, Main Road', '10 Dec, 2024', 'Haresh Paneri', '9999888877');

-- --------------------------------------------------------

--
-- Table structure for table `profile`
--

CREATE TABLE `profile` (
  `Id` int(11) NOT NULL,
  `User_Email` varchar(256) NOT NULL,
  `Collage_Name` varchar(256) DEFAULT NULL,
  `Contact_Information` varchar(128) DEFAULT NULL,
  `Branches` varchar(128) DEFAULT NULL,
  `Address` varchar(512) DEFAULT NULL,
  `Reference` varchar(256) DEFAULT NULL,
  `Established` varchar(128) DEFAULT NULL,
  `Achievement` varchar(512) DEFAULT NULL,
  `Image` varchar(256) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `profile`
--

INSERT INTO `profile` (`Id`, `User_Email`, `Collage_Name`, `Contact_Information`, `Branches`, `Address`, `Reference`, `Established`, `Achievement`, `Image`) VALUES
(2, 'admin1@gmail.com', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Screenshot 2024-10-03 102002.png'),
(3, 'admin@gmail.com', 'RK University', '9558023237', 'MCA BCA', 'Rajkot', 'NAAC', '2011', 'Krishna Murti', 'Screenshot 2024-09-28 152308.png'),
(4, 'darahan95580@gmail.com', 'RK University', '95580', 'MCA 1st', 'Bhayavadar', 'NAAC, YYA', '2024', 'SSIP', 'Screenshot 2024-09-28 150931.png'),
(5, 'yash@gmail.com', 'Marvadi University', '597654', 'MCA, BCA', 'Rajkot', 'NAAC A+', '1900', 'CTR', 'Screenshot 2024-09-28 150915_20241128100424.png'),
(6, 'darshan@gmail.com', 'MArvadi University', '', '', '', '', '', '', 'Screenshot 2024-10-17 200953.png'),
(7, 'madam@gmail.com', 'RK University', '', '', '', '', '', '', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `students`
--

CREATE TABLE `students` (
  `Id` int(11) NOT NULL,
  `StudentName` varchar(100) NOT NULL,
  `DOB` varchar(50) NOT NULL,
  `Enrollment` varchar(50) DEFAULT NULL,
  `Course` varchar(100) DEFAULT NULL,
  `Batch` varchar(50) DEFAULT NULL,
  `Email` varchar(255) DEFAULT NULL,
  `Mobile` varchar(15) NOT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `Pincode` varchar(8) DEFAULT NULL,
  `LastMark` varchar(50) NOT NULL,
  `Skills` varchar(255) NOT NULL,
  `Experience` varchar(255) NOT NULL,
  `Resume` varchar(255) NOT NULL,
  `Registered` varchar(3) DEFAULT NULL,
  `Status` varchar(50) DEFAULT 'Active',
  `Modified_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `students`
--

INSERT INTO `students` (`Id`, `StudentName`, `DOB`, `Enrollment`, `Course`, `Batch`, `Email`, `Mobile`, `Address`, `Pincode`, `LastMark`, `Skills`, `Experience`, `Resume`, `Registered`, `Status`, `Modified_at`) VALUES
(2, 'Yash Surani', '1 July, 2002', '24SOECA21077', 'MCA', '2025', 'yash@gmail.com', '98475394857', 'Godhra', '485633', '6 CGPA', 'PHP, JAVA', '6 Month as Designer', 'cv_png', 'Yes', 'Active', '2024-11-28 04:33:26');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `Id` int(11) NOT NULL,
  `Usertype` varchar(50) NOT NULL,
  `Email` varchar(256) NOT NULL,
  `Password` varchar(256) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`Id`, `Usertype`, `Email`, `Password`) VALUES
(1, 'Admin', 'darahan95580@gmail.com', '123'),
(2, 'Admin', 'yash@gmail.com', '123'),
(3, 'Admin', 'darshan@gmail.com', '123'),
(4, 'Admin', 'madam@gmail.com', '1234');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `jobs`
--
ALTER TABLE `jobs`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `profile`
--
ALTER TABLE `profile`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `students`
--
ALTER TABLE `students`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `Enrollment` (`Enrollment`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `Email` (`Email`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `jobs`
--
ALTER TABLE `jobs`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `profile`
--
ALTER TABLE `profile`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `students`
--
ALTER TABLE `students`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
