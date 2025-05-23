using System.Net.Http.Headers;
void hinh(int n)
{
    int count = 0;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
            if (j == 0 || j == n - 1 ||  i == j )
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        Console.WriteLine();
    }
}
hinh(8);
