/*De tai
 * Nhap vao 1 so >=0, neu nhap sai quy tac
 * thi yeu cau nhap lai khi nao dung moi dung
 * Neu nhao dung thi tinh giai thua cua so nay
 */
int n = -1; //gia su nhap sai
while (n<0)//bat nhap den khi nao n>0
{
    Console.WriteLine("Nhap n >= 0: ");
    string input=Console.ReadLine();
    if (int.TryParse(input, out n) == true)
    {//khi vao day thi n la so, nhung co the <0
        if (n >= 0)// nhap dung
            break;//ko bat nhap nua
        else
            Console.WriteLine("Tui noi la nhap n >=0 ma li qua z cha noi");
    }
    else
    {
        Console.WriteLine("Luu dan qua chaaaa");
    }
}
int gt = 1;
for (int i = 1; i <= n; i++)
    gt = gt * i;
Console.WriteLine($"{n}!= {gt}");