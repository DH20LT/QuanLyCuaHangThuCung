using System;

namespace QuanLyCuaHangThuCung
{
    class Cho : Thu
    {
        int kichThuocLong;
        public int getKichThuocLong() { return kichThuocLong; }
        public void setKichThuocLong(int kichThuocLong) { this.kichThuocLong = kichThuocLong; }
        public Cho()
        {
            this.setMaThu(0);
            this.setLoaiThu(2);
            this.setTenThu(" ");
            this.setNguonGoc("");
            this.setDonGia(0);
            this.setSoLuong(0);
            this.setKichThuocLong(0);
        }
        public Cho(int maThu, string tenThu, string nguonGoc, int donGia, int kichThuocLong, int soLuong)
        {
            this.setLoaiThu(2);
            this.setMaThu(maThu);
            this.setTenThu(tenThu);
            this.setNguonGoc(nguonGoc);
            this.setDonGia(donGia);
            this.setSoLuong(soLuong);
            this.setKichThuocLong(kichThuocLong);
        }
        public override void tiengKeu()
        {
            Console.WriteLine("Gau Gau");
        }
        public override void thucAn()
        {
            Console.WriteLine("Xuong");
        }
        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.WriteLine("Nhap Kich Thuoc Long: ");
            kichThuocLong = int.Parse(Console.ReadLine());
        }
        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine("Kich Thuoc Long: " + kichThuocLong);
        }
    }
}
