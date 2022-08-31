﻿using System;
using System.Collections.Generic;

namespace CentinelaV3.Data.sql
{
    public partial class Materias
    {
        public Materias()
        {
            FaltasClase = new HashSet<FaltasClase>();
        }

        public int MMateriaId { get; set; }
        public string MPlanEstudio { get; set; }
        public string MClave { get; set; }
        public string MNombre { get; set; }
        public bool MOptativa { get; set; }
        public decimal? MOrdenMateria { get; set; }
        public int MSemestre { get; set; }
        public string MPreRequisito { get; set; }
        public decimal MNumeroHoras { get; set; }
        public int MCreditos { get; set; }
        public string MDescripcio { get; set; }

        public virtual ICollection<FaltasClase> FaltasClase { get; set; }
    }
}