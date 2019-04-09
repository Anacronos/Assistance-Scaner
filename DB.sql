-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost:3306
-- Tiempo de generación: 04-04-2019 a las 23:03:34
-- Versión del servidor: 5.6.41
-- Versión de PHP: 7.2.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `taola562_AyPS`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Asignatures`
--

CREATE TABLE `Asignatures` (
  `Id` int(11) NOT NULL,
  `Name` varchar(30) CHARACTER SET utf8 NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `Asignatures`
--

INSERT INTO `Asignatures` (`Id`, `Name`) VALUES
(1, 'AyPS');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `assistance`
--

CREATE TABLE `assistance` (
  `Id` int(11) NOT NULL,
  `Matricula` int(11) NOT NULL,
  `Alumno` varchar(150) NOT NULL,
  `Grupo` varchar(11) NOT NULL,
  `Asignatura` varchar(11) NOT NULL,
  `Llegada` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  `Salida` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `assistance`
--

INSERT INTO `assistance` (`Id`, `Matricula`, `Alumno`, `Grupo`, `Asignatura`, `Llegada`, `Salida`) VALUES
(12, 171245, 'Fabian Jheovanny Leon Espinosa', '7B', 'AyPS', '0000-00-00 00:00:00', '2019-03-18 00:01:36'),
(10, 171222, 'Jose Guadalupe Gonzalez Nunez', '7B', 'AyPS', '0000-00-00 00:00:00', '2019-03-17 23:59:55'),
(11, 171245, 'Fabian Jheovanny Leon Espinosa', '7B', 'AyPS', '0000-00-00 00:00:00', '2019-03-17 23:59:55'),
(13, 171245, 'Fabian Jheovanny Leon Espinosa', '7B', 'AyPS', '0000-00-00 00:00:00', '2019-03-18 00:02:36'),
(14, 171245, 'Fabian Jheovanny Leon Espinosa', '7B', 'AyPS', '2019-03-18 00:20:49', '2019-03-18 00:21:43'),
(15, 171245, 'Fabian Jheovanny Leon Espinosa', '7B', 'AyPS', '2019-03-18 00:20:49', '2019-03-18 00:22:43'),
(16, 171245, 'Fabian Jheovanny Leon Espinosa', '7B', 'AyPS', '2019-03-18 00:20:49', '2019-03-18 00:23:43');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `Asignatures`
--
ALTER TABLE `Asignatures`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `Name` (`Name`);

--
-- Indices de la tabla `assistance`
--
ALTER TABLE `assistance`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `Asignatures`
--
ALTER TABLE `Asignatures`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `assistance`
--
ALTER TABLE `assistance`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
