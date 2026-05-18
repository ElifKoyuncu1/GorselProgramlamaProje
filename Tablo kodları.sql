-- 1. Bölüm Tablosu
CREATE TABLE Bolum (
    BolumID INT PRIMARY KEY IDENTITY(1,1),
    BolumAd NVARCHAR(100) NOT NULL
);

-- 2. Ders Tipi Tablosu
CREATE TABLE DersTipi (
    DersTipiID INT PRIMARY KEY IDENTITY(1,1),
    TipAd NVARCHAR(50) NOT NULL -- 'Rektörlük', 'Havuz', 'Alan Dersi'
);

-- 3. Sýnýf Seviyesi Tablosu
CREATE TABLE SinifSeviyesi (
    SinifSeviyeID INT PRIMARY KEY IDENTITY(1,1),
    BolumID INT FOREIGN KEY REFERENCES Bolum(BolumID),
    SeviyeNo INT, -- 1, 2, 3, 4
    SinifMevcudu INT -- O sýnýfýn toplam öðrenci sayýsý
);

-- 4. Derslik Tablosu
CREATE TABLE Derslik (
    DerslikID INT PRIMARY KEY IDENTITY(1,1),
    DerslikAd NVARCHAR(50) NOT NULL, -- 'Lab 1', '101' vb.
    Kapasite INT
);

-- 5. Kullanýcý Tablosu
CREATE TABLE Kullanici (
    KullaniciID INT PRIMARY KEY IDENTITY(1,1),
    KullaniciAdi NVARCHAR(50) NOT NULL,
    Sifre NVARCHAR(50) NOT NULL,
    Rol NVARCHAR(20), -- 'Admin', 'Sekreter'
    BolumID INT FOREIGN KEY REFERENCES Bolum(BolumID)
);

-- 6. Akademik Takvim
CREATE TABLE AkademikTakvim (
    TakvimID INT PRIMARY KEY IDENTITY(1,1),
    DonemAdi NVARCHAR(50), -- '2025-2026 Güz'
    SinavTipi NVARCHAR(20), -- 'Vize', 'Final'
    BaslangicTarihi DATE,
    BitisTarihi DATE
);

-- 7. Zaman Dilimi
CREATE TABLE ZamanDilimi (
    ZamanID INT PRIMARY KEY IDENTITY(1,1),
    TakvimID INT FOREIGN KEY REFERENCES AkademikTakvim(TakvimID),
    Tarih DATE,
    BaslangicSaat TIME,
    BitisSaat TIME
);

-- 8. Ders Tablosu (Sýnýf Seviyesi ve Ders Tipi Baðlý)
CREATE TABLE Ders (
    DersID INT PRIMARY KEY IDENTITY(1,1),
    DersAdi NVARCHAR(100),
    HocaAdSoyad NVARCHAR(100),
    BolumID INT FOREIGN KEY REFERENCES Bolum(BolumID),
    DersTipiID INT FOREIGN KEY REFERENCES DersTipi(DersTipiID),
    SinifSeviyeID INT FOREIGN KEY REFERENCES SinifSeviyesi(SinifSeviyeID),
    Kredi INT,
    SinavSuresi INT DEFAULT 60,
    DersiAlanOgrenciSayisi INT -- Sýnýf mevcudundan farklý olabilir (alttan alanlar vb.)
);

-- 9. Sýnav Tablosu (DerslikID'yi buraya aldýk)
CREATE TABLE Sinav (
    SinavID INT PRIMARY KEY IDENTITY(1,1),
    DersID INT FOREIGN KEY REFERENCES Ders(DersID),
    ZamanID INT FOREIGN KEY REFERENCES ZamanDilimi(ZamanID),
    DerslikID INT FOREIGN KEY REFERENCES Derslik(DerslikID),
    ProgramVersiyon INT -- 1, 2, 3
);