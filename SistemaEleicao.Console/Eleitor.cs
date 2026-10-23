
namespace SistemaEleicao.Console
{
    public class Eleitor
    {
        public string Titulo { get; private set; }
        public bool JaVotou { get; private set; }

        public Eleitor(string titulo)
        {
            Titulo = titulo;
            JaVotou = false;
        }

        public void RegistrarVoto()
        {
            JaVotou = true;
        }
    }
}
