namespace FirstProject.Services;

public class TodosService
{
    private readonly TodoRepository _repo;
    public TodosService(TodoRepository repo)
    {
        _repo = repo;
    }

    internal Todo CreateTodo(Todo todoData)
    {
        Todo todo = _repo.CreateTodo(todoData);
        return todo;
    }

    public List<Todo> GetAllTodos()
    {
        List<Todo> todos = _repo.GetAllTodos();
        return todos;
    }

    internal string RemoveTodo(int todoId)
    {
        Todo todo = _repo.GetById(todoId);
        if (todo == null) throw new Exception("the todo does not exist");
        _repo.RemoveTodo(todoId);
        return $"todo deleted from your list";

    }

    internal Todo UpdateTodo(Todo updateData)
    {
        Todo original = _repo.GetById(updateData.Id);
        if (original == null) throw new Exception($"No Todo at Id : {updateData.Id}");
        original.Description = updateData.Description != null ? updateData.Description : original.Description;
        original.Name = updateData.Name != null ? updateData.Name : original.Name;
        original.IsComplete = updateData.IsComplete != null ? updateData.IsComplete : original.IsComplete;

        _repo.UpdateTodo(updateData);
        return updateData;

    }
}
