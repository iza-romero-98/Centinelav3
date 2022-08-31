﻿using System;
using System.Collections.Generic;

namespace CentinelaV3.Data.sql
{
    public partial class PagoTarjeta
    {
        public long RequestTarjetasId { get; set; }
        public long? RReferenciaId { get; set; }
        public int TAccountNivel { get; set; }
        public string TDescription { get; set; }
        public string TSignature { get; set; }
        public string TPayerName { get; set; }
        public decimal TMonto { get; set; }
        public int? TMedioPago { get; set; }
        public int? TMonth { get; set; }
        public string TBanco { get; set; }
        public string TdeviceSessionId { get; set; }
        public string TRespuesta { get; set; }
        public string TarCode { get; set; }
        public string TarError { get; set; }
        public string TarOrden { get; set; }
        public string TarTransaccion { get; set; }
        public string TarState { get; set; }
        public string TarResponseCode { get; set; }
        public string TarResponseMessage { get; set; }
        public string TarPaymentNetworkResponseCode { get; set; }
        public string TarTrazabilityCode { get; set; }
        public string TarAuthorizationCode { get; set; }
        public DateTime? TarOperationDate { get; set; }
        public string Alumno { get; set; }
        public DateTime? FEstatus { get; set; }
        public bool? Asociadot { get; set; }
        public string TTerminacion { get; set; }
        public string TarEmail { get; set; }
    }
}
