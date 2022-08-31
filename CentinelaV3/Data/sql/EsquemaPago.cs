﻿using System;
using System.Collections.Generic;

namespace CentinelaV3.Data.sql
{
    public partial class EsquemaPago
    {
        public EsquemaPago()
        {
            Alumno = new HashSet<Alumno>();
        }

        public int EpId { get; set; }
        public int EpListaPrecio { get; set; }
        public string EpDescripcion { get; set; }
        public bool EpInscripcion { get; set; }
        public int EpNoInscripciones { get; set; }
        public decimal EpMontoInscripcion { get; set; }
        public int EpNoMensualidades { get; set; }
        public decimal EpMontoMensualidad { get; set; }
        public DateTime EpFechaInicio { get; set; }
        public int? EpDiaVencimiento { get; set; }
        public long EpUsuid { get; set; }
        public DateTime EpFechaRegistro { get; set; }

        public virtual ListaPrecios EpListaPrecioNavigation { get; set; }
        public virtual ICollection<Alumno> Alumno { get; set; }
    }
}
