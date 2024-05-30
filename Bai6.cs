using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Bài 6: Kiểm tra một số là số chẵn hay số lẻ trong C#
namespace BaiTapC_
{
    internal class Bai6
    {
        static void Main(string[] args)
        {
           // Console.Write("Nhap mot so: ");
           // int Number = int.Parse(Console.ReadLine());
            int Number;
            do
            {
                Console.Write("Nhap mot so tu nhien: ");
                try
                {
                    Number = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Du lieu nhap vao khong hop le. Vui long nhap mot so.");
                }
            } while (true);
            switch (Number % 2)
            {
                case 0:
                    Console.WriteLine("Day la so chan");
                    break;
                case 1:
                    Console.WriteLine("Day la so le");
                    break;
                default:
                    Console.WriteLine("Du lieu nhap khong hop le");
                    break;

            }
        }
    }
}
