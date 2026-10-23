
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
    }
}
