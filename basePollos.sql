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
  `nombreCliente` VARCHAR(200) NOT NULL,
  `telefonoCliente` VARCHAR(50) NOT NULL,
  `direccionCliente` VARCHAR(200) NULL DEFAULT NULL,
  `entreCallesCliente` VARCHAR(200) NULL DEFAULT NULL,
  `coloniaCliente` VARCHAR(200) NULL DEFAULT NULL,
  `estatusCliente` VARCHAR(45) NOT NULL DEFAULT 'ACTIVO',
  PRIMARY KEY (`idclientes`))
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `pollos`.`pedidos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pollos`.`pedidos` (
  `idpedidos` INT(11) NOT NULL AUTO_INCREMENT,
  `idcliente` INT(11) NULL DEFAULT NULL,
  `fechapedido` DATETIME NOT NULL,
  `comentarios` VARCHAR(200) NULL DEFAULT NULL,
  `totalPedido` DECIMAL(10,0) NULL DEFAULT NULL,
  PRIMARY KEY (`idpedidos`),
  INDEX `idcliente_idx` (`idcliente` ASC),
  CONSTRAINT `idcliente`
    FOREIGN KEY (`idcliente`)
    REFERENCES `pollos`.`clientes` (`idclientes`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
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
AUTO_INCREMENT = 18
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `pollos`.`detallepedido`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pollos`.`detallepedido` (
  `cantidad` DECIMAL(10,0) NULL DEFAULT NULL,
  `precio` DECIMAL(10,0) NULL DEFAULT NULL,
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
AUTO_INCREMENT = 4
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `pollos`.`ventas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pollos`.`ventas` (
  `idventa` INT(11) NOT NULL AUTO_INCREMENT,
  `idusuario` INT(11) NULL DEFAULT NULL,
  `total` FLOAT NULL DEFAULT NULL,
  `estatus` VARCHAR(45) NULL DEFAULT 'ACTIVA',
  `fecha` DATETIME NULL DEFAULT NULL,
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


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

