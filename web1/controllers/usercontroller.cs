// This brings all the MVC features we need to this file
using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace Web1.Controllers;   
public class UserController : Controller   // Remember inheritance?    
{      
    [HttpGet("")] // We will go over this in more detail on the next page    
     // We will go over this in more detail on the next page
    public ViewResult Index()        
    {            
     return View("Index");        
    }   
[HttpGet("user/{name}/{surname}")]
public ViewResult User2(string name,string surname){
   
    ViewBag.test="test";
    ViewBag.name=name;
    ViewBag.surname=surname;
   
    return View();
}



}