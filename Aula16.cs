using System;

namespace Aula_16
{
    class Program
    {
        static void Main(string[] args)
        {
            inicio:
            Console.Clear();
            Console.WriteLine("Hello World!");
            Console.WriteLine("Deseja reexecutar o programa?[s/n]");
            char escolha = char.Parse(Console.ReadLine());
            if (escolha == 's' || escolha == 'S')
            {
                goto inicio;
            }
            else 
            {
                Console.Clear();
                Console.WriteLine("Fim do programa");
            }
        }
    }
}
