using Microsoft.AspNetCore.Mvc;
using TodoList.API.Models;

namespace TodoList.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CreateToDoItemController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateToDoItem([FromBody] ToDoItem todoItem)
        {
            // Logic to create a new ToDoItem
            // ...
            _context.ToDoItems.Add(toDoItem);
            await _context.SaveChangesAsync();

            // Return a 201 Created status code along with the created ToDoItem
            return CreatedAtAction(nameof(GetToDoItem), new { id = toDoItem.Id }, toDoItem);

            return Ok();
        }
    }
}
