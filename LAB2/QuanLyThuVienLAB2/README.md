HƯỚNG DẪN CÀI ĐẶT
Khởi tạo CSDL (Database):
Mở SQL Server Management Studio (SSMS).
Mở và chạy (F5) file script SQL đính kèm để tự động tạo Database QuanLyThuVien_Winform cùng với dữ liệu mẫu.
Cấu hình kết nối (Connection String):
Mở Solution bằng Visual Studio.
Tìm đến file cấu hình (App.config hoặc Data/Db.cs).
Đổi tên Server (hoặc Data Source) sao cho khớp với tên SQL Server trên máy.
Ví dụ: Server=.\SQLEXPRESS;Database=QuanLyThuVien_Winform;Integrated Security=True;
HƯỚNG DẪN SỬ DỤNG
Nhấn Ctrl + Shift + B để Build Solution, đảm bảo không có lỗi.
Nhấn F5 để khởi chạy ứng dụng.
Sử dụng các chức năng chính trên Menu:
Tài liệu & Độc giả: Thực hiện các thao tác Thêm, Sửa, Xóa thông tin sách và thẻ độc giả.
Mượn & Trả sách: Lập phiếu mượn (hệ thống sẽ tự check hạn thẻ và trừ tồn kho). Khi trả sách, phần mềm tự động tính tiền phạt 5.000 VNĐ/ngày nếu trễ hạn.
Yêu cầu mua sách: Gõ tên sách có sẵn hệ thống sẽ tự động điền Tác giả/Năm xuất bản, hoặc nhập tay sách mới.
Thống kê: Xem ngay tổng số sách, độc giả, sách đang quá hạn và doanh thu tiền phạt trên giao diện Dashboard.
