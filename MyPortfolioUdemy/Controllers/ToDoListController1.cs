using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class ToDoListController1 : Controller
    {MyPortfolioContext context=new MyPortfolioContext();
        public IActionResult Index()
        {
            var values = context.ToDoLists1.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateToDoList()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateToDoList(ToDoList toDoList)
        {
            toDoList.Status = false;
            context.ToDoLists1.Add(toDoList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteToDoList(int id)
        {
            var values = context.ToDoLists1.Find(id);
            context.ToDoLists1.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateToDoList(int id)
        {
            var values = context.ToDoLists1.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateToDoList(ToDoList toDoList)
        {
            context.ToDoLists1.Update(toDoList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatusToDoListTrue(int id)
        {
            var value = context.ToDoLists1.Find(id);
            value.Status = true;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ChangeStatusToDoListFalse(int id)
        {
            var value = context.ToDoLists1.Find(id);
            value.Status = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
