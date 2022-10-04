using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_number_20_to_50_by_while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 20;
            while (i <= 50) 
            Console.WriteLine(i++);
            i++;
            Console.ReadLine();
        }
      
    }
}
