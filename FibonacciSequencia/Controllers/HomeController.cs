using FibonacciSequencia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FibonacciSequencia.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(FibonacciModel numero)
        {
            ViewBag.Message = IsFibonacci(numero.Numero) ? "Pertence" : "Não Pertence";
            return View();
        }

        private bool IsFibonacci(int c)
        {
            int a = 0, b = 1, i;

            for (i = a = b; i <= c; i = a + b)
            {
                a = b;
                b = i;
            }

            return i == c;
        }



    }

       

       
    
}