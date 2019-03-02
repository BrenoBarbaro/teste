using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Teste t1 = new Teste("t1",80);
            Teste t2 = new Teste("t2",40);
            Teste t3 = new Teste("t3",20);

            t1.ImprimeLinha();
            Console.ReadKey();
        }
    }
}
