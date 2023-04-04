using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using ComercioNegocio;
using System.Data.SqlClient;
using System.Net.Configuration;
using System.ComponentModel;
using ComercioCatalogoNegocio;
using System.Net;
using System.Runtime.CompilerServices;
using System.IO;

namespace ComercioNegocio
{
    public class CatalogoArticulos
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, ImagenUrl, Precio, IdCategoria,IdMarca, A.Id From ARTICULOS A,CATEGORIAS C,MARCAS M where C.Id = A.IdCategoria AND M.Id = A.IdMarca");
                datos.ejecutarLectura();
                   
                
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.codigoArticulo = (string)datos.Lector["Codigo"];
                    aux.nombre = (string)datos.Lector["Nombre"];
                    aux.descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marcas();
                    aux.Marca.id = (int)datos.Lector["IdMarca"];
                    aux.Marca.descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categorias();
                    aux.Categoria.id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.descripcion = (string)datos.Lector["Categoria"];
                                      
                    if (!(datos.Lector["ImagenUrl"] is DBNull)) 
                        aux.imagenUrl = (string)datos.Lector["ImagenUrl"];


                    aux.precio = (decimal)datos.Lector["Precio"];

                    lista.Add(aux);
                }

                

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

        public void agregar(Articulo nuevo) 
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Insert into ARTICULOS(Codigo, Nombre, Descripcion,IdMarca, IdCategoria, ImagenUrl, Precio)values(@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @UrlImagen, @Precio)");
                datos.setearParametro("@Codigo",nuevo.codigoArticulo);
                datos.setearParametro("@Nombre",nuevo.nombre);
                datos.setearParametro("@Descripcion",nuevo.descripcion);
                datos.setearParametro("@IdMarca",nuevo.Marca.id);
                datos.setearParametro("@IdCategoria",nuevo.Categoria.id);
                datos.setearParametro("@UrlImagen", nuevo.imagenUrl);
                datos.setearParametro("@Precio",nuevo.precio);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(Articulo modificar) 
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion= @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @ImagenUrl, Precio = @Precio Where Codigo = @Codigo");
                datos.setearParametro("@Codigo", modificar.codigoArticulo);
                datos.setearParametro("@Nombre", modificar.nombre);
                datos.setearParametro("@Descripcion", modificar.descripcion);
                datos.setearParametro("@IdMarca", modificar.Marca.id);
                datos.setearParametro("@IdCategoria", modificar.Categoria.id);
                datos.setearParametro("@ImagenUrl", modificar.imagenUrl);
                datos.setearParametro("@Precio", modificar.precio);
                datos.setearParametro("@Id", modificar.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            {
                datos.cerrarConexion();
            }

        }

        public void eliminar(string Codigo) 
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("Delete From ARTICULOS Where Codigo = @Codigo");
                datos.setearParametro("@Codigo",Codigo);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }



        public List<Marcas> listarMarcas()
        {
            List<Marcas> lista = new List<Marcas>();

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Id, Descripcion from MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marcas aux = new Marcas();
                    aux.id = (int)datos.Lector["Id"];
                    aux.descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Categorias> listarCategorias()
        {
            List<Categorias> lista = new List<Categorias>();

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Id, Descripcion from CATEGORIAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Categorias aux = new Categorias();
                    aux.id = (int)datos.Lector["Id"];
                    aux.descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Articulo> Busqueda(string campo, string criterio, string busqueda)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                if (campo == "Marca")
                    campo = "M.Descripcion";
                else if (campo == "Categoria")
                    campo = "C.Descripcion";

                string consulta = "Select Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, ImagenUrl, Precio, IdCategoria,IdMarca, A.Id From ARTICULOS A,CATEGORIAS C,MARCAS M where C.Id = A.IdCategoria AND M.Id = A.IdMarca AND ";

                if (campo == "Precio")
                {
                    switch (criterio)
                    {
                        case "Mayor a ":
                            consulta += "Precio > " + busqueda;
                            break;
                        case "Menor a ":
                            consulta += "Precio < " + busqueda;
                            break;
                        case "Igual a ":
                            consulta += "Precio = " + busqueda;
                            break;

                    }

                }
                else
                {
                    switch (criterio)
                    {
                        case "Comienza con ":
                            consulta += campo + " like '" + busqueda + "%' ";
                            break;
                        case "Termina con ":
                            consulta += campo + " like '%" + busqueda + "' ";
                            break;
                        case "Contiene ":
                            consulta += campo + " like '%" + busqueda + "%' ";
                            break;

                    }


                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.codigoArticulo = (string)datos.Lector["Codigo"];
                    aux.nombre = (string)datos.Lector["Nombre"];
                    aux.descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marcas();
                    aux.Marca.id = (int)datos.Lector["IdMarca"];
                    aux.Marca.descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categorias();
                    aux.Categoria.id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.descripcion = (string)datos.Lector["Categoria"];
                                       
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.imagenUrl = (string)datos.Lector["ImagenUrl"];


                    aux.precio = (decimal)datos.Lector["Precio"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

        public bool validarExistenciaArticulo(string articulo)
        {
            
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Codigo From ARTICULOS Where Codigo = @Codigo");
                datos.setearParametro("@Codigo", articulo);

                datos.ejecutarLectura();
                if (datos.Lector.Read())
                {
                    return true;
                }
                else
                {

                    return false;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            {
                datos.cerrarConexion();
            }
               
          
        }

        public bool validacionConexionBD()
        {
            AccesoDatos datos = new AccesoDatos();
            
            try
            {
                datos.setearConsulta("Select A.Id, Codigo, Nombre ,A.Descripcion, IdMarca ,IdCategoria ,ImagenUrl ,Precio, C.Id , C.Descripcion, M.Id, M.Descripcion From ARTICULOS A, CATEGORIAS C, MARCAS M");
                datos.ejecutarLectura();
                return true;
            }
            catch (Exception)
            {
                
                return false;
            }
            finally
            {
                datos.cerrarConexion();
            }


        }












    }
}
