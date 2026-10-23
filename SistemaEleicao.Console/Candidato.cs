
namespace SistemaEleicao.Console
{
    public class Candidato
    {
        public string Nome { get; private set; }
        public int Numero { get; private set; }
        public int TotalVotos { get; private set; }

        public Candidato(string nome, int numero)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("O nome do candidato é obrigatório.");
            }

            if (numero <= 0)
            {
                throw new ArgumentException("O número do candidato deve ser positivo.");
            }

            Nome = nome;
            Numero = numero;
            TotalVotos = 0;
        }

        public void RegistrarVoto()
        {
            TotalVotos++;
        }
    }
}
