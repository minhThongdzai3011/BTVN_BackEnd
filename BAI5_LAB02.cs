using System;

namespace LAB02
{
    internal class BAI5_LAB02
    {
        public static void HoanViHaiSoNguyen(int a, int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"Sau khi hoán vị: a = {a}, b = {b}");

        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int a, b;
            Console.Write("Nhập a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhập b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Trước khi hoán vị: a = {a}, b = {b}");
            HoanViHaiSoNguyen(a, b);
        }
    }
}
