using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Customer
    {
        //Cách viết POCD
        public string Id  { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public void PrinInfor()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Customer ID= {Id}");
            Console.WriteLine($"Sustomer Name= {Name}");
            Console.WriteLine($"Sustomer Email= {Email}");
            Console.WriteLine($"Sustomer Phone= {Phone}");
            Console.WriteLine($"Sustomer Address= {Address}");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    };
 
   
}
