
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System;


namespace Negocio
{
    public class NegocioEstilo
    {
        public List<Estilo> Listar()
        {
			List<Estilo> lista= new List<Estilo>();	
			AccesoDatos datos= new AccesoDatos();
			try
			{
				datos.setconsulta("select id, descripcion from ESTILOS");
				datos.ejecutarlectura();
				while (datos.Lector.Read())
				{
					Estilo aux = new Estilo();
					aux.descripcion = (string)datos.Lector["descripcion"];
					aux.id = (int)datos.Lector["id"];
					lista.Add(aux);
				}
				return lista;
			}
			catch (Exception)
			{

				throw;
			}
        }
    }
}
