using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 4: Tính giai thừa của 1 số 
namespace BaiTapC_
{
    internal class Bai4
    {
        static void Main()
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
                catch (FormatException)
                {
                    Console.WriteLine("Du lieu khong hop le. Vui long nhap vao mot so nguyen duong.");
                }
            } while (true);

            if (Number < 0)
            {
                Console.WriteLine("So nhap vao phai lon hon 0.");
            }
            else
            {
                long GiaiThua = TinhGiaiThua(Number);
                Console.WriteLine("Giai thu cua so {0} la: {1}", Number, GiaiThua);
            }
        }

        static long TinhGiaiThua(int n)
        {
            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result =result * i;
            }
            return result;
        }
    }
}
