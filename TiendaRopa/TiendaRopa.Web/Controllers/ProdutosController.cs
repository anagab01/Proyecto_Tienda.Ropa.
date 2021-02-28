﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiendaRopa.Web.Models;

namespace TiendaRopa.Web.Controllers
{
    public class ProdutosController : Controller
    {
        // GET: Produtos
        public ActionResult Index()
        {
            var producto1 = new ProductoModel();
            producto1.Id = 1;
            producto1.Descripcion = "Camisa de Talla M";

            var producto2 = new ProductoModel();
            producto2.Id = 2;
            producto2.Descripcion = "Pantalon Jean Azul Talla 32";

            var producto3 = new ProductoModel();
            producto3.Id = 3;
            producto3.Descripcion = "Blusa Roja Talla S";

            var producto4 = new ProductoModel();
            producto4.Id = 4;
            producto4.Descripcion = "Pantalon de Tela Talla 30";

            var producto5 = new ProductoModel();
            producto5.Id = 5;
            producto5.Descripcion = "Tenis Nike Talla 9";

            var listadeProductos = new List<ProductoModel>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);
            listadeProductos.Add(producto4);
            listadeProductos.Add(producto5);

            return View(listadeProductos);
        }
    }
}