using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 9: Cho một mảng số nguyên hãy thực hiện sắp xếp dãy tang và giảm dần
namespace BaiTapC_
{
    internal class Bai9
    {
        static void Main(string[] args)
        {
            int[] array;
            NhapMang(out array);

            // Sắp xếp tăng dần
            Console.WriteLine("\nMang sap xep tang dan:");
            int[] SapXepASC = (int[])array.Clone();
            SapXepTangDan(SapXepASC);
            InMang(SapXepASC);

            // Sắp xếp giảm dần
            Console.WriteLine("\nMang sap xep giam dan:");
            int[] SapXepDesc = (int[])array.Clone();
            SapXepGiamDan(SapXepDesc);
            InMang(SapXepDesc);

            Console.ReadLine();
        }

        // Hàm nhập mảng
        static void NhapMang(out int[] mang)
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
                    Console.Write("Nhap phan tu thu  " + (i + 1) + ": ");
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

        // Hàm in mảng
        static void InMang(int[] mang)
        {
            for (int i = 0; i < mang.Length; i++)
            {
                Console.Write(mang[i] + " ");
            }
            Console.WriteLine(); // Thêm dòng mới sau khi in mảng
        }

        // Hàm sắp xếp tăng dần
        static void SapXepTangDan(int[] mang)
        {
            for (int i = 0; i < mang.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < mang.Length; j++) // Sửa thành i + 1
                {
                    if (mang[j] < mang[min])
                    {
                        min = j;
                    }
                }
                if (i != min)
                {
                    int temp = mang[i];
                    mang[i] = mang[min];
                    mang[min] = temp;
                }
            }
        }

        // Hàm sắp xếp giảm dần
        static void SapXepGiamDan(int[] mang)
        {
            for (int i = 0; i < mang.Length - 1; i++)
            {
                for (int j = 0; j < mang.Length - i - 1; j++)
                {
                    if (mang[j] < mang[j + 1])
                    {
                        int temp = mang[j];
                        mang[j] = mang[j + 1];
                        mang[j + 1] = temp;
                    }
                }
            }
        }
    }
}
