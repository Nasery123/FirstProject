namespace FirstProject.Controllers;
//  then make the controlers put them under the apiContorller and then define the route.
//  the [HTTGET] specifies the get api for the method we wrote. After getting the methodes doen then go to the service and write the service.


[ApiController]
[Route("api/todos")]
public class TodosController : ControllerBase
{
    private readonly TodosService _todosService;

    public TodosController(TodosService todosService)
    {
        _todosService = todosService;
    }

    [HttpPost]
    public ActionResult<Todo> CreateTodo([FromBody] Todo todoData)
    {
        try
        {
            Todo todo = _todosService.CreateTodo(todoData);
            return Ok(todo);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet]
    public ActionResult<List<Todo>> GetAllTodos()
    {
        try
        {
            List<Todo> todos = _todosService.GetAllTodos();
            return Ok(todos);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpDelete("{todoId}")]
    public ActionResult<string> RemoveTodo(int todoId)
    {
        try
        {
            string message = _todosService.RemoveTodo(todoId);
            return Ok(message);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpPut("{todoId}")]
    public ActionResult<Todo> UpdateTodo(int todoId, [FromBody] Todo updateData)
    {
        try
        {
            updateData.Id = todoId;
            Todo todo = _todosService.UpdateTodo(updateData);
            return Ok(todo);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

}
