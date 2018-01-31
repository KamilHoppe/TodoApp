using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoApp.Context;
using TodoApp.Models;

namespace TodoApp.Controllers
{
    public class HomeController : Controller
    {
        private IRepository interfaceobj;

        public HomeController()
        {
            this.interfaceobj = new TodoRepository(new TodoTable());
        }

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Todo todo)
        {
            todo.Date = DateTime.Now;
            interfaceobj.InsertTodo(todo);
            interfaceobj.Save();
            ModelState.Clear();
            return View(todo);
        }
      
        public ActionResult ShowTodo()
        {
            return PartialView("_ShowTodo", interfaceobj.GetTodo());
        }
        //public ActionResult Details(int id)
        //{
        //    Todo todo = interfaceobj.getTodoByID(id);
        //    return View(todo);
        //}

        //public ActionResult Edit(int id)
        //{
        //    Todo todo =interfaceobj.getTodoByID(id);
        //    return View(todo);
        //}
        //[HttpPost]
        //public ActionResult Edit(int id, Todo todo)
        //{
        //    interfaceobj.UpdateTodo(todo);
        //    interfaceobj.Save();
        //    return RedirectToAction("index");
        //}

        public ActionResult Delete(int id)
        {
            Todo todo = interfaceobj.getTodoByID(id);
            return View(todo);
        }
        [HttpPost]
        public ActionResult Delete(int id, Todo todo)
        {
            interfaceobj.DeleteTodo(id);
            interfaceobj.Save();
            return RedirectToAction("index");
        }

    }
}