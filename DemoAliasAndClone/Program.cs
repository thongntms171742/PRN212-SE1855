using System.Text;
using DemoAliasAndClone;

Console.OutputEncoding = Encoding.UTF8;

Student st1 = new Student();
st1.Id = 1;
st1.Name = "Trần Thị Tèo";

Student st2 = new Student();
st2.Id = 2;
st2.Name = "Nguyễn Văn Tủn";

//Lúc này trên thanh RAM sẽ phát 2 ô nhớ khác nhau
//Cho s1 và s2 quản lý
//==> s1 đổi giá trị ko liên qua gì đến s2
//vì s1 và s2 đang quản lý 2 ô nhớ khác nhau
st1 = st2;
//ta viết lệnh s1 = s2
//Tuy nhiên về bản chất nó hoạt động như sau:
//s1 trỏ tới vùng nhớ mà s2 đang quản lý
//chứ không phải s1 bằng s2
//sẽ có 2 tình huống xảy ra:
//(1) ô nhớ bên s2 giờ có thêm s1 quản lý ==> alias (>= 2 đối tượng quản lý)
//   chỉ cần 1 đối tượng dổi thì các đối tượng khác đều bị đổi 
st2.Name = "Nguyễn Thị Lung Linh";
Console.WriteLine("s2 đổi tên, vậy s1 có tên là gì?");
Console.WriteLine(st1.Name);
//(2) ô nhớ lúc trước bên s1 đang quản lý, giờ ko còn đối tượng nào quản lý 
// thì lúc này HDH tự dộng thu hồi ô nhớ: Automatic Garbage Collection
//tức là ta ko thể truy suất để lấy lại giá trị s1 có id=1 và name="Trần Thị Tèo"

Product p1 = new Product() { Id = 1, Name = "P1", Quantity = 30, Price = 50 };
Product p2 = new Product() { Id = 2, Name = "P2", Quantity = 20, Price = 15 };

p1 = p2;
p2.Name = "Thuốc trị hôi nách";
p2.Price = 80;
Console.WriteLine("Thông tin p1");
Console.WriteLine(p1);

Product p3 = new Product() { Id = 3, Name = "P3", Quantity = 30, Price = 50 };
Product p4 = new Product() { Id = 4, Name = "P4", Quantity = 40, Price = 90 };
Product p5 = p3; //p5 trỏ tới vùng nhớ mà p3 đang quản lý
p3 = p4; //p3 trỏ tới vùng nhớ mà p4 đang quản lý
         //Hỏi ô nhớ cấp phát cho p3 và p4 có bị thu hồi hay không?

Product p6 = p4.clone();
//sao chép toàn bộ dữ liệu trong ô nhớ mà p4 đang quản lý
//sang ô nhớ mới và giao cho p6 quản lý
//lúc này không phải là ALIAS vì p4 và p6 đang quản lý 2 ô nhớ khác nhau
Console.WriteLine("Dữ liệu của Product 6: ");
Console.WriteLine(p6);
Console.WriteLine("Dữ liệu của Product 4: ");
Console.WriteLine(p4);
p4.Name = "Thuốc trị Xàm";
Console.WriteLine("Dữ liệu của Product 6: ");
Console.WriteLine(p6);
