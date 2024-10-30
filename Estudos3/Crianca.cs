using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Estudos3
{
    public class Crianca : Pessoa
    {
        public string Nome { get; set; }

        public Crianca(string nome, double peso, double altura) : base(peso, altura)
        {
            Nome = nome;
        }
        public override void ImprimirIMC()
        {
            base.ImprimirIMC();
            double calculo = Peso / (Altura * Altura);
            Console.WriteLine($"Seu imc é: {calculo:n2}");
            Console.WriteLine($"Nome: {Nome}");
        }
    }
}
      