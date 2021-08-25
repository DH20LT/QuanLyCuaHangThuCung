using System;

namespace QuanLyCuaHangThuCung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Thu[] arrThu = new Thu[50];
            
            int iChucNang;
            int iThuSoLuong = 0;
            do
            {
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
                ChucNang.Play(iChucNang, arrThu, ref iThuSoLuong);
            } while (iChucNang < 12);
        }
        
    }
}
