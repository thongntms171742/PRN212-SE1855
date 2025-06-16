using System.Text;

Console.OutputEncoding = Encoding.UTF8;
int[] arr = { 20, 11, 30, 15, 40, 45, 73, 19, 50 };
/*Câu 1: Lọc ra các số chẵn 
 * 
 */
//Cách 1: Dùng Extention Method - Method Syntax
var ar_chan = arr.Where(x => x % 2 == 0);
Console.WriteLine("Các số chẵn - Method Syntax: ");
ar_chan.ToList().ForEach(x => Console.WriteLine(x));
//Cách 2: Dùng LINQ - Query Syntax
var ar_chan2 = from x in arr
               where x % 2 == 0
               select x;
Console.WriteLine("Các số chẵn - Query Syntax: ");
ar_chan2.ToList().ForEach(x => Console.WriteLine(x));
/*
 *Câu 2: Tăng các phần tử lên 2 đơn vị 
 */
var arr2 = arr.Where(x => x % 2 != 0)
               .Select(x => x + 2);
Console.WriteLine("\nDữ liệu gốc");
foreach (var x in arr)
{
    Console.Write(x + "\t");
}
Console.WriteLine("\nCác số lẻ tăng lên 2 đơn vị - Method Syntax: ");
foreach (var x in arr2)
{
    Console.Write(x + "\t");
}
/*
 * Câu 3: Sắp xếp các phần tử theo thứ tự tăng dần
 */
var arr4 = arr.OrderBy(x => x);
var arr5 = from x in arr
           orderby x ascending
           select x;
Console.WriteLine("\nSau khi tăng dần");
foreach (var x in arr4)
{
    Console.Write(x + "\t");
}
/*
 * Câu 4: Sắp xếp giảm dần
 */
var arr6 = arr.OrderByDescending(x => x);
var arr7 = from x in arr
           orderby x descending
           select x;
Console.WriteLine("\nSau khi giảm dần");
foreach (var x in arr6)
{
    Console.Write(x + "\t");
}
/*
 * Câu 5: Đếm các phần tử lẻ
 */
Console.WriteLine("\nSố lẻ là: "+arr.Where(x=>x%2!=0).Count());
int sole = (from x in arr
            where x % 2 != 0
            select x).Count();
Console.WriteLine("\nSố lẻ là: "+sole);