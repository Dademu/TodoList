using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace TodoList.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ToDoItembyIdController : ControllerBase
    {
        private readonly List<ToDoItem> _todoItems;

        public ToDoItembyIdController()
        {
            // Initialize the list of ToDoItems
            _todoItems = new List<ToDoItem>
            {
                new ToDoItem { Id = 1, Title = "Task 1", IsCompleted = false },
                new ToDoItem { Id = 2, Title = "Task 2", IsCompleted = true },
                new ToDoItem { Id = 3, Title = "Task 3", IsCompleted = false }
            };
        }

        [HttpGet("{id}")]
        public ActionResult<ToDoItem> GetToDoItemById(int id)
        {
            var todoItem = _todoItems.FirstOrDefault(item => item.Id == id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }
    }

    public class ToDoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
    }
}
