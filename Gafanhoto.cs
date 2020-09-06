namespace Ex_4
{
    public class Gafanhoto : Pessoa
    {
        private string login;
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        private int totAssistido;

        public Gafanhoto(string name, int age, char genre, string login) : base(name, age, genre)
        {
            this.Login = login;
            this.totAssistido = 0;
        }

        public int TotAssistido
        {
            get { return totAssistido; }
            set { totAssistido = value; }
        }
        
        public void ViuMaisUm()
        {
            this.GanharExp();
        }
        public override string Status()
        {
            return base.Status() + "\n\tLogin: " + this.Login;
        }

    }
}