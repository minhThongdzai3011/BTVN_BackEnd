using System;


//Bai_1
//string ten;
//int tuoi;
//Console.WriteLine("Nhap ten: ");
//ten = Console.ReadLine();
//Console.WriteLine("Nhap tuoi: ");
//tuoi = int.Parse(Console.ReadLine());
//Console.WriteLine("Xin chao " + ten + ", ban " + tuoi + " tuoi");

//Bai_2
//float chieudai, chieurong;
//Console.WriteLine("Nhap chieu dai: ");
//chieudai = float.Parse(Console.ReadLine());
//Console.WriteLine("Nhap chieu rong: ");
//chieurong = float.Parse(Console.ReadLine());
//float dientich = chieudai * chieurong;
//Console.WriteLine("Dien tich hinh chu nhat la: " + dientich);

//Bai_3
//float doC;
//Console.WriteLine("Nhap do C: ");
//doC = int.Parse(Console.ReadLine());
//float doF = doC * 9 / 5 + 32;
//Console.WriteLine("Do F la: " + doF);

//Bai_4
//int soNguyen;
//Console.WriteLine("Nhap so nguyen: ");
//soNguyen = int.Parse(Console.ReadLine());
//if (soNguyen == 0 || soNguyen % 2 == 0 )
//{
//    Console.WriteLine("So nguyn la so chan");
//}
//else
//{
//    Console.WriteLine("So nguyen la so le");
//}

//Bai_5
//float a, b;
//Console.WriteLine("Nhap a: ");
//a = float.Parse(Console.ReadLine());
//Console.WriteLine("Nhap b: ");
//b = float.Parse(Console.ReadLine());
//float tong, tich;
//tong = a + b;
//tich = a * b;
//Console.WriteLine("Tong la: " + tong);
//Console.WriteLine("Tich la: " + tich);

//Bai_6
//float a;
//Console.WriteLine("Nhap a: ");
//a = float.Parse(Console.ReadLine());
//if (a > 0)
//{
//    Console.WriteLine("So duong");
//}
//else if (a < 0)
//{
//    Console.WriteLine("So am");
//}
//else
//{
//    Console.WriteLine("So 0");
//}

//Bai_7
//int nam;
//Console.WriteLine("Nhap nam: ");
//nam = int.Parse(Console.ReadLine());
//if (nam % 4 == 0 && nam % 100 != 0 || nam % 400 == 0)
//{
//    Console.WriteLine(nam + " la nam nhuan");
//}
//else
//{
//    Console.WriteLine(nam + " khong phai la nam nhuan");
//}

//Bai_8
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//}

//Bai_9
//int n, giaithua = 1;
//Console.WriteLine("Nhap n: ");
//n = int.Parse(Console.ReadLine());
//for (int i = 1; i <= n ; i++)
//{
//    giaithua *= i;
//}
//Console.WriteLine("Giai thua cua " + n + " la: " + giaithua);

//Bai_10
//int songuyento;
//Console.WriteLine("Nhap so nguyen: ");
//songuyento = int.Parse(Console.ReadLine());
//bool isPrime = true;
//if (songuyento < 2)
//{
//    isPrime = false;
//}
//else
//{
//    for (int i = 2; i <= Math.Sqrt(songuyento); i++)
//    {
//        if (songuyento % i == 0)
//        {
//            isPrime = false;
//            break;
//        }
//    }
//}
//if (isPrime)
//{
//    Console.WriteLine(songuyento + " la so nguyen to");
//}
//else
//{
//    Console.WriteLine(songuyento + " khong phai la so nguyen to");
//}