﻿using System;
using System.Collections.Generic;

namespace CentinelaV3.Data.sql
{
    public partial class DetallePago
    {
        public int DpId { get; set; }
        public int DpPagoId { get; set; }
        public int DpCuentaDetalle { get; set; }
        public string DpDocLinea { get; set; }
        public decimal DpImporteAplicado { get; set; }
        public decimal DpImportePendiente { get; set; }
        public bool? DpSaldoCreado { get; set; }
        public long DpUsuid { get; set; }
        public DateTime DpFechaRegistro { get; set; }

        public virtual DetalleCuentaPorCobrar DpCuentaDetalleNavigation { get; set; }
        public virtual AlumnoPagos DpPago { get; set; }
    }
}
