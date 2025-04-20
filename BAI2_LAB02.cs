using System;

namespace LAB02
{
    internal class BAI2_LAB02
    {
        public static void NhapMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        public static void SoNguyenTo(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                int songuyento = a[i];
                if (songuyento > 0)
                {
                    int dem = 0;
                    for (int j = 1; j <= songuyento; j++)
                    {
                        if (songuyento % j == 0)
                        {
                            dem++;
                        }
                    }
                    if (dem == 2)
                    {
                        Console.WriteLine($"{songuyento} là số nguyên tố");
                    }
                    else
                    {
                        Console.WriteLine($"{songuyento} không phải là số nguyên tố");
                    }
                }
                else
                {
                    Console.WriteLine($"{songuyento} không phải là số nguyên tố");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n;
            Console.Write("Nhập n: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            NhapMang(a, n);
            SoNguyenTo(a, n);
        }
    }
}
