﻿using System;
using System.Collections.Generic;

namespace CentinelaV3.Data.sql
{
    public partial class DatosMedicos
    {
        public DatosMedicos()
        {
            Consulta = new HashSet<Consulta>();
            Justificantes = new HashSet<Justificantes>();
        }

        public string DmPacienteId { get; set; }
        public string DmTipoSangre { get; set; }
        public bool DmAlergico { get; set; }
        public decimal DmPeso { get; set; }
        public decimal DmEstatura { get; set; }
        public bool DmFuma { get; set; }
        public bool DmTatuajes { get; set; }
        public bool DmToma { get; set; }
        public bool DmMascotas { get; set; }
        public bool DmHijos { get; set; }
        public string DmCirugias { get; set; }
        public bool DmDiabetes { get; set; }
        public bool DmHipertension { get; set; }

        public virtual Administrativos DmPaciente { get; set; }
        public virtual ICollection<Consulta> Consulta { get; set; }
        public virtual ICollection<Justificantes> Justificantes { get; set; }
    }
}
