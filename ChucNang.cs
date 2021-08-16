using System;

namespace QuanLyCuaHangThuCung
{
    class ChucNang
    {
        static void XuatChim10Nam(Chim chim)
        {
            if (chim.getTuoiThoChim() > 10)
            {
                chim.XuatThongTin();
            }
        }
        static void XuatMeoMy(Meo meo)
        {
            if (meo.getGiongMeo().Equals("My"))
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

        static void SapXepSoLuongGiamDan(Thu[] thu, int index)
        {
            Thu[] arrThu = thu;

        }
        public static void Play(int iChucNang, Thu[] arrThu)
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
                        Console.ReadKey();
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
                        Console.ReadKey();
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
                        Console.ReadKey();
                        break;
                    }
                case 7: // Xuat Tat Ca Doi Tuong
                    {
                        for (int iThuTu = 0; iThuTu < iThuSoLuong; iThuTu++)
                        {
                            arrThu[iThuTu].XuatThongTin();
                        }
                        Console.ReadKey();
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
                        Console.ReadKey();
                        break;
                    }
                case 10: // Sap Xep Tat ca Thu cung theo Thu tu Tang Dan
                    {
                        SapXepDonGiaTangDan(arrThu, iThuSoLuong);
                        break;
                    }
                case 11: //Xuat thong tin cua cac Loai Chim theo So Luong Giam Dan
                    {
                        //Lọc ra và đưa vào mảng mới
                        Chim[] arrChim = new Chim[iThuSoLuong];
                        for (int iThuTu = 0; iThuTu < iThuSoLuong; iThuTu++)
                        {
                            if (arrThu[iThuTu].getLoaiThu() == 3)
                            {
                                arrChim[iThuTu] = (Chim)arrThu[iThuTu];
                            }
                        }

                        // Sắp xếp mảng mới
                        for (int i = 1; i < iThuSoLuong; i++)
                        {
                            for (int j = 1; j < iThuSoLuong - 1; j++)
                            {
                                if (arrChim[j].getSoLuong() > arrChim[j + 1].getSoLuong())
                                {
                                    Chim tam = arrChim[j + 1];
                                    arrChim[j + 1] = arrChim[j];
                                    arrChim[j] = tam;
                                }
                            }
                        }
                        for (int i = 1; i < iThuSoLuong; i++)
                        {
                            arrChim[i].XuatThongTin();
                        }
                        Console.ReadKey();
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
