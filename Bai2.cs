//Bài 2: Viết Chương trình giải phương trình bậc 1 , bậc 2 ( 2x2 + 3x +1=0)
using System;
namespace BaiTapC_
{
    internal class Bai2
    {
        static void Main(string[] args)
        {

            //================= Code lần 1=====================================
            /*float a, b, c; 
            Console.Write("Nhap he so bac 2, a = ");
            String valA = Console.ReadLine();
            a = Convert.ToInt32(valA);
            Console.Write("Nhap he so bac 1, b = ");
            String valB = Console.ReadLine();
            b = Convert.ToInt32(valB);
            Console.Write("Nhap he so bac 0, c = ");
            String valC = Console.ReadLine();
            c = Convert.ToInt32(valC);*/
            //================ Code lần 2 ========================================
            /*float a;
                    do
                    {
                        Console.Write("Nhap he so bac 2, a = ");
                        try
                        {
                            a = float.Parse(Console.ReadLine());
                            break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Du lieu nhap vao khong hop le. Vui long nhap mot so.");
                        }
                    } while (true);
                    float b;
                    do
                    {
                        Console.Write("Nhap he so bac 1, b = ");
                        try
                        {
                            b = float.Parse(Console.ReadLine());
                            break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Du lieu nhap vao khong hop le. Vui long nhap mot so.");
                        }
                    } while (true);
                    float c;
                    do
                    {
                        Console.Write("Nhap he so bac 0, c = ");
                        try
                        {
                            c= float.Parse(Console.ReadLine());
                            break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Du lieu nhap vao khong hop le. Vui long nhap mot so.");
                        }
                    } while (true);*/
            //==================== Code lần 3 ===============
            int[] numbers = new int[3]; // Tạo mảng để lưu trữ 3 số

            for (int i = 0; i < numbers.Length; i++)
            {
                do
                {
                    Console.Write("Nhap he so thu {0}: ", i + 1);

                    try
                    {
                        numbers[i] = int.Parse(Console.ReadLine());
                        break; // Thoát khỏi vòng lặp do-while nếu nhập thành công
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Du lieu chuong trinh nhap vao khong hop le. Vui long nhap so nguyen");
                    }
                } while (true); // Vòng lặp lặp vô hạn cho đến khi nhập thành công
            }
                int a = numbers[0], b = numbers[1], c = numbers[2]; // Gán giá trị cho các hệ số
                giaiPTBac2(a, b, c);
                Console.ReadKey();
            //Hàm giả phương trình
            static void giaiPTBac2(float a, float b, float c)
            {
                if (a == 0)
                {
                    if (b == 0)
                    {
                        Console.WriteLine("Phuong trinh vo nghiem");
                    }
                    else
                    {
                        Console.WriteLine("Phuong trinh co nghiem kep x1 = x2 = {0}", -b / c);
                    }
                    return;
                }
                //Tinh delta
                float delta = b * b - 4 * a * c;
                float x1;
                float x2;
                //Tinh nghiem
                if (delta > 0)
                {
                    x1 = (float)((-b + Math.Sqrt(delta)) / (2 * a));
                    x2 = (float)((-b - Math.Sqrt(delta)) / (2 * a));
                    Console.WriteLine("Phuong trinh co hai nghiem phan biet: x1 = {0} ; x2 = {1}", x1, x2);
                }
                else if (delta == 0)
                {
                    x1 = (float)(-b / 2 * a);
                    Console.WriteLine("Phuong trinh co nghiem kep: x1 = x2 = {0}", x1);
                }
                else
                {
                    Console.Write("Phuong trinh vo nghiem!");
                }
            }
        }
    }
}