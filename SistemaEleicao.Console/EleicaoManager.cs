
using System.Collections.Generic;

namespace SistemaEleicao.Console
{
    public class EleicaoManager
    {
        private readonly List<Candidato> candidatos = new List<Candidato>();

        public bool CadastrarCandidato(string nome, int numero)
        {
            foreach (Candidato candidato in candidatos)
            {
                if (candidato.Numero == numero)
                {
                    return false;
                }
            }

            Candidato novoCandidato = new Candidato(nome, numero);
            candidatos.Add(novoCandidato);

            return true;
        }
    }
}
