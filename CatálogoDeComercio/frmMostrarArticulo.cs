using ComercioCatalogoNegocio;
using ComercioNegocio;
using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatálogoDeComercio
{
    public partial class frmMostrarArticulo : Form 
    {
        private Articulo articulo;

        public frmMostrarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void frmMostrarArticulo_Load(object sender, EventArgs e)
        {
                        
            lblCodigoArticulo.Text = "Codigo: " + articulo.codigoArticulo;
            lblNombre.Text = "Nombre: " + articulo.nombre;
            lblMarca.Text = "Marca: " + (articulo.Marca).ToString();
            lblCategoria.Text = "Categoria: " + (articulo.Categoria).ToString();
            lblPrecio.Text = "Precio: " + (articulo.precio).ToString("0.00");
            lblDescripcion.Text = "Descripcion: " + articulo.descripcion;
            lblUrlImagen.Text = "UrlImagen:" + articulo.imagenUrl;
            cargarImagen(articulo.imagenUrl);
            

        }
        public void cargarImagen(string imagen)
        {
            lblSinImagen.Visible = false;
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception)
            {
                try
                {
                    pbxArticulo.Load("https://thealmanian.com/wp-content/uploads/2019/01/product_image_thumbnail_placeholder.png");

                }
                catch (Exception)
                {
                    lblSinImagen.Visible = true;
                }

            }
        }


    }
}
