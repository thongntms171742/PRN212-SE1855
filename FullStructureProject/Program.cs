using System.Text;

namespace FullStructureProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Cha Me \"thoi doi\" an o bac");
            Console.WriteLine("Co chong ca chon cung nhu khong!");
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
            Console.ReadLine();
        }
    }
}
