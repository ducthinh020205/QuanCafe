# Đức Thịnh Coffee - Quán Café Web Application

Dự án website giới thiệu thực đơn cho quán café/quán ăn nhỏ mang thương hiệu **Đức Thịnh Coffee**, xây dựng bằng **ASP.NET Core MVC** (.NET 10), **Entity Framework Core** và cơ sở dữ liệu **SQLite**.

Đây là sản phẩm Tuần 1 trong chuỗi mục tiêu *"mỗi tuần một trang web ASP.NET"*.

---

## 🔗 Demo
*(Sẽ cập nhật sau khi deploy)*

## 📸 Ảnh chụp màn hình
*(Sẽ bổ sung ảnh trang chủ, thực đơn, liên hệ và trang admin)*

---

## 📌 Tính năng

### Đã hoàn thành (Đã có)
- **Trang chủ (Home):** Giới thiệu tổng quan về quán cà phê.
- **Trang Giới thiệu (Giới Thiệu - `/Home/GioiThieu`):** Giới thiệu chi tiết về thương hiệu Đức Thịnh Coffee, không gian quán, hương vị cà phê chuẩn gu truyền thống và thực đơn phong phú.
- **Thực đơn (Menu):** Hiển thị danh sách món ăn, thức uống được phân loại theo từng nhóm (Đồ ăn nhanh, Đồ nước, Thức uống), kèm giá bán và mô tả chi tiết.
- **Form Liên hệ (`/LienHe`):** Khách hàng có thể gửi tin nhắn/phản hồi trực tiếp (Họ tên, Số điện thoại, Nội dung). Có kiểm tra tính hợp lệ (Validation) và hiển thị thông báo thành công.
- **Trang Quản trị Liên hệ (`/Admin/LienHe`):** Dành cho admin xem danh sách các tin nhắn gửi đến (sắp xếp mới nhất lên đầu) và hỗ trợ xóa tin nhắn với hộp thoại xác nhận.
- **Cơ sở dữ liệu (Database):**
  - Sử dụng Entity Framework Core theo hướng Code-First với SQLite.
  - Dữ liệu mẫu (Seed Data) về món ăn được nạp tự động qua migration (`HasData`).
  - Lưu trữ tin nhắn liên hệ vào bảng `LienHes`.

### Đang phát triển (Tuần 1)
- [x] Trang Giới thiệu (giới thiệu thương hiệu, phong cách quán và điểm nổi bật).
- [x] Form liên hệ gửi thông tin trực tiếp vào bảng `LienHe` (có validation dữ liệu nhập).
- [x] Trang admin đơn giản để xem và quản lý/xóa các liên hệ.
- [ ] Bổ sung thêm món ăn mẫu, phân chia danh mục chi tiết hơn.
- [ ] Gắn thêm nút/link trang Liên Hệ vào thanh điều hướng (Navbar).
- [ ] Tối ưu giao diện Responsive với Bootstrap 5 trên thiết bị di động.
- [ ] Triển khai (Deploy) và cập nhật đường dẫn demo.

### Hướng phát triển tiếp theo
- [ ] Hệ thống đăng nhập và phân quyền cho quản trị viên (Admin).
- [ ] Quản lý CRUD món ăn trực tiếp trên giao diện quản trị.
- [ ] Bộ lọc và tìm kiếm món ăn theo khoảng giá và danh mục.

---

## 🛠 Công nghệ sử dụng

- **Framework:** [.NET 10.0](https://dotnet.microsoft.com/) (ASP.NET Core MVC)
- **ORM:** Entity Framework Core 10
- **Cơ sở dữ liệu:** SQLite (file `quancafe.db`)
- **Giao diện / Frontend:** HTML5, CSS3, Razor Views, [Bootstrap 5](https://getbootstrap.com/), [jQuery](https://jquery.com/)

---

## 📂 Cấu trúc thư mục

```text
QuanCafe/
├── Controllers/
│   ├── AdminController.cs       # Quản lý xem và xóa tin nhắn liên hệ
│   ├── HomeController.cs        # Trang chủ, Giới thiệu, Privacy và xử lý lỗi
│   ├── LienHeController.cs      # Xử lý nhận phản hồi/tin nhắn liên hệ từ khách
│   └── MenuController.cs        # Truy vấn và hiển thị danh sách thực đơn
├── Data/
│   └── AppDbContext.cs          # DbContext, cấu hình bảng và dữ liệu mẫu cho MonAn
├── Migrations/                  # Lịch sử migration của EF Core
├── Models/
│   ├── MonAn.cs                 # Thông tin món (Tên, Giá, Mô tả, Ảnh, Nhóm)
│   ├── LienHe.cs                # Thông tin liên hệ của khách hàng
│   └── ErrorViewModel.cs        # Model hiển thị lỗi
├── Views/
│   ├── Admin/                   # Giao diện quản trị (Xem & xóa tin nhắn liên hệ)
│   ├── Home/                    # Trang chủ (Index), Giới thiệu (GioiThieu), Privacy
│   ├── LienHe/                  # Giao diện form liên hệ cho khách hàng
│   ├── Menu/                    # Trang danh sách thực đơn
│   └── Shared/                  # Layout chung (_Layout.cshtml), trang lỗi
├── wwwroot/                     # Tài nguyên tĩnh (CSS, JS, Bootstrap, jQuery)
├── appsettings.json             # Chuỗi kết nối CSDL và cấu hình Logging
├── Program.cs                   # Đăng ký dịch vụ (DI) và Middleware pipeline
└── QuanCafe.csproj              # Cấu hình project và các gói NuGet
```

---

## 🚀 Cài đặt và khởi chạy

### 1. Yêu cầu hệ thống
- Đã cài đặt [.NET 10 SDK](https://dotnet.microsoft.com/download).
- Công cụ EF Core CLI:
  ```bash
  dotnet tool install --global dotnet-ef
  ```

### 2. Cài đặt các gói phụ thuộc
Mở terminal tại thư mục gốc của dự án và chạy:
```bash
dotnet restore
```

### 3. Cập nhật cơ sở dữ liệu
Chạy migration để khởi tạo file `quancafe.db` và nạp dữ liệu mẫu:
```bash
dotnet ef database update
```

### 4. Khởi chạy ứng dụng
Chạy ứng dụng:
```bash
dotnet run
```
Hoặc chạy ở chế độ Hot-Reload:
```bash
dotnet watch
```

Sau khi chạy, truy cập đường dẫn xuất hiện trên terminal (mặc định tại `https://localhost:5001` hoặc `http://localhost:5000`).

---

## 🧭 Các trang chính

| Đường dẫn | Controller / Action | Mô tả |
| :--- | :--- | :--- |
| `/` hoặc `/Home/Index` | `HomeController.Index` | Trang chủ Đức Thịnh Coffee |
| `/Home/GioiThieu` | `HomeController.GioiThieu` | Trang giới thiệu về quán |
| `/Menu` | `MenuController.Index` | Danh sách thực đơn món ăn & thức uống |
| `/LienHe` | `LienHeController.Index` | Form gửi phản hồi / tin nhắn liên hệ |
| `/Admin/LienHe` | `AdminController.LienHe` | Trang quản trị xem và xóa tin nhắn liên hệ |
| `/Home/Privacy` | `HomeController.Privacy` | Chính sách bảo mật |

---

## 📝 Nhật ký cập nhật (Changelog)

### [21/11/2026]
- **Thêm Form Liên Hệ:**
  - Tạo [LienHeController.cs](file:///d:/Desktop/My_project_web/QuanCafe/Controllers/LienHeController.cs) tiếp nhận dữ liệu khách hàng gửi.
  - Tạo giao diện [Views/LienHe/Index.cshtml](file:///d:/Desktop/My_project_web/QuanCafe/Views/LienHe/Index.cshtml) có validation trường nhập và thông báo gửi thành công.
- **Thêm Trang Quản trị Liên Hệ:**
  - Tạo [AdminController.cs](file:///d:/Desktop/My_project_web/QuanCafe/Controllers/AdminController.cs) với chức năng hiển thị danh sách và xóa tin nhắn (`XoaLienHe`).
  - Tạo giao diện [Views/Admin/LienHe.cshtml](file:///d:/Desktop/My_project_web/QuanCafe/Views/Admin/LienHe.cshtml) dạng bảng dữ liệu kèm nút xác nhận xóa.
- **Cập nhật README.md:** Đồng bộ tính năng, cấu trúc thư mục và danh sách các trang.

### [20/11/2026]
- **Thêm trang Giới Thiệu:** Tạo Action `GioiThieu()` trong `HomeController.cs` và view `Views/Home/GioiThieu.cshtml` với giao diện Bootstrap 5 giới thiệu thương hiệu, hương vị cà phê và thực đơn.
- **Cập nhật thanh điều hướng:** Thêm liên kết dẫn tới trang Giới Thiệu trên Navbar (`_Layout.cshtml`).

---

## 👤 Tác giả

**Mã Đức Thịnh** - GitHub: [@ducthinh020205](https://github.com/ducthinh020205)
