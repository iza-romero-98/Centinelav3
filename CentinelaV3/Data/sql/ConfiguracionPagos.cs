﻿using System;
using System.Collections.Generic;

namespace CentinelaV3.Data.sql
{
    public partial class ConfiguracionPagos
    {
        public int ConfId { get; set; }
        public int? ConfAño { get; set; }
        public int? ConfPeriodo { get; set; }
        public int? ConfRecargos { get; set; }
        public int? ConfDiaVencimiento { get; set; }
    }
}
