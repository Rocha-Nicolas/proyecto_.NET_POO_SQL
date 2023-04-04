using ComercioNegocio;
using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Xml;
using System.Net;


namespace CatálogoDeComercio
{
    public partial class frmCatalogoComercio : Form 
    {
        private List<Articulo> listaArticulo;
        private Articulo articulo;
        private OpenFileDialog archivo;
           

        public frmCatalogoComercio()
        {
            InitializeComponent();
                                      
        }

        private void frmCatalogoComercio_Load(object sender, EventArgs e)
        {

                cargar();

                cboCampo.Items.Add("Codigo");
                cboCampo.Items.Add("Nombre");
                cboCampo.Items.Add("Categoria");
                cboCampo.Items.Add("Marca");
                cboCampo.Items.Add("Precio");
                                        
        }

        private void cargar()
        {
            CatalogoArticulos negocio = new CatalogoArticulos();

            if (!negocio.validacionConexionBD())
            {
                MessageBox.Show("No se pudo establecer una conexión ó no se pudo obtener ciertos campos necesarios de la Base de Datos", "Error Conexión BD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            listaArticulo = negocio.listar();
            dgvArticulos.DataSource = listaArticulo;

            if (dgvArticulos.RowCount == 0)
            {
                cargaCboCategoriaMarca();
                return;
            }
                                    
            try
            {
                Helper.ocultarColumnas(dgvArticulos);

                cargarImagen(listaArticulo[0].imagenUrl);

                cargaCboCategoriaMarca();

                txtCodigoArticulo.Text = listaArticulo[0].codigoArticulo;
                txtNombre.Text = listaArticulo[0].nombre;
                txtImagenUrl.Text = listaArticulo[0].imagenUrl;
                txtPrecio.Text = listaArticulo[0].precio.ToString();
                txtDescripcion.Text = listaArticulo[0].descripcion;

                
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (Helper.validacionDataGrid(dgvArticulos)) 
                return;
            articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargaTxtBox();
        }
        
        private void btnRecarga_Click(object sender, EventArgs e)
        {
             cargaTxtBox();
        }

        public void cargaTxtBox()
        {
            if (Helper.validacionDataGrid(dgvArticulos))
                return;

            cargarImagen(articulo.imagenUrl);
            txtCodigoArticulo.Text = articulo.codigoArticulo;
            txtNombre.Text = articulo.nombre;
            txtImagenUrl.Text = articulo.imagenUrl;

            cboCategoria.SelectedValue = articulo.Categoria.id;
            cboMarca.SelectedValue = articulo.Marca.id;

            txtPrecio.Text = articulo.precio.ToString();
            txtDescripcion.Text = articulo.descripcion;

        }



        public void cargarImagen(string imagen)
        {
            lblSinImagen.Visible= false;
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarModificar("AGREGAR");
        }

        private void txtImagenUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagenUrl.Text);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarTbx();
        }

        public void limpiarTbx()
        {
            CatalogoArticulos negocio = new CatalogoArticulos();

            if (!negocio.validacionConexionBD())
            {
                MessageBox.Show("No se pudo establecer una conexión ó no se pudo obtener ciertos campos necesarios de la Base de Datos", "Error Conexión BD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            txtCodigoArticulo.Text = "";
            txtNombre.Text = "";
            txtImagenUrl.Text = "";
            cargarImagen(txtImagenUrl.Text);
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            cboCategoria.DataSource = negocio.listarCategorias();
            cboMarca.DataSource = negocio.listarMarcas();
        }

    
        public void agregarModificar(string opcion)
        {
            CatalogoArticulos negocio = new CatalogoArticulos();

            if (!negocio.validacionConexionBD())
            {
                MessageBox.Show("No se pudo establecer una conexión ó no se pudo obtener ciertos campos necesarios de la Base de Datos", "Error Conexión BD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (opcion == "AGREGAR")
                articulo = new Articulo();

            try
            {
                if (Helper.validartxtCodigoArticulo(txtCodigoArticulo.Text))
                    return;
                articulo.codigoArticulo = txtCodigoArticulo.Text;
                articulo.nombre = txtNombre.Text;
                articulo.imagenUrl = txtImagenUrl.Text;
                articulo.descripcion = txtDescripcion.Text;

                if (Helper.validarDecimalText(txtPrecio.Text))
                    return;
                articulo.precio = decimal.Parse(txtPrecio.Text);
                articulo.Categoria = (Categorias)cboCategoria.SelectedItem;
                articulo.Marca = (Marcas)cboMarca.SelectedItem;

               

                if (opcion == "AGREGAR")
                {
                    if ((negocio.validarExistenciaArticulo(txtCodigoArticulo.Text)))
                    {
                        MessageBox.Show("Ya existe un Articulo con ese Codigo en la Base de Datos", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    DialogResult respuesta = MessageBox.Show("¿Esta seguro de AGREGAR el Articulo " + articulo.codigoArticulo + " ?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        articulo.imagenUrl =  administarCarpetaImagenesLocal(articulo.imagenUrl);
                        negocio.agregar(articulo);
                        MessageBox.Show("El Articulo " + articulo.codigoArticulo + ", " + articulo.nombre + " fue agregado exitosamente", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargar();
                    }

                }
                else
                {
                    if (!(negocio.validarExistenciaArticulo(txtCodigoArticulo.Text)))
                    {
                        MessageBox.Show("No se pudo MODIFICAR, el Articulo no esta la Base de Datos", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    DialogResult respuesta = MessageBox.Show("¿Esta seguro de MODIFICAR el Articulo " + articulo.codigoArticulo + " ?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        articulo.imagenUrl = administarCarpetaImagenesLocal(articulo.imagenUrl);
                        negocio.modificar(articulo);
                        MessageBox.Show("El Articulo fue modificado exitosamente", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargar();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            agregarModificar("");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CatalogoArticulos negocio = new CatalogoArticulos();

            if (!negocio.validacionConexionBD())
            {
                MessageBox.Show("No se pudo establecer una conexión ó no se pudo obtener ciertos campos necesarios de la Base de Datos", "Error Conexión BD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (Helper.validartxtCodigoArticulo(txtCodigoArticulo.Text))
                return;
            articulo.codigoArticulo = txtCodigoArticulo.Text;

            try
            {
                if (!(negocio.validarExistenciaArticulo(txtCodigoArticulo.Text)))
                {
                    MessageBox.Show("No se pudo ELIMINAR, el Articulo no esta en la Base de Datos", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                DialogResult respuesta = MessageBox.Show("¿Esta seguro de ELIMINAR el Articulo " + articulo.codigoArticulo + " ?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    negocio.eliminar(articulo.codigoArticulo);
                    cargar();
                    MessageBox.Show("El Articulo fue eliminado exitosamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnMostrarArticulo_Click(object sender, EventArgs e)
        {
            if (Helper.validacionDataGrid(dgvArticulos))
                return;

                foreach (var item in Application.OpenForms)
                {
                    if (item.GetType() == typeof(frmMostrarArticulo))
                    {
                        return;
                    }

                }

                frmMostrarArticulo ventana = new frmMostrarArticulo(articulo);
                ventana.Show();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;

            string filtro = txtFiltro.Text;

            if (filtro != "")
            {
                listaFiltrada = listaArticulo.FindAll(x => x.nombre.ToUpper().Contains(txtFiltro.Text.ToUpper()) || x.codigoArticulo.ToUpper().Contains(filtro.ToUpper()) || x.Categoria.ToString().ToUpper().Contains(filtro.ToUpper()));

            }
            else
            {
                listaFiltrada = listaArticulo;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            Helper.ocultarColumnas(dgvArticulos);

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;

            string filtro = txtFiltro.Text;

            if (filtro != "")
            {
                txtBusqueda.Enabled = false;
                txtBusqueda.Clear();
                listaFiltrada = listaArticulo.FindAll(x => x.nombre.ToUpper().Contains(txtFiltro.Text.ToUpper()) || x.codigoArticulo.ToUpper().Contains(filtro.ToUpper()) || x.Categoria.ToString().ToUpper().Contains(filtro.ToUpper()));

            }
            else
            {
                txtBusqueda.Enabled = true;
                listaFiltrada = listaArticulo;
            }
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            Helper.ocultarColumnas(dgvArticulos);
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();

            if (opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a ");
                cboCriterio.Items.Add("Menor a ");
                cboCriterio.Items.Add("Igual a ");
                txtBusqueda.Clear();
                txtBusqueda.MaxLength = 38;
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con ");
                cboCriterio.Items.Add("Termina con ");
                cboCriterio.Items.Add("Contiene ");
                txtBusqueda.MaxLength = 50;

            }

        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            CatalogoArticulos negocio = new CatalogoArticulos();

            if (!negocio.validacionConexionBD())
            {
                MessageBox.Show("No se pudo establecer una conexión ó no se pudo obtener ciertos campos necesarios de la Base de Datos", "Error Conexión BD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                if (Helper.validarBusqueda(txtBusqueda,cboCampo,cboCriterio))
                    return;
                if (cboCampo.SelectedItem.ToString() == "Precio")
                    if (Helper.validarDecimalText(txtBusqueda.Text))
                        return;


                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string busqueda = txtBusqueda.Text;



                dgvArticulos.DataSource = negocio.Busqueda(campo, criterio, busqueda);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnRecargaBD_Click(object sender, EventArgs e)
        {
            cargar();
        }

        private void txtImagenUrl_TextChanged(object sender, EventArgs e)
        {
            cargarImagen(txtImagenUrl.Text);
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (txtBusqueda.Text != "")
            {
                txtFiltro.Enabled = false;
                txtFiltro.Clear();
            }
            else
                txtFiltro.Enabled = true;

        }
        
        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            CatalogoArticulos negocio = new CatalogoArticulos();

            if (!negocio.validacionConexionBD())
            {
                MessageBox.Show("No se pudo establecer una conexión ó no se pudo obtener ciertos campos necesarios de la Base de Datos", "Error Conexión BD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string key = ConfigurationManager.AppSettings["carpetaImagenLocal"];

            if (!Directory.Exists(key))
                if (Helper.crearCarpetaImagenesLocal())
                    return;


            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtImagenUrl.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
                
            }

        }


        private string administarCarpetaImagenesLocal(string imagenUrl) 
        {

            try
            {
                if ((archivo != null) && (imagenUrl != null) && (!(imagenUrl.ToUpper().Contains("HTTP"))))
                    if (imagenUrl != (ConfigurationManager.AppSettings["carpetaImagenLocal"] + @"\" + archivo.SafeFileName))
                        if (imagenUrl.EndsWith(".jpg") || imagenUrl.EndsWith(".png"))
                        {
                            File.Copy(archivo.FileName, ConfigurationManager.AppSettings["carpetaImagenLocal"] + @"\" + archivo.SafeFileName);
                            imagenUrl = ConfigurationManager.AppSettings["carpetaImagenLocal"] + @"\" + archivo.SafeFileName;
                        }
                return imagenUrl;

            }
            catch (Exception )
            {
                if (File.Exists(imagenUrl))
                    return imagenUrl;
                else 
                {
                    MessageBox.Show("No se a podido Almacenar la Imagen en la Carpeta" +imagenUrl.ToString(), "Incompatibilidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return imagenUrl;
                }

                
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show((ConfigurationManager.AppSettings["carpetaImagenLocal"] ).ToString(), "Carpeta imagen");
        }

        private void cargaCboCategoriaMarca()
        {
            CatalogoArticulos negocio = new CatalogoArticulos();

            cboCategoria.DataSource = negocio.listarCategorias();
            cboCategoria.ValueMember = "id";
            cboCategoria.DisplayMember = "descripcion";

            cboMarca.DataSource = negocio.listarMarcas();
            cboMarca.ValueMember = "id";
            cboMarca.DisplayMember = "descripcion";
        }

        
    }

}
