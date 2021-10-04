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
                throw new Exception("wiiii");
                List<TipoBiblioteca> lista = new List<TipoBiblioteca>();
                var db = new Dani_BibIiotecaEntities();
                lista = db.TipoBiblioteca.ToList();
                db.Dispose();
                //using ()
                //{
                    

                //}
                return View(lista);
            }
            catch(Exception ex)
            {
                // Logger
                return ErrorController.capturaError(ex);
            }
            
        }
    }
}