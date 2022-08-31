﻿using System;
using System.Collections.Generic;

namespace CentinelaV3.Data.sql
{
    public partial class ViewDeudores
    {
        public long AlId { get; set; }
        public string AlMatricula { get; set; }
        public string AlCorreoInst { get; set; }
        public string AlApp { get; set; }
        public string AlApm { get; set; }
        public string AlNombre { get; set; }
        public int AlStatusActual { get; set; }
        public int? AlSemestre { get; set; }
        public string GaCorreoAlternativo { get; set; }
        public string GaTelefonoTutor { get; set; }
        public int Idcarrera { get; set; }
        public string CarreraClave { get; set; }
        public string NivelNombre { get; set; }
        public int NivelId { get; set; }
        public string DcpcDescripcion { get; set; }
        public string SlDescripcion { get; set; }
        public decimal? Pendiente { get; set; }
        public int? NoCon { get; set; }
    }
}
