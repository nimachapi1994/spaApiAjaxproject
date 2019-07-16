using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPA_App.Controllers
{
    public class HomeController : Controller
    {
        SPA_App.Models.SpaModel db = new Models.SpaModel();
        public ActionResult Index()
        {
            //try
            //{
            //    db.persons.Add(new Models.person
            //    {
            //        Name="nima"
            //    });
            //    db.SaveChanges();
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            return View();
        }
        public ActionResult listperson()
        {
           // System.Threading.Thread.Sleep(3000);
            return PartialView();
        }
        public ActionResult Add()
        {
            return PartialView();
        }
        public ActionResult Edit(int id)
        {
            return PartialView(id);
        }

    }
}