using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using Negocio;
using System.Security.Cryptography.X509Certificates;

namespace negocio
{
    public class NegocioDiscos
    {
        public List<Discos> listar()
        {
            List<Discos>listadiscos = new List<Discos>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setconsulta("select Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, E.Descripcion Tipo, t.Descripcion Formato, D.IdEstilo,D.IdTipoEdicion,D.Id from DISCOS D, ESTILOS E, TIPOSEDICION T where IdEstilo = e.Id and IdTipoEdicion = t.Id and Activo=1");
                datos.ejecutarlectura();
                while (datos.Lector.Read())
                {
                    Discos aux = new Discos();
                    aux.Nombre = (string)datos.Lector["Titulo"];
                    aux.lanzamiento = (DateTime)datos.Lector["FechaLanzamiento"];
                    aux.ventas = (int)datos.Lector["CantidadCanciones"];

                    if (!(datos.Lector["UrlImagenTapa"] is DBNull))
                    {
                        aux.imagen = (string)datos.Lector["UrlImagenTapa"];
                    }
                    aux.id = (int)datos.Lector["Id"];
                    aux.Tipo = new Estilo();
                    aux.Tipo.descripcion = (string)datos.Lector["Tipo"];
                    aux.Form = new Formato();
                    aux.Form.TipoDisc = (string)datos.Lector["Formato"];
                    aux.Tipo.id = (int)datos.Lector["IdEstilo"];
                    aux.Form.id = (int)datos.Lector["IdTipoEdicion"];
                    
                    listadiscos.Add(aux);
                }
                datos.cerrarconexion();
                return listadiscos;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void agregar(Discos disco)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setconsulta("INSERT INTO DISCOS(Titulo, FechaLanzamiento, CantidadCanciones, IdEstilo, IdTipoEdicion,Activo) VALUES ('" + disco.Nombre + "', '" + disco.lanzamiento.ToString("yyyy-MM-dd") + "', " + disco.ventas + ", @IdEstilo, @IdTipoEdicion,1)");
                datos.setparametros("@IdEstilo",disco.Tipo.id);
                datos.setparametros("@IdTipoEdicion",disco.Form.id);
                datos.ejecutaraccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarconexion();
            }
        }

        public void modificar(Discos discos)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setconsulta("update DISCOS set Titulo=@Nombre,FechaLanzamiento=@Lanzamiento,CantidadCanciones=@Ventas,UrlImagenTapa=@Imagen,IdEstilo=@IdEstilo,IdTipoEdicion=@IdFormato where Id=@Id");
                datos.setparametros("@Nombre", discos.Nombre);
                datos.setparametros("@Lanzamiento", discos.lanzamiento);
                datos.setparametros("@Ventas", discos.ventas);
                datos.setparametros("@Imagen", discos.imagen);
                datos.setparametros("@IdEstilo", discos.Tipo.id);
                datos.setparametros("@IdFormato", discos.Form.id);
                datos.setparametros("@Id", discos.id);
                datos.ejecutaraccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally { datos.cerrarconexion();}

        }

        public void eliminar(Discos disco)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setconsulta("delete from discos where id=@id");
                datos.setparametros("@id", disco.id);
                datos.ejecutaraccion();
                

            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public void eliminarlogica(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setconsulta("update DISCOS set Activo=0 WHERE Id=@Id");
                datos.setparametros("@Id", id);
                datos.ejecutaraccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Discos> filtrar(string campo, string criterio, string filtro)
        {
            List<Discos > lista = new List<Discos >();
            AccesoDatos datos=new AccesoDatos();
            try
            {
                string consulta = "select Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, E.Descripcion Tipo, t.Descripcion Formato, D.IdEstilo,D.IdTipoEdicion,D.Id from DISCOS D, ESTILOS E, TIPOSEDICION T where IdEstilo = e.Id and IdTipoEdicion = t.Id and Activo=1 and ";
                if ( filtro!="")
                {
                    switch (campo)
                    {
                        case "Numero":
                            switch (criterio)
                            {
                                case "Mayor a":
                                    consulta += " D.Id > " + filtro;
                                    break;
                                case "Menor a":
                                    consulta += "D.Id < " + filtro;
                                    break;
                                case "Igual a":
                                    consulta += "D.Id= " + filtro;
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case "Nombre":
                            switch (criterio)
                            {
                                case "Comienza con":
                                    consulta += "Titulo LIKE '" + filtro + "%' ";
                                    break;
                                case "Termina con":
                                    consulta += "Titulo LIKE '%" + filtro + "'";
                                    break;
                                case "Contiene a":
                                    consulta += "Titulo LIKE '%" + filtro + "%'";
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case "Descripcion":
                            switch (criterio)
                            {
                                case "Comienza con":
                                    consulta += "E.Descripcion  LIKE '" + filtro + "%'";
                                    break;
                                case "Termina con":
                                    consulta += "E.Descripcion  LIKE '%" + filtro + "'";
                                    break;
                                case "Contiene a":
                                    consulta += "E.Descripcion  LIKE '%" + filtro + "%'";
                                    break;
                                default:
                                    break;
                            }
                            break;
                        default: break;

                    }
                }
                else
                {
                    NegocioDiscos negocio = new NegocioDiscos();
                    consulta = "select Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, E.Descripcion Tipo, t.Descripcion Formato, D.IdEstilo,D.IdTipoEdicion,D.Id from DISCOS D, ESTILOS E, TIPOSEDICION T where IdEstilo = e.Id and IdTipoEdicion = t.Id and Activo=1 ";

                }
                datos.setconsulta(consulta);
                datos.ejecutarlectura();
                while (datos.Lector.Read())
                {
                    Discos aux = new Discos();
                    aux.Nombre = (string)datos.Lector["Titulo"];
                    aux.lanzamiento = (DateTime)datos.Lector["FechaLanzamiento"];
                    aux.ventas = (int)datos.Lector["CantidadCanciones"];

                    if (!(datos.Lector["UrlImagenTapa"] is DBNull))
                    {
                        aux.imagen = (string)datos.Lector["UrlImagenTapa"];
                    }
                    aux.id = (int)datos.Lector["Id"];
                    aux.Tipo = new Estilo();
                    aux.Tipo.descripcion = (string)datos.Lector["Tipo"];
                    aux.Form = new Formato();
                    aux.Form.TipoDisc = (string)datos.Lector["Formato"];
                    aux.Tipo.id = (int)datos.Lector["IdEstilo"];
                    aux.Form.id = (int)datos.Lector["IdTipoEdicion"];

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
