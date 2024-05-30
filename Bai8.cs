using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 8: Cho một mảng số nguyên hãy in ra mảng sổ lẻ và mảng số chẵn
namespace BaiTapC_
{
    internal class Bai8
    {


        static void Main(string[] args)
        {
            int[] Array;
            NhapMang(out Array);

            int[] mangSoLe = new int[Array.Length]; // Tạo mảng để lưu số lẻ
            int[] mangSoChan = new int[Array.Length]; // Tạo mảng để lưu số chẵn
            int demSoLe = 0, demSoChan = 0;

            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] % 2 != 0) // Kiểm tra số lẻ
                {
                    mangSoLe[demSoLe] = Array[i];
                    demSoLe++;
                }
                else // Số chẵn
                {
                    mangSoChan[demSoChan] = Array[i];
                    demSoChan++;
                }
            }

            // In ra mảng số lẻ
            Console.Write("\nMang so le: ");
            for (int i = 0; i < demSoLe; i++)
            {
                Console.Write(mangSoLe[i] + " ");
            }

            // In ra mảng số chẵn
            Console.Write("\nMang so chan: ");
            for (int i = 0; i < demSoChan; i++)
            {
                Console.Write(mangSoChan[i] + " ");
            }
            
            Console.ReadKey();
        }

        //============= Hàm nhập mảng =====================
        static void NhapMang(out int[] mang) //khóa out thì tham số không cần khởi tạo khi truyền cho phương thức
        {
            int n;
            while (true)
            {
                Console.Write("Nhap so luong phan tu mang: ");
                try
                {
                    n = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Du lieu nhap vao khong hop le. Vui long nhap mot so.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Co loi xay ra: " + ex.Message);
                }
            }

            mang = new int[n]; // cấp phát bộ nhớ cho mảng
            for (int i = 0; i < n; i++)
            {
                while (true)
                {
                    Console.Write("Nhap phan tu thu " + (i + 1) + ": ");
                    try
                    {
                        mang[i] = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Du lieu nhap vao khong hop le. Vui long nhap mot so.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Co loi xay ra: " + ex.Message);
                    }
                }
            }

        }
    }
}
