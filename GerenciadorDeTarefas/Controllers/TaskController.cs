using GerenciadorDeTareas.Comunication.Request;
using GerenciadorDeTareas.Comunication.Responses;
using GerenciadorDeTarefas.Application.UseCases.Task.Create;
using GerenciadorDeTarefas.Application.UseCases.Task.GetById;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeTarefas.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseCreateTaskJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]

    public IActionResult Create([FromBody] RequestTaskJson request)
    {
        var useCase = new CreateTaskUseCase();
        var response = useCase.Execute(request);

        return Created(string.Empty, response);
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult Get(Guid id)
    {
        var useCase = new GetTaskByIdUseCase();
        var response = useCase.Execute(id);

        return Ok(response);
    }

}