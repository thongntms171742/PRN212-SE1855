using OOP1;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
//Tạo 1 dối tượng danh mục 
Category c1 = new Category();
//Gán giá trị 
c1.Name = "Nước mắm";
c1.Id = 1;
//gọi hàm xuất dữ liệu 
c1.PrintInfor();

Employee e1 = new Employee();
e1.Id = 1;
e1.Id_Card = "00123";
e1.Name = "Tèo";
e1.Email = "teo@gmail.com";
e1.Phone = "0234567890";
e1.PrintInfor();
Console.WriteLine("=========================================================================");
Console.WriteLine("Id của e1 = "+e1.Id);
Console.WriteLine($"Name của e1 là : "+e1.Name);

//Ta cũng có thể khởi tạo đói tượng và các giá trị của thuộc tính như sau
Employee e2 = new Employee()
{
    Id = 2,
    Id_Card = "00243",
    Name = "Tý",
    Email = "ty@gmail.com",
    Phone = "0367123789",
};
Console.WriteLine("[--------E2--------]");
e2.PrintInfor();

Console.WriteLine("=======================================================");
Employee e3 = new Employee(3, "00837", "Tam", "tam@gmail.com", "0968886868");
e3.PrintInfor();
Console.WriteLine(e3);

//Thử dùng constructer không đối số
Employee e4 = new Employee();
Console.WriteLine(e4);

//Tạo đối tượng Customer
Customer cus1 = new Customer()
{
    Id = "CUS1",
    Name = "Nguyễn Thị Lung LInh",
    Email = "LungLinh@gmail.com",
    Phone = "0223222333",
    Address = "Số 1 Đinh Tiên Hoàng - Quận 1 - Bình Thạnh - HCM "
};
cus1.PrinInfor();
cus1.Address = "Số 2 Đinh Tiên Hoàng - Quận 5 - Gò Vấp - HCM";
cus1.Phone = "0987333555";
Console.WriteLine("Thông tin đã sửa");
cus1.PrinInfor();
