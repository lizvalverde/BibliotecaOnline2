using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBibliotecaOnline2.Models.Pruebas;

namespace WebBibliotecaOnline2.Controllers
{
    public class PruebasController : Controller
    {
        // GET: Pruebas
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Damefecha(int? id)
        {
            DateTime valor = DateTime.Now;

            //if (id != null)
            //  valor.AddDays(Convert.ToDouble(id));
            valor = valor.AddDays(id.GetValueOrDefault(0));

            return View(valor);
        }

        [Route("Pruebas/DameFecha2/{dias}")]
        public ActionResult DameFecha2(int dias)
        {
            DateTime valor = DateTime.Now;

            //if (id != null)
            //  valor.AddDays(Convert.ToDouble(id));
            valor = valor.AddDays(dias);

            return View(valor);
        }
        public ActionResult  DameObjetoPrueba(int id, string nombre)

        {
            Prueba p = new Prueba();
            p.id = id;
            p.nombre = nombre;
            return View(p);

            // (El view es una forma más facil de devolver un new viewresult)
            //var x = new ViewResult();
            //x.ViewData = new ViewDataDictionary();
            //x.ViewData.Model = p;
            //return x;
        }
        public ContentResult DameContentResult()
        {
            
            return Content("precioso JESUS");
        }

        public HttpNotFoundResult DameNotFound()
        {

            return HttpNotFound();
        }
        public RedirectToRouteResult DameRedirect()
        {

            return RedirectToAction("About","Home");
        }
        public ActionResult ObjetoMultiple()
        {
            List<int> listaprueba = new List<int>();

            listaprueba.Add(1);
            listaprueba.Add(2);

            List <PruebaVariasPropiedades> parte= new List<PruebaVariasPropiedades>();

            parte.Add(new PruebaVariasPropiedades() { id = 1, nombre = "liz", lista= listaprueba });
            parte.Add(new PruebaVariasPropiedades() { id =2, nombre ="chain ring", lista= listaprueba });

            return View(parte);
        }
    }
}