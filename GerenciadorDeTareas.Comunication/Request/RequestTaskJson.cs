using GerenciadorDeTareas.Comunication.Enum;

namespace GerenciadorDeTareas.Comunication.Request;
public class RequestTaskJson
{
    public string Name { get; set; } = string.Empty;
    public string Discription { get; set; } = string.Empty;
    public TaskPriority Priority { get; set; }
    public DateTime Deadline { get; set; }
    public Enum.TaskStatus Status { get; set; }
}
