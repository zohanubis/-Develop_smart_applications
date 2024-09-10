CREATE TABLE DM_ManHinh (
    MaManHinh INT PRIMARY KEY IDENTITY(1,1),
    TenManHinh NVARCHAR(255) NOT NULL
);
CREATE TABLE QL_NguoiDung (
    TenDangNhap NVARCHAR(50) PRIMARY KEY,
    MatKhau NVARCHAR(255) NOT NULL,
    HoatDong BIT NOT NULL
);
CREATE TABLE QL_NhomNguoiDung (
    MaNhom INT PRIMARY KEY IDENTITY(1,1),
    TenNhom NVARCHAR(255) NOT NULL,
    GhiChu NVARCHAR(255)
);
CREATE TABLE QL_NguoiDungNhomNguoiDung (
    TenDangNhap NVARCHAR(50) NOT NULL,
    MaNhomNguoiDung INT NOT NULL,
    GhiChu NVARCHAR(255),

    CONSTRAINT FK_NguoiDung FOREIGN KEY (TenDangNhap) REFERENCES QL_NguoiDung(TenDangNhap),
    CONSTRAINT FK_NhomNguoiDung FOREIGN KEY (MaNhomNguoiDung) REFERENCES QL_NhomNguoiDung(MaNhom)
);
CREATE TABLE QL_PhanQuyen (
    MaNhomNguoiDung INT NOT NULL,
    MaManHinh INT NOT NULL,
    CoQuyen BIT NOT NULL,

    CONSTRAINT FK_NhomNguoiDungPhanQuyen FOREIGN KEY (MaNhomNguoiDung) REFERENCES QL_NhomNguoiDung(MaNhom),
    CONSTRAINT FK_ManHinhPhanQuyen FOREIGN KEY (MaManHinh) REFERENCES DM_ManHinh(MaManHinh)
);

INSERT INTO DM_ManHinh (TenManHinh) VALUES 
(N'Trang chủ'),
(N'Quản lý người dùng'),
(N'Quản lý quyền'),
(N'Báo cáo'),
(N'Cài đặt hệ thống');

INSERT INTO QL_NguoiDung (TenDangNhap, MatKhau, HoatDong) VALUES 
('admin', 'password123', 1),
('user01', 'userpass01', 1),
('user02', 'userpass02', 0);

INSERT INTO QL_NhomNguoiDung (TenNhom, GhiChu) VALUES 
(N'Quản trị viên', N'Nhóm có quyền cao nhất'),
(N'Nhân viên', N'Nhóm nhân viên quản lý thông thường'),
(N'Khách', N'Nhóm khách không có quyền chỉnh sửa');

INSERT INTO QL_NguoiDungNhomNguoiDung (TenDangNhap, MaNhomNguoiDung, GhiChu) VALUES 
('admin', 1, 'Quản trị viên hệ thống'),
('user01', 2, 'Nhân viên bình thường'),
('user02', 3, 'Khách đăng nhập');

INSERT INTO QL_PhanQuyen (MaNhomNguoiDung, MaManHinh, CoQuyen) VALUES 
(1, 1, 1), -- Quản trị viên có quyền trên Trang chủ
(1, 2, 1), -- Quản trị viên có quyền trên Quản lý người dùng
(1, 3, 1), -- Quản trị viên có quyền trên Quản lý quyền
(1, 4, 1), -- Quản trị viên có quyền trên Báo cáo
(1, 5, 1), -- Quản trị viên có quyền trên Cài đặt hệ thống
(2, 1, 1), -- Nhân viên có quyền trên Trang chủ
(2, 2, 1), -- Nhân viên có quyền trên Quản lý người dùng
(2, 3, 0), -- Nhân viên không có quyền trên Quản lý quyền
(2, 4, 1), -- Nhân viên có quyền trên Báo cáo
(2, 5, 0), -- Nhân viên không có quyền trên Cài đặt hệ thống
(3, 1, 1), -- Khách có quyền trên Trang chủ
(3, 2, 0), -- Khách không có quyền trên Quản lý người dùng
(3, 3, 0), -- Khách không có quyền trên Quản lý quyền
(3, 4, 0), -- Khách không có quyền trên Báo cáo
(3, 5, 0); -- Khách không có quyền trên Cài đặt hệ thống

