using System;

class Aula17
{
    static void Main()
    {
        //int n1,n2,n3,n4,n5; // ou
        /*int[] n= new int[5]; // a primeira posição do array é sempre o indice 0
        n[0] = 3;
        n[1] = 4;
        n[2] = 5;
        n[3] = 12315123;
        n[4] = 321121;
        Console.WriteLine(n[0]); ou */
       // int[] num = new int[3]{55,32,41}; ou
        int[] num = {55,77,99}; // usa automaticamente o numero de elementos dentro da chave para o tamanho do ARRAY
        Console.WriteLine(num[2]);
        string[] veiculos= new string[3];
        veiculos[1]="carro";
        }
}