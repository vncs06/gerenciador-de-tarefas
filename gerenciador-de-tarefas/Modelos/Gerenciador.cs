namespace Gerenciador.Tarefas;

class GerenciadorTarefas
{
    public List<Tarefas> tarefas = new();

    public void AdicionarTarefaLista(Tarefas tarefa)
    {
        tarefas.Add(tarefa);

    }

}