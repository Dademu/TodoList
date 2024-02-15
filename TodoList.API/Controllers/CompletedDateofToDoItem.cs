using System;
using TodoList.Models;

namespace TodoList.API.Controllers
{
    public class CompletedDateofToDoItem
    {
        public void UpdateCompletedDate(ToDoItem item, DateTime completedDate)
        {
            item.CompletedDate = completedDate;
        }
    }
}
