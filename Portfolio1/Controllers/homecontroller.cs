// This brings all the MVC features we need to this file
using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace YourNamespace.Controllers;   
public class HelloController : Controller   // Remember inheritance?    
{      
    [HttpGet] // We will go over this in more detail on the next page    
    [Route("Index")] // We will go over this in more detail on the next page
    public string Index()        
    {            
    	return "This is my index!";        
    }  
    [HttpGet] // We will go over this in more detail on the next page    
    [Route("Projects")] // We will go over this in more detail on the next page
    public string Projects()        
    {            
    	return "These are my projects!";        
    }   
    [HttpGet] // We will go over this in more detail on the next page    
    [Route("Contact")] // We will go over this in more detail on the next page
    public string Contact()        
    {            
    	return "This is my Contact!";        
    }       
}

