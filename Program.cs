using System;

namespace QuanLyCuaHangThuCung
{
    
    abstract class Thu
    {
        int maThu, loaiThu, donGia;
        string tenThu, nguonGoc;
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
            Console.WriteLine("Nhao Don gia");
            donGia = int.Parse(Console.ReadLine());
        } //Nhap Cac Thuoc Tinh
        public virtual void XuatThongTin() 
        {
            Console.WriteLine(" Ma Thu: " + maThu);
            Console.WriteLine(" Ten Thu: " + tenThu);
            Console.WriteLine(" Nguon Goc: " + nguonGoc);
            Console.WriteLine(" Don gia" + donGia);
        } //Xuat Cac Thuoc Tinh
        public abstract void tiengKeu();
        public abstract void thucAn();
    }
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
            giongMeo = "";
        }
        public Meo(int maThu, string tenThu, string nguonGoc, int donGia, string giongMeo)
        {
            this.setLoaiThu(1);
            this.setMaThu(maThu);
            this.setTenThu(tenThu);
            this.setNguonGoc(nguonGoc);
            this.setDonGia(donGia);
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
            this.setKichThuocLong(0);
        }
        public Cho(int maThu, string tenThu, string nguonGoc, int donGia, int kichThuocLong)
        {
            this.setLoaiThu(2);
            this.setMaThu(maThu);
            this.setTenThu(tenThu);
            this.setNguonGoc(nguonGoc);
            this.setDonGia(donGia);
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
        public Chim(int maThu, string tenThu, string nguonGoc, int donGia, string loaiChim)
        {
            this.setLoaiThu(3);
            this.setMaThu(maThu);
            this.setTenThu(tenThu);
            this.setNguonGoc(nguonGoc);
            this.setDonGia(donGia);
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
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Thu[] arrThu = new Thu[50];
            
            int iChucNang;
            Console.WriteLine("1. Create a Cat object");
            Console.WriteLine("2. Create a Dog object");
            Console.WriteLine("3. Create a Bird object");
            Console.WriteLine("4. Show all Cat");
            Console.WriteLine("5. Xuat Tat ca Cho");
            Console.WriteLine("6. Xuat Tat ca Chim");
            Console.WriteLine("7. Xuat tat ca cac Thu Cung");
            Console.WriteLine("8. Xuat nhung con Chim voi tuoi tho lon hon 10 nam");
            Console.WriteLine("9. Xuat Meo My");
            Console.WriteLine("10. Sap Xep Tat ca Thu cung theo Don gia Tang Dan");
            Console.WriteLine("11. Xuat thong tin cua cac Loai Chim theo So Luong Giam Dan");
            Console.WriteLine("12. Exit");
            Console.WriteLine("Chon Chuc Nang");
            iChucNang = int.Parse(Console.ReadLine());
            if (iChucNang >= 13 || iChucNang <= 0)
                Console.WriteLine("Wrong Function, Try Again!");
            do
            {
                Play(iChucNang, arrThu);
            } while (iChucNang < 12);
        }
        static void XuatChim10Nam(Chim chim)
        {
            if (chim.getTuoiThoChim() > 10)
            {
                chim.XuatThongTin();
            }
        }
        static void XuatMeoMy(Meo meo)
        {
            if(meo.getGiongMeo().Equals("My"))
            {
                meo.XuatThongTin();
            }
        }
        static void SapXepDonGiaTangDan(Thu[] thu, int index)
        {
            Thu[] arrThu = thu;
            for (int i = 1; i < index; i++)
            {
                for (int j = 1; j < index - 1; j++)
                {
                    if (arrThu[j].getDonGia() > arrThu[j + 1].getDonGia())
                    {
                        Thu tam = arrThu[j + 1];
                        arrThu[j + 1] = arrThu[j];
                        arrThu[j] = tam;
                    }
                }
            }
            for (int i = 1; i < index; i++)
            {
                arrThu[i].XuatThongTin();
            }
        }
        static void Play(int iChucNang, Thu[] arrThu)
        {
            int iThuSoLuong = 0;
            switch (iChucNang)
            {
                case 1: // Tao Meo
                    {
                        arrThu[iThuSoLuong] = new Meo();
                        arrThu[iThuSoLuong].NhapThongTin();
                        iThuSoLuong++;
                        break;
                    }
                case 2: // Tap Cho
                    {
                        arrThu[iThuSoLuong] = new Cho();
                        arrThu[iThuSoLuong].NhapThongTin();
                        iThuSoLuong++;
                        break;
                    }
                case 3: // Tao Chim
                    {
                        arrThu[iThuSoLuong] = new Chim();
                        arrThu[iThuSoLuong].NhapThongTin();
                        iThuSoLuong++;
                        break;
                    }
                case 4: // Xuat Meo
                    {
                        for (int iThuTu = 0; iThuTu < iThuSoLuong; iThuTu++)
                        {
                            if (arrThu[iThuTu].getLoaiThu() == 1)
                            {
                                arrThu[iThuTu].XuatThongTin();
                            }
                        }
                        break;
                    }
                case 5: // Xuat Cho
                    {
                        for (int iThuTu = 0; iThuTu < iThuSoLuong; iThuTu++)
                        {
                            if (arrThu[iThuTu].getLoaiThu() == 2)
                            {
                                arrThu[iThuTu].XuatThongTin();
                            }
                        }
                        break;
                    }
                case 6: // Xuat Chim
                    {
                        for (int iThuTu = 0; iThuTu < iThuSoLuong; iThuTu++)
                        {
                            if (arrThu[iThuTu].getLoaiThu() == 3)
                            {
                                arrThu[iThuTu].XuatThongTin();
                            }
                        }
                        break;
                    }
                case 7: // Xuat Tat Ca Doi Tuong
                    {
                        for (int iThuTu = 0; iThuTu < iThuSoLuong; iThuTu++)
                        {
                            arrThu[iThuTu].XuatThongTin();
                        }
                        break;
                    }
                case 8: // Xuat nhung con Chim voi tuoi tho lon hon 10
                    {
                        for (int iThuTu = 0; iThuTu < iThuSoLuong; iThuTu++)
                        {
                            if (arrThu[iThuTu].getLoaiThu() == 3)
                            {
                                XuatChim10Nam((Chim)arrThu[iThuTu]);
                            }
                        }
                        break;
                    }
                case 9: // Xuat Meo My
                    {
                        for (int iThuTu = 0; iThuTu < iThuSoLuong; iThuTu++)
                        {
                            if (arrThu[iThuTu].getLoaiThu() == 1)
                            {
                                XuatMeoMy((Meo)arrThu[iThuTu]);
                            }
                        }
                        break;
                    }
                case 10: // Sap Xep Tat ca Thu cung theo Thu tu Tang Dan
                    {
                        SapXepDonGiaTangDan(arrThu, iThuSoLuong);
                        break;
                    }
                case 11: //
                default:
                    break;
            }
        }
    }
}
