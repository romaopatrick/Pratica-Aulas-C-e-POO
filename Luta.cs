using System;

namespace UEC
{
    public class Luta
    {
       private Lutador desafiado;
       public Lutador Desafiado
       {
           get { return desafiado;}
           set { desafiado = value;}
       }
       private Lutador desafiante;
       public Lutador Desafiante
       {
           get { return desafiante;}
           set { desafiante = value;}
       }
       private int rounds;
       public int Rounds
       {
           get { return rounds;}
           set { rounds = value;}
       }
       private bool aprovada;
       public bool Aprovada
       {
           get { return aprovada;}
           set { aprovada = value;}
       }  
        //Públicos
        public void MarcarLuta(Lutador l1, Lutador l2)
        {
            if (l1.getCategoria().Equals(l2.getCategoria())
                && (l1 != l2))
            {
                this.Aprovada = true;
                this.Desafiado = l1;
                this.Desafiante = l2;
            }
            else
            {
                this.Aprovada = false;
                this.Desafiado = null;
                this.Desafiante = null;
            }
        }
        public void Lutar()
        {
            if(this.Aprovada == true)
            {
                this.Desafiante.Apresentar();
                Console.WriteLine("### Desafiado ###");
                this.Desafiado.Apresentar();

                Random r = new Random();
                int vencedor = r.Next(3); // 0 1 2
                switch(vencedor)
                {
                    case 0: //Empate
                        Console.WriteLine("Empatou");
                        this.Desafiado.EmpatarLuta();
                        this.Desafiante.EmpatarLuta();
                    break;
                    case 1: // Desafiante vence
                        Console.WriteLine("Venceu: " + this.Desafiante.getNome());
                        this.Desafiante.GanharLuta();
                        this.Desafiado.PerderLuta();
                    break;
                    case 2: // Desafiado Vence
                        Console.WriteLine("Venceu: " + this.Desafiado.getNome());
                        this.Desafiado.GanharLuta();
                        this.Desafiante.PerderLuta();
                    break;
                }
            }
            else
            {
                Console.WriteLine("A luta não pode acontecer :c");
            }
            Console.ReadKey();
        }
    }
}