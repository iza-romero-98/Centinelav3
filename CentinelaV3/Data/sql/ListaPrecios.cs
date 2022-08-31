﻿using System;
using System.Collections.Generic;

namespace CentinelaV3.Data.sql
{
    public partial class ListaPrecios
    {
        public ListaPrecios()
        {
            CuentasPorCobrar = new HashSet<CuentasPorCobrar>();
            DetalleEsquema = new HashSet<DetalleEsquema>();
            EsquemaPago = new HashSet<EsquemaPago>();
        }

        public int LpId { get; set; }
        public string LpDescripcion { get; set; }
        public int LpConcepto { get; set; }
        public decimal LpMonto { get; set; }
        public bool? LpParcialidades { get; set; }
        public int? LpCarrera { get; set; }
        public int? LpGeneracion { get; set; }
        public int? LpNivel { get; set; }
        public DateTime? LpFechaInicio { get; set; }
        public DateTime? LpFechaFin { get; set; }
        public long LpUsuid { get; set; }
        public DateTime LpFechaRegistro { get; set; }

        public virtual Carreras LpCarreraNavigation { get; set; }
        public virtual CatalogoConceptos LpConceptoNavigation { get; set; }
        public virtual Niveles LpNivelNavigation { get; set; }
        public virtual ICollection<CuentasPorCobrar> CuentasPorCobrar { get; set; }
        public virtual ICollection<DetalleEsquema> DetalleEsquema { get; set; }
        public virtual ICollection<EsquemaPago> EsquemaPago { get; set; }
    }
}
