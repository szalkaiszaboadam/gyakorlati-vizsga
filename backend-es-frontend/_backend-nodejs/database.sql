-- Adatbázis létrehozása
DROP DATABASE IF EXISTS ingatlanok;
CREATE DATABASE ingatlanok DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_hungarian_ci;
USE ingatlanok;

-- Kategóriák tábla
CREATE TABLE categories (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(100) NOT NULL
);

-- Eladók tábla
CREATE TABLE sellers (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(100) NOT NULL
);

-- Ingatlanok tábla
CREATE TABLE realestates (
    id INT AUTO_INCREMENT PRIMARY KEY,
    categoryId INT NOT NULL,
    sellerId INT NOT NULL,
    description TEXT NOT NULL,
    createAt DATE NOT NULL,
    freeofcharge BOOLEAN NOT NULL,
    imageUrl VARCHAR(255) NOT NULL,
    area INT NOT NULL,
    rooms INT NOT NULL,
    floors INT NOT NULL,
    latlong VARCHAR(100) NOT NULL,
    FOREIGN KEY (categoryId) REFERENCES categories(id),
    FOREIGN KEY (sellerId) REFERENCES sellers(id)
);

-- Minta adatok feltöltése

-- Kategóriák
INSERT INTO categories (name) VALUES 
('Családi ház'),
('Társasházi lakás'),
('Panel lakás'),
('Nyaraló');

-- Eladók
INSERT INTO sellers (name) VALUES 
('Nagy Anna'),
('Kiss Péter'),
('Kovács Kft.'),
('Lakáscentrum Zrt.');

-- Ingatlanok
INSERT INTO realestates (
    categoryId, sellerId, description, createAt, freeofcharge, imageUrl, area, rooms, floors, latlong
) VALUES
(1, 1, 'Szép családi ház kerttel.', '2024-01-10', TRUE, 'https://example.com/haz1.jpg', 120, 4, 2, '47.4979,19.0402'),
(2, 2, 'Felújított társasházi lakás.', '2024-03-05', FALSE, 'https://example.com/lakas1.jpg', 65, 3, 3, '47.4925,19.0513'),
(3, 3, 'Panellakás jó közlekedéssel.', '2024-04-15', TRUE, 'https://example.com/panel.jpg', 54, 2, 10, '47.5012,19.0432'),
(4, 4, 'Balatoni nyaraló kilátással.', '2024-05-01', FALSE, 'https://example.com/nyaralo.jpg', 80, 3, 1, '46.9500,17.8895');
