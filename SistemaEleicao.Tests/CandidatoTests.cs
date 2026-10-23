using System;
using SistemaEleicao.Console;
using Xunit;

namespace SistemaEleicao.Tests
{
    public class CandidatoTests
    {
        [Fact]
        public void DeveCriarCandidatoComDadosValidos()
        {
            Candidato candidato = new Candidato("Ana", 10);

            Assert.Equal("Ana", candidato.Nome);
            Assert.Equal(10, candidato.Numero);
        }

        [Fact]
        public void NaoDeveCadastrarCandidatosComMesmoNumero()
        {
            EleicaoManager eleicao = new EleicaoManager();

            bool primeiroCadastro = eleicao.CadastrarCandidato("Ana", 10);
            bool segundoCadastro = eleicao.CadastrarCandidato("Carlos", 10);

            Assert.True(primeiroCadastro);
            Assert.False(segundoCadastro);
        }
    }
}