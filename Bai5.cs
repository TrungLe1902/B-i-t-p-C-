using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Bài 5: Viết chương trình C# liệt kê tất cả
//các số nguyên tố nhỏ hơn n.

namespace BaiTapC_
{
    internal class Bai5
    {
        static void Main()
        {
          //  Console.Write("Nhap mot so: ");
           // int Number = int.Parse(Console.ReadLine());
            int Number;
            do
            {
                Console.Write("Nhap so thu nhat: ");
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
           
           Console.WriteLine("Cac so nguyen to nho hon {0} ",Number);

           for(int i = 2; i < Number; i++) 
            {
                if(LaSoNguyenTo(i))
                {
                    Console.Write(i + " ");
                }    
            }
            Console.ReadKey();
        }

        //======= Hàm kiểm tra số nguyên tố ==========
        static bool LaSoNguyenTo(int n)
        {

            if (n < 2)
            {
                return false;
            }
            for(int i = 2;i < n;i++)
            {
                if(n % i == 0)
                {
                    return false ;
                }
            }
            return true;
        }
    }
}
