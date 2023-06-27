namespace FirstProject.Repositories;
public class TodoRepository
{
    private List<Todo> dbTodos;
    public TodoRepository()
    {
        this.dbTodos = new List<Todo> { };
        dbTodos.Add(new Todo("School", true, "home work for cominng check point", 1));
        dbTodos.Add(new Todo("Home Work", false, "Add some more functionality", 2));
        dbTodos.Add(new Todo("fs-journal", false, "make sure to answer all question", 3));
    }

    internal Todo CreateTodo(Todo todoData)
    {
        int lastId = dbTodos[dbTodos.Count - 1].Id;
        todoData.Id = lastId + 1;
        dbTodos.Add(todoData);
        return todoData;
    }

    internal List<Todo> GetAllTodos()
    {
        return dbTodos;
    }

    internal Todo GetById(int todoId)
    {
        Todo todo = dbTodos.Find(t => t.Id == todoId);
        return todo;
    }

    internal void RemoveTodo(int todoId)
    {
        Todo todo = dbTodos.Find(t => t.Id == todoId);
        dbTodos.Remove(todo);
    }

    internal void UpdateTodo(Todo updateData)
    {
        Todo todo = GetById(updateData.Id);
        todo = updateData;
    }
}
