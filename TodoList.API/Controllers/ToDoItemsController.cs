using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TodoList.API;
using TodoList.Models;
using TodoList.API.Controllers;

namespace TodoList.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ToDoItemsController : ControllerBase

    {
        private readonly List<ToDoItem> _toDoItems;

        public ToDoItemsController()
        {
            // Initialize the list of ToDoItems
            _toDoItems = new List<ToDoItem>
            {
                new ToDoItem { Id = 1, Title = "Task 1", CompletedDate = null },
                new ToDoItem { Id = 2, Title = "Task 2", CompletedDate = null },
                new ToDoItem { Id = 3, Title = "Task 3", CompletedDate = null },
                new ToDoItem { Id = 4, Title = "Task 4", CompletedDate = null },
                new ToDoItem { Id = 5, Title = "Task 5", CompletedDate = null }
            };
        }

        [HttpGet]
        public IList<ToDoItem> GetToDoItems()
        {
            // Filter the ToDoItems with no CompletedDate set
            var items = _toDoItems.Where(item => item.CompletedDate == null).ToList();
            return (items);
        }
    }
}
