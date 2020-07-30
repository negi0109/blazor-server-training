using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTraining.Data
{
    public class TodoListService
    {
        public List<Todo> todos = new List<Todo>();

		public void AddTodo(params string[] texts){
			foreach (var text in texts)
			{
				todos.Add(new Todo(text));
			}
		}
    }
}
