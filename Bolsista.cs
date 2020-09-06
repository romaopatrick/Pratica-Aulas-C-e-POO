using System.Runtime.CompilerServices;
using System;

namespace Ex_2
{
    public sealed class Bolsista : Aluno
    {
        private float bolsa;
        public float Bolsa
        {
            get { return bolsa; }
            set { bolsa = value; }
        }
        public void RenovarBolsa()
        {
            Console.WriteLine("Renovando bolsa de: " + this.Nome);
        }
        public override void PagarMensalidade()
        {
            Console.WriteLine(this.Nome + " é bolsista // Pagamento Facilitado.");
        }
    }
}