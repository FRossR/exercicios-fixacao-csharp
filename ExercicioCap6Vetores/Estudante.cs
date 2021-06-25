namespace ExercicioCap6Vetores
{
    class Estudante
    {
        public string NomeEstudante { get; set; }
        public string EMail { get; set; }

        public Estudante(string nomeEstudante, string eMail)
        {
            NomeEstudante = nomeEstudante;
            EMail = eMail;
        }

        public override string ToString()
        {
            return NomeEstudante + " , " + EMail;

        }
    }
}
