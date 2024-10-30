using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos3
{
    public class Adulto : Pessoa
    {
        public string Nome { get; set; }

        public Adulto(string nome, double peso, double altura) : base(peso, altura)
        {
            Nome = nome;
        }
        public override void ImprimirIMC()
        {
            double calculo = Peso / (Altura * Altura);
            base.ImprimirIMC();
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Seu imc é: {calculo:n2}");
         
        }

        public override void ValorImc()
        {
            double calculo = Peso / (Altura * Altura);


            if (calculo < 18)
            {
                Console.WriteLine("Abaixo do Peso");
            }
            else if (calculo <= 25)
            {

                Console.WriteLine("Peso Normal");
            }
            else if (calculo < 30)
            {

                Console.WriteLine("Sobre Peso");
            }
           else 
            { 
             Console.WriteLine("Obesidade"); 
            }
        }
    }
}
