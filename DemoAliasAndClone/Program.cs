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