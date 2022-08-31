﻿using System;
using System.Collections.Generic;

namespace CentinelaV3.Data.sql
{
    public partial class VrepFormEspCrm
    {
        public long GpProspectoId { get; set; }
        public string GpporsMat { get; set; }
        public string GpNombre { get; set; }
        public string GpApp { get; set; }
        public string GpApm { get; set; }
        public string Gpmatricula { get; set; }
        public int GpBeca { get; set; }
        public int? GpDescPromocion { get; set; }
        public int GpBecaInscripcion { get; set; }
        public int GpPorcentajeBeca { get; set; }
        public int IdCarrera { get; set; }
        public string CarreraClave { get; set; }
        public int? NivelId { get; set; }
        public string NivelNombre { get; set; }
        public int GpSemestre { get; set; }
        public int Campid { get; set; }
        public string Periodo { get; set; }
        public int GpDifusion { get; set; }
        public int GpEstado { get; set; }
    }
}
