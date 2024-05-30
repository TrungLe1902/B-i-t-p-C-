using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 3: Viết chương trình C# để giải bài tập chuyển đổi độ C thành độ K và độ F trong C# 

namespace BaiTapC_
{
    internal class Bai3
    {
        static void Main(string[] args)
        {
            double DoC;

            while (true) 
            {
                Console.Write("Nhap gia tri do C: ");
                try
                {
                    DoC = Double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Du lieu dau vao khong hop le. Vui long nhap mot so nguyen.");
                }
            }

            // Chuyển đổi sang độ K, độ F
            double DoK = ChuyenDoiDoK(DoC);
            double DoF = ChuyenDoiDoF(DoC);

            // In kết quả
            Console.WriteLine("{0} do C = {1} do K", DoC, DoK);
            Console.WriteLine("{0} do C = {1} do F", DoC, DoF);
            Console.ReadKey();
        }

        static double ChuyenDoiDoK(double DoC)
        {
            return DoC + 273; 
        }

        static double ChuyenDoiDoF(double DoC)
        {
            return (DoC * 18 / 10) + 32; 
        }
    }
}
