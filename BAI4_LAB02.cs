using System;

namespace LAB02
{
    internal class BAI4_LAB02
    {
        public static void NhapMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        public static void SoLonThuHai(int[] a, int n)
        {
            int max = a[0];
            int max2 = a[0];
            for (int i = 0; i < n; i++)
            {
                if (a[i] > max)
                {
                    max2 = max;
                    max = a[i];
                }
                else if (a[i] > max2 && a[i] != max)
                {
                    max2 = a[i];
                }
            }
            Console.WriteLine($"Số lớn thứ hai là: {max2}");

        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n;
            Console.Write("Nhập n: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            NhapMang(a, n);
            SoLonThuHai(a, n);
        }
    }
}
