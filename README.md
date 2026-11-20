Đức Thịnh Coffee - Quán Café Web Application

Dự án website giới thiệu thực đơn cho quán café/quán ăn nhỏ mang thương hiệu Đức Thịnh Coffee, xây dựng bằng ASP.NET Core MVC (.NET 10), Entity Framework Core và cơ sở dữ liệu SQLite.

Đây là sản phẩm Tuần 1 trong chuỗi mục tiêu "mỗi tuần một trang web ASP.NET".

🔗 Demo: (sẽ cập nhật sau khi deploy)

📸 Ảnh chụp màn hình

(sẽ bổ sung ảnh trang chủ và trang thực đơn)

📌 Tính năng
Đã có
Trang chủ (Home): Giới thiệu thông tin quán.
Thực đơn (Menu): Hiển thị danh sách món ăn, thức uống được phân loại theo nhóm, kèm tên, giá bán và mô tả.
Cơ sở dữ liệu:
Entity Framework Core theo hướng Code-First.
Dữ liệu mẫu về món ăn được nạp qua migration (HasData), có hiệu lực khi chạy dotnet ef database update.
Model liên hệ (LienHe): Đã thiết kế cấu trúc dữ liệu (Họ tên, Số điện thoại, Nội dung, Ngày gửi).
Đang làm (Tuần 1)
[ ] Bổ sung thêm món ăn mẫu, chia nhóm rõ ràng.
[ ] Trang Giới thiệu (thông tin quán, giờ mở cửa, địa chỉ).
[ ] Form liên hệ gửi thông tin vào bảng LienHe, có kiểm tra dữ liệu nhập.
[ ] Trang admin đơn giản để xem và xoá các liên hệ.
[ ] Làm đẹp giao diện bằng Bootstrap, kiểm tra trên điện thoại.
[ ] Deploy và cập nhật link demo.
Hướng phát triển sau
[ ] Đăng nhập và phân quyền cho trang quản trị.
[ ] CRUD món ăn để chỉnh sửa thực đơn trực tiếp trên web.
[ ] Tìm kiếm, lọc món theo nhóm và mức giá.
🛠 Công nghệ sử dụng
Framework: .NET 10.0 (ASP.NET Core Web App - MVC)
ORM: Entity Framework Core 10
Cơ sở dữ liệu: SQLite (file quancafe.db)
Giao diện: HTML5, CSS3, Razor Views, Bootstrap 5, jQuery
📂 Cấu trúc thư mục
text
QuanCafe/
├── Controllers/
│   ├── HomeController.cs        # Trang chủ, chính sách và xử lý lỗi
│   └── MenuController.cs        # Truy vấn và hiển thị danh sách thực đơn
├── Data/
│   └── AppDbContext.cs          # DbContext, cấu hình bảng và dữ liệu mẫu cho MonAn
├── Migrations/                  # Lịch sử migration của EF Core
├── Models/
│   ├── MonAn.cs                 # Thông tin món (Tên, Giá, Mô tả, Ảnh, Nhóm)
│   ├── LienHe.cs                # Thông tin liên hệ của khách
│   └── ErrorViewModel.cs        # Model hiển thị lỗi
├── Views/
│   ├── Home/                    # Trang chủ, Privacy
│   ├── Menu/                    # Trang thực đơn
│   └── Shared/                  # Layout chung (_Layout.cshtml), trang lỗi
├── wwwroot/                     # Tài nguyên tĩnh (CSS, JS, Bootstrap, jQuery)
├── .config/dotnet-tools.json    # Công cụ dotnet của dự án (CSharpier)
├── appsettings.json             # Chuỗi kết nối CSDL và cấu hình log
├── Program.cs                   # Đăng ký dịch vụ (DI) và middleware
└── QuanCafe.csproj              # Cấu hình project và các gói NuGet
🚀 Cài đặt và chạy
1. Yêu cầu
Đã cài .NET 10 SDK.
Công cụ EF Core CLI:
bash
dotnet tool install --global dotnet-ef
2. Cài các gói phụ thuộc

Mở terminal tại thư mục gốc của dự án và chạy:

bash
dotnet restore
dotnet tool restore
3. Tạo hoặc cập nhật cơ sở dữ liệu
bash
dotnet ef database update

Lệnh này tạo file quancafe.db và nạp dữ liệu mẫu.

4. Chạy ứng dụng
bash
dotnet run

Hoặc chạy ở chế độ tự làm mới khi sửa code:

bash
dotnet watch

Sau khi chạy, mở trình duyệt và truy cập đường dẫn hiện trong terminal (cổng cụ thể được cấu hình trong Properties/launchSettings.json).

🧭 Các trang chính
Đường dẫn	Controller / Action	Mô tả
/ hoặc /Home/Index	HomeController.Index	Trang chủ
/Menu	MenuController.Index	Danh sách thực đơn
/Home/Privacy	HomeController.Privacy	Chính sách bảo mật

Bảng này sẽ được cập nhật khi thêm trang Giới thiệu, Liên hệ và trang admin.

👤 Tác giả

Mã Đức Thịnh - GitHub: @ducthinh020205