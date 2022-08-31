﻿using System;
using System.Collections.Generic;

namespace CentinelaV3.Data.sql
{
    public partial class Referencias
    {
        public Referencias()
        {
            AlumnoPagos = new HashSet<AlumnoPagos>();
            AlumnoPo = new HashSet<AlumnoPo>();
            DetalleReferencia = new HashSet<DetalleReferencia>();
        }

        public long RReferenciaId { get; set; }
        public long? RAlumnoId { get; set; }
        public string RAlumnoClave { get; set; }
        public string RReferencia { get; set; }
        public DateTime RFechaCreacion { get; set; }
        public DateTime RFechaInicio { get; set; }
        public DateTime RFechaVigencia { get; set; }
        public decimal RTotalReferencia { get; set; }
        public int RReferenciaStatus { get; set; }
        public long RUsuid { get; set; }
        public DateTime RFechaRegistro { get; set; }

        public virtual Alumno RAlumno { get; set; }
        public virtual EstatusList RReferenciaStatusNavigation { get; set; }
        public virtual ICollection<AlumnoPagos> AlumnoPagos { get; set; }
        public virtual ICollection<AlumnoPo> AlumnoPo { get; set; }
        public virtual ICollection<DetalleReferencia> DetalleReferencia { get; set; }
    }
}
