using SPA_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SPA_App.Controllers
{
    public class personController : ApiController
    {
        SpaModel db = new SpaModel();
        public List<person> Get()
        {
            return db.persons.ToList();
        }
      public person GetById(int id)
        {
            return db.persons.Find(id);
        }
        public void Post(person p)
        {
            //db.persons.Add(p);
            //db.SaveChanges();
            db.Entry(p).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
        }
        public void Put (int id,person p)
        {
            if(id==p.Id)
            {
                db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            db.persons.Remove(db.persons.Find(id));
            db.SaveChanges();
        }
    }
}
