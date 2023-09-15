using Microsoft.AspNetCore.Mvc;

namespace MainApp.Controllers;

public class SubChapterController : Controller
{
    public IActionResult Courses()
    {
        return View();
    }
    public IActionResult Intensive()
    {
        return View();
    }
    public IActionResult Services()
    {
        return View();
    }
    public IActionResult FAQ()
    {
        return View();
    }
}
