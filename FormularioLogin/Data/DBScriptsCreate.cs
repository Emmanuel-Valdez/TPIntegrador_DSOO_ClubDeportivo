using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioLogin.Data
{
	public class DBScriptsCreate
	{

		public static string CreateDatabase => @"
		
		-- Schema club
		-- -----------------------------------------------------
		CREATE SCHEMA IF NOT EXISTS `club` DEFAULT CHARACTER SET utf8 ;
		USE `club` ;
		SET FOREIGN_KEY_CHECKS = 0;
		";

		public static string CreateTables => @"

		USE club;

		DROP TABLE IF EXISTS `club`.`cuota`;
		DROP TABLE IF EXISTS `club`.`inscripcion`;
		DROP TABLE IF EXISTS `club`.`actividad`;
		DROP TABLE IF EXISTS `club`.`profesor`;
		DROP TABLE IF EXISTS `club`.`noSocio`;
		DROP TABLE IF EXISTS `club`.`socio`;
		DROP TABLE IF EXISTS `club`.`usuario`;
		DROP TABLE IF EXISTS `club`.`rol`;

		-- -----------------------------------------------------
		-- Table `club`.`rol`
		-- -----------------------------------------------------
		CREATE TABLE IF NOT EXISTS `club`.`rol` (
		  `id` INT NOT NULL AUTO_INCREMENT,
		  `name` VARCHAR(255) NOT NULL,
		  PRIMARY KEY (`id`)
		) ENGINE = InnoDB;

		-- -----------------------------------------------------
		-- Table `club`.`usuario`
		-- -----------------------------------------------------
		CREATE TABLE IF NOT EXISTS `club`.`usuario` (
		  `id` INT NOT NULL AUTO_INCREMENT,
		  `nombre` VARCHAR(45) NOT NULL,
		  `email` VARCHAR(45) NOT NULL,
		  `contrasenia` NVARCHAR(250) NOT NULL,
		  `rol_id` INT NOT NULL DEFAULT 1,
		  `create_time` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
		  `activo` TINYINT NOT NULL DEFAULT 1,
		  PRIMARY KEY (`id`),
		  UNIQUE INDEX `id_UNIQUE` (`id` ASC) VISIBLE,
		  UNIQUE INDEX `email_UNIQUE` (`email` ASC) VISIBLE,
		  INDEX `fk_rol_idx` (`rol_id` ASC) VISIBLE,
		  CONSTRAINT `fk_rol`
			FOREIGN KEY (`rol_id`)
			REFERENCES `club`.`rol` (`id`)
			ON DELETE NO ACTION
			ON UPDATE NO ACTION
		) ENGINE = InnoDB;

		-- -----------------------------------------------------
		-- Table `club`.`socio`
		-- -----------------------------------------------------
		CREATE TABLE IF NOT EXISTS `club`.`socio` (
		  `id` INT NOT NULL AUTO_INCREMENT,
		  `nombre` VARCHAR(45) NOT NULL,
		  `apellido` VARCHAR(45) NOT NULL,
		  `dni` VARCHAR(11) NOT NULL,
		  `fecha_nac` DATE NOT NULL,
		  `email` VARCHAR(100) NOT NULL,
		  `fecha_emision` DATE NOT NULL,
		  `estado` TINYINT NOT NULL DEFAULT 1,
		  `create_time` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
		  `carnet` TINYINT NOT NULL DEFAULT 1,
		  PRIMARY KEY (`id`),
		  UNIQUE INDEX `dni_UNIQUE` (`dni` ASC)
		) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

		-- -----------------------------------------------------
		-- Table `club`.`noSocio`
		-- -----------------------------------------------------
		CREATE TABLE IF NOT EXISTS `club`.`noSocio` (
		  `id` INT NOT NULL AUTO_INCREMENT,
		  `nombre` VARCHAR(45) NOT NULL,
		  `apellido` VARCHAR(45) NOT NULL,
		  `dni` VARCHAR(11) NOT NULL,
		  `fecha_nac` DATE NOT NULL,
		  `email` VARCHAR(100) NOT NULL,
		  `create_time` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
		  PRIMARY KEY (`id`),
		  UNIQUE INDEX `dni_UNIQUE` (`dni` ASC) VISIBLE
		) ENGINE = InnoDB;

		-- -----------------------------------------------------
		-- Table `club`.`profesor`
		-- -----------------------------------------------------
		CREATE TABLE IF NOT EXISTS `club`.`profesor` (
		  `id` INT NOT NULL AUTO_INCREMENT,  
		  `especialidad` VARCHAR(45) NULL,
		  `asistencia` VARCHAR(45) NULL,
		  `sueldo_mensual` DECIMAL(10,2) NULL, 
		  `fecha_ingreso` DATE NULL,
		  `salon_asignado` VARCHAR(45) NULL,
		  PRIMARY KEY (`id`)
		) ENGINE = InnoDB;

		-- -----------------------------------------------------
		-- Table `club`.`actividad`
		-- -----------------------------------------------------
		CREATE TABLE IF NOT EXISTS `club`.`actividad` (
		  `id` INT NOT NULL AUTO_INCREMENT, 
		  `nombre_actividad` VARCHAR(45) NOT NULL,  
		  `tipo` VARCHAR(45) NULL,
		  `horario` INT NOT NULL,
		  `profesor_id` INT NULL,
		  `cupo_max` INT NOT NULL,
		  PRIMARY KEY (`id`),
		  INDEX `profesor_id_idx` (`profesor_id` ASC) VISIBLE,
		  CONSTRAINT `fk_actividad_profesor`
			FOREIGN KEY (`profesor_id`)
			REFERENCES `club`.`profesor` (`id`)
			ON DELETE NO ACTION
			ON UPDATE NO ACTION
		) ENGINE = InnoDB;

		-- -----------------------------------------------------
		-- Table `club`.`cuota`
		-- -----------------------------------------------------
		CREATE TABLE `cuota` (
				`id` int NOT NULL AUTO_INCREMENT,
				`socio_id` int DEFAULT NULL,
				`monto` decimal(10,2) NOT NULL,
				`fecha_emision` date NOT NULL,
				`fecha_vencimiento` date DEFAULT NULL,
				`nombre` varchar(45) DEFAULT NULL,
				`apellido` varchar(45) DEFAULT NULL,
				`estado` tinyint DEFAULT '0',
				`no_socio_id` int DEFAULT NULL,
				`es_socio` tinyint NOT NULL DEFAULT '0',
				PRIMARY KEY (`id`),
				KEY `fk_socio_id_idx` (`socio_id`),
				KEY `fk_no_socio_id_idx` (`no_socio_id`),
				CONSTRAINT `fk_no_socio_id` FOREIGN KEY (`no_socio_id`) REFERENCES `noSocio` (`id`),
				CONSTRAINT `fk_socio_id` FOREIGN KEY (`socio_id`) REFERENCES `socio` (`id`)
			) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;


		-- -----------------------------------------------------
		-- Table `club`.`inscripcion`
		-- -----------------------------------------------------
		CREATE TABLE IF NOT EXISTS `club`.`inscripcion` (
		  `id` INT NOT NULL AUTO_INCREMENT,  
		  `socio_id` INT NULL,
		  `no_socio_id` INT NULL,
		  `actividad_id` INT NOT NULL,  
		  `fecha_inscripcion` DATE NOT NULL,  
		  `estado` TINYINT NULL DEFAULT 1,
		 
		  PRIMARY KEY (`id`),
		  INDEX `fk_inscripcion_socio_idx` (`socio_id` ASC) VISIBLE,
		  INDEX `fk_inscripcion_nosocio_idx` (`no_socio_id` ASC) VISIBLE,
		  INDEX `fk_inscripcion_actividad_idx` (`actividad_id` ASC) VISIBLE,
		  CONSTRAINT `fk_inscripcion_socio`  
			FOREIGN KEY (`socio_id`)
			REFERENCES `club`.`socio` (`id`)
			ON DELETE NO ACTION
			ON UPDATE NO ACTION,
		  CONSTRAINT `fk_inscripcion_nosocio`
			FOREIGN KEY (`no_socio_id`)
			REFERENCES `club`.`noSocio` (`id`)
			ON DELETE NO ACTION
			ON UPDATE NO ACTION,
		  CONSTRAINT `fk_inscripcion_actividad`
			FOREIGN KEY (`actividad_id`)
			REFERENCES `club`.`actividad` (`id`)
			ON DELETE NO ACTION
			ON UPDATE NO ACTION,
		  CONSTRAINT `chk_inscripcion_participante` 
			CHECK ((socio_id IS NOT NULL AND no_socio_id IS NULL) OR 
				   (socio_id IS NULL AND no_socio_id IS NOT NULL))
		) ENGINE = InnoDB;

		SET FOREIGN_KEY_CHECKS = 1;";


		//en estos scripts van los datos iniciales para la BBDD
		public static string InsertInitialData => @"
		USE club;
		
		INSERT INTO Rol (name) VALUES ('Admin');

		INSERT INTO Usuario (Nombre, Email, contrasenia) VALUES 
		('admin', 'admin@sistema.com','admin')
		;
		";



	}

}
