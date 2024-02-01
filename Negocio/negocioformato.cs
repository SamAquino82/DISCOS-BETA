using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class negocioformato
    {
        public List<Formato> Listar()
        {
            List<Formato> lista = new List<Formato>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setconsulta("select id, descripcion from TIPOSEDICION");
                datos.ejecutarlectura();
                while (datos.Lector.Read())
                {
                    Formato aux = new Formato();
                    aux.TipoDisc = (string)datos.Lector["descripcion"];
                    aux.id = (int)datos.Lector["id"];
                    lista.Add(aux);
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
