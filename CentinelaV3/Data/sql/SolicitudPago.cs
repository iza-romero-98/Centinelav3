﻿using System;
using System.Collections.Generic;

namespace CentinelaV3.Data.sql
{
    public partial class SolicitudPago
    {
        public long SolicitudId { get; set; }
        public string RReferenciaId { get; set; }
        public int EfectivoAccountNivel { get; set; }
        public string EfectivoEmailBuyer { get; set; }
        public string DescripcionE { get; set; }
        public string EfectivoSignature { get; set; }
        public decimal EfectivoMonto { get; set; }
        public int? EfectivoMetodoPago { get; set; }
        public string EfectivoRespuesta { get; set; }
        public string EfecCode { get; set; }
        public string EfecError { get; set; }
        public string EfecOrder { get; set; }
        public string EfecTransaccion { get; set; }
        public string EfecState { get; set; }
        public string EfectrazabilityCode { get; set; }
        public string EfecPendingReason { get; set; }
        public string EfecResponseCode { get; set; }
        public DateTime? EfecOperationDate { get; set; }
        public DateTime? FechaExpiro { get; set; }
        public string RefPayu { get; set; }
        public string CodBarras { get; set; }
        public DateTime? FechaEstatus { get; set; }
        public string Alumno { get; set; }
        public bool? FlagAsocio { get; set; }
        public string ErrorRedPago { get; set; }
    }
}
