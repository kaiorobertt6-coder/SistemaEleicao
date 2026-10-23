
using System;
using System.Collections.Generic;

namespace SistemaEleicao.Console
{
    public class EleicaoManager
    {
        private readonly List<Candidato> candidatos = new List<Candidato>();
        private readonly List<Eleitor> eleitores = new List<Eleitor>();

        public int VotosBrancos { get; private set; }
        public int VotosNulos { get; private set; }

        public bool CadastrarCandidato(string nome, int numero)
        {
            foreach (Candidato candidato in candidatos)
            {
                if (candidato.Numero == numero)
                    return false;
            }

            candidatos.Add(new Candidato(nome, numero));
            return true;
        }

        public bool CadastrarEleitor(string titulo)
        {
            if (string.IsNullOrWhiteSpace(titulo))
                return false;

            foreach (Eleitor eleitor in eleitores)
            {
                if (eleitor.Titulo == titulo)
                    return false;
            }

            eleitores.Add(new Eleitor(titulo));
            return true;
        }

        public bool RegistrarVoto(string titulo, string voto)
        {
            Eleitor eleitorEncontrado = null;

            foreach (Eleitor eleitor in eleitores)
            {
                if (eleitor.Titulo == titulo)
                {
                    eleitorEncontrado = eleitor;
                    break;
                }
            }

            if (eleitorEncontrado == null || eleitorEncontrado.JaVotou)
                return false;

            if (string.IsNullOrWhiteSpace(voto))
            {
                VotosBrancos++;
            }
            else if (int.TryParse(voto, out int numero))
            {
                Candidato candidatoEncontrado = null;

                foreach (Candidato candidato in candidatos)
                {
                    if (candidato.Numero == numero)
                    {
                        candidatoEncontrado = candidato;
                        break;
                    }
                }

                if (candidatoEncontrado == null)
                    VotosNulos++;
                else
                    candidatoEncontrado.RegistrarVoto();
            }
            else
            {
                VotosNulos++;
            }

            eleitorEncontrado.RegistrarVoto();
            return true;
        }

        public List<Candidato> ObterCandidatos()
        {
            return new List<Candidato>(candidatos);
        }

        public string ObterVencedor()
        {
            if (candidatos.Count == 0)
                return "Nenhum candidato cadastrado.";

            int maiorTotal = -1;

            foreach (Candidato candidato in candidatos)
            {
                if (candidato.TotalVotos > maiorTotal)
                    maiorTotal = candidato.TotalVotos;
            }

            int quantidadeEmpatados = 0;
            string vencedor = "";

            foreach (Candidato candidato in candidatos)
            {
                if (candidato.TotalVotos == maiorTotal)
                {
                    quantidadeEmpatados++;
                    vencedor = candidato.Nome;
                }
            }

            if (quantidadeEmpatados > 1)
                return "Empate";

            return vencedor;
        }
    }
}
