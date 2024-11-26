using GerenciadorDeTareas.Comunication.Responses;

namespace GerenciadorDeTarefas.Application.UseCases.Task.GetById;
public class GetTaskByIdUseCase
{
    public ResponseTaskJson Execute (Guid id)
    {
        return new ResponseTaskJson
        {
            Id = id,
            Name = "Isso seria buscado no banco de dados",
            Status = GerenciadorDeTareas.Comunication.Enum.TaskStatus.aguardando,
            Priority = GerenciadorDeTareas.Comunication.Enum.TaskPriority.baixa,
        };
    }
}
