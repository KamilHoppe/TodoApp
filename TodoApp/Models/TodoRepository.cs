using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TodoApp.Context;
using TodoApp.Models;

namespace TodoApp.Models
{
    public class TodoRepository : IRepository
    {
        private TodoTable _context;

        public TodoRepository(TodoTable _context)
        {
            this._context = _context;
        }
        public void DeleteTodo(int id)
        {
            Todo todo = _context.Todos.Find(id);
            _context.Todos.Remove(todo);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Todo> GetTodo()
        {
            return _context.Todos.ToList();
        }

        public Todo getTodoByID(int id)
        {
            return _context.Todos.Find(id);
        }

        public void InsertTodo(Todo todo)
        {
            _context.Todos.Add(todo);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateTodo(Todo todo)
        {
            _context.Entry(todo).State = System.Data.Entity.EntityState.Modified;
        }
    }
}