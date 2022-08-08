using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copypasta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();

            Console.WriteLine(p.ToString() );

            p.Nome = "Tiago";

            Console.WriteLine(p);
            Console.ReadKey();
           }
    }
}
