using CRUDdatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDdatos.Controllers
{
    
    public class DatosController : Controller
    {
        datosPersonalesContext obj = new datosPersonalesContext();
        // GET: Datos
        public ActionResult Index()
        {
            var list = obj.datosPersonales.ToList();
            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(datosPersonales info)
        {
            if (ModelState.IsValid)
            {
                obj.datosPersonales.Add(info);
                obj.SaveChanges();
                return RedirectToAction("Index");
            }
            
            return View(info);
        }
        public ActionResult Details(int id)
        {
            var registro = obj.datosPersonales.Find(id);
            return View(registro);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return Content("<center><font color='red' size='5'> <h1> Registro no encontrado</h1> </font> </center>");
            }
            var registro = obj.datosPersonales.Find(id);
            return View(registro);
        }
        [HttpPost]
        public ActionResult Delete(int id, datosPersonales datos)
        {
            var eliminar = obj.datosPersonales.Find(id);
            obj.datosPersonales.Remove(eliminar);
            obj.SaveChanges();
            return RedirectToAction("Index");
        }
         public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return Content("<center><font color='red' size='5'> <h1> Registro no encontrado</h1> </font> </center>");
            }
            var registro = obj.datosPersonales.Find(id);
            return View(registro);

        }
        [HttpPost]
        public ActionResult Edit (int? id, datosPersonales datos)
        {
            obj.Entry(datos).State = System.Data.Entity.EntityState.Modified;
            obj.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}