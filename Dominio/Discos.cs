
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Discos
    {
        public string Nombre { get; set; }
        public Formato Form { get; set; }
        public Estilo Tipo { get; set; }
        public  int ventas{ get; set; }
        public  string imagen { get; set; }
        public DateTime lanzamiento { get; set; }
    }
}
