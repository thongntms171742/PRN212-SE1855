﻿using OOP3_ExtensionMethod;
using System;
Console.OutputEncoding = System.Text.Encoding.UTF8;
int n1 = 5;
Console.WriteLine("Tổng từ 1 tới 5 = "+n1.Tongtu1toiN());
int n2 = 10;
Console.WriteLine("Tổng từ 1 tới 10 = " + n2.Tongtu1toiN());
Console.WriteLine("Tổng từ 1 tới 100 = "+100.Tongtu1toiN());
Console.WriteLine("(10+20) = "+10.Cong(20));

int[] arr = new int[8];
arr.TaoMang();
Console.WriteLine("Mảng trước khi sắp xếp: ");
arr.XuatMang();
arr.SapXepTangDan();
Console.WriteLine("Mảng sau khi sắp xếp: ");
arr.XuatMang();