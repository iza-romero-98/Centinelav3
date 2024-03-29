﻿using System;
using System.Collections.Generic;

namespace CentinelaV3.Data.sql
{
    public partial class ContactoProspecto
    {
        public long ContId { get; set; }
        public string NombreC { get; set; }
        public string AppC { get; set; }
        public string ApmC { get; set; }
        public string TelC { get; set; }
        public string CelC { get; set; }
        public string EmailC { get; set; }
        public int? TipoC { get; set; }
        public DateTime? FechaR { get; set; }
        public long? GpprospectoId { get; set; }

        public virtual GeneralesProspecto Gpprospecto { get; set; }
    }
}
