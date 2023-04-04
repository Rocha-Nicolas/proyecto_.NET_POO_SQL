using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatálogoDeComercio
{
    public static class Helper
    {
        
        // Carpeta Imagenes

        public static bool crearCarpetaImagenesLocal()
        {
            MessageBox.Show("La carpeta de imagenes no fue localizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            FolderBrowserDialog carpeta = new FolderBrowserDialog();
            if (carpeta.ShowDialog() == DialogResult.OK)
            {
                string ruta = carpeta.SelectedPath.ToString();
                Directory.CreateDirectory(ruta);
                actualizarCarpetaAppSettings(ruta);
                return false;

            }
            else
                return true;

        }


        public static void actualizarCarpetaAppSettings(string ruta)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings["carpetaImagenLocal"].Value = ruta;
            configuration.Save(ConfigurationSaveMode.Full, true);
            ConfigurationManager.RefreshSection("appSettings");

        }

        //Validaciones

        public static bool validarDecimalText(string cadena)
        {
            if (validacionSoloNumero(cadena))
            {
                MessageBox.Show("Valor ingresado INCORRECTO el campo solo admite Numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            if (cadena == "" || cadena == ".")
            {
                MessageBox.Show("El campo del Precio no fue cargado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }

        public static bool validartxtCodigoArticulo(string codigo)
        {

            if (codigo == "")
            {
                MessageBox.Show("Es obligatorio ingresar un Codigo de Articulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }


        private static bool validacionSoloNumero(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!((char.IsNumber(caracter) || (caracter == '.'))))
                    return true;
            }
            return false;
        }

        

        public static bool validacionDataGrid(DataGridView dgvArticulos)
        {

            if (dgvArticulos.RowCount == 0)
            {
               return true;
            }
            return false;
        }

        public static bool validarBusqueda(TextBox txtBusqueda, ComboBox cboCampo, ComboBox cboCriterio)
        {
            if (txtBusqueda.Text == "" || cboCampo.SelectedIndex < 0 || cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Campo no cargado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }

        // Otros
        public static void ocultarColumnas(DataGridView dgvArticulos)
        {
            dgvArticulos.Columns["imagenUrl"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
        }

    }
}
