using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {

        public int Id { get; set; }

        [DisplayName("Cod. de Articulo")]
        public string codigoArticulo { get; set; }

        [DisplayName("Nombre")]
        public string nombre { get; set; }

        [DisplayName("Categoría")]
        public Categorias Categoria { get; set; }

        [DisplayName("Marca")]
        public Marcas Marca { get; set; }
                        
        public string imagenUrl { get; set; }

        [DisplayName("Precio")]
        public decimal precio { get; set; }

        [DisplayName("Descripción")]
        public string descripcion { get; set; }
    }
}
