using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class frmDetalle : Form
    {

        private Articulo articulo = null;

        public frmDetalle()
        {
            InitializeComponent();
        }
        public frmDetalle(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            MostrarDetalle();
        }

        private void MostrarDetalle()
        {
           txtCodificado.Text = articulo.Codigo;
           txtNombramiento.Text = articulo.Nombre;
           txtDescription.Text = articulo.Descripcion;
           txtCat.Text = articulo.Categoria.ToString();
           txtMarcado.Text = articulo.Marca.ToString();
           txtCosto.Text = articulo.PrecioFormateado.ToString();
        }
    }
}
