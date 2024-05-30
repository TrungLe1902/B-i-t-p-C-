/*Bài 1: Viết chương trình C# để giải bài tập tìm tổng hai số , tích 2 số , hiệu 2 số */
using System;

namespace BaiTapC_
{
    internal class Bai1
    {
        static void Main(string[] args)
        {
            double SoThuNhat;
            do
            {
                Console.Write("Nhap so thu nhat: ");
                try
                {
                    SoThuNhat = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Du lieu nhap vao khong hop le. Vui long nhap mot so.");
                }
            } while (true);
            double SoThuHai;
            do
            {
                Console.Write("Nhap so thu hai: ");
                try
                {
                    SoThuHai = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Du lieu nhap vao khong hop le. Vui long nhap mot so.");
                }
            } while (true);
            //Console.Write("Nhap so thu nhat: ");
            //double SoThuNhat = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Nhap so thu hai: ");
            //double SoThuHai = Convert.ToDouble(Console.ReadLine());
            double Sum = SoThuNhat + SoThuHai;
            double Hieu = SoThuNhat - SoThuHai;
            double Tich = SoThuNhat * SoThuHai;
            Console.WriteLine("Tong cua {0} và {1} la: {2} ", SoThuNhat, SoThuHai, Sum);
          
            Console.WriteLine("Tong cua {0} và {1} la: {2} ", SoThuNhat, SoThuHai, Hieu);
         
            Console.WriteLine("Tong cua {0} và {1} la: {2} ", SoThuNhat, SoThuHai, Tich);

            Console.ReadKey();
        }

        static void Swap(ref double x, ref double y)
        {
            double temp = x;
            x = y;
            y = temp;
        }

    }


}