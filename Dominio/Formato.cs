﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Dominio
{
    public class Formato
    {
        public int  id { get; set; }
        public string TipoDisc { get; set; }

        public override string ToString()
        {
            return TipoDisc;
        }
    }
}
