using System.Runtime.CompilerServices;
using System;

namespace UEC
{
    //Acessores
    public class Lutador
    {
        private string nome, nacionalidade;
        private int idade;
        private double altura, peso;
        private string categoria;
        private int vitorias, derrotas, empates;

        //Métodos Especiais.
        public Lutador(string no, string na, int id, 
                       double al, double pe,int vi,
                       int de, int em)
        {
            this.setNome(no);
            this.setNacionalidade(na);
            this.setIdade(id);
            this.setAltura(al);
            this.setPeso(pe);
            this.setVitorias(vi);
            this.setDerrotas(de);
            this.setEmpates(em);
            
        }
        public int getEmpates()
        {
            return this.empates;
        }
        public void setEmpates(int em)
        {
            this.empates = em;
        }
        public int getDerrotas()
        {
            return this.derrotas;
        }
        public void setDerrotas(int de)
        {
            this.derrotas=de;
        }
        public int getVitorias()
        {
            return this.vitorias;
        }
        public void setVitorias(int vi)
        {
            this.vitorias=vi;
        }
        public string getCategoria()
        {
            return this.categoria;
        }
        private void setCategoria()
        {
            if(this.peso<52.2)
            {
                this.categoria = "INVÁLIDO";
            }
            else if(this.peso<=70.3)
            {
                this.categoria = "LEVE";
            }
            else if (this.peso<=83.9)
            {
                this.categoria = "MÉDIO";
            }
            else if (this.peso<=120.2)
            {
                this.categoria = "PESADO";
            }
            else 
            {
                this.categoria = "INVÁLIDO";
            }
        }
        public double getPeso()
        {
            return this.peso;
        }
        public void setPeso(double pe)
        {
            this.peso=pe;;
            this.setCategoria();
        }
        public int getIdade()
        {
            return this.idade;
        }
        public void setIdade(int id)
        {
            this.idade = id;
        }
        public double getAltura()
        {
            return this.altura;
        }
        public void setAltura(double alt)
        {
            this.altura=alt;
        }


        public string getNacionalidade()
        {
            return this.nacionalidade;
        }
        public void setNacionalidade(string na)
        {
            this.nacionalidade = na;
        }
        public string getNome()
        {
            return this.nome;
        }
        public void setNome(string no)
        {
            this.nome=no;
        }

        //Métodos públicos.
        public void Apresentar()
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("CHEGOU A HORA! Apresentamos o lutador " + this.getNome());
            Console.WriteLine("Diretamente de " + this.getNacionalidade());
            Console.WriteLine("com " + this.getIdade() + " anos e " + this.getAltura() + " metros");
            Console.WriteLine("pesando " + this.getPeso() + " kg");
            Console.WriteLine(this.getVitorias() + " vitórias");
            Console.WriteLine(this.getDerrotas() + " derrotas");
            Console.WriteLine("e " + this.getEmpates() + " empates!");
            Console.WriteLine("------------------------------------------------------------------");
            Console.ReadKey();  
        }
        public void Status()
        {
            Console.WriteLine("------------------------------------------------------------------");

            Console.Write("NOME:\t" + this.getNome());
            Console.WriteLine("\t//\tCATEGORIA:\t PESO " + this.getCategoria());
            Console.WriteLine("Vitorias: {0} // Derrotas: {1} // Empates: {2}",this.getVitorias(),
                                                                               this.getDerrotas(),
                                                                               this.getEmpates()); 
            Console.WriteLine("------------------------------------------------------------------");
            Console.ReadKey();
        }
        public void GanharLuta()
        {
            this.setVitorias(this.getVitorias() + 1);
        }
        public void PerderLuta()
        {
            this.setDerrotas(this.getDerrotas() + 1);
        }
        public void EmpatarLuta()
        {
            this.setEmpates(this.getEmpates() + 1);
        }
        

    }
}