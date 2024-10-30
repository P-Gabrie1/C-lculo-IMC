using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos3
{
    public abstract class Pessoa
    {
        public double Peso { get; set; }
        public double Altura { get; set; }

        public Pessoa (double peso, double altura)
        {
            Peso = peso;
            Altura = altura;
        }

        public virtual void ImprimirIMC() 
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("==========");
            Console.WriteLine($"Peso:{Peso}");
            Console.WriteLine($"Altura:{Altura}");
        
        }
        public virtual void ValorImc() 
        {
        Console.WriteLine("");
        Console.WriteLine("==========");
        }



    }
}
