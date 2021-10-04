using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebBibliotecaOnline2.Models;

namespace WebBibliotecaOnline2.Controllers
{
    public static class ErrorController : Object
    {
        public static ActionResult capturaError(Exception e)
        {
            return new ErrorController2().capturaError2(e);
        }



        private class ErrorController2 : Controller
        {
            public ActionResult capturaError2(Exception e)
            {
                return Content(e.Message + " " + e.StackTrace);
            }
        }
    }


    
}