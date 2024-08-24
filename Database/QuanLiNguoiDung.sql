-- T?o c? s? d? li?u v� chuy?n v�o c? s? d? li?u v?a t?o
CREATE DATABASE QuanLiNguoiDung;
USE QuanLiNguoiDung;

-- T?o b?ng Sequence ?? qu?n l� gi� tr? t?ng d?n
CREATE TABLE Sequence (
    Name VARCHAR(50) PRIMARY KEY,
    CurrentValue INT NOT NULL
);

-- Kh?i t?o gi� tr? sequence cho c�c b?ng DM_ManHinh v� QL_NhomNguoiDung
INSERT INTO Sequence (Name, CurrentValue) VALUES ('DM_ManHinh_Seq', 0);
INSERT INTO Sequence (Name, CurrentValue) VALUES ('QL_NhomNguoiDung_Seq', 0);

-- T?o stored procedure GetNextSequenceValue ?? l?y gi� tr? ti?p theo t? sequence
CREATE PROCEDURE GetNextSequenceValue
    @seq_name VARCHAR(50),
    @next_value INT OUTPUT
AS
BEGIN
    -- T?ng gi� tr? CurrentValue v� tr? v? gi� tr? m?i
    UPDATE Sequence
    SET CurrentValue = CurrentValue + 1
    WHERE Name = @seq_name;

    -- L?y gi� tr? m?i nh?t sau khi t?ng
    SELECT @next_value = CurrentValue
    FROM Sequence
    WHERE Name = @seq_name;
END;

-- T?o b?ng DM_ManHinh v� trigger ?? t? ??ng t?ng gi� tr?
CREATE TABLE DM_ManHinh (
    MaManHinh INT PRIMARY KEY,
    TenManHinh VARCHAR(100) NOT NULL
);

CREATE TRIGGER trg_after_insert_DM_ManHinh
ON DM_ManHinh
AFTER INSERT
AS
BEGIN
    DECLARE @next_value INT;
    
    -- L?y gi� tr? sequence ti?p theo
    EXEC GetNextSequenceValue 'DM_ManHinh_Seq', @next_value OUTPUT;
    
    -- C?p nh?t MaManHinh v?i gi� tr? sequence m?i cho c�c d�ng v?a m?i th�m
    UPDATE DM_ManHinh
    SET MaManHinh = @next_value
    WHERE MaManHinh IS NULL; -- C?p nh?t c�c d�ng m� MaManHinh ?ang l� NULL
END;

-- T?o b?ng QL_NhomNguoiDung v� trigger ?? t? ??ng t?ng gi� tr?
CREATE TABLE QL_NhomNguoiDung (
    MaNhom INT PRIMARY KEY,
    TenNhom VARCHAR(100) NOT NULL,
    GhiChu TEXT
);

CREATE TRIGGER trg_after_insert_QL_NhomNguoiDung
ON QL_NhomNguoiDung
AFTER INSERT
AS
BEGIN
    DECLARE @next_value INT;
    
    -- L?y gi� tr? sequence ti?p theo
    EXEC GetNextSequenceValue 'QL_NhomNguoiDung_Seq', @next_value OUTPUT;
    
    -- C?p nh?t MaNhom v?i gi� tr? sequence m?i cho c�c d�ng v?a m?i th�m
    UPDATE QL_NhomNguoiDung
    SET MaNhom = @next_value
    WHERE MaNhom IS NULL; -- C?p nh?t c�c d�ng m� MaNhom ?ang l� NULL
END;

-- T?o b?ng QL_NguoiDung
CREATE TABLE QL_NguoiDung (
    TenDangNhap VARCHAR(50) PRIMARY KEY,
    MatKhau VARCHAR(255) NOT NULL,
    HoatDong TINYINT NOT NULL DEFAULT 1
);

-- T?o b?ng QL_NguoiDungNhomNguoiDung
CREATE TABLE QL_NguoiDungNhomNguoiDung (
    TenDangNhap VARCHAR(50),
    MaNhom INT,
    GhiChu TEXT,
    PRIMARY KEY (TenDangNhap, MaNhom),
    FOREIGN KEY (TenDangNhap) REFERENCES QL_NguoiDung(TenDangNhap)
        ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (MaNhom) REFERENCES QL_NhomNguoiDung(MaNhom)
        ON DELETE CASCADE ON UPDATE CASCADE
);

-- T?o b?ng QL_PhanQuyen
CREATE TABLE QL_PhanQuyen (
    MaNhomNguoiDung INT,
    MaManHinh INT,
    CoQuyen TINYINT NOT NULL DEFAULT 0,
    PRIMARY KEY (MaNhomNguoiDung, MaManHinh),
    FOREIGN KEY (MaNhomNguoiDung) REFERENCES QL_NhomNguoiDung(MaNhom)
        ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (MaManHinh) REFERENCES DM_ManHinh(MaManHinh)
        ON DELETE CASCADE ON UPDATE CASCADE
);
