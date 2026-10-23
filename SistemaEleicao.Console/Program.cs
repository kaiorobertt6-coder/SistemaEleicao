
using System;
using SistemaEleicao.Console;

EleicaoManager eleicao = new EleicaoManager();

int opcao;

do
{
    System.Console.WriteLine("\n===== SISTEMA DE ELEIÇÃO =====");
    System.Console.WriteLine("1 - Cadastrar candidato");
    System.Console.WriteLine("2 - Cadastrar eleitor");
    System.Console.WriteLine("3 - Registrar voto");
    System.Console.WriteLine("4 - Exibir resultado");
    System.Console.WriteLine("0 - Sair");
    System.Console.Write("Escolha uma opção: ");

    if (!int.TryParse(System.Console.ReadLine(), out opcao))
    {
        System.Console.WriteLine("Opção inválida.");
        continue;
    }

    switch (opcao)
    {
        case 1:
            System.Console.Write("Nome do candidato: ");
            string nome = System.Console.ReadLine() ?? "";

            System.Console.Write("Número do candidato: ");

            if (int.TryParse(System.Console.ReadLine(), out int numero))
            {
                try
                {
                    bool cadastrado = eleicao.CadastrarCandidato(nome, numero);

                    System.Console.WriteLine(
                        cadastrado
                            ? "Candidato cadastrado com sucesso!"
                            : "Já existe um candidato com esse número.");
                }
                catch (ArgumentException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
            }
            else
            {
                System.Console.WriteLine("Número inválido.");
            }
            break;

        case 2:
            System.Console.Write("Título do eleitor: ");
            string titulo = System.Console.ReadLine() ?? "";

            System.Console.WriteLine(
                eleicao.CadastrarEleitor(titulo)
                    ? "Eleitor cadastrado com sucesso!"
                    : "Título vazio ou já cadastrado.");
            break;

        case 3:
            System.Console.Write("Título do eleitor: ");
            string tituloVoto = System.Console.ReadLine() ?? "";

            System.Console.Write("Número do candidato (Enter para branco): ");
            string voto = System.Console.ReadLine() ?? "";

            System.Console.WriteLine(
                eleicao.RegistrarVoto(tituloVoto, voto)
                    ? "Voto registrado com sucesso!"
                    : "Eleitor não cadastrado ou já votou.");
            break;

        case 4:
            System.Console.WriteLine("\n===== RESULTADO DA ELEIÇÃO =====");

            foreach (Candidato candidato in eleicao.ObterCandidatos())
            {
                System.Console.WriteLine(
                    $"{candidato.Numero} - {candidato.Nome}: {candidato.TotalVotos} voto(s)");
            }

            System.Console.WriteLine($"Votos brancos: {eleicao.VotosBrancos}");
            System.Console.WriteLine($"Votos nulos: {eleicao.VotosNulos}");
            System.Console.WriteLine($"Vencedor: {eleicao.ObterVencedor()}");
            break;

        case 0:
            System.Console.WriteLine("Encerrando o sistema...");
            break;

        default:
            System.Console.WriteLine("Opção inválida.");
            break;
    }

} while (opcao != 0);
