using System;

namespace Printing
{
    public class Impressora
    {
        private bool on;
        private string model;
        
        public Impressora(string Model, bool ON)
        {
            this.setmodel(Model);
            this.seton(ON);
        }
        public bool geton()
        {
            return on;
        }
        public void seton(bool On)
        {
            this.on = On;
        }
        public string getmodel()
        {
            return model;
        }
        public void setmodel(string Model)
        {
            this.model = Model;
        }
        public void status()
        {
            Console.WriteLine("Modelo: {0}", this.getmodel());
            Console.WriteLine("On: {0}",this.geton());
            Console.ReadKey();
        }
        public void TurnOn()
        {
            if(this.geton()==false)
            {
                this.seton(true);
                Console.WriteLine("A impressora foi ligada");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Está Ligada");
                Console.ReadKey();
            }
        }
        public void TurnOff()
        {
            if(this.geton()==true)
            {
                this.seton(false);
                Console.WriteLine("Foi Desligada.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Está Desligada");
                Console.ReadKey();
            }
        }
        public void Imprimir()
        {
            if(this.geton()==true)
            {
                Console.WriteLine("Foi impresso");
            }
            else
            {
                int d=0;
                Console.WriteLine("A impressora está desligada, deseja ligar?[1]SIM   [2]NÃO");
                d=int.Parse(Console.ReadLine());
                if(d==1)
                {
                    this.seton(true);
                }
                else if(d==2)
                {
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Erro, reinicie o programa.");
                }
            }
        }
    }
}

