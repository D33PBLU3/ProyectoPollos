-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema pollos
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema pollos
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `pollos` DEFAULT CHARACTER SET utf8 ;
USE `pollos` ;

-- -----------------------------------------------------
-- Table `pollos`.`clientes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pollos`.`clientes` (
  `idclientes` INT(11) NOT NULL AUTO_INCREMENT,
  `nombreCliente` VARCHAR(200) NOT NULL DEFAULT ' ',
  `telefonoCliente` VARCHAR(50) NOT NULL DEFAULT ' ',
  `direccionCliente` VARCHAR(200) NOT NULL DEFAULT ' ',
  `entreCallesCliente` VARCHAR(200) NOT NULL DEFAULT ' ',
  `coloniaCliente` VARCHAR(200) NOT NULL DEFAULT ' ',
  `estatusCliente` VARCHAR(45) NOT NULL DEFAULT 'ACTIVO',
  PRIMARY KEY (`idclientes`))
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `pollos`.`pedidos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pollos`.`pedidos` (
  `idpedidos` INT(11) NOT NULL AUTO_INCREMENT,
  `idcliente` INT(11) NULL DEFAULT NULL,
  `fechapedido` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `comentarios` VARCHAR(200) NULL DEFAULT NULL,
  `totalPedido` DECIMAL(10,2) NULL DEFAULT NULL,
  PRIMARY KEY (`idpedidos`),
  INDEX `idcliente_idx` (`idcliente` ASC),
  CONSTRAINT `idcliente`
    FOREIGN KEY (`idcliente`)
    REFERENCES `pollos`.`clientes` (`idclientes`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `pollos`.`productos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pollos`.`productos` (
  `idproductos` INT(11) NOT NULL AUTO_INCREMENT,
  `tipoproducto` VARCHAR(100) NOT NULL,
  `nombreproducto` VARCHAR(100) NULL DEFAULT NULL,
  `precioproducto` DECIMAL(10,2) NULL DEFAULT NULL,
  `estatusProducto` VARCHAR(45) NULL DEFAULT 'ACTIVO',
  PRIMARY KEY (`idproductos`),
  UNIQUE INDEX `idproductos_UNIQUE` (`idproductos` ASC))
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `pollos`.`detallepedido`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pollos`.`detallepedido` (
  `cantidad` DECIMAL(10,2) NULL DEFAULT NULL,
  `precio` DECIMAL(10,2) NULL DEFAULT NULL,
  `idpedido` INT(11) NULL DEFAULT NULL,
  `idproducto` INT(11) NULL DEFAULT NULL,
  INDEX `idpedido_idx` (`idpedido` ASC),
  INDEX `idproducto_idx` (`idproducto` ASC),
  CONSTRAINT `idpedido_detalle`
    FOREIGN KEY (`idpedido`)
    REFERENCES `pollos`.`pedidos` (`idpedidos`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `idproducto_detalle`
    FOREIGN KEY (`idproducto`)
    REFERENCES `pollos`.`productos` (`idproductos`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `pollos`.`usuarios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pollos`.`usuarios` (
  `idUsuario` INT(11) NOT NULL AUTO_INCREMENT,
  `nickName` VARCHAR(100) NOT NULL,
  `password` VARCHAR(200) NULL DEFAULT '',
  `tipoPermiso` VARCHAR(100) NOT NULL DEFAULT 'NINGUNO',
  `estatusUsuario` VARCHAR(45) NULL DEFAULT 'ACTIVO',
  PRIMARY KEY (`idUsuario`),
  UNIQUE INDEX `idUsuario_UNIQUE` (`idUsuario` ASC),
  UNIQUE INDEX `nickName_UNIQUE` (`nickName` ASC))
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `pollos`.`ventas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pollos`.`ventas` (
  `idventa` INT(11) NOT NULL AUTO_INCREMENT,
  `idusuario` INT(11) NULL DEFAULT NULL,
  `total` DECIMAL(10,2) NULL DEFAULT NULL,
  `estatus` VARCHAR(45) NULL DEFAULT 'ACTIVA',
  `fecha` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `comentarios` VARCHAR(200) NULL DEFAULT NULL,
  PRIMARY KEY (`idventa`),
  INDEX `idusuario_venta_idx` (`idusuario` ASC),
  CONSTRAINT `idusuario_venta`
    FOREIGN KEY (`idusuario`)
    REFERENCES `pollos`.`usuarios` (`idUsuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `pollos`.`detalleventa`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pollos`.`detalleventa` (
  `idventa` INT(11) NULL DEFAULT NULL,
  `idproducto` INT(11) NULL DEFAULT NULL,
  `cantidad` FLOAT NULL DEFAULT NULL,
  `precio` FLOAT NULL DEFAULT NULL,
  INDEX `idventa_detalle_idx` (`idventa` ASC),
  INDEX `idproducto_detalle_venta_idx` (`idproducto` ASC),
  CONSTRAINT `idproducto_detalle_venta`
    FOREIGN KEY (`idproducto`)
    REFERENCES `pollos`.`productos` (`idproductos`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `idventa_detalle`
    FOREIGN KEY (`idventa`)
    REFERENCES `pollos`.`ventas` (`idventa`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `pollos`.`subproductos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pollos`.`subproductos` (
  `idProductos` INT(11) NOT NULL,
  `idSubProducto` INT(11) NOT NULL,
  `cantidad` DECIMAL(10,0) NULL DEFAULT NULL,
  INDEX `idSubProducto_idx` (`idSubProducto` ASC),
  INDEX `idProducto_idx` (`idProductos` ASC),
  CONSTRAINT `idProducto`
    FOREIGN KEY (`idProductos`)
    REFERENCES `pollos`.`productos` (`idproductos`)
    ON DELETE CASCADE
    ON UPDATE NO ACTION,
  CONSTRAINT `idSubProducto`
    FOREIGN KEY (`idSubProducto`)
    REFERENCES `pollos`.`productos` (`idproductos`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;
INSERT INTO `pollos`.`usuarios` (`nickName`, `password`, `tipoPermiso`, `estatusUsuario`) VALUES ('root', '', '', 'ACTIVO');


INSERT INTO `productos` VALUES (1, 'NORMAL', 'pollo', 99.00, 'ACTIVO');
INSERT INTO `productos` VALUES (2, 'NORMAL', 'tacos', 1.00, 'ACTIVO');
INSERT INTO `productos` VALUES (3, 'NORMAL', 'col', 15.00, 'ACTIVO');
INSERT INTO `productos` VALUES (4, 'NORMAL', 'codito', 15.00, 'ACTIVO');
INSERT INTO `productos` VALUES (5, 'NORMAL', 'pure', 15.00, 'ACTIVO');
INSERT INTO `productos` VALUES (6, 'NORMAL', 'verduras', 15.00, 'ACTIVO');
INSERT INTO `productos` VALUES (7, 'NORMAL', 'cuernitos', 20.00, 'ACTIVO');
INSERT INTO `productos` VALUES (8, 'NORMAL', 'p_familiar', 159.00, 'ACTIVO');
INSERT INTO `productos` VALUES (9, 'NORMAL', 'p_individual', 45.00, 'ACTIVO');
INSERT INTO `productos` VALUES (10, 'NORMAL', 'cocag', 18.00, 'ACTIVO');
INSERT INTO `productos` VALUES (11, 'NORMAL', 'agua', 18.00, 'ACTIVO');
INSERT INTO `productos` VALUES (12, 'NORMAL', 'refresco gde', 0.00, 'ACTIVO');
INSERT INTO `productos` VALUES (13, 'NORMAL', 'refresco chico', 10.00, 'ACTIVO');
INSERT INTO `productos` VALUES (14, 'NORMAL', 'medio_pollo', 50.00, 'ACTIVO');
INSERT INTO `productos` VALUES (15, 'NORMAL', 'cuarto_pollo', 30.00, 'ACTIVO');
INSERT INTO `productos` VALUES (16, 'NORMAL', 'tortillas', 15.00, 'ACTIVO');
INSERT INTO `productos` VALUES (17, 'NORMAL', 'medio_tortillas', 8.00, 'ACTIVO');
INSERT INTO `productos` VALUES (18, 'NORMAL', 'papas', 4.00, 'ACTIVO');
INSERT INTO `productos` VALUES (19, 'NORMAL', 'tortilla_extra', 4.00, 'ACTIVO');
INSERT INTO `productos` VALUES (20, 'NORMAL', 'cupon', -15.00, 'ACTIVO');
INSERT INTO `productos` VALUES (21, 'NORMAL', 'p_familiar_st', 244.00, 'ACTIVO');
INSERT INTO `productos` VALUES (22, 'NORMAL', 'p1', 0.00, 'ACTIVO');
INSERT INTO `productos` VALUES (23, 'NORMAL', 'p2', 0.00, 'ACTIVO');
INSERT INTO `productos` VALUES (24, 'NORMAL', 'p3', 0.00, 'ACTIVO');
INSERT INTO `productos` VALUES (25, 'NORMAL', 'p4', 0.00, 'ACTIVO');
INSERT INTO `productos` VALUES (26, 'NORMAL', 'paq_pure', 0.00, 'ACTIVO');
INSERT INTO `productos` VALUES (27, 'NORMAL', 'paq_verduras', 0.00, 'ACTIVO');
INSERT INTO `productos` VALUES (28, 'NORMAL', 'paq_col', 0.00, 'ACTIVO');
INSERT INTO `productos` VALUES (29, 'NORMAL', 'paq_codito', 0.00, 'ACTIVO');
INSERT INTO `productos` VALUES (30, 'NORMAL', 'salsa', 0.00, 'ACTIVO');
INSERT INTO `productos` VALUES (31, 'NORMAL', 'Pollo oferta', 0.00, 'ACTIVO');
INSERT INTO `productos` VALUES (32, 'NORMAL', 'Paq_fam_serv_dom', 0.00, 'ACTIVO');
INSERT INTO `productos` VALUES (33, 'NORMAL', 'Pollo_cons_int', 0.00, 'ACTIVO');
INSERT INTO `productos` VALUES (34, 'NORMAL', 'tacos_cort', 0.00, 'ACTIVO');
INSERT INTO `productos` VALUES (35, 'NORMAL', 'ensaladas_cons_int', 0.00, 'ACTIVO');
INSERT INTO `productos` VALUES (36, 'NORMAL', 'ensaladas_cort', 0.00, 'ACTIVO');
INSERT INTO `productos` VALUES (37, 'NORMAL', 'salsa_ext', 0.00, 'ACTIVO');
INSERT INTO `productos` VALUES (38, 'NORMAL', 'tortillas_ext', 0.00, 'ACTIVO');
INSERT INTO `productos` VALUES (39, 'NORMAL', 'Pollo domicilio', 0.00, 'ACTIVO');
INSERT INTO `productos` VALUES (40, 'NORMAL', 'medio_pollo_dom', 0.00, 'ACTIVO');
INSERT INTO `productos` VALUES (41, 'NORMAL', 'Pollo cortesia',0.00, 'ACTIVO');
INSERT INTO `productos` VALUES (42, 'NORMAL', 'p_fam_st_dom',0.00, 'ACTIVO');

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
