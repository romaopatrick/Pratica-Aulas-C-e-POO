using System;

namespace Ex_2
{
    public sealed class Tecnico : Aluno
    {
        private String rp;
        public String Rp
        {
            get { return rp; }
            set { rp = value; }
        }
        public void Praticar()
        {
            Console.WriteLine(this.Nome + " está praticando.");
        }
    }
}