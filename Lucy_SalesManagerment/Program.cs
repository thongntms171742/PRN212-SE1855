using System.Text;
using Lucy_SalesManagerment;

Console.OutputEncoding = Encoding.UTF8;
string connectionString = @"server=DESKTOP-IIENV9Q;database=Lucy_SalesData;uid=sa;pwd=12345";
Lucy_SalesDataDataContext context = new Lucy_SalesDataDataContext(connectionString);
// Cau 1: Lay thong tin chi tiet khach hang khi bet ma
int makh = 1;
Customer cust = context.Customers.FirstOrDefault(x => x.CustomerID == makh);
if (cust != null)
{
    Console.WriteLine(cust.CustomerID+"\t"+cust.ContactName);
}

//Cau 2: Loc ra danh sach cac hoa don cua khach hang tim thay
if (cust != null)
{
    Console.WriteLine("Danh sach hoa don cua khach hang: ");
    foreach(Order od in cust.Orders)
    {
        Console.WriteLine(od.OrderID + "\t" + od.OrderDate.ToString("dd/MM/yyyy"));
    }
}

//Cau 3: Nam cap cau 2
//Bo sung them 1 cot hien thi cua hoa don
if (cust != null)
{
    Console.WriteLine("Danh sach hoa don cua khach hang: ");
    foreach (Order od in cust.Orders)
    {
        decimal money = od.Order_Details
                          .Sum(odd => odd.Quantity * odd.UnitPrice 
                          - (decimal)odd.Discount * odd.Quantity * odd.UnitPrice);
        Console.WriteLine(od.OrderID + "\t" + od.OrderDate.ToString("dd/MM/yyyy")+"\t"+ money);
    }
}
//Query Syntax
if (cust != null)
{
    Console.WriteLine("Customer's Orders");
    foreach (Order od in cust.Orders)
    {
        decimal totalPrice = 0;
        List<Order_Detail> odd = (from o in context.Order_Details where o.OrderID == od.OrderID select o).ToList();
        foreach (Order_Detail o in odd)
        {
            totalPrice += (o.UnitPrice * o.Quantity - o.UnitPrice * o.Quantity * (decimal)o.Discount);
        }
        Console.WriteLine(od.OrderID + "\t" + od.OrderDate.ToString("dd/MM/yyyy") + "\t" + totalPrice);

    }
}