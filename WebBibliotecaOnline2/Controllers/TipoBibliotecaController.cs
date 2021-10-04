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
            List<TipoBiblioteca> lista = new List<TipoBiblioteca>();
            using(var db = new Dani_BibIiotecaEntities())
              {
                lista = db.TipoBiblioteca.ToList();

               }
             return View(lista);
        }
    }
}