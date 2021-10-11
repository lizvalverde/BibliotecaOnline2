using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebBibliotecaOnline2.Models;

namespace WebBibliotecaOnline2.Controllers
{
    public class TipoBibliotecaController : Controller
    {
        // GET: TipoBiblioteca
        public ActionResult Index()
        {
            try
            {
                List<TipoBiblioteca> lista = new List<TipoBiblioteca>();
                var db = new Dani_BibIiotecaEntities();
                lista = db.TipoBiblioteca.ToList();
                db.Dispose();
                
                return View(lista);
            }
            catch(Exception ex)
            {
                // Logger
                return ErrorController.capturaError(ex);
            }
            
        }

        public ActionResult Eliminar(int id)
        {
            try
            {   
                var db = new Dani_BibIiotecaEntities();   

                var objeto = db.TipoBiblioteca.Find(id);
                db.TipoBiblioteca.Remove(objeto);

                db.SaveChanges();
                db.Dispose();
                return RedirectToAction("Index", "TipoBiblioteca");
            }
            catch (Exception ex)
            {
                return ErrorController.capturaError(ex);

            }

        }
        [HttpGet]
        public ActionResult Editar(int id)
        {
            try
            {
              
                var db = new Dani_BibIiotecaEntities();

                var objeto = db.TipoBiblioteca.Find(id);
                db.Dispose();
                return View(objeto);
            }
            catch (Exception ex)
            {
                return ErrorController.capturaError(ex);

            }

        }
        [HttpPost]
        public ActionResult Editar(TipoBiblioteca modelo)
        {
            try {
                var db = new Dani_BibIiotecaEntities();
                var modeloBBDD = db.TipoBiblioteca.Find(modelo.TipoBibliotecaId);
                modeloBBDD.Nombre = modelo.Nombre;
                db.SaveChanges();
                db.Dispose();

            }
            catch (Exception ex)
            {
                return ErrorController.capturaError(ex);

            }

            return RedirectToAction("Index", "TipoBiblioteca");

        }
    }
}