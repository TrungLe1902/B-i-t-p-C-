using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapC_
{
    internal class Bai7
    {
        static void Main(string[] args)
        {
            int Number;
            do
            {
                Console.Write("Nhap mot so nguyen duong: ");
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

            bool LaSoNT = KiemtraNT(Number);
            if (LaSoNT)
            {
                Console.WriteLine("{0} la so nguyen to", Number);
            }
            else
            {
                Console.WriteLine("{0} khong phai so nguyen to", Number);
            }

            Console.ReadKey();
            //================ Hàm kiểm tra số nguyên tố ===========
            static bool KiemtraNT(int n)
            {
                if (n < 2)
                {
                    return false;
                }
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
