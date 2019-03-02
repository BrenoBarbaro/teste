using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Teste
    {
        public int tamanho;
        public Teste(String nome, int tamanho)
        {
            Console.WriteLine("O construtor {0} esta rodando...", nome);
            this.tamanho = tamanho;
        }

        public void ImprimeLinha()
        {
            Console.WriteLine("");
            for(int x = 0; x < tamanho; x++)
            {
                Console.Write("-");
            }
            Console.WriteLine("");
        }
    }
}
