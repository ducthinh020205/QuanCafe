# Đức Thịnh Coffee - Quán Café Web Application

Dự án website giới thiệu thực đơn cho quán café/quán ăn nhỏ mang thương hiệu **Đức Thịnh Coffee**, xây dựng bằng **ASP.NET Core MVC** (.NET 10), **Entity Framework Core** và cơ sở dữ liệu **SQLite**.

Đây là sản phẩm Tuần 1 trong chuỗi mục tiêu *"mỗi tuần một trang web ASP.NET"*.

---

## 🔗 Demo
*(Sẽ cập nhật sau khi deploy)*

## 📸 Ảnh chụp màn hình
*(Sẽ bổ sung ảnh trang chủ, thực đơn và trang giới thiệu)*

---

## 📌 Tính năng

### Đã hoàn thành (Đã có)
- **Trang chủ (Home):** Giới thiệu tổng quan về quán cà phê.
- **Trang Giới thiệu (Giới Thiệu - `/Home/GioiThieu`):** Giới thiệu chi tiết về thương hiệu Đức Thịnh Coffee, không gian quán, hương vị cà phê chuẩn gu truyền thống và thực đơn phong phú.
- **Thực đơn (Menu):** Hiển thị danh sách món ăn, thức uống được phân loại theo từng nhóm (Đồ ăn nhanh, Đồ nước, Thức uống), kèm giá bán và mô tả.
- **Cơ sở dữ liệu (Database):**
  - Sử dụng Entity Framework Core theo hướng Code-First với SQLite.
  - Dữ liệu mẫu (Seed Data) về món ăn được nạp tự động qua migration (`HasData`).
- **Model liên hệ (LienHe):** Đã thiết kế cấu trúc dữ liệu tiếp nhận thông tin phản hồi từ khách hàng (Họ tên, Số điện thoại, Nội dung, Ngày gửi).

### Đang phát triển (Tuần 1)
- [ ] Trang Giới thiệu (giới thiệu thương hiệu, phong cách quán và điểm nổi bật).
- [ ] Bổ sung thêm món ăn mẫu, phân chia danh mục chi tiết hơn.
- [ ] Form liên hệ gửi thông tin trực tiếp vào bảng `LienHe` (có validation dữ liệu nhập).
- [ ] Trang admin đơn giản để xem và quản lý các liên hệ.
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
│   ├── HomeController.cs        # Trang chủ, Giới thiệu, Privacy và xử lý lỗi
│   └── MenuController.cs        # Truy vấn và hiển thị danh sách thực đơn
├── Data/
│   └── AppDbContext.cs          # DbContext, cấu hình bảng và dữ liệu mẫu cho MonAn
├── Migrations/                  # Lịch sử migration của EF Core
├── Models/
│   ├── MonAn.cs                 # Thông tin món (Tên, Giá, Mô tả, Ảnh, Nhóm)
│   ├── LienHe.cs                # Thông tin liên hệ của khách hàng
│   └── ErrorViewModel.cs        # Model hiển thị lỗi
├── Views/
│   ├── Home/                    # Trang chủ (Index), Giới thiệu (GioiThieu), Privacy
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

Sau khi chạy, truy cập đường dẫn hiện trên terminal (cổng cấu hình trong Properties/launchSettings.json).

---

## 🧭 Các trang chính

| Đường dẫn | Controller / Action | Mô tả |
| :--- | :--- | :--- |
| `/` hoặc `/Home/Index` | `HomeController.Index` | Trang chủ Đức Thịnh Coffee |
| `/Home/GioiThieu` | `HomeController.GioiThieu` | Trang giới thiệu về quán |
| `/Menu` | `MenuController.Index` | Danh sách thực đơn món ăn & thức uống |
| `/Home/Privacy` | `HomeController.Privacy` | Chính sách bảo mật |

---

## 📝 Nhật ký cập nhật (Changelog)

### [20/11/2026]
- **Thêm trang Giới Thiệu:** Tạo Action `GioiThieu()` trong `HomeController.cs` và view `Views/Home/GioiThieu.cshtml` với giao diện Bootstrap 5 hiện đại, giới thiệu câu chuyện thương hiệu, hương vị cà phê và thực đơn.
- **Cập nhật thanh điều hướng:** Thêm liên kết dẫn tới trang Giới Thiệu trên Navbar chung (`_Layout.cshtml`).
- **Cập nhật tài liệu dự án:** Hoàn thiện và cập nhật `README.md`.

---

## 👤 Tác giả

**Mã Đức Thịnh** - GitHub: [@ducthinh020205](https://github.com/ducthinh020205)
