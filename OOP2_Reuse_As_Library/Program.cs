﻿using System.Text;
using OOP2;
using OOP2_Reuse_As_Library;

Console.OutputEncoding = Encoding.UTF8;
FulltimeEmployee e1 = new FulltimeEmployee();
e1.Id = 1;
e1.Name = "Tèo";
e1.BirthDay = new DateTime(1990,12,25);
Console.WriteLine("----Thông tin của E1----");
Console.WriteLine(e1);
Console.WriteLine("===>AGE = "+e1.TinhTuoi());