// This brings all the MVC features we need to this file
using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace Portoflio1.Controllers;   
public class HelloController : Controller   // Remember inheritance?    
{      
    [HttpGet("")] // We will go over this in more detail on the next page    
    public string Index()        
    {            
    	return "This is my index!";        
    }  
    [HttpGet("Projects")]
    public string Projects()        
    {            
    	return "These are my projects!";        
    }   
    [HttpGet("Contacts")]
    public string Contact()        
    {            
    	return "This is my Contact!";        
    }       
}

