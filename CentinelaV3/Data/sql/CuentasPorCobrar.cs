﻿using System;
using System.Collections.Generic;

namespace CentinelaV3.Data.sql
{
    public partial class CuentasPorCobrar
    {
        public CuentasPorCobrar()
        {
            CancelacionCuenta = new HashSet<CancelacionCuenta>();
            DetalleCuentaPorCobrar = new HashSet<DetalleCuentaPorCobrar>();
            InverseCpcReferenciaCuentaNavigation = new HashSet<CuentasPorCobrar>();
        }

        public int CpcId { get; set; }
        public int CpcListaPrecio { get; set; }
        public long? CpcAlumnoId { get; set; }
        public string CpcAlumnoClave { get; set; }
        public int? CpcReferenciaCuenta { get; set; }
        public DateTime CpcFechaCreacion { get; set; }
        public decimal CpcImporteTotal { get; set; }
        public decimal CpcImportePendiente { get; set; }
        public int CpcAño { get; set; }
        public int CpcPeriodo { get; set; }
        public int CpcEstatus { get; set; }
        public long CpcUsuid { get; set; }
        public DateTime CpcFechaRegistro { get; set; }
        public int CpcUnidad { get; set; }
        public decimal CpcPrecioUnitario { get; set; }

        public virtual Alumno CpcAlumno { get; set; }
        public virtual EstatusList CpcEstatusNavigation { get; set; }
        public virtual ListaPrecios CpcListaPrecioNavigation { get; set; }
        public virtual CuentasPorCobrar CpcReferenciaCuentaNavigation { get; set; }
        public virtual ICollection<CancelacionCuenta> CancelacionCuenta { get; set; }
        public virtual ICollection<DetalleCuentaPorCobrar> DetalleCuentaPorCobrar { get; set; }
        public virtual ICollection<CuentasPorCobrar> InverseCpcReferenciaCuentaNavigation { get; set; }
    }
}
