using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Models;
using TodoList.API;

namespace TodoList.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoItemstoController : ControllerBase
    {
        private readonly DataContext _context;

        public ToDoItemstoController(DataContext context)
        {
            _context = context;
        }

        // GET: api/ToDoItems
        [HttpGet]
        public async Task<IList<ToDoItem>> GetToDoItems()
        {
            return await _context.ToDoItems.Where(item => item.CompletedDate == null).ToListAsync();
        }
    }
}