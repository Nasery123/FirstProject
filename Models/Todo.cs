// for importing and exporting classes we should put the nam eof our class in namespaces. then go to controller
using System.ComponentModel.DataAnnotations;
namespace FirstProject.Models;


public class Todo
{
    public Todo(string description, bool isComplete, string name, int id)
    {
        Description = description;
        Name = name;
        IsComplete = isComplete;
        Id = id;
    }

    public int Id { get; set; }

    public string Description { get; set; }
    public bool? IsComplete { get; set; }
    public string Name { get; set; }

}
