﻿using System;
using System.Collections.Generic;

namespace CentinelaV3.Data.sql
{
    public partial class CancelacionPagos
    {
        public CancelacionPagos()
        {
            DetalleCancelacionPago = new HashSet<DetalleCancelacionPago>();
        }

        public int CpCanId { get; set; }
        public int CpPagoId { get; set; }
        public int? CpTipoCancelacion { get; set; }
        public bool? CpCancelacion { get; set; }
        public DateTime CpFechaCancelacion { get; set; }
        public string CpComentario { get; set; }
        public long CpUsuid { get; set; }
        public DateTime CpFechaRegistro { get; set; }

        public virtual AlumnoPagos CpPago { get; set; }
        public virtual CatalogoCancelacion CpTipoCancelacionNavigation { get; set; }
        public virtual ICollection<DetalleCancelacionPago> DetalleCancelacionPago { get; set; }
    }
}
