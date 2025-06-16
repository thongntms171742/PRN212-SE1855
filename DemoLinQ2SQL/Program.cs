using System.Text;
using DemoLinQ2SQL;

Console.OutputEncoding = Encoding.UTF8;

string connectionString = @"server=DESKTOP-IIENV9Q;database=MyStore;uid=sa;pwd=12345";
MyStoreDataContext context = new MyStoreDataContext(connectionString);
//Cau1: Truy van toan bo danh muc
var dsdm = context.Categories.ToList();
Console.WriteLine("Danh sach danh muc");
dsdm.ForEach(x => 
                Console.WriteLine(x.CategoryID+"\t"+x.CategoryName));

//Cau 2: Dung Query SynTax de loc ra toan bo san pham
var dssp = from p in context.Products
           select p;
Console.WriteLine("Danh sach san pham");
foreach(var p in dssp)
{
    Console.WriteLine(p.ProductID+"\t"+p.ProductName+"\t"+p.UnitPrice);
}

//Cau 3: Tim danh muc khi biet ma danh muc
int dmd = 3;
Category cate = context.Categories.FirstOrDefault(x => x.CategoryID == dmd);
if(cate == null)
{
    Console.WriteLine("Khong tim thay danh muc co ma: "+dmd);
}
else
{
    Console.WriteLine("Danh muc co ma: " + dmd);
    Console.WriteLine(cate.CategoryID + "\t" + cate.CategoryName);
}
// Cau 4: Loc ra TOP 3 san pham co gia lon nhat
var dssptop3 = context.Products
                      .OrderByDescending(x => x.UnitPrice)
                      .Take(3);
Console.WriteLine("--Danh sach 3 san pham dat nhat--");
foreach (var p in dssptop3)
{
    Console.WriteLine(p.ProductID + "\t" + p.ProductName + "\t" + p.UnitPrice);
}

var dssptop3_2 = (from p in context.Products
                  orderby p.UnitPrice descending
                  select p).Take(3);
Console.WriteLine("--Danh sach 3 san pham dat nhat (Query Syntax)--");
foreach (var p in dssptop3_2)
{
    Console.WriteLine(p.ProductID + "\t" + p.ProductName + "\t" + p.UnitPrice);
}

//Cau 5: Them moi mot danh muc
/*Category c1 = new Category();
c1.CategoryName = "Hang dien tu hhahaahahaha";
context.Categories.InsertOnSubmit(c1);
context.SubmitChanges();*/

//Cau 6: Sua ten danh muc
//Buoc 1: Tim danh muc
//Buoc 2: Tim thay thi sua
Category c13 = context.Categories.FirstOrDefault(x => x.CategoryID == 9);
if (c13 != null)
{
    c13.CategoryName = "Hang gia dung";
    context.SubmitChanges();
}

//Cau 7: Xoa danh muc khi biet ma danh muc
Category c9 = context.Categories.FirstOrDefault(x => x.CategoryID == 9);
if (c9 != null)
{
    context.Categories.DeleteOnSubmit(c9);
    context.SubmitChanges();
}

//Cau 8: Xoa tat ca danh muc khi chua co bat ky san pham nao
var dssp_empty_product = context.Categories
                                .Where(c => c.Products.Count() == 0)
                                .ToList();
context.Categories.DeleteAllOnSubmit(dssp_empty_product);
context.SubmitChanges();

//Cau 9: Them nhieu danh muc cung mot luc
List<Category> dsdm_new = new List<Category>();
dsdm_new.Add(new Category() { CategoryName = "Hang dien tu 1" });
dsdm_new.Add(new Category() { CategoryName = "Hang hoa chat" });
dsdm_new.Add(new Category() { CategoryName = "Hang thuc pham" });
dsdm_new.Add(new Category() { CategoryName = "Hang thoi trang" });
dsdm_new.Add(new Category() { CategoryName = "Hang dien thoai" });
context.Categories.InsertAllOnSubmit(dsdm_new);
context.SubmitChanges();