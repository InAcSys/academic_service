CREATE TABLE
    IF NOT EXISTS "Types" (
        "Id" INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
        "Name" VARCHAR(100) NOT NULL UNIQUE,
        "IsActive" BOOLEAN NOT NULL DEFAULT TRUE,
        "Created" TIMESTAMP NOT NULL DEFAULT NOW (),
        "Updated" TIMESTAMP NULL,
        "Deleted" TIMESTAMP NULL
    );

CREATE TABLE
    IF NOT EXISTS "Natures" (
        "Id" INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
        "Name" VARCHAR(100) NOT NULL UNIQUE,
        "IsActive" BOOLEAN NOT NULL DEFAULT TRUE,
        "Created" TIMESTAMP NOT NULL DEFAULT NOW (),
        "Updated" TIMESTAMP NULL,
        "Deleted" TIMESTAMP NULL
    );

CREATE TABLE
    IF NOT EXISTS "Periods" (
        "Id" INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
        "Name" VARCHAR(100) NOT NULL UNIQUE,
        "MonthsDuration" DECIMAL NOT NULL,
        "IsActive" BOOLEAN NOT NULL DEFAULT TRUE,
        "Created" TIMESTAMP NOT NULL DEFAULT NOW (),
        "Updated" TIMESTAMP NULL,
        "Deleted" TIMESTAMP NULL
    );

CREATE TABLE
    IF NOT EXISTS "Countries" (
        "Id" INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
        "Name" VARCHAR(100) NOT NULL UNIQUE,
        "PhoneCode" VARCHAR(5) NOT NULL,
        "IsActive" BOOLEAN NOT NULL DEFAULT TRUE,
        "Created" TIMESTAMP NOT NULL DEFAULT NOW (),
        "Updated" TIMESTAMP NULL,
        "Deleted" TIMESTAMP NULL
    );

CREATE TABLE
    IF NOT EXISTS "Departaments" (
        "Id" INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
        "Name" VARCHAR(100) NOT NULL UNIQUE,
        "Country" INT NOT NULL,
        "IsActive" BOOLEAN NOT NULL DEFAULT TRUE,
        "Created" TIMESTAMP NOT NULL DEFAULT NOW (),
        "Updated" TIMESTAMP NULL,
        "Deleted" TIMESTAMP NULL,
        FOREIGN KEY ("Country") REFERENCES "Countries" ("Id")
    );

CREATE TABLE
    IF NOT EXISTS "Cities" (
        "Id" INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
        "Name" VARCHAR(100) NOT NULL UNIQUE,
        "Departament" INT NOT NULL,
        "IsActive" BOOLEAN NOT NULL DEFAULT TRUE,
        "Created" TIMESTAMP NOT NULL DEFAULT NOW (),
        "Updated" TIMESTAMP NULL,
        "Deleted" TIMESTAMP NULL,
        FOREIGN KEY ("Departament") REFERENCES "Departaments" ("Id")
    );

CREATE TABLE
    IF NOT EXISTS "Institutes" (
        "Id" UUID PRIMARY KEY NOT NULL DEFAULT gen_random_uuid (),
        "Name" VARCHAR(255) NOT NULL,
        "Principal" UUID NULL,
        "Type" INT NOT NULL,
        "Nature" INT NOT NULL,
        "Period" INT NOT NULL,
        "SubDomain" VARCHAR(255) NOT NULL,
        "Country" INT NOT NULL,
        "Departament" INT NOT NULL,
        "City" INT NOT NULL,
        "Location" VARCHAR(255) NOT NULL,
        "Logo" VARCHAR(255) NOT NULL,
        "MiddleVacations" INT NULL,
        "StartTime" TIMESTAMP NOT NULL,
        "EndTime" TIMESTAMP NOT NULL,
        "IsActive" BOOLEAN NOT NULL DEFAULT TRUE,
        "Created" TIMESTAMP NOT NULL DEFAULT NOW (),
        "Updated" TIMESTAMP NULL,
        "Deleted" TIMESTAMP NULL,
        FOREIGN KEY ("Type") REFERENCES "Types" ("Id"),
        FOREIGN KEY ("Nature") REFERENCES "Natures" ("Id"),
        FOREIGN KEY ("Period") REFERENCES "Periods" ("Id"),
        FOREIGN KEY ("Country") REFERENCES "Countries" ("Id"),
        FOREIGN KEY ("Departament") REFERENCES "Departaments" ("Id"),
        FOREIGN KEY ("City") REFERENCES "Cities" ("Id")
    );

INSERT INTO
    "Types" ("Name")
VALUES
    ('Universidad'),
    ('Colegio'),
    ('Instituto alternativo'),
    ('Instituto de idiomas');

INSERT INTO
    "Natures" ("Name")
VALUES
    ('Público/Gubernamental'),
    ('Privado/Particular'),
    ('Convenio');

INSERT INTO
    "Periods" ("Name", "MonthsDuration")
VALUES
    ('Semestral', 6),
    ('Trimestral', 3),
    ('Anual', 12);

INSERT INTO
    "Countries" ("Name", "PhoneCode")
VALUES
    ('Bolivia', '+591');

INSERT INTO
    "Departaments" ("Name", "Country")
VALUES
    ('La Paz', 1),
    ('Cochabamba', 1),
    ('Santa Cruz', 1),
    ('Oruro', 1),
    ('Potosí', 1),
    ('Chuquisaca', 1),
    ('Tarija', 1),
    ('Beni', 1),
    ('Pando', 1);

INSERT INTO
    "Cities" ("Name", "Departament")
VALUES
    -- La Paz
    ('La Paz', 1),
    ('El Alto', 1),
    ('Viacha', 1),
    -- Cochabamba
    ('Cochabamba', 2),
    ('Quillacollo', 2),
    ('Sacaba', 2),
    -- Santa Cruz
    ('Santa Cruz de la Sierra', 3),
    ('Montero', 3),
    ('Warnes', 3),
    -- Oruro
    ('Oruro', 4),
    ('Huanuni', 4),
    ('Caracollo', 4),
    -- Potosí
    ('Potosí', 5),
    ('Uyuni', 5),
    ('Villazón', 5),
    -- Chuquisaca
    ('Sucre', 6),
    ('Yotala', 6),
    ('Monteagudo', 6),
    -- Tarija
    ('Tarija', 7),
    ('Bermejo', 7),
    ('Yacuiba', 7),
    -- Beni
    ('Trinidad', 8),
    ('Riberalta', 8),
    ('Guayaramerín', 8),
    -- Pando
    ('Cobija', 9),
    ('Porvenir', 9),
    ('Puerto Rico', 9);