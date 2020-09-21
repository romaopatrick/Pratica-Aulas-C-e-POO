using System.Data.Common;
using System;

class Aula21
{
    static void Main()
    {
        int num=5;
        while(num<5) ///este bloco não sera executado
                     /// o do while faz com que o bloco seja executado pelo menos uma vez, mesmo que a expressão
                     /// nao seja verdadeira enquanto o while nao.
        {
            Console.WriteLine("CFB Cursos");
        }
        string senha = "123";
        string typedSenha;
        int tentativas=0;
        do 
        {   
            Console.Clear();
            Console.WriteLine("Digite a senha");
            typedSenha= Console.ReadLine();
            tentativas++;
        }
        while(senha!=typedSenha);
        Console.Clear();
        Console.WriteLine(tentativas);
    }
} 