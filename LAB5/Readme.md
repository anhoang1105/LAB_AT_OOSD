# 1. Thông tin sinh viên

* **Họ và tên:** Trần Hoàng Ân
* **MSSV:** 1250080003
* **Môn học:** OOSD

---

# 2. Môi trường phát triển

* **Ngôn ngữ & Nền tảng:** C# WinForms, .NET Framework 4.7.2
* **Cơ sở dữ liệu:** SQL Server / LocalDB
* **Công cụ (IDE):** Visual Studio 2022

---

# 3. Nội dung đã thực hiện

* **Hoàn thiện các module quản lý nghiệp vụ:** Danh mục (phương tiện, điểm bán vé, HDV, điểm tham quan), Tour - hành trình, Lịch chuyến khách lẻ, Đăng ký khách lẻ, Đăng ký theo đoàn, Phân công HDV, Kết thúc tour và Khảo sát.
* **Xử lý toàn vẹn dữ liệu và giao dịch:** Áp dụng `SqlTransaction` khi lập phiếu đoàn và hủy phiếu đoàn (tự động giải phóng phân công HDV khi đoàn hủy, mất cọc).
* **Hiện thực chặt chẽ các ràng buộc nghiệp vụ:**
  * Khách lẻ < 12 người mua và thanh toán vé ngay; khách đoàn > 12 người bắt buộc đặt cọc trước.
  * Tự động tính ngày về của chuyến và ngày kết thúc tour (`NgayDi + SoNgay - 1`).
  * Kiểm tra chặt chẽ hạng sao khách sạn (2 - 5 sao khi có lưu trú).
  * Kiểm tra chồng chéo lịch hướng dẫn viên trước khi phân công.
* **Thống kê & Tính lương:** Tính tổng lương HDV (`LuongCoBan + Thù lao tour`) và tổng hợp số liệu kinh doanh đa chỉ tiêu (`UNION ALL`).

---

# 4. Kết quả

* Giao diện UI thiết kế trực quan, phân tách rõ ràng theo kiến trúc UI → Service → Data.
* Tự động tính toán thành tiền, ngày về dự kiến và công nợ sau tour chính xác theo dữ liệu CSDL.
* Thực hiện các bài test case kiểm thử chức năng và ràng buộc toàn vẹn.

---

# 5. Lỗi gặp phải & Cách khắc phục

* **Lỗi vi phạm khóa chính khi thêm điểm dừng (Primary Key Constraint Violation):** Xảy ra khi nhập trùng thứ tự điểm dừng cho cùng một mã tour (`PK(MaTour, ThuTu)`). Khắc phục bằng cách hiển thị rõ thứ tự hiện có trên bảng hoặc tự động tăng số thứ tự điểm dừng kế tiếp.
* **Lỗi chữ placeholder bị lưu nhầm vào Database:** Khi dùng text mặc định trong TextBox để làm gợi ý, nếu người dùng không sửa sẽ bị lưu sai chuỗi vào DB. Khắc phục bằng cách xử lý sự kiện `Enter`/`Leave` và tạo hàm lọc chuỗi trả về rỗng nếu trùng với nội dung placeholder.
* **Lỗi thiếu file thực thi (.exe) khi Debug:** Do project còn lỗi biên dịch (chưa tạo đủ Form con nhưng đã gọi mở Form ở `FrmMain`). Khắc phục bằng cách hoàn thiện lần lượt từng Form hoặc tạm thời comment lệnh mở form chưa tạo.

---

# 6. Hướng dẫn chạy chương trình

1. Mở SQL Server Management Studio (SSMS), mở và thực thi toàn bộ script `QuanLyCongTyDuLich.sql` để tạo Database và nạp dữ liệu mẫu ban đầu.
2. Mở file `QuanLyCongTyDuLich.sln` bằng Visual Studio 2022.
3. Kiểm tra chuỗi kết nối `QuanLyCongTyDuLichDB` trong file `App.config` cho khớp với SQL Server / LocalDB trên máy.
4. Chọn **Build > Rebuild Solution** (Ctrl + Shift + B).
5. Nhấn **F5** (hoặc nút Start) để khởi chạy chương trình từ `FrmMain`.
