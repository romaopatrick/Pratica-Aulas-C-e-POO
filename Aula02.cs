using System;

namespace Aula_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CFB Cursos");
            if(args.GetLength(0) > 0){
            Console.Write(args.GetValue(0));
            }
        }
    }
}
