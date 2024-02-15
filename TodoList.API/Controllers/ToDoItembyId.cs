using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TodoList.Models;

namespace TodoList.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ToDoItembyIdController : ControllerBase
    {
        private readonly List<ToDoItem> _todoItems;



        [HttpGet("{id}")]
        public ToDoItem GetToDoItemById(int id)
        {
            var todoItem = _todoItems.FirstOrDefault(item => item.Id == id);

            return todoItem;
        }
    }
}
