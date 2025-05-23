void do_calculate(double a, double b, string op)
{
    switch(op)
    {
        case "+":
            Console.WriteLine("{0}+{1}={2}", a, b, a+b);
            break;
        case "-": 
            Console.WriteLine("{0}-{1}={2}", a, b, a-b); 
            break;
        case "*":
            Console.WriteLine("{0}*{1}={2}", a, b, a*b);
            break;
        case "/":
            Console.WriteLine("{0}/{1}={2}", a, b, a/b);
            break;
        default:
            Console.WriteLine("Nhap cai gi vay cha!!!!");
            break;
    }
}
Console.WriteLine("SIMPLE CALCULATION!!");
Console.WriteLine("Nhap a: ");
double a=Double.Parse(Console.ReadLine());
Console.WriteLine("Nap b: ");
double b=Double.Parse(Console.ReadLine());
Console.WriteLine("Nhap phep toan (+, -, *, /): ");
string op = Console.ReadLine();
do_calculate(a, b, op);
Console.ReadLine();