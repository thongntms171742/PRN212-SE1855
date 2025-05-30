using System.Text;
using OOP2;

Console.OutputEncoding = Encoding.UTF8;

/*Sử dungk Generic List dể quản lý nhân sự
 * thực hiện đầy đủ tính năng CRUD
 * C--> Create --> Thêm mới nhân sự
 * R--> Read/Retrieve --> Hiển thị danh sách nhân sự
 * U--> Update --> Cập nhật thông tin nhân sự
 * D--> Delete --> Xóa nhân sự
 */


//Câu 1 - C (Create) Thêm mới nhân sự
//Dùng List để tạo 5 Employee, trong đó 4 Employee là chính thức 
//và 1 Employee là thời vụ 
List<Employee> employees = new List<Employee>();
FulltimeEmployee e1 = new FulltimeEmployee();
e1.Id = 1;
e1.Name = "Name 1";
e1.IdCard = "Card 1";
e1.BirthDay = new DateTime(1990, 12, 25);
employees.Add(e1);

FulltimeEmployee e2 = new FulltimeEmployee();
e2.Id = 2;
e2.Name = "Name 2";
e2.IdCard = "Card 2";
e2.BirthDay = new DateTime(1995, 1, 15);
employees.Add(e2);

FulltimeEmployee e3 = new FulltimeEmployee();
e3.Id = 3;
e3.Name = "Name 3";
e3.IdCard = "Card 3";
e3.BirthDay = new DateTime(1992, 6, 10);
employees.Add(e3);

FulltimeEmployee e4 = new FulltimeEmployee();
e4.Id = 4;
e4.Name = "Name 4";
e4.IdCard = "Card 4";
e4.BirthDay = new DateTime(1988, 3, 20);
employees.Add(e4);

ParttimeEmployee e5 = new ParttimeEmployee();
e5.Id = 5;
e5.Name = "Name 5";
e5.IdCard = "Card 5";
e5.BirthDay = new DateTime(2000, 8, 30);
employees.Add(e5);

// Câu 2 - R (Read/Retrieve) Hiển thị danh sách nhân sự
//Cách xuất 1
Console.WriteLine("-----Danh sách nhân sự - cách 1-----");
employees.ForEach(e => Console.WriteLine(e));
//Cách xuất 2
Console.WriteLine("-----Danh sách nhân sự - cách 2-----");
foreach (var e in employees)
{
    Console.WriteLine(e);    
}

// Câu 3 - R --. Lọc ra dân sự chính thức và tính tổng lương
//Cách 1:
List<FulltimeEmployee> fe_list =
    employees.OfType<FulltimeEmployee>().ToList();
Console.WriteLine("-----Danh sách chính thức----- ");
fe_list.ForEach(e => Console.WriteLine(e));
//Cách 2:
List<FulltimeEmployee> fe_list2 = new List<FulltimeEmployee>();
foreach (var e in employees)
{
    if (e is FulltimeEmployee)
    {
        fe_list2.Add(e as FulltimeEmployee);
    }
}
Console.WriteLine("-----Danh sách nhân sự chính thức cách 2-----");
fe_list2.ForEach(e => Console.WriteLine(e));

//Tổng lương
double sum_salary = fe_list2.Sum(e=> e.calSalary());
Console.WriteLine("Tổng lương : "+sum_salary);

//Câu 4 : R--> Sắp xấp danh sách dân sự theo ngày tháng năm sinh    
for (int i = 0; i < employees.Count; i++)
{
    for (int j = i + 1; j < employees.Count; j++)
    {
        if (employees[i].BirthDay > employees[j].BirthDay)
        {
            //Hoán đổi
            Employee ei  = employees[i];
            Employee ej = employees[j];
            if(ei.BirthDay>ej.BirthDay)
           {
                employees[i] = ej;
                employees[j] = ei;
            }
        }
    }
}

Console.WriteLine("----Danh sách nhân sự sau khi sort----- ");
employees.ForEach(e => Console.WriteLine(e));

