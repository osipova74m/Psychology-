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
        //PostContext pc;  ошиб в назв
        public ActionResult Index()
        {
            var model = new List<PostText>();
            // example of view render a list
            //todo: transform this into context call (get from database)
            PostText pt = new PostText
            {
                Body = "fggfjjiutytygdfd",
                Name = "Perseptoin",
                Id = Guid.NewGuid()
            };
            
            PostText pt2 = new PostText
            {
                Body = "test cont",
                Name = "lsd",
                Id = Guid.NewGuid()
            };

            model.Add(pt);
            model.Add(pt2);
            
            
            return View(model);
        }

        

        
    }
}