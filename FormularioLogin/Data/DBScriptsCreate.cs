
namespace FormularioLogin.Data
{
	public class DBScriptsCreate
	{

		public static string CreateDatabase => @"
		
		-- Schema u462690221_club
		-- -----------------------------------------------------
		CREATE SCHEMA IF NOT EXISTS `u462690221_club` DEFAULT CHARACTER SET utf8 ;
		USE `u462690221_club` ;
		SET FOREIGN_KEY_CHECKS = 0;
		";

		public static string CreateTables => @"

		USE u462690221_club;

		DROP TABLE IF EXISTS `u462690221_club`.`cuota`;
		DROP TABLE IF EXISTS `u462690221_club`.`inscripcion`;
		DROP TABLE IF EXISTS `u462690221_club`.`actividad`;
		DROP TABLE IF EXISTS `u462690221_club`.`profesor`;
		DROP TABLE IF EXISTS `u462690221_club`.`noSocio`;
		DROP TABLE IF EXISTS `u462690221_club`.`socio`;
		DROP TABLE IF EXISTS `u462690221_club`.`usuario`;
		DROP TABLE IF EXISTS `u462690221_club`.`rol`;

		-- -----------------------------------------------------
		-- Table `u462690221_club`.`rol`
		-- -----------------------------------------------------
		CREATE TABLE IF NOT EXISTS `u462690221_club`.`rol` (
		  `id` INT NOT NULL AUTO_INCREMENT,
		  `name` VARCHAR(255) NOT NULL,
		  PRIMARY KEY (`id`)
		) ENGINE = InnoDB;

		-- -----------------------------------------------------
		-- Table `u462690221_club`.`usuario`
		-- -----------------------------------------------------
		CREATE TABLE IF NOT EXISTS `u462690221_club`.`usuario` (
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
			REFERENCES `u462690221_club`.`rol` (`id`)
			ON DELETE NO ACTION
			ON UPDATE NO ACTION
		) ENGINE = InnoDB;

		-- -----------------------------------------------------
		-- Table `u462690221_club`.`socio`
		-- -----------------------------------------------------
		CREATE TABLE IF NOT EXISTS `u462690221_club`.`socio` (
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
		-- Table `u462690221_club`.`noSocio`
		-- -----------------------------------------------------
		CREATE TABLE IF NOT EXISTS `u462690221_club`.`noSocio` (
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
		-- Table `u462690221_club`.`profesor`
		-- -----------------------------------------------------
		CREATE TABLE IF NOT EXISTS `u462690221_club`.`profesor` (
		  `id` INT NOT NULL AUTO_INCREMENT,  
		  `especialidad` VARCHAR(45) NULL,
		  `asistencia` VARCHAR(45) NULL,
		  `sueldo_mensual` DECIMAL(10,2) NULL, 
		  `fecha_ingreso` DATE NULL,
		  `salon_asignado` VARCHAR(45) NULL,
		  PRIMARY KEY (`id`)
		) ENGINE = InnoDB;

		-- -----------------------------------------------------
		-- Table `u462690221_club`.`actividad`
		-- -----------------------------------------------------
		CREATE TABLE IF NOT EXISTS `u462690221_club`.`actividad` (
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
			REFERENCES `u462690221_club`.`profesor` (`id`)
			ON DELETE NO ACTION
			ON UPDATE NO ACTION
		) ENGINE = InnoDB;

		-- -----------------------------------------------------
		-- Table `u462690221_club`.`cuota`
		-- -----------------------------------------------------
		CREATE TABLE IF NOT EXISTS `u462690221_club`.`cuota` (
		  `id` INT NOT NULL AUTO_INCREMENT,  
		  `socio_id` INT NOT NULL,  
		  `monto` DECIMAL(10,2) NOT NULL,  
		  `fecha_emision` DATE NOT NULL,
		  `fecha_vencimiento` DATE NULL,
		  `nombre` VARCHAR(45) NULL,
		  `apellido` VARCHAR(45) NULL,
		  `estado` TINYINT NULL DEFAULT 0,
		  PRIMARY KEY (`id`),
		  INDEX `fk_cuota_socio_idx` (`socio_id` ASC) VISIBLE,
		  CONSTRAINT `fk_cuota_socio`  
			FOREIGN KEY (`socio_id`)
			REFERENCES `u462690221_club`.`socio` (`id`)
			ON DELETE NO ACTION
			ON UPDATE NO ACTION
		) ENGINE = InnoDB;

		-- -----------------------------------------------------
		-- Table `u462690221_club`.`inscripcion`
		-- -----------------------------------------------------
		CREATE TABLE IF NOT EXISTS `u462690221_club`.`inscripcion` (
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
			REFERENCES `u462690221_club`.`socio` (`id`)
			ON DELETE NO ACTION
			ON UPDATE NO ACTION,
		  CONSTRAINT `fk_inscripcion_nosocio`
			FOREIGN KEY (`no_socio_id`)
			REFERENCES `u462690221_club`.`noSocio` (`id`)
			ON DELETE NO ACTION
			ON UPDATE NO ACTION,
		  CONSTRAINT `fk_inscripcion_actividad`
			FOREIGN KEY (`actividad_id`)
			REFERENCES `u462690221_club`.`actividad` (`id`)
			ON DELETE NO ACTION
			ON UPDATE NO ACTION,
		  CONSTRAINT `chk_inscripcion_participante` 
			CHECK ((socio_id IS NOT NULL AND no_socio_id IS NULL) OR 
				   (socio_id IS NULL AND no_socio_id IS NOT NULL))
		) ENGINE = InnoDB;

		SET FOREIGN_KEY_CHECKS = 1;";


		//en estos scripts van los datos iniciales para la BBDD
		
		public static string InsertInitialData => @"
		INSERT INTO u462690221_club.rol(name) VALUES('Admin');

		INSERT INTO u462690221_club.usuario(Nombre, Email, contrasenia) VALUES
		('admin', 'admin@sistema.com','admin');
		";



	}

}
