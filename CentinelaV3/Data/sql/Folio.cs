﻿using System;
using System.Collections.Generic;

namespace CentinelaV3.Data.sql
{
    public partial class Folio
    {
        public int FolioId { get; set; }
        public int FolioAlu { get; set; }
        public int FolioPrs { get; set; }
        public DateTime FolioPrsDate { get; set; }
        public DateTime FolioAluDate { get; set; }
        public int FolioAluUsuid { get; set; }
        public int FolioPrsUsuid { get; set; }
    }
}
