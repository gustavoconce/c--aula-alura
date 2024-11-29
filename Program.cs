// ScreenSound
string mensagemBoasVindas = "Boas vindas ao Screen Sound!";

//Lista
// List <string> listaDasBandas = new List<string> {"U2", "AC/DC", "Metallica"};

//Dicionário
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("U2", new List<int> { 2, 8, 6 });
bandasRegistradas.Add("Linkin Park", new List<int>());

//Criar Funções:
void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine("");
    Console.WriteLine(mensagemBoasVindas);
    Console.WriteLine("");
    Console.WriteLine("Github.com/gustavoconce");
    Console.WriteLine("");
    Console.WriteLine("");
}

void ExibirTituloEscolha(string titulo)
{
    Console.WriteLine(titulo);
    Console.WriteLine("-------------------------");
    Console.WriteLine("");
}

void ExibirOpcoesMenu()
{

    ExibirLogo();

    Console.WriteLine("Menu:");
    Console.WriteLine("");
    Console.WriteLine("1. Registrar Banda");
    Console.WriteLine("2. Listar Bandas");
    Console.WriteLine("3. Avaliar Banda");
    Console.WriteLine("4. Exibir média de avaliação");
    Console.WriteLine("5. Sair da aplicação\n");

    Console.Write("Escolha uma opção: ");
    string resposta = Console.ReadLine()!;
    //convertendo string para int
    int respostaInt = int.Parse(resposta);

    //estrutura switch case
    switch (respostaInt)
    {
        case 1: RegistrarBanda();
            break;
        case 2: ListarBandas();
            break;
        case 3: AvaliarBandas();
            break;
        case 4: ObterMedias();
            break;
        case 5:
            Console.WriteLine("");
            Console.WriteLine("Que pena... Até a próxima!");
            break;
        default:
            Console.WriteLine("");
            Console.WriteLine("Opção inválida!");
            break;
    }
}

//Função 1
void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloEscolha("Registrar Banda");

    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;

    bandasRegistradas.Add(nomeBanda, new List<int>() );

    Console.WriteLine("");
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");

    Console.WriteLine("");
    Console.WriteLine("Aguarde....");

    Thread.Sleep(2000);

    Console.Clear();
    ExibirOpcoesMenu();
}

//Função 2
void ListarBandas()
{
    Console.Clear();
    ExibirTituloEscolha("Listando bandas:");

    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"{i + 1} - : {listaDasBandas[i]} ");
    //    Console.WriteLine("");
    //}

    //ForEach:
    int i = 0;
    foreach (string banda in bandasRegistradas.Keys)
    {
        i++;
        Console.WriteLine($"{i} - {banda}");
        Console.WriteLine("");
    }

    Console.WriteLine("");
    Console.WriteLine("Digite qualquer tecla para sair...");
    Console.WriteLine("");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

//Função 3

void AvaliarBandas()
{
    Console.Clear();
    ExibirTituloEscolha("Avaliar Banda");

    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        Console.Write($"Digite uma nota para {nomeBanda}: ");
        int nota = int.Parse(Console.ReadLine()!);

        bandasRegistradas[nomeBanda].Add(nota);

        Console.WriteLine("");
        Console.WriteLine($"A nota {nota} foi registrada com sucesso!");
        Console.WriteLine("");


        Console.WriteLine("");
        Console.WriteLine("Aguarde....");

        Thread.Sleep(2000);

        Console.Clear();
        ExibirOpcoesMenu();
    } 
    
    else
    {
        Console.WriteLine($"A banda {nomeBanda} não foi encontrada!");
        Console.WriteLine("");
        Console.WriteLine("Digite qualquer tecla para sair...");
        Console.WriteLine("");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }

}


//Função 4 

void ObterMedias()
{
    Console.Clear();
    ExibirTituloEscolha("Obter média da banda");

    Console.Write("Digite o nome da banda que deseja ver média de avaliações: ");
    string nomeBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        List<int> notasDaBanda = bandasRegistradas [nomeBanda];
        Console.WriteLine("");
        Console.WriteLine($"A média da banda {nomeBanda} é: {notasDaBanda.Average()}.");
        Console.WriteLine("");


        Console.WriteLine("Digite qualquer tecla para sair...");
        Console.WriteLine("");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();

    }
    else
    {
        Console.WriteLine($"A banda {nomeBanda} não foi encontrada!");
        Console.WriteLine("");
        Console.WriteLine("Digite qualquer tecla para sair...");
        Console.WriteLine("");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }
}


ExibirOpcoesMenu();

