# Đức Thịnh Coffee - Quán Café Web Application

Dự án website quản lý và giới thiệu thực đơn cho quán café/quán ăn nhỏ mang thương hiệu **Đức Thịnh Coffee**, được xây dựng trên nền tảng **ASP.NET Core MVC** (.NET 10) kết hợp với **Entity Framework Core** và cơ sở dữ liệu **SQLite**.

---

## 📌 Tính năng chính

- **Trang chủ (Home):** Giới thiệu thông tin quán cà phê.
- **Thực đơn (Menu):** Hiển thị danh sách món ăn, thức uống được phân loại theo nhóm (Đồ ăn nhanh, Đồ nước, Thức uống) cùng với tên, giá bán và mô tả chi tiết.
- **Quản lý dữ liệu (Database & Seed Data):**
  - Tích hợp Entity Framework Core Code-First.
  - Tự động nạp (Seed) sẵn dữ liệu mẫu về món ăn, nước uống ban đầu.
- **Hệ thống liên hệ (Contact Model):** Đã thiết kế cấu trúc dữ liệu liên hệ/phản hồi từ khách hàng (Họ tên, Số điện thoại, Nội dung, Ngày gửi).

---

## 🛠 Công nghệ sử dụng

- **Framework:** [.NET 10.0](https://dotnet.microsoft.com/) (ASP.NET Core Web App - MVC)
- **ORM:** [Entity Framework Core 10](https://learn.microsoft.com/ef/core/)
- **Cơ sở dữ liệu:** [SQLite](https://www.sqlite.org/) (File cơ sở dữ liệu: `quancafe.db`)
- **Frontend / UI:** HTML5, CSS3, Razor Views, [Bootstrap 5](https://getbootstrap.com/), [jQuery](https://jquery.com/)

---

## 📂 Cấu trúc thư mục dự án

```text
QuanCafe/
├── Controllers/
│   ├── HomeController.cs        # Điều hướng trang chủ, chính sách và xử lý lỗi
│   └── MenuController.cs        # Xử lý truy vấn và hiển thị danh sách thực đơn
├── Data/
│   └── AppDbContext.cs          # DbContext cấu hình các bảng và Seed Data cho MonAn
├── Migrations/                  # Lịch sử các bản migration cơ sở dữ liệu EF Core
├── Models/
│   ├── MonAn.cs                 # Entity thông tin món (Tên, Giá, Mô tả, Ảnh, Nhóm)
│   ├── LienHe.cs                # Entity thông tin liên hệ của khách hàng
│   └── ErrorViewModel.cs        # Model hỗ trợ hiển thị lỗi
├── Views/
│   ├── Home/                    # Giao diện Trang chủ, Privacy
│   ├── Menu/                    # Giao diện hiển thị thực đơn
│   └── Shared/                  # Layout chung (_Layout.cshtml), Error page
├── wwwroot/                     # Tài nguyên tĩnh (CSS, JS, Thư viện Bootstrap, jQuery)
├── appsettings.json             # Cấu hình chuỗi kết nối Database và Logging
├── Program.cs                   # Cấu hình dịch vụ (DI) và Middleware pipeline
└── QuanCafe.csproj              # File cấu hình project và các NuGet packages
```

---

## 🚀 Hướng dẫn cài đặt và khởi chạy

### 1. Yêu cầu hệ thống
- Đã cài đặt [.NET 10 SDK](https://dotnet.microsoft.com/download).
- Công cụ dòng lệnh EF Core CLI (nếu cần quản lý migrations):
  ```bash
  dotnet tool install --global dotnet-ef
  ```

### 2. Cài đặt các gói phụ thuộc
Mở terminal tại thư mục gốc của dự án (`QuanCafe`) và chạy lệnh:
```bash
dotnet restore
```

### 3. Cập nhật cơ sở dữ liệu
Nếu file cơ sở dữ liệu `quancafe.db` chưa có hoặc cần cập nhật migration mới nhất:
```bash
dotnet ef database update
```

### 4. Khởi chạy ứng dụng
Chạy ứng dụng bằng lệnh:
```bash
dotnet run
```
Hoặc chạy ở chế độ Hot-Reload:
```bash
dotnet watch
```

Sau khi chạy, mở trình duyệt web và truy cập vào đường dẫn được hiển thị trên console (mặc định thường là `https://localhost:5001` hoặc `http://localhost:5000`).

---

## 🧭 Các trang và đường dẫn chính

| Đường dẫn | Controller / Action | Mô tả |
| :--- | :--- | :--- |
| `/` hoặc `/Home/Index` | `HomeController.Index` | Trang chủ Đức Thịnh Coffee |
| `/Menu` | `MenuController.Index` | Xem danh sách thực đơn món ăn & thức uống |
| `/Home/Privacy` | `HomeController.Privacy` | Chính sách bảo mật |

---

## 🔮 Hướng phát triển tiếp theo

- [ ] Hoàn thiện giao diện Form liên hệ (Contact Us) gửi thông tin vào bảng `LienHe`.
- [ ] Trang quản trị (Admin Dashboard) thêm/sửa/xóa (CRUD) món ăn và quản lý tin nhắn liên hệ.
- [ ] Tính năng tìm kiếm, lọc món ăn theo danh mục và mức giá.
- [ ] Chức năng giỏ hàng và đặt bàn / đặt món online.
