using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Modelos
{
    public class Producto
    {

        public int Id { get; set; }
        public string  Descripcion { get; set; }
        public int CategoriaId { get; set; }
        public double   Precio { get; set; }
        public Categoria Categoria { get; set; }

        public Producto(int id,string descrpcion,double precio,Categoria categoria)
        {

            Id = id;
            Descripcion = descrpcion;
            Precio = precio;
            Categoria = categoria;
            CategoriaId = Categoria.Id;
        }

    }
}
