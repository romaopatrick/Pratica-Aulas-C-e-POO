using System;

namespace Aula_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //SE(E_L){}
            //10 < 5 = false
            //10>5 = true 
            int nota = 0;
            string resultado = "Reprovado";

            nota = int.Parse(Console.ReadLine());

            if(nota>=60)
            {
                resultado = "Aprovado";
            }
            Console.WriteLine("Resultado: {0}", resultado);
        }
    }
}
