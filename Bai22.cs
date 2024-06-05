using System;

namespace BaiTapC_
{
    internal class Bai22
    {
        static void Main(string[] args)
        {
            string str;
            NhapChuoi(out str);
            Console.WriteLine("Do dai chuoi: {0}", demDoDaiChuoi(str));

            Console.ReadLine();
        }

        // Hàm nhập chuỗi
        static void NhapChuoi(out string chuoi)
        {
            Console.Write("Nhap chuoi: ");
            chuoi = Console.ReadLine();
        }

        // Hàm đếm độ dài chuỗi
        int demDoDaiChuoi(* str)
        {
            int dem = 0;
            while (*str != '\0')
            {
                dem++;
                str++;
            }
            return dem;
        }

    }
}
