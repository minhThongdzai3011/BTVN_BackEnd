using System;

namespace LAB02
{
    internal class BAI3_LAB02
    {
        public static void NhapMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        public static void SoAmDuong(int[] a, int n)
        {
            int soam = 0;
            int soduong = 0;
            int sokhong = 0;
            for (int i = 0; i < n; i++)
            {

                if (a[i] > 0)
                {
                    soduong++;
                }
                else if (a[i] < 0)
                {
                    soam++;
                }
                else
                {
                    sokhong++;
                }
            }
            Console.WriteLine($"Số dương: {soduong}");
            Console.WriteLine($"Số âm: {soam}");
            Console.WriteLine($"Số không: {sokhong}");
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n;
            Console.Write("Nhập n: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            NhapMang(a, n);
            SoAmDuong(a, n);
        }
    }
}
