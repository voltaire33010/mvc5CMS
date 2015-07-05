using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using asptraining;
using asptraining.Models;
using asptraining.Services;
namespace asptraining.Controllers
{
  
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            System.Console.WriteLine("hello there from Post");
            return View();
        }
        
       
       [HttpGet]
     //  [Route("edit/{id}")]
        public IActionResult Edit(string id)
        {
            //todo
            var model= new Post();
            return View(model);
            
        }
        
     [HttpPost]
       [ValidateAntiForgeryToken]
       // [Route("edit/{id}")]
        public IActionResult Edit(Post model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
//todo
             return RedirectToAction("index");
        }
        
     [HttpGet] 
      // [Route("create")]
        public IActionResult Create()
        {
             System.Console.WriteLine("hello there from create");
             var model= new Post();
            return View(model);
            
        }
     [HttpPost]
     [ValidateAntiForgeryToken]
      //  [Route("create")]
        public IActionResult Create(Post model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
//todo
             return RedirectToAction("index");
        }
        
        

       
    }
}