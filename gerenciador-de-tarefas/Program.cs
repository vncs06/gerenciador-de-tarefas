using Gerenciador.Tarefas;

GerenciadorTarefas lista = new();

Tarefas teste = new();
teste.Titulo = "teste";
teste.Descricao = "teste";
teste.DataDeVencimento = 30062006;
teste.Status = "Pendente";
//GerenciadorTarefas testeObjeto = new(teste);

void Menu()
{
    Console.WriteLine("Bem vindo ao gerenciador de tarefas!\n");
    Console.WriteLine("1 - Adicioar Tarefa");
    Console.WriteLine("2 - Listar Tarefas");
    Console.WriteLine("3 - Atualizar Tarefas");
    Console.WriteLine("4 - Excluir Tarefas");
    Console.WriteLine("5 - Sair do programa");
    Console.Write("\nEscolha uma opcao: ");
    string escolha = Console.ReadLine()!;

    switch(int.Parse(escolha)) {
        case 1: AdicionarTarefa();
            break;
        case 2: ListarTarefas();
            break;
        case 3: AtualizarTarefa();
            break;
        case 4: ExcluirTarefa();
            break;
        case 5: SairPrograma();
            break;

    }

}

Menu();


void AdicionarTarefa()
{
    Tarefas tarefa = new();
    Console.Clear();
    Console.Write("Digite o nome da tarefa: ");
    tarefa.Titulo = Console.ReadLine()!;
    Console.Write("Descreva a tarefa: ");
    tarefa.Descricao = Console.ReadLine()!;
    Console.Write("Qual o prazo limite para concluir essa tarefa?: ");
    tarefa.DataDeVencimento = int.Parse(Console.ReadLine()!);
    Console.Write("Defina o Status(Pendente ou Concluido): ");
    string status = Console.ReadLine()!;
    if (status == "Pendente" || status == "Concluido")
    {
        tarefa.Status = status;
    }
    else
    {
        Console.WriteLine("Digite um status valido!");

    }
    lista.AdicionarTarefaLista(tarefa);
    Console.WriteLine("Tarefa adicionada com sucesso! Aperte Qualquer tecla para voltar ao Menu");
    Console.ReadKey();
    Console.Clear();
    Menu();

}

void ListarTarefas()
{
    Console.Clear();
    Console.WriteLine("Segue a lista de tarefas atualmente: \n");
    foreach (Tarefas i in lista.tarefas)
    {
        Console.WriteLine(i.Titulo);

    }
    Console.Write("\nPressione qualquer tecla para voltar ao menu de opcoes...");
    Console.ReadKey();
    Console.Clear();
    Menu();

}

void AtualizarTarefa()
{
    Console.Clear();
    Console.Write("Digite o nome da tarefa que voce deseja atualizar: ");
    string titulo = Console.ReadLine()!;

    Tarefas tarefaEncontrada = lista.tarefas.Find(t => t.Titulo == titulo);

    if (tarefaEncontrada != null)
    {
        Console.WriteLine($"O que deseja fazer com {tarefaEncontrada.Titulo}?\n");

        Console.Write("Deseja mudar o nome? (Caso nao deixe em branco)");
        string novoTitulo = Console.ReadLine()!;
        if (!string.IsNullOrEmpty(novoTitulo))
        {
            tarefaEncontrada.Titulo = novoTitulo;

        }
        Console.Write("Deseja mudar a descricao? Caso nao queira deixe em branco: ");
        string novaDescricao = Console.ReadLine()!;
        if (!string.IsNullOrEmpty(novaDescricao))
        {
            tarefaEncontrada.Descricao = novaDescricao;

        }
        Console.Write("Deseja mudar a data de vencimento? Caso nao queira deixe em branco: ");
        string novaDatadeVencimento = (Console.ReadLine()!);
        if (!string.IsNullOrEmpty(novaDatadeVencimento))
        {
            tarefaEncontrada.DataDeVencimento = int.Parse(novaDatadeVencimento);

        }
        Console.Write("Deseja atualizar os Status da tarefa? Caso nao queira deixe em branco: ");
        string novoStatus = Console.ReadLine()!;
        if (!string.IsNullOrEmpty(novoStatus))
        {
            tarefaEncontrada.Status = novoStatus;

        }

        Console.Write("Tarefas atualizadas, aperte qualquer tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        Menu();


    }
    else
    {
        Console.Write("Tarefa nao encontrada, pressione qualquer tecla para voltar ao Menu.");
        Console.ReadKey();
        Console.Clear();
        Menu();

    }


}

void ExcluirTarefa()
{
    Console.Clear();
    Console.Write("Qual Tarefa voce deseja excluir? Digite o nome da mesma: ");
    string tarefaExcluir = Console.ReadLine()!;

    Tarefas tarefaEncontarda = lista.tarefas.Find(t => t.Titulo == tarefaExcluir);

    if (!string.IsNullOrEmpty(tarefaExcluir))
    {
        lista.tarefas.Remove(tarefaEncontarda);
        Console.WriteLine("Tarefa excluida, pressione qualquer botao para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        Menu();

    }
    else
    {
        Console.WriteLine("Tarefa nao existente ou campo nao preenchido, pressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }

}

void SairPrograma()
{
    Menu();
}