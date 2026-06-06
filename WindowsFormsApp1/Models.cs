namespace WindowsFormsApp1
{
    public class NguoiDung
    {
        public int MaND { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string NhomQuyen { get; set; }  // Sale | Kế toán | Quản lý
        public string TrangThai { get; set; }  // Đang hoạt động | Đã khóa
        public string NgayTao { get; set; }
    }

    public class Phong
    {
        public string MaPhong { get; set; }
        public string ChiNhanh { get; set; }
        public string KhuVuc { get; set; }    // Nam | Nữ | Hỗn hợp
        public string LoaiPhong { get; set; } // Nguyên căn | Ghép
        public int SucChua { get; set; }
        public decimal GiaThue { get; set; }  // giá/giường/tháng
        public string TienNghi { get; set; }
        public string TrangThai { get; set; } // Trống | Đã đặt cọc | Đang ở | Bảo trì
    }

    public class Giuong
    {
        public string MaGiuong { get; set; }
        public string MaPhong { get; set; }
        public string ViTri { get; set; }     // Tầng dưới | Tầng trên
        public string TrangThai { get; set; }
        public string GhiChu { get; set; }
    }
}
