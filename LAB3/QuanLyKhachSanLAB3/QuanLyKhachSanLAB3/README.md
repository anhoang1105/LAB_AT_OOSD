# BÁO CÁO LAB 3: XÂY DỰNG HỆ THỐNG QUẢN LÝ KHÁCH SẠN

## 1. Thông tin sinh viên
* **Họ và tên:** Trần Hoàng Ân
* **MSSV:** 1250080003
* **Môn học:** OOSD

## 2. Môi trường phát triển
* **Ngôn ngữ & Nền tảng:** C# WinForms, .NET Framework
* **Cơ sở dữ liệu:** SQL Server
* **Công cụ (IDE):** Visual Studio

## 3. Nội dung đã thực hiện
* Hoàn thiện các module quản lý: Danh mục, Tiện nghi, Đặt/Nhận/Trả phòng, Dịch vụ.
* Tạo chức năng thống kê doanh thu theo khoảng thời gian.
* Tích hợp tính năng in ấn (PrintDocument) cho các biểu mẫu trắng (Phiếu nhận phòng, dịch vụ, hóa đơn,...).

## 4. Kết quả
* Giao diện tương tác mượt mà, tự động điền dữ liệu khi click vào DataGridView.
* Thuật toán tính tiền, trừ cọc, lưu lịch sử hoạt động chính xác theo cơ sở dữ liệu.

## 5. Lỗi gặp phải & Cách khắc phục
* **Lỗi giao diện không nhận sự kiện click:** Khắc phục bằng cách chủ động gán sự kiện qua code (`+=`) trong hàm khởi tạo thay vì dùng giao diện Properties.
* **Lỗi Invalid column name khi lưu DB:** Xảy ra do nhầm tên cột hoặc chèn nhầm vào cột tự tính toán (PERSISTED). Khắc phục bằng cách chỉ định rõ danh sách cột khi dùng lệnh `INSERT INTO`.

## 6. Hướng dẫn chạy chương trình
1. Mở SQL Server, chạy file script `QuanLyKhachSanDB.sql` để tạo Database và dữ liệu mẫu.
2. Mở project bằng Visual Studio, vào cấu hình sửa lại chuỗi kết nối (Connection String) cho đúng với tên Server SQL máy.
3. Nhấn **F5** (hoặc nút Start) để chạy chương trình.