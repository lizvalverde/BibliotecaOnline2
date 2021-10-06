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

        public ActionResult Eliminar(string id)
        {
            try
            {   
                var db = new Dani_BibIiotecaEntities();
                var consulta = db.TipoBiblioteca.Where(p => p.TipoBibliotecaId.Equals(id)).ToList();

                foreach (TipoBiblioteca tipoBib in consulta)
                {
                    db.TipoBiblioteca.Remove(tipoBib);
                }

                db.SaveChanges();
                db.Dispose();
                return RedirectToAction("Index", "TipoBiblioteca");
            }
            catch (Exception ex)
            {
                return ErrorController.capturaError(ex);

            }

        }
    }
}