﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;


namespace Ventas.BL
{
   public  class ProductosBL
    {

        public List<Producto>  ListadeProductos { get; set; }

        public ProductosBL()
        {
            ListadeProductos = new List<Producto>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var categoria1 = new Categoria(1, "Laptop");
            var categoria2 = new Categoria(2, "Accesorio");

            var producto1 = new Producto(1, "Laptop Dell", 9000, categoria1);
            var producto2 = new Producto(2, "Laptop Asus", 6000, categoria1);
            var producto3 = new Producto(3, "Mouse Logitech", 200, categoria2);


            ListadeProductos.Add(producto1);
            ListadeProductos.Add(producto2);
            ListadeProductos.Add(producto3);


        }
    }
}
