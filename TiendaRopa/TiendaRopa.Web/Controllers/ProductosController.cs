using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tiendaropa.BL;

namespace TiendaRopa.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Produtos
        public ActionResult Index()
        {
            var productosBL = new ProductosBL();
            var listadeProductos = productosBL.ObtenerProductos();

            return View(listadeProductos);
        }
    }
}