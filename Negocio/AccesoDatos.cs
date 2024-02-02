using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class AccesoDatos
    {
        private SqlCommand comando = new SqlCommand();
        private SqlConnection conexion=new SqlConnection();
        private SqlDataReader lector;
        public SqlDataReader Lector
        {
            get { return lector; }
        }

        public AccesoDatos()
        {
            comando=new SqlCommand();
            conexion=new SqlConnection("server=.\\SQLEXPRESS08; database=DISCOS_DB; integrated security=true");

        }
        public void setconsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;

        }

        public void ejecutaraccion() {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        
        }
        public void ejecutarlectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void setparametros(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre,valor);
        }

        public void cerrarconexion()
        {
            if(lector != null)
                lector.Close();
            conexion.Close();
            
        }
    }
}
