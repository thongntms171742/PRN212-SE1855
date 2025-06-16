using System.Text;
using DemoLinQ2Object2;

Console.OutputEncoding = Encoding.UTF8;

ListProduct lp = new ListProduct();
lp.gen_products();
//Câu 1: lọc ra các sản phẩm có giá trị từ a tới b
//sử dụng Method Syntax và Query Syntax
var result1 = lp.FilterProductByPrice(200, 300);
Console.WriteLine("Danh sách sản phẩm có giá từ 200-300");
result1.ForEach(p => Console.WriteLine(p));

//Câu 2: Sắp xếp các sản phẩm theo đơn giá giảm dần
//Sử dụng Method Syntax và Query Syntax
var result2 = lp.SortProductByPriceDesc2();
Console.WriteLine("Danh sách sản phẩm sau khi sắp xếp: ");
result2.ForEach(p => Console.WriteLine(p));

//Câu 3: Tính tổng giá trị sản phẩm trong kho hàng
Console.WriteLine("Tổng giá trị bằng: "+lp.SumOfValue());
