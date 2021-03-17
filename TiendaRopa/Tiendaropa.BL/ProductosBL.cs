﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendaropa.BL
{
    public class ProductosBL
    {
        public List<Producto> ObtenerProductos()
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Camisa de Talla M";
            producto1.Precio = 200;

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Pantalon Jean Azul Talla 32";
            producto2.Precio = 700;

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Blusa Roja Talla S";
            producto3.Precio = 600;

            var producto4 = new Producto();
            producto4.Id = 4;
            producto4.Descripcion = "Pantalon de Tela Talla 30";
            producto4.Precio = 500;

            var producto5 = new Producto();
            producto5.Id = 5;
            producto5.Descripcion = "Tenis Nike Talla 9";
            producto5.Precio = 1200;

            var listadeProductos = new List<Producto>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);
            listadeProductos.Add(producto4);
            listadeProductos.Add(producto5);

            return listadeProductos; 
        }
    }
}
