using System.Text;
using System.Threading.Channels;
using OOP5_Dictionary;

Console.OutputEncoding = Encoding .UTF8;
Category c1 = new Category ();
c1.Id = 1;
c1.Name = "Nước ngọt";

Product p1 = new Product();
p1.Id = 1;
p1.Name = "Coca";
p1.Quality = 10;
p1.Price = 15;
c1.AddProduct(p1);

Product p2 = new Product();
p2.Id = 2;
p2.Name = "Pepsi";
p2.Quality = 30;
p2.Price = 15;
c1.AddProduct(p2);

Product p3 = new Product();
p3.Id = 3;
p3.Name = "Sting";
p3.Quality = 7;
p3.Price = 20;
c1.AddProduct(p3);

Product p4 = new Product();
p4.Id = 4;
p4.Name = "Redbull";
p4.Quality = 5;
p4.Price = 18;
c1.AddProduct(p4);

Product p5 = new Product();
p5.Id = 5;
p5.Name = "Spirte";
p5.Quality = 8;
p5.Price = 20;
c1.AddProduct(p5);

//Xuất toàn bộ sản phẩm của danh mục
Console.WriteLine("--|Toàn bộ sản phẩm Nước Ngọt|--");
c1.PrintAllProducts();

Dictionary<int, Product> results = c1.FilterProductsByPrice(10, 15);
Console.WriteLine("--|Sản phẩm có giá từ 10 --> 15|--");
foreach(KeyValuePair<int, Product> kvp in results)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}

Dictionary<int, Product> sortedResults = c1.SortProductsByPrice();
Console.WriteLine("--|Sản phẩm có giá tăng dần|--");
foreach (KeyValuePair<int, Product> kvp in sortedResults)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}

Dictionary<int, Product> sort_complex = c1.ComplexSort();
Console.WriteLine("--|Sản phẩm sau khi sắp xếp - Complex|--");
foreach (KeyValuePair<int, Product> kvp in sort_complex)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}

p1.Name = "Xá xị";
p1.Quality = 30;
p1.Price = 28;
c1.UpdateProduct(p1);
Console.WriteLine("---|Sản phẩm sau khi chỉnh sửa|---");
c1.PrintAllProducts();

int id = 1;
bool ret=c1.RemoveProduct(id);
if (ret)
{
    Console.WriteLine($"---|Sản phẩm có mã [{id}] đã được xóa thành công|---");
    Console.WriteLine("--Sản phẩm sau khi xóa--");
    c1.PrintAllProducts();
}
else
{
    Console.WriteLine($"---|Không tìm thấy sản phẩm có mã [{id}] để xóa|---");
}

Category c2 = new Category();
c2.Id = 2;
c2.Name = "Bia";
c2.AddProduct(new Product { Id = 6, Name = "Sài Gòn", Quality = 10, Price = 350 });
c2.AddProduct(new Product { Id = 7, Name = "Huda", Quality = 20, Price = 400 });
c2.AddProduct(new Product { Id = 8, Name = "Tiger", Quality = 15, Price = 200 });
LinkedList<Category> ss = new LinkedList<Category>();
    ss.AddLast(c1);
    ss.AddLast(c2);
Console.WriteLine("--|Danh sách danh mục|--");
foreach (Category c in ss)
{
    Console.WriteLine($"{c.Name}");
    Console.WriteLine("****************************");
    c.PrintAllProducts();
    Console.WriteLine("****************************");
}