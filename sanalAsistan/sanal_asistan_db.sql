USE asistan_db;

CREATE TABLE hatirlatici (
    id INT AUTO_INCREMENT PRIMARY KEY,
    kullanici_id INT NOT NULL,
    baslik VARCHAR(255),
    aciklama TEXT,
    tarih DATETIME,
    FOREIGN KEY (kullanici_id) REFERENCES kullanici(id)
);