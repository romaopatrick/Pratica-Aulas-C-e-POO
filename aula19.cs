using System;
class aula19
{
    static void Main()
    {
        
        int[] num1 = new int[10];
        int i1=num1.Length - 1;
        while (i1>0) //Enquanto essa espressão retornar verdadeiro, ele vai executar o que estiver dentro do while
        {
            Console.WriteLine("CFB Cursos");
            num1[i1]=0;
            Console.WriteLine(num1[i1]);
            i1--;// Tambem pode ser usado com i-- para decremento, alterando toda a formula
        }
        Console.WriteLine("Fim do loop");




        int[] num = new int[10];

        for(int i = 0; i < num.Length - 1; i ++, num[i]++)
        {
            Console.WriteLine(num[i]);
        }

        for(int e1 = 0;e1 < 10;e1++) // e1 = inicializador da repetição, quando o bloco irá começar
        {                            // e2 = quantidade de vezes que vou repetir, enquanto e2 retornar true, fara o loop
          //Comandos                 // e3 = incremento ou decremento do contador
        }
    }
}