using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoApp.Models
{
     interface IRepository : IDisposable
    {
        IEnumerable<Todo> GetTodo();
        Todo getTodoByID(int id);
        void InsertTodo(Todo todo);
        void DeleteTodo(int id);
        void UpdateTodo(Todo todo);
        void Save();
     
    }
}