# 🏢 Hệ thống Quản lý Nhân sự (HR Management System)

Dự án phần mềm **Quản lý Nhân sự** được xây dựng trên nền tảng **C# WinForms** kết hợp cơ sở dữ liệu **Microsoft SQL Server**. Hệ thống được thiết kế theo kiến trúc **3 lớp (3-Tier Architecture)** chuẩn mực, đi kèm giao diện người dùng tối giản (Minimalism UI) giúp tối ưu hóa trải nghiệm thao tác và xử lý nghiệp vụ tại các doanh nghiệp.

## 🚀 Các tính năng chính (Features)

Phần mềm cung cấp đầy đủ các phân hệ từ quản lý hồ sơ cơ bản đến tính toán lương thưởng:
- **🗂️ Quản lý Danh mục:** Thiết lập danh sách Phòng ban, vị trí công tác.
- **👤 Quản lý Hồ sơ Nhân viên:** Quản lý thông tin cá nhân, liên hệ, quá trình công tác.
- **📜 Quản lý Hợp đồng:** Theo dõi hợp đồng lao động, thời hạn và trạng thái hiệu lực.
- **⏰ Quản lý Chấm công:** Ghi nhận số giờ làm việc thực tế hàng tháng.
- **⏳ Quản lý Phụ trội:** Theo dõi các phiếu làm thêm giờ, tăng ca.
- **🏅 Khen thưởng & Kỷ luật:** Lưu trữ quyết định và số tiền thưởng/phạt.
- **💰 Quản lý Bảng lương:** Tính toán tự động tổng thu nhập, khấu trừ và thực lãnh.
- **📊 Thống kê & Báo cáo:** Trích xuất dữ liệu nhân sự, tổng hợp báo cáo lương theo tháng/năm.

## 🛠️ Công nghệ sử dụng (Technologies)

- **Ngôn ngữ lập trình:** C#
- **Framework:** .NET Framework (Windows Forms)
- **Cơ sở dữ liệu:** Microsoft SQL Server
- **Kiến trúc mã nguồn:** 3-Tier (Mô hình 3 lớp)
  - `Data` (Data Access Layer): Tương tác trực tiếp CSDL.
  - `Services` (Business Logic Layer): Xử lý nghiệp vụ.
  - `Forms` (GUI): Giao diện người dùng.
- **IDE:** Visual Studio 2019 / 2022

---

## 📋 Yêu cầu hệ thống (Prerequisites)

Để mở và chạy được dự án này, máy tính của bạn cần cài đặt sẵn:
1. **Visual Studio 2019** hoặc **2022** (Đã tick chọn *.NET desktop development* trong Visual Studio Installer).
2. **Microsoft SQL Server** và **SQL Server Management Studio (SSMS)**.

---

## ⚙️ Hướng dẫn Cài đặt & Chạy dự án (Installation & Setup)

Hãy làm theo các bước dưới đây để thiết lập dự án trên máy cục bộ của bạn:

### Bước 1: Tải mã nguồn (Clone Repository)
Tải mã nguồn dự án về máy bằng cách sử dụng Git hoặc tải file `.zip`:
```bash
git clone https://github.com/your-username/QuanLyNhanSu.git
```
*(Nếu tải file .zip, hãy giải nén vào một thư mục trên ổ đĩa của bạn).*

### Bước 2: Thiết lập Cơ sở dữ liệu (Database Setup)
1. Mở **SQL Server Management Studio (SSMS)** và kết nối vào Server của bạn.
2. Chọn **File > Open > File...** và tìm đến file `QuanLyNhanSuDB.sql` nằm trong thư mục gốc của dự án.
3. Bấm **Execute (F5)** để chạy script. Script này sẽ tự động:
   - Tạo Database mới tên là `QuanLyNhanSuDB`.
   - Tạo đầy đủ các bảng dữ liệu (Tables) và khóa ngoại (Foreign Keys).
   - Thêm sẵn (Insert) các dữ liệu mẫu (Dummy data) để bạn có thể test ngay chức năng.

### Bước 3: Cấu hình chuỗi kết nối (Connection String)
1. Mở file **`QuanLyNhanSu.sln`** bằng Visual Studio.
2. Trong cửa sổ **Solution Explorer**, tìm mở thư mục **`Data`** -> nhấp đúp vào file **`Db.cs`**.
3. Sửa biến chuỗi `ConnectionString` lại cho khớp với tên Server trên máy của bạn (Thay `YOUR_SERVER_NAME` bằng tên server SQL của bạn, thường là `localhost` hoặc `.\SQLEXPRESS`):
```csharp
private static string ConnectionString = @"Server=YOUR_SERVER_NAME;Database=QuanLyNhanSuDB;Integrated Security=True;";
```

### Bước 4: Chạy phần mềm (Build and Run)
1. Nhấn **Ctrl + Shift + B** để Build (Biên dịch) toàn bộ dự án nhằm đảm bảo không có lỗi.
2. Nhấn phím **F5** (hoặc click nút Start) để khởi chạy phần mềm.
3. Giao diện trang chủ (Dashboard) sẽ hiện ra và bạn có thể bắt đầu thao tác.

---

## 📸 Cấu trúc thư mục (Folder Structure)

```text
QuanLyNhanSu/
│
├── Data/
│   └── Db.cs                  # Xử lý kết nối CSDL và thao tác SQL chung (DAL)
│
├── Services/                  # Tầng Business Logic (BLL)
│   ├── DanhMucService.cs
│   ├── NhanVienService.cs
│   ├── HopDongService.cs
│   ├── ChamCongService.cs
│   └── ...
│
├── Forms/                     # Tầng Giao diện (GUI)
│   ├── FrmMain.cs             # Giao diện Trang chủ (Dashboard)
│   ├── FormHelper.cs          # Các hàm tiện ích định dạng UI chung
│   ├── FrmNhanVien.cs
│   ├── FrmChamCong.cs
│   └── ...
│
├── QuanLyNhanSuDB.sql         # Script tự động tạo toàn bộ CSDL và dữ liệu mẫu
└── README.md                  # Hướng dẫn dự án (File này)
```

## 📝 Giấy phép (License)
Dự án này được xây dựng cho mục đích học tập và tham khảo. Bạn có thể tự do sao chép, chỉnh sửa và phát triển thêm các tính năng mới.