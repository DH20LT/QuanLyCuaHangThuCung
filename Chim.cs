using System;

namespace QuanLyCuaHangThuCung
{
    class Chim : Thu
    {
        int tuoiThoChim;
        string loaiChim;

        public string getLoaiChim() { return loaiChim; }
        public void setLoaiChim(string loaiChim) { this.loaiChim = loaiChim; }
        public int getTuoiThoChim() { return tuoiThoChim; }
        public void setTuoiThoChim(int tuoiThoChim) { this.tuoiThoChim = tuoiThoChim; }
        public Chim()
        {
            this.setMaThu(0);
            this.setLoaiThu(3);
            this.setTenThu(" ");
            this.setNguonGoc(" ");
            this.setDonGia(0);
            this.setLoaiChim(" ");
        }
        public Chim(int maThu, string tenThu, string nguonGoc, int donGia, string loaiChim, int soLuong)
        {
            this.setLoaiThu(3);
            this.setMaThu(maThu);
            this.setTenThu(tenThu);
            this.setNguonGoc(nguonGoc);
            this.setDonGia(donGia);
            this.setSoLuong(soLuong);
            this.setLoaiChim(loaiChim);
        }
        public override void tiengKeu()
        {
            Console.WriteLine("Chi chi");
        }
        public override void thucAn()
        {
            Console.WriteLine("Ngu coc");
        }
        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.WriteLine("Nhap Loai Chim: ");

            loaiChim = Console.ReadLine();
            Console.WriteLine("Nhap Tuoi Tho Chim: ");
            tuoiThoChim = int.Parse(Console.ReadLine());
        }
        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine("Loai Chim: " + loaiChim);
            Console.WriteLine("Tuoi Tho Chim: " + tuoiThoChim);
        }
    }
}
