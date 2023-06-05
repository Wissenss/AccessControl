-- lmerino
-- inicializa el esquema de la base de datos

-- -----------------------------------------------------
-- Table `Puerta`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Puerta` (
  `idPuerta` INT NOT NULL,
  `Descripcion` VARCHAR(255) NULL,
  `Ubicacion` VARCHAR(45) NULL,
  `Observaciones` VARCHAR(255) NULL,
  PRIMARY KEY (`idPuerta`),
  UNIQUE INDEX `idPuerta_UNIQUE` (`idPuerta` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `GrupoPuerta`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `GrupoPuerta` (
  `idGrupoPuerta` INT NOT NULL,
  `Nombre` VARCHAR(45) NOT NULL,
  `Descripcion` VARCHAR(255) NULL,
  `Puerta_idPuerta` INT NOT NULL,
  PRIMARY KEY (`idGrupoPuerta`),
  UNIQUE INDEX `idGrupoPuerta_UNIQUE` (`idGrupoPuerta` ASC) VISIBLE,
  INDEX `fk_GrupoPuerta_Puerta1_idx` (`Puerta_idPuerta` ASC) VISIBLE,
  CONSTRAINT `fk_GrupoPuerta_Puerta1`
    FOREIGN KEY (`Puerta_idPuerta`)
    REFERENCES `Puerta` (`idPuerta`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `GrupoPersona`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `GrupoPersona` (
  `idGrupoPersona` INT NOT NULL,
  `Nombre` VARCHAR(45) NULL,
  `Descripcion` VARCHAR(255) NULL,
  PRIMARY KEY (`idGrupoPersona`),
  UNIQUE INDEX `idGrupoPersona_UNIQUE` (`idGrupoPersona` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Periodo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Periodo` (
  `idPeriodo` INT NOT NULL,
  `Descripcion` VARCHAR(255) NULL,
  `Ano` INT NULL,
  PRIMARY KEY (`idPeriodo`),
  UNIQUE INDEX `idPeriodo_UNIQUE` (`idPeriodo` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `AccesosSemana`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `AccesosSemana` (
  `idAccesosSemana` INT NOT NULL,
  `DiaSemana` VARCHAR(45) NOT NULL,
  `HoraInciol` DATETIME NULL,
  `HoraFin` DATETIME NOT NULL,
  `GrupoPuerta_idGrupoPuerta` INT NOT NULL,
  `GrupoPersona_idGrupoPersona` INT NOT NULL,
  `Periodo_idPeriodo` INT NOT NULL,
  PRIMARY KEY (`idAccesosSemana`),
  UNIQUE INDEX `idAccesosSemana_UNIQUE` (`idAccesosSemana` ASC) VISIBLE,
  INDEX `fk_AccesosSemana_GrupoPuerta1_idx` (`GrupoPuerta_idGrupoPuerta` ASC) VISIBLE,
  INDEX `fk_AccesosSemana_GrupoPersona1_idx` (`GrupoPersona_idGrupoPersona` ASC) VISIBLE,
  INDEX `fk_AccesosSemana_Periodo1_idx` (`Periodo_idPeriodo` ASC) VISIBLE,
  CONSTRAINT `fk_AccesosSemana_GrupoPuerta1`
    FOREIGN KEY (`GrupoPuerta_idGrupoPuerta`)
    REFERENCES `GrupoPuerta` (`idGrupoPuerta`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_AccesosSemana_GrupoPersona1`
    FOREIGN KEY (`GrupoPersona_idGrupoPersona`)
    REFERENCES `GrupoPersona` (`idGrupoPersona`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_AccesosSemana_Periodo1`
    FOREIGN KEY (`Periodo_idPeriodo`)
    REFERENCES `Periodo` (`idPeriodo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SemanaTipo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SemanaTipo` (
  `idSemanaTipo` INT NOT NULL,
  `Descripcion` VARCHAR(255) NULL,
  `DiaSemana` VARCHAR(45) NULL,
  `HoraInicio` DATETIME NULL,
  `HoraFin` DATETIME NULL,
  `GrupoPuerta_idGrupoPuerta` INT NOT NULL,
  `GrupoPersona_idGrupoPersona` INT NOT NULL,
  PRIMARY KEY (`idSemanaTipo`),
  UNIQUE INDEX `idSemanaTipo_UNIQUE` (`idSemanaTipo` ASC) VISIBLE,
  INDEX `fk_SemanaTipo_GrupoPuerta1_idx` (`GrupoPuerta_idGrupoPuerta` ASC) VISIBLE,
  INDEX `fk_SemanaTipo_GrupoPersona1_idx` (`GrupoPersona_idGrupoPersona` ASC) VISIBLE,
  CONSTRAINT `fk_SemanaTipo_GrupoPuerta1`
    FOREIGN KEY (`GrupoPuerta_idGrupoPuerta`)
    REFERENCES `GrupoPuerta` (`idGrupoPuerta`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_SemanaTipo_GrupoPersona1`
    FOREIGN KEY (`GrupoPersona_idGrupoPersona`)
    REFERENCES `GrupoPersona` (`idGrupoPersona`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Persona`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Persona` (
  `idPersona` INT NOT NULL,
  `Nombres` VARCHAR(255) NULL,
  `Apellidos` VARCHAR(255) NULL,
  `Celular` VARCHAR(20) NULL,
  `Correo` VARCHAR(45) NULL,
  PRIMARY KEY (`idPersona`),
  UNIQUE INDEX `idPersona_UNIQUE` (`idPersona` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DetalleGrupPersona`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DetalleGrupPersona` (
  `idDetalleGrupPersona` INT NOT NULL,
  `Persona_idPersona` INT NOT NULL,
  `GrupoPersona_idGrupoPersona` INT NOT NULL,
  PRIMARY KEY (`idDetalleGrupPersona`),
  INDEX `fk_DetalleGrupPersona_Persona1_idx` (`Persona_idPersona` ASC) VISIBLE,
  INDEX `fk_DetalleGrupPersona_GrupoPersona1_idx` (`GrupoPersona_idGrupoPersona` ASC) VISIBLE,
  CONSTRAINT `fk_DetalleGrupPersona_Persona1`
    FOREIGN KEY (`Persona_idPersona`)
    REFERENCES `Persona` (`idPersona`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_DetalleGrupPersona_GrupoPersona1`
    FOREIGN KEY (`GrupoPersona_idGrupoPersona`)
    REFERENCES `GrupoPersona` (`idGrupoPersona`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;