using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Pages
{
    public partial class Todo
    {
        private IList<TodoItem> todos = new List<TodoItem>();
        private string newTodo;
        private void AddTodo()
        {
            if (!string.IsNullOrEmpty(newTodo))
            {
                todos.Add(new TodoItem() { Title = newTodo });
                newTodo = string.Empty;
            }
        }
    }
}
