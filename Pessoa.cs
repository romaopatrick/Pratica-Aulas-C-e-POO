using System.Text;
using System;

namespace Ex_1
{
    public abstract class Pessoa
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
        public void  FazerAniver()
        {
            this.Idade ++;
        }
        public String Detalhes()
        {
            return "Pessoa{" + "\n Nome: " + this.Nome + "\n Idade: " 
            + this.Idade + "\n Sexo: " + this.Sexo + "\n}";
        }
    }
}