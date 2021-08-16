using System;

namespace QuanLyCuaHangThuCung
{
    class Meo : Thu
    {
        string giongMeo; //AnDo, My, TayBanNha, Anh
        public Meo()
        {
            this.setMaThu(0);
            this.setLoaiThu(1);
            this.setTenThu(" ");
            this.setNguonGoc("");
            this.setDonGia(0);
            this.setSoLuong(0);
            giongMeo = "";
        }
        public Meo(int maThu, string tenThu, string nguonGoc, int donGia, string giongMeo, int soLuong)
        {
            this.setLoaiThu(1);
            this.setMaThu(maThu);
            this.setTenThu(tenThu);
            this.setNguonGoc(nguonGoc);
            this.setDonGia(donGia);
            this.setSoLuong(soLuong);
            this.giongMeo = giongMeo;
        }
        public string getGiongMeo() { return giongMeo; }
        public void setGiongMeo(string giongMeo) { this.giongMeo = giongMeo; }
        public override void tiengKeu()
        {
            Console.WriteLine("Meo Meo");
        }
        public override void thucAn()
        {
            Console.WriteLine("Chuot");
        }
        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.WriteLine("Nhap Giong Meo: ");
            giongMeo = Console.ReadLine();
        }
        public override void XuatThongTin() 
        {
            base.XuatThongTin();
            Console.WriteLine("Giong Meo" + giongMeo);
        }
    }
}
