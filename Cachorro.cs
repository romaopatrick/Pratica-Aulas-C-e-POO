using System.IO.IsolatedStorage;
using System;

namespace Ex_3
{
    public sealed class Cachorro : Lobo
    {
        public override void EmitirSom()
        {
            Console.WriteLine("AuAuAu!");
        }
        public void EnterrarOssos()
        {
            Console.WriteLine("Ossos Enterrados");
        }
        public void AbanarRabo()
        {
            Console.WriteLine("Abanando rabo");
        }
        public void Reagir(String frase)
        {
            if(frase.Equals("Comida") || frase.Equals("Olá"))
            {
                Console.WriteLine("Abanar e latir");
            }
            else
            {
                Console.WriteLine("Rosnar");
            }
        }
        public void Reagir (int hora, int min)
        {
            if(hora <12)
            {
                Console.WriteLine("Abanar o rabo");
            }
            else if(hora>=18)
            {
                Console.WriteLine("Ignorar");
            }
            else
            {
                Console.WriteLine("Abanar e Latir");
            }
        }
        public void Reagir (bool dono)
        {
            if(dono)
            {
                Console.WriteLine("Abanar");
            }
            else
            {
            Console.WriteLine("Rosnar e latir");
            }
        }
        public void Reagir (int idade, float peso)
        {
            if (idade < 5)
            {
                if (peso<10)
                {
                    Console.WriteLine("Abanar");
                }
                else 
                {
                    Console.WriteLine("Latir");
                }
            }
            else
            {
                if (peso < 10)
                {
                    Console.WriteLine("Rosnar");
                }
                else
                {
                    Console.WriteLine("Ignorar");
                }
            }
        }
    }
}