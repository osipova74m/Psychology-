using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationmvs1.Models;

namespace WebApplicationmvs1.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            //var model = new List<PostText>();
            // example of view render a list
            //todo: transform this into context call (get from database)
            // PostText pt = new PostText
            //{
            //  Body = "best regard",
            //Name = "Perseptoin",
            //Id = Guid.NewGuid()
            //};
            //model.Add(pt);
            // return View(model);

            //  2 способ
             List<PostText> model = new List<PostText>();
             //Add parts to the list.
             model.Add(new PostText() { Body = "arm1", Name = "First", Id = Guid.NewGuid() });
             model.Add(new PostText() { Body = "arm2", Name = "Second", Id = Guid.NewGuid() });
             model.Add(new PostText() { Body = "arm3", Name = "Fird", Id = Guid.NewGuid() });

             return View(model);

            
        }
        // 3 способ                      


        



    }
}