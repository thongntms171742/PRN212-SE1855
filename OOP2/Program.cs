using OOP2;

Console.OutputEncoding = System.Text.Encoding.UTF8;
FulltimeEmployee obama = new FulltimeEmployee()
{
    Id = 1,
    IdCard = "123456789",
    Name = "Barack Obama",
    BirthDay = new DateTime(1961, 8, 4)
};
Console.WriteLine("----Thong tin cua OBAMA----");
Console.WriteLine($"Id: {obama.Id}");
Console.WriteLine($"IdCard: {obama.IdCard}");
Console.WriteLine($"Name: {obama.Name}");
Console.WriteLine($"BirthDay: {obama.BirthDay.ToString("dd/MM/yy")}");
Console.WriteLine("Muc luong Obama nhan = " + obama.calSalary());

ParttimeEmployee trump = new ParttimeEmployee()
{
    Id = 2,
    IdCard = "987654321",
    Name = "Donald Trump",
    BirthDay = new DateTime(1946, 6, 14),
    WorkingHours = 20
};
Console.WriteLine("----Thong tin cua TRUMP----");
Console.WriteLine($"Id: {trump.Id}");
Console.WriteLine($"IdCard: {trump.IdCard}");
Console.WriteLine($"Name: {trump.Name}");
Console.WriteLine($"BirthDay: {trump.BirthDay.ToString("dd/MM/yy")}");

Console.WriteLine("Muc luong Trump nhan = " + trump.calSalary());

Console.WriteLine("----Su dung to String----");
Console.WriteLine(obama);
Console.WriteLine(trump);