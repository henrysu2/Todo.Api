using Microsoft.AspNetCore.Mvc;

namespace Todo.Api.Controllers
{
    [ApiController]
    [Route("api/todos")]
    public class TodoItemsController : ControllerBase
    {
[HttpGet]
public IActionResult GetTodos()
{
    var result = new List<TodoItem>(){
        new TodoItem{ ID = 1, Action= "Thing one.", IsDone=true},
        new TodoItem{ ID = 2, Action="Thing two.", IsDone=false},
    };
    return Ok(result);
}
    }
}
