﻿using System;
using System.Collections.Generic;

namespace CentinelaV3.Data.sql
{
    public partial class Query
    {
        public long Usuid { get; set; }
        public int Idcarrera { get; set; }
        public int Carrera { get; set; }
        public DateTime? Gppfecha { get; set; }
        public string Gpmatricula { get; set; }
        public string GpporsMat { get; set; }
        public string GpNombre { get; set; }
        public string GpApp { get; set; }
        public string GpApm { get; set; }
        public int GpEstado { get; set; }
        public int GpEscuelaPros { get; set; }
        public int GpNacionalidad { get; set; }
        public int GpBeca { get; set; }
        public int GpPorcentajeBeca { get; set; }
        public string GpBecaOfrecidaPor { get; set; }
        public int GpDifusion { get; set; }
        public int GpCp { get; set; }
        public int GpModalidadInterez { get; set; }
        public string GpTelefono { get; set; }
        public string GpCorreoElectronico { get; set; }
        public int GpEstatus { get; set; }
        public long Idferia { get; set; }
        public int Campid { get; set; }
        public int GpBecaInscripcion { get; set; }
        public double? GpImporte { get; set; }
        public string GpObservaciones { get; set; }
        public int GpTipDocExtra { get; set; }
        public string GpNumDocExtra { get; set; }
        public long GpUsuValBeca { get; set; }
        public DateTime? GpValBecaFecha { get; set; }
        public int GpSemestre { get; set; }
        public int? GpModPago { get; set; }
        public int? GpDescPromocion { get; set; }
        public string GpDireccion { get; set; }
        public int? GpFirmaContra { get; set; }
        public DateTime? GpFechaFirReg { get; set; }
        public int? GpEdad { get; set; }
        public bool? GpTermyCond { get; set; }

        public virtual Carreras CarreraNavigation { get; set; }
        public virtual Carreras IdcarreraNavigation { get; set; }
    }
}
