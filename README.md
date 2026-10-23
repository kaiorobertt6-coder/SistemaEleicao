# SistemaEleicao

## Descrição
Sistema de eleição desenvolvido em C# como atividade da disciplina de Gestão e Qualidade de Software. O projeto permite cadastrar candidatos e eleitores, registrar votos e consultar o resultado da eleição.

## Funcionalidades
- Cadastro de candidatos com nome e número.
- Bloqueio de números duplicados de candidatos.
- Cadastro de eleitores por título.
- Bloqueio de títulos duplicados.
- Registro de votos por número de candidato.
- Impedimento de mais de um voto por eleitor.
- Contabilização de votos brancos e nulos.
- Exibição da quantidade de votos por candidato e identificação do vencedor.
- Testes automatizados com xUnit.

## Tecnologias utilizadas
- C#
- .NET 10
- xUnit
- Git e GitHub

## Como executar

Na pasta raiz do projeto, execute:

```bash
dotnet test
```

Para iniciar o sistema:

```bash
dotnet run --project SistemaEleicao.Console
```

## Estrutura do projeto

- `SistemaEleicao.Console`: aplicação e regras de negócio.
- `SistemaEleicao.Tests`: testes automatizados.

## Autor
Desenvolvido como atividade acadêmica da disciplina de Gestão e Qualidade de Software.
