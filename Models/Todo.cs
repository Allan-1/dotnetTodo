using System.ComponentModel.DataAnnotations;

namespace RazorTodoApp.Models;

public class Todo
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    [DataType(DataType.Date)]
    public DateTime ToBeCompleted { get; set; }
}