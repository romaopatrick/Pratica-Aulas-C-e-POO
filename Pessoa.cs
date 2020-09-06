using System;

namespace Ex_1
{
    public class Pessoa
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private int idade;
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        private string sexo;
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        
        public Pessoa(string name, int age, string genre)
        {
            this.Nome=name;
            this.Idade=age;
            this.Sexo=genre;
        }
        public void FazerAniver()
        {
            this.Idade ++;
        }
        



    }
}