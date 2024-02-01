-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 01-02-2024 a las 21:31:03
-- Versión del servidor: 10.4.28-MariaDB
-- Versión de PHP: 8.0.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `prueba`
-- --
-- CREATE DATABASE `prueba`;

-- USE DATABASE `prueba`;
-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cargos`
--

CREATE TABLE `cargos` (
  `id_cg` int(11) NOT NULL,
  `codigo_cg` varchar(255) NOT NULL,
  `nombre_cg` varchar(255) NOT NULL,
  `activo` tinyint(1) NOT NULL,
  `idUsuarioCreacion_cg` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `cargos`
--

INSERT INTO `cargos` (`id_cg`, `codigo_cg`, `nombre_cg`, `activo`, `idUsuarioCreacion_cg`) VALUES
(1, '2V5RA8', 'Administrador', 1, 1),
(2, 'A8A2F52S', 'Desarrollador Front End', 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `departamentos`
--

CREATE TABLE `departamentos` (
  `id_dep` int(11) NOT NULL,
  `codigo_dep` varchar(255) NOT NULL,
  `nombre_dep` varchar(255) NOT NULL,
  `activo_dep` tinyint(1) NOT NULL,
  `idUsuarioCreacion_dep` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `departamentos`
--

INSERT INTO `departamentos` (`id_dep`, `codigo_dep`, `nombre_dep`, `activo_dep`, `idUsuarioCreacion_dep`) VALUES
(1, 'A1B2C3', 'Tecnologias de la información', 1, 1),
(2, '1a58s2a', 'Seguridad', 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `users`
--

CREATE TABLE `users` (
  `usuario_us` varchar(255) NOT NULL,
  `primerNombre_us` varchar(255) NOT NULL,
  `segundoNombre_us` varchar(255) NOT NULL,
  `primerApellido_us` varchar(255) NOT NULL,
  `segundoApellido_us` varchar(255) NOT NULL,
  `idDepartamento_us` int(11) NOT NULL,
  `idCargo_us` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `users`
--

INSERT INTO `users` (`usuario_us`, `primerNombre_us`, `segundoNombre_us`, `primerApellido_us`, `segundoApellido_us`, `idDepartamento_us`, `idCargo_us`) VALUES
('pumamusic', 'Bryan', 'Santiago', 'Puma', 'Criollo', 1, 1),
('ppicapiedra', 'Pedro', 'Pablo', 'Picapiedra', 'Marmol', 1, 1);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cargos`
--
ALTER TABLE `cargos`
  ADD PRIMARY KEY (`id_cg`);

--
-- Indices de la tabla `departamentos`
--
ALTER TABLE `departamentos`
  ADD PRIMARY KEY (`id_dep`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `cargos`
--
ALTER TABLE `cargos`
  MODIFY `id_cg` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `departamentos`
--
ALTER TABLE `departamentos`
  MODIFY `id_dep` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
