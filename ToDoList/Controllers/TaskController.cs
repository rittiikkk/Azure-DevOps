using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class TaskController : Controller
{
    private static List<string> tasks = new List<string>();

    public IActionResult Index()
    {
        ViewBag.Tasks = tasks;
        return View();
    }

    [HttpPost]
    public IActionResult AddTask(string task)
    {
        tasks.Add(task);
        return RedirectToAction("Index");
    }
}
