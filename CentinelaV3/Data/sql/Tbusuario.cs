﻿using System;
using System.Collections.Generic;

namespace CentinelaV3.Data.sql
{
    public partial class Tbusuario
    {
        public int Idbit { get; set; }
        public int ModuloId { get; set; }
        public long Usuid { get; set; }
        public DateTime Tbufecha { get; set; }
        public string Tbuaccion { get; set; }
        public string Tbuso { get; set; }
        public string Tbuipadress { get; set; }

        public virtual Modulo Modulo { get; set; }
        public virtual Usuario Usu { get; set; }
    }
}
