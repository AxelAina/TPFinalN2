using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class MarcaNegocio
    {
        public List<PMarca> listar() 
        {
            List<PMarca> listaMarca = new List<PMarca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Id, Descripcion from MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    PMarca mar = new PMarca();
                    mar.Id = (int)datos.Lector["Id"];
                    mar.Descripcion = (string)datos.Lector["Descripcion"];

                    listaMarca.Add(mar);
                }

                return listaMarca;
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
    }
}
