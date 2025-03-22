using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using System.Security.AccessControl;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;
using System.ComponentModel;
using System.Globalization;
using System.Collections;


namespace negocio

{
    public class ArticuloNegocio
    {

        public List<Articulo> listar()
        { 
          List<Articulo> lista = new List<Articulo>();
          SqlConnection conexion = new SqlConnection();
          SqlCommand comando = new SqlCommand();
          SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=DESKTOP-DTLS7T1\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                //comando.CommandText = "SELECT Codigo, Nombre, A.Descripcion, A.ImagenUrl, Precio, C.Descripcion as Descripcion_Categoria, M.Descripcion as Descripcion_Marca From ARTICULOS A, CATEGORIAS C, MARCAS M Where C.Id = A.IdCategoria AND M.Id = A.IdMarca";
                //comando.CommandText = "SELECT Codigo, Nombre, A.Descripcion, A.ImagenUrl, Precio, C.Descripcion as Descripcion_Categoria, M.Descripcion as Descripcion_Marca, M.Id, C.Id, A.Id From ARTICULOS A, CATEGORIAS C, MARCAS M Where C.Id = A.IdCategoria AND M.Id = A.IdMarca";
                comando.CommandText = "SELECT Codigo, Nombre, A.Descripcion, A.ImagenUrl, A.Precio, M.Descripcion AS Descripcion_Marca, C.Descripcion AS Descripcion_Categoria, M.Id AS Id_Marca, C.Id AS Id_Categoria, A.Id AS Id_Articulo FROM ARTICULOS A, MARCAS M, CATEGORIAS C WHERE M.Id = A.IdMarca AND C.Id = A.IdCategoria";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read()) 
                {
                    Articulo art = new Articulo();
                    art.Id = (int)lector["Id_Articulo"];
                    art.Codigo = lector.GetString(0);
                    art.Nombre = (string)lector["Nombre"];
                    art.Descripcion = (string)lector["Descripcion"];
                    if(!(lector.IsDBNull(lector.GetOrdinal("ImagenUrl"))))
                    art.ImagenUrl = (string)lector["ImagenUrl"];
                    art.Precio = (decimal)lector["Precio"];
                    art.Marca = new PMarca();
                    art.Marca.Id = (int)lector["Id_Marca"];
                    art.Marca.Descripcion = (string)lector["Descripcion_Marca"];
                    art.Categoria = new Categoria();
                    art.Categoria.Id = (int)lector["Id_Categoria"];
                    art.Categoria.Descripcion = (string)lector["Descripcion_Categoria"];


                    lista.Add(art);
                }

              conexion.Close();
              return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void agregar (Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();  

            try
            {
                datos.setearConsulta("Insert into ARTICULOS (Codigo, Nombre, Descripcion, ImagenUrl)" + " VALUES (@Codigo, @Nombre, @Descripcion, @ImagenUrl);");
                //("Insert into ARTICULOS(Codigo, Nombre, Descripcion, ImagenUrl) values('" + nuevo.Codigo + "', '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "', @ImagenUrl)")
                datos.setearParametro("@Codigo", nuevo.Codigo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@ImagenUrl", nuevo.ImagenUrl);

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

        public void modificar (Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idMarca, IdCategoria = @idCategoria, ImagenUrl = @imagenUrl, Precio = @precio where Id = @id;");
                datos.setearParametro("@codigo",  articulo.Codigo);
                datos.setearParametro("@nombre", articulo.Nombre);
                datos.setearParametro("@descripcion", articulo.Descripcion);
                datos.setearParametro("@idMarca", articulo.Marca.Id);
                datos.setearParametro("@idCategoria", articulo.Categoria.Id);
                datos.setearParametro("@imagenUrl", articulo.ImagenUrl);
                datos.setearParametro("@precio", articulo.Precio);
                datos.setearParametro("@id", articulo.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void eliminar (int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from ARTICULOS where id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

     

        public List <Articulo> filtrar (string campo, string criterio, string filtro)
        {
            List <Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos ();

            try
            {
                string consulta = "SELECT Codigo, Nombre, A.Descripcion, A.ImagenUrl, Precio, C.Descripcion as Descripcion_Categoria, M.Descripcion as Descripcion_Marca, M.Id, C.Id, A.Id From ARTICULOS A, CATEGORIAS C, MARCAS M Where C.Id = A.IdCategoria AND M.Id = A.IdMarca And ";

                if (campo == "Precio")
                {
                    filtro = filtro.Replace(',', '.');
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "Precio > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "Precio < " + filtro;
                            break;
                        default:
                            consulta += "Precio = " + filtro;
                            break;
                    } 
                } 
                else if(campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "Nombre like '" + filtro + "%'";
                            break;                                     
                        case "Termina con":
                            consulta += "Nombre like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "Nombre like '%" + filtro + "%'";
                            break;
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "Codigo like '" + filtro + "%'";
                    break;
                        case "Termina con":
                            consulta += "Codigo like '%" + filtro + "'";
                        break;
                    default:
                            consulta += "Codigo like '%" + filtro + "%'";
                        break;
                    }
                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo art = new Articulo();
                    art.Id = (int)datos.Lector["Id"];
                    art.Codigo = datos.Lector.GetString(0);
                    art.Nombre = (string)datos.Lector["Nombre"];
                    art.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector.IsDBNull(datos.Lector.GetOrdinal("ImagenUrl"))))
                        art.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    art.Precio = (decimal)datos.Lector["Precio"];
                    art.Marca = new PMarca();
                    art.Marca.Id = (int)datos.Lector["Id"];
                    art.Marca.Descripcion = (string)datos.Lector["Descripcion_Marca"];
                    art.Categoria = new Categoria();
                    art.Categoria.Id = (int)datos.Lector["Id"];
                    art.Categoria.Descripcion = (string)datos.Lector["Descripcion_Categoria"];


                    lista.Add(art);
                }

                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
