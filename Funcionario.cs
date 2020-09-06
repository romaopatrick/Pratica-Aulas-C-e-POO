using System;
using Ex_1;

namespace Ex_2
{
    public class Funcionario : Pessoa
    {
        private String setor;
        public String Setor
        {
            get { return setor; }
            set { setor = value; }
        }
        private bool trabalhando;
        public bool Trabalhando
        {
            get { return trabalhando; }
            set { trabalhando = value; }
        }
        
        public void mudarTrabalho()
        {
            this.trabalhando =! this.trabalhando;
        }
    }
}