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
- **Thực đơn (Menu - `/Menu`):** 
  - Phân nhóm món trực quan bằng `GroupBy` (Đồ ăn nhanh, Đồ nước, Thức uống).
  - Trình bày dạng lưới thẻ Card Bootstrap 5 đẹp mắt, responsive trên mọi kích thước màn hình.
  - Giá món được làm nổi bật với màu sắc chủ đạo.
- **Form Liên hệ (`/LienHe`):** Khách hàng có thể gửi tin nhắn/phản hồi trực tiếp (Họ tên, Số điện thoại, Nội dung). Có kiểm tra tính hợp lệ (Validation) và hiển thị thông báo thành công.
- **Trang Quản trị Liên hệ (`/Admin/LienHe`):** Dành cho admin xem danh sách các tin nhắn gửi đến (sắp xếp mới nhất lên đầu) và hỗ trợ xóa tin nhắn với hộp thoại xác nhận.
- **Giao diện & Trải nghiệm (UI/UX):**
  - Tông màu nhận diện thương hiệu quán café ấm áp: nâu cà phê (`#6f4e37`), màu nền kem dịu mắt (`#faf6f1`).
  - Tích hợp font chữ tiếng Việt hiện đại Google Fonts (`Be Vietnam Pro`).
  - Thanh điều hướng (Navbar) chuyên nghiệp với đầy đủ liên kết tới các trang và lối tắt vào trang Admin.
- **Cơ sở dữ liệu (Database):**
  - Sử dụng Entity Framework Core theo hướng Code-First với SQLite.
  - Dữ liệu mẫu (Seed Data) về món ăn được nạp tự động qua migration (`HasData`).
  - Lưu trữ tin nhắn liên hệ vào bảng `LienHes`.

### Đang phát triển (Tuần 1)
- [x] Trang Giới thiệu (giới thiệu thương hiệu, phong cách quán và điểm nổi bật).
- [x] Form liên hệ gửi thông tin trực tiếp vào bảng `LienHe` (có validation dữ liệu nhập).
- [x] Trang admin đơn giản để xem và quản lý/xóa các liên hệ.
- [x] Đồng bộ thanh điều hướng (Navbar) liên kết tới đầy đủ các trang: Trang chủ, Thực đơn, Giới thiệu, Liên hệ, Admin.
- [x] Nâng cấp giao diện với Bootstrap 5, font chữ `Be Vietnam Pro` và bảng màu cà phê riêng.
- [ ] Bổ sung thêm món ăn mẫu, phân chia danh mục chi tiết hơn.
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
- **Giao diện / Frontend:** HTML5, CSS3, Razor Views, [Bootstrap 5](https://getbootstrap.com/), [jQuery](https://jquery.com/), [Google Fonts](https://fonts.google.com/specimen/Be+Vietnam+Pro) (`Be Vietnam Pro`)

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
│   ├── Menu/                    # Trang danh sách thực đơn (dạng Card theo nhóm)
│   └── Shared/                  # Layout chung (_Layout.cshtml), trang lỗi
├── wwwroot/                     # Tài nguyên tĩnh (CSS tùy biến tông màu café, JS, Bootstrap, jQuery)
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
| `/Menu` | `MenuController.Index` | Danh sách thực đơn món ăn & thức uống (theo nhóm) |
| `/LienHe` | `LienHeController.Index` | Form gửi phản hồi / tin nhắn liên hệ |
| `/Admin/LienHe` | `AdminController.LienHe` | Trang quản trị xem và xóa tin nhắn liên hệ |
| `/Home/Privacy` | `HomeController.Privacy` | Chính sách bảo mật |

---

## 📝 Nhật ký cập nhật (Changelog)

### [21/11/2026]
- **Nâng cấp giao diện (UI/UX) toàn diện:**
  - Tích hợp font chữ tiếng Việt `Be Vietnam Pro` từ Google Fonts.
  - Tùy biến bộ màu phong cách cà phê với CSS Variables: nâu cà phê (`#6f4e37`), nền kem (`#faf6f1`), chữ nâu sẫm (`#3e2f26`).
  - Tái thiết kế trang **Thực đơn** (`/Menu`): Hiển thị món dạng thẻ Card theo từng nhóm danh mục bằng `GroupBy`, giao diện responsive theo thiết bị.
  - Cải tiến thanh điều hướng (**Navbar**): Đổi sang màu nâu café (`navbar-dark`), cập nhật đầy đủ liên kết: *Trang chủ*, *Thực đơn*, *Giới thiệu*, *Liên hệ* và nút *Admin* riêng biệt.
- **Thêm Form Liên Hệ:**
  - Tạo [LienHeController.cs](file:///d:/Desktop/My_project_web/QuanCafe/Controllers/LienHeController.cs) tiếp nhận dữ liệu khách hàng gửi.
  - Tạo giao diện [Views/LienHe/Index.cshtml](file:///d:/Desktop/My_project_web/QuanCafe/Views/LienHe/Index.cshtml) có validation trường nhập và thông báo gửi thành công.
- **Thêm Trang Quản trị Liên Hệ:**
  - Tạo [AdminController.cs](file:///d:/Desktop/My_project_web/QuanCafe/Controllers/AdminController.cs) với chức năng hiển thị danh sách và xóa tin nhắn (`XoaLienHe`).
  - Tạo giao diện [Views/Admin/LienHe.cshtml](file:///d:/Desktop/My_project_web/QuanCafe/Views/Admin/LienHe.cshtml) dạng bảng dữ liệu kèm nút xác nhận xóa.

### [20/11/2026]
- **Thêm trang Giới Thiệu:** Tạo Action `GioiThieu()` trong `HomeController.cs` và view `Views/Home/GioiThieu.cshtml` với giao diện Bootstrap 5 giới thiệu thương hiệu, hương vị cà phê và thực đơn.
- **Cập nhật thanh điều hướng:** Thêm liên kết dẫn tới trang Giới Thiệu trên Navbar (`_Layout.cshtml`).

---

## 👤 Tác giả

**Mã Đức Thịnh** - GitHub: [@ducthinh020205](https://github.com/ducthinh020205)
