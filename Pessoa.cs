namespace Ex_4
{
    public abstract class Pessoa
    {
        protected string nome;
        public string Nome
        {
            get { return nome;}
            set { nome = value;}
        }
        protected int idade;
        public int Idade
        {
            get { return idade;}
            set { idade = value;}
        }
        protected char sexo;
        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        protected float experiencia;
        public float Experiencia
        {
            get { return experiencia; }
            set { experiencia = value; }
        }
        public Pessoa (string name, int age, char genre)
        {
            this.Nome = name;
            this.Idade = age;
            this.Sexo = genre;
            this.Experiencia = 0;

        }
        protected void GanharExp()
        {
            this.Experiencia ++;
        }
        public virtual string Status()
        {
            return "Gafanhoto:\n{" + "\n Nome: " + this.Nome + "\n Idade: " + this.Idade + "\n Sexo: "
            + this.Sexo + "\n}";
        }
    }
}