using Microsoft.AspNetCore.Mvc;

namespace MainApp.Controllers;

public class MainChapterController : Controller
{
    public IActionResult Gallery()
    {
        return View();
    }
    
    public IActionResult Vacancies()
    {
        return View();
    }

    public IActionResult Contacts()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }
}
