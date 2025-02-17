using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using cloudsoft.Models;

namespace cloudsoft.Controllers;

public class AboutusController : Controller
{
    
    public IActionResult Aboutus()
    {
        return View();
    }

    
}
