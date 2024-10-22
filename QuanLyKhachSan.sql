CREATE DATABASE QuanLyKhachSan;

USE QuanLyKhachSan;

CREATE TABLE KhachHang (
    MaKhachHang VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(100),
    DiaChi NVARCHAR(200),
    DienThoai VARCHAR(20)
);



CREATE TABLE Phong (
    MaPhong VARCHAR(10) PRIMARY KEY,
    SoNguoi INT,
    DonGia DECIMAL(10, 2)
);



CREATE TABLE NhanPhong (
    MaNhanPhong VARCHAR(10) PRIMARY KEY,
    MaKhachHang VARCHAR(10),
    MaPhong VARCHAR(10),
    NgayVao DATE,
    NgayDi DATE,
    ThanhTien DECIMAL(10, 2),
    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang),
    FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong)
);


INSERT INTO KhachHang (MaKhachHang, HoTen, DiaChi, DienThoai) VALUES
('KH001', 'Nguyen Van A', '123 Tran Phu, Ha Noi', '0912345678'),
('KH002', 'Le Thi B', '456 Le Loi, Da Nang', '0987654321'),
('KH003', 'Tran Van C', '789 Phan Chau Trinh, Ho Chi Minh', '0909123456'),
('KH004', 'Pham Thi D', '321 Ngo Quyen, Hai Phong', '0934567890'),
('KH005', 'Nguyen Van E', '654 Ly Thuong Kiet, Can Tho', '0976543210');


INSERT INTO Phong (MaPhong, SoNguoi, DonGia) VALUES
('P101', 2, 300000),
('P102', 4, 500000),
('P103', 1, 200000),
('P104', 3, 400000),
('P105', 2, 350000);



INSERT INTO NhanPhong (MaNhanPhong, MaKhachHang, MaPhong, NgayVao, NgayDi, ThanhTien) VALUES
('NP001', 'KH001', 'P101', '2024-10-15', '2024-10-17', 600000),
('NP002', 'KH002', 'P102', '2024-10-14', '2024-10-18', 2000000),
('NP003', 'KH003', 'P103', '2024-10-16', '2024-10-19', 600000),
('NP004', 'KH004', 'P104', '2024-10-15', '2024-10-16', 400000),
('NP005', 'KH005', 'P105', '2024-10-17', '2024-10-20', 1050000);

