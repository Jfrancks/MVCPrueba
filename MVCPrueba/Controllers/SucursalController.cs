using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPrueba.Models;

namespace MVCPrueba.Controllers
{
    public class SucursalController : Controller
    {
        // GET: Sucursal
        public ActionResult Index()
        {
            using ( TiendaBDContext db = new TiendaBDContext())
            {

                return View(db.Sucursal.ToList());
            }
                
        }

        
      
        [HttpGet]
        public ActionResult Edit(int id)
        {
            using (TiendaBDContext db = new TiendaBDContext())
            {

                return View(db.Sucursal.FirstOrDefault(p => p.Id == id) );
            }
        }
        [HttpPost]
        public ActionResult Edit(Sucursal sucursal)
        {
            return View();
        }
    }
}