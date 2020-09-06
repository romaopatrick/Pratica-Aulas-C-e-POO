using System;
using Ex_1;

namespace Ex_2
{
    public class Professor : Pessoa
    {
        private string  especialidade;
        public string  Especialidade
        {
            get { return especialidade; }
            set { especialidade = value; }
        }
        private float salario;
        public float Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public void receberAumento(float aum)
        {
            this.Salario += aum;
        }
    }
}