-- Creator:       MySQL Workbench 6.3.6/ExportSQLite Plugin 0.1.0
-- Author:        vincent.erbrich
-- Caption:       New Model
-- Project:       Name of the project
-- Changed:       2018-03-13 14:06
-- Created:       2018-03-08 15:48
PRAGMA foreign_keys = OFF;

-- Schema: mydb
ATTACH "mydb.sdb" AS "mydb";
BEGIN;
CREATE TABLE "mydb"."Patient"(
  "PAT_ID" INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
  "PAT_Nom" VARCHAR(30) NOT NULL,
  "PAT_Prenom" VARCHAR(30) NOT NULL,
  "PAT_Date_Naissance" DATE NOT NULL,
  "PAT_Titre" VARCHAR(6),
  "PAT_Etat_Civil" VARCHAR(10),
  "PAT_Origine" VARCHAR(25),
  "PAT_Adresse" VARCHAR(45),
  "PAT_Ville" VARCHAR(25),
  "PAT_Code_Postal" VARCHAR(4),
  "PAT_Canton" VARCHAR(20),
  "PAT_Telephone_Mobile" VARCHAR(14),
  "PAT_Telephone_Professionnel" VARCHAR(14),
  "PAT_Telephone_Urgence" VARCHAR(14),
  "PAT_Email" VARCHAR(14),
  "PAT_Emp_Titre" VARCHAR(45),
  "PAT_Emp_Adresse" VARCHAR(45),
  "PAT_Emp_Canton" VARCHAR(20),
  "PAT_Emp_Ville" VARCHAR(25),
  "PAT_Emp_Code_Postal" VARCHAR(4),
  "PAT_Emp_Pays" VARCHAR(20),
  "PAT_Ass_Numero_Avs" VARCHAR(13),
  "PAT_Ass_Numero_Carte" VARCHAR(20),
  "PAT_Ass_Numero_OFSP" VARCHAR(45),
  "PAT_Ass_Institution" VARCHAR(15),
  "PAT_Ass_Police" VARCHAR(20),
  CONSTRAINT "IDPatient_UNIQUE"
    UNIQUE("PAT_ID")
);
CREATE TABLE "mydb"."Consultation"(
  "CON_Visite_Routine" INTEGER,
  "CON_ID" INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
  "CON_Date_Heure" DATETIME NOT NULL,
  "CON_PAT_FID" INTEGER NOT NULL,
  "CON_Premiere_Consultation" BOOL NOT NULL,
  "CON_Notes" LONGTEXT,
  "CON_Facture_Validee" BOOL NOT NULL,
  "CON_Facture_Payee" BOOL NOT NULL,
  "CON_Facture_Pdf" BLOB,
  CONSTRAINT "CON_ID_Consultation_UNIQUE"
    UNIQUE("CON_ID"),
  CONSTRAINT "fk_Consultation_Patient"
    FOREIGN KEY("CON_PAT_FID")
    REFERENCES "Patient"("PAT_ID")
);
CREATE INDEX "mydb"."Consultation.fk_Consultation_Patient" ON "Consultation" ("CON_PAT_FID");
CREATE TABLE "mydb"."CIM10"(
  "CIM_ID" INTEGER PRIMARY KEY NOT NULL,
  "CIM_Description" LONGTEXT,
  CONSTRAINT "CIM_ID_UNIQUE"
    UNIQUE("CIM_ID")
);
CREATE TABLE "mydb"."Service_Type"(
  "SET_ID" INTEGER PRIMARY KEY NOT NULL,
  "SET_Nom" VARCHAR(15),
  "SET_Chf_Minute" FLOAT
);
CREATE TABLE "mydb"."Utilisateurs"(
  "USR_ID" VARCHAR(25) PRIMARY KEY NOT NULL,
  "USR_Nom" VARCHAR(35),
  "USR_Prenom" VARCHAR(25),
  "USR_EstAdmin" BOOL NOT NULL,
  CONSTRAINT "USR_ID_UNIQUE"
    UNIQUE("USR_ID")
);
CREATE TABLE "mydb"."Probleme"(
  "PRB_ID" INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
  "PRB_Titre" VARCHAR(35) NOT NULL,
  "PRB_Type" VARCHAR(15) NOT NULL,
  "PRB_Description" LONGTEXT,
  "PRB_Date_Debut" DATE,
  "PRB_Date_Fin" DATE,
  "PRB_Occurence" VARCHAR(20),
  "PRB_PAT_FID" INTEGER NOT NULL,
  CONSTRAINT "PRB_ID_UNIQUE"
    UNIQUE("PRB_ID"),
  CONSTRAINT "fk_Probleme_Patient1"
    FOREIGN KEY("PRB_PAT_FID")
    REFERENCES "Patient"("PAT_ID")
);
CREATE INDEX "mydb"."Probleme.fk_Probleme_Patient" ON "Probleme" ("PRB_PAT_FID");
CREATE TABLE "mydb"."Consultation_Problemes"(
  "COPB_CON_ID" INTEGER NOT NULL,
  "Probleme_PRB_ID" INTEGER NOT NULL,
  PRIMARY KEY("COPB_CON_ID","Probleme_PRB_ID"),
  CONSTRAINT "fk_Consultations_Problemes_Consultation1"
    FOREIGN KEY("COPB_CON_ID")
    REFERENCES "Consultation"("CON_ID"),
  CONSTRAINT "fk_Consultations_Problemes_Probleme1"
    FOREIGN KEY("Probleme_PRB_ID")
    REFERENCES "Probleme"("PRB_ID")
);
CREATE INDEX "mydb"."Consultation_Problemes.fk_COPB_Consultation" ON "Consultation_Problemes" ("COPB_CON_ID");
CREATE INDEX "mydb"."Consultation_Problemes.fk_COPB_Probleme" ON "Consultation_Problemes" ("Probleme_PRB_ID");
CREATE TABLE "mydb"."Service_Rendu"(
  "SER_ID" INTEGER NOT NULL,
  "SER_Duree" INTEGER NOT NULL,
  "SER_Description" LONGTEXT,
  "SER_CON_FID" INTEGER NOT NULL,
  "SER_SET_ID" INTEGER NOT NULL,
  PRIMARY KEY("SER_ID","SER_SET_ID"),
  CONSTRAINT "SER_ID_UNIQUE"
    UNIQUE("SER_ID"),
  CONSTRAINT "fk_Service_Rendu_Consultation1"
    FOREIGN KEY("SER_CON_FID")
    REFERENCES "Consultation"("CON_ID"),
  CONSTRAINT "fk_Service_Rendu_Service_Type1"
    FOREIGN KEY("SER_SET_ID")
    REFERENCES "Service_Type"("SET_ID")
);
CREATE INDEX "mydb"."Service_Rendu.fk_Service_Rendu_Consultation1_idx" ON "Service_Rendu" ("SER_CON_FID");
CREATE INDEX "mydb"."Service_Rendu.fk_Service_Rendu_Service_Type1_idx" ON "Service_Rendu" ("SER_SET_ID");
CREATE TABLE "mydb"."Probleme_CIM10"(
  "PBCI_PRB_ID" INTEGER NOT NULL,
  "PBCI_CIM_ID" INTEGER PRIMARY KEY NOT NULL,
  CONSTRAINT "fk_Probleme_CIM10_Probleme1"
    FOREIGN KEY("PBCI_PRB_ID")
    REFERENCES "Probleme"("PRB_ID"),
  CONSTRAINT "fk_Probleme_CIM10_CIM101"
    FOREIGN KEY("PBCI_CIM_ID")
    REFERENCES "CIM10"("CIM_ID")
);
CREATE INDEX "mydb"."Probleme_CIM10.fk_Probleme_CIM10_Probleme1_idx" ON "Probleme_CIM10" ("PBCI_PRB_ID");
CREATE INDEX "mydb"."Probleme_CIM10.fk_Probleme_CIM10_CIM101_idx" ON "Probleme_CIM10" ("PBCI_CIM_ID");
COMMIT;
