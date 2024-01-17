using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BeltExam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Identity;

namespace BeltExam.Controllers;
public class SessionCheckAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        int? userId = context.HttpContext.Session.GetInt32("UserId");
        if (userId == null)
        {
            context.Result = new RedirectToActionResult("Auth", "Home", null);
        }
    }
}

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private MyContext _context;

    public HomeController(ILogger<HomeController> logger , MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("Auth")]
    public IActionResult Auth()
    {
        return View();
    }
    [HttpPost("Register")]
    public IActionResult Register(User useriNgaForma)
    {

        if (ModelState.IsValid)
        {
            PasswordHasher<User> Hasher = new PasswordHasher<User>();
            useriNgaForma.Password = Hasher.HashPassword(useriNgaForma, useriNgaForma.Password);
            _context.Add(useriNgaForma);
            _context.SaveChanges();
            return RedirectToAction("Auth");
        }
        return View("Auth");

    }

        [HttpPost("Login")]
    public IActionResult Login(Login useriNgaForma)
    {

        if (ModelState.IsValid)
        {

            User useriNgaDB = _context.Users
            .FirstOrDefault(e => e.Username == useriNgaForma.Username);
            if (useriNgaDB == null)
            {
                ModelState.AddModelError("LoginEmail", "Invalid Email");
                return View("Auth");
            }

            PasswordHasher<Login> hasher = new PasswordHasher<Login>();
            var result = hasher.VerifyHashedPassword(useriNgaForma, useriNgaDB.Password, useriNgaForma.Password);
            if (result == 0)
            {
                ModelState.AddModelError("LoginPassword", "Invalid Password");
                return View("Auth");
            }
            HttpContext.Session.SetInt32("UserId", useriNgaDB.UserId);
            return RedirectToAction("Index");

        }
        return View("Auth");

    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
