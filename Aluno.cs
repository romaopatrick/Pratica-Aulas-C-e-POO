using System;
using Ex_1;

namespace Ex_2
{
    public class Aluno : Pessoa
    {
        private int matricula;
        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        private String curso;

        public String Curso
        {
            get { return curso; }
            set { curso = value; }
        }
        public virtual void PagarMensalidade()
        {
            Console.WriteLine("Pagando Mensalidade de aluno: " + this.Nome);
        }
    }
}