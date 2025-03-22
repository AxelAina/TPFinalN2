using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public int Id { get; set; }

        [DisplayName("Código")]
        public string Codigo { get; set; }
        public string Nombre { get; set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public string ImagenUrl { get; set; }

        //public decimal Precio { get; set; }
        public PMarca Marca { get; set; }
        public Categoria Categoria { get; set; }





        private decimal _precio;
        [DisplayName("Precio")]

        public decimal Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        [DisplayName("Precio Argentino ($)")]
        public string PrecioFormateado
        { 
            get { return _precio.ToString("C", CultureInfo.CreateSpecificCulture("es-AR")); }
        }

    }
}
