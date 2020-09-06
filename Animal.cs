using System;

namespace Ex_3
{
    public abstract class Animal
    {
        private float peso;
        public float Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        private int idade;
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        private int membros;
        public int Membros
        {
            get { return membros; }
            set { membros = value; }
        }
        public abstract void Locomover();
        public abstract void Alimentar();
        public abstract void EmitirSom();
    }
}