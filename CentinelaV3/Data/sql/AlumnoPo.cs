﻿using System;
using System.Collections.Generic;

namespace CentinelaV3.Data.sql
{
    public partial class AlumnoPo
    {
        public int ApoSolicitud { get; set; }
        public long? ApoReferencia { get; set; }
        public int? ApoNivelCuenta { get; set; }
        public string ApoDescripcion { get; set; }
        public int? ApoMetodoPago { get; set; }
        public DateTime? ApoFreg { get; set; }
        public DateTime? ApoFexpiro { get; set; }
        public int? ApoMeses { get; set; }
        public string ApoBanco { get; set; }
        public string ApoRespuesta { get; set; }
        public int? ApoRcodigo { get; set; }
        public string ApoError { get; set; }
        public string ApoOrden { get; set; }
        public string ApoTansaccion { get; set; }
        public int? ApoEstatus { get; set; }
        public string ApoCodBarras { get; set; }
        public int? ApoAutorizacion { get; set; }
        public int? ApoAluid { get; set; }
        public int? ApoUsuid { get; set; }
        public DateTime? ApoFasocio { get; set; }
        public int? ApoAsociado { get; set; }

        public virtual StatusPago ApoEstatusNavigation { get; set; }
        public virtual Referencias ApoReferenciaNavigation { get; set; }
    }
}
