using System;

namespace QuanLyCuaHangThuCung
{
    abstract class Thu
    {
        int maThu, loaiThu, donGia;
        string tenThu, nguonGoc;
        int SoLuong;
        public int getSoLuong() { return SoLuong; }
        public void setSoLuong(int SoLuong) { this.SoLuong = SoLuong; }
        /* 1 - Meo
         * 2 - Cho
         * 3 - Chim
         */
        public int getDonGia() { return donGia; }
        public void setDonGia(int donGia) { this.donGia = donGia; }
        public int getMaThu() { return maThu; }
        public void setMaThu(int maThu) { this.maThu = maThu; }
        public string getTenThu() { return tenThu; }
        public void setTenThu(string tenThu) { this.tenThu = tenThu; }
        public string getNguonGoc() { return nguonGoc; }
        public void setNguonGoc(string nguonGoc) { this.nguonGoc = nguonGoc; }
        public int getLoaiThu() { return loaiThu; }
        public void setLoaiThu(int loaiThu) { this.loaiThu = loaiThu; }
        public virtual void NhapThongTin() 
        {
            Console.WriteLine("Nhap Ma Thu: ");
            maThu = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Ten Thu: ");
            tenThu = Console.ReadLine();
            Console.WriteLine("Nhap Nguon Goc: ");
            nguonGoc = Console.ReadLine();
            Console.WriteLine("Nhap Don gia");
            donGia = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhaop So Luong");
            SoLuong = int.Parse(Console.ReadLine());
        } //Nhap Cac Thuoc Tinh
        public virtual void XuatThongTin() 
        {
            Console.WriteLine(" Ma Thu: " + maThu);
            Console.WriteLine(" Ten Thu: " + tenThu);
            Console.WriteLine(" Nguon Goc: " + nguonGoc);
            Console.WriteLine(" Don gia" + donGia);
            Console.WriteLine(" So Luong" + SoLuong);
        } //Xuat Cac Thuoc Tinh
        public abstract void tiengKeu();
        public abstract void thucAn();
    }
}
