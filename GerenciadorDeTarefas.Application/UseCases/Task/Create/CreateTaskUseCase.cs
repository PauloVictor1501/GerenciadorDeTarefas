using GerenciadorDeTareas.Comunication.Request;
using GerenciadorDeTareas.Comunication.Responses;

namespace GerenciadorDeTarefas.Application.UseCases.Task.Create;
public class CreateTaskUseCase
{
    public ResponseCreateTaskJson Execute(RequestTaskJson request)
    {
        return new ResponseCreateTaskJson
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Priority = request.Priority,
        };
    }
}
