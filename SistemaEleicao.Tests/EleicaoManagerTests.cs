
using SistemaEleicao.Console;
using Xunit;

namespace SistemaEleicao.Tests
{
    public class EleicaoManagerTests
    {
        [Fact]
        public void DeveCadastrarCandidatoComNumeroUnico()
        {
            EleicaoManager eleicao = new EleicaoManager();

            bool resultado = eleicao.CadastrarCandidato("Ana", 10);

            Assert.True(resultado);
        }

        [Fact]
        public void NaoDeveCadastrarCandidatosComNumeroDuplicado()
        {
            EleicaoManager eleicao = new EleicaoManager();

            eleicao.CadastrarCandidato("Ana", 10);
            bool resultado = eleicao.CadastrarCandidato("Carlos", 10);

            Assert.False(resultado);
        }
    }
}


[Fact]
public void DeveCadastrarEleitorComTituloValido()
{
    EleicaoManager eleicao = new EleicaoManager();

    bool resultado = eleicao.CadastrarEleitor("123456");

    Assert.True(resultado);
}

[Fact]
public void NaoDeveCadastrarEleitorComTituloDuplicado()
{
    EleicaoManager eleicao = new EleicaoManager();

    eleicao.CadastrarEleitor("123456");
    bool resultado = eleicao.CadastrarEleitor("123456");

    Assert.False(resultado);
}
