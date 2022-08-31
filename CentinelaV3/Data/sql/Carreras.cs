﻿using System;
using System.Collections.Generic;

namespace CentinelaV3.Data.sql
{
    public partial class Carreras
    {
        public Carreras()
        {
            Alumno = new HashSet<Alumno>();
            GeneralesProspecto = new HashSet<GeneralesProspecto>();
            ListaPrecios = new HashSet<ListaPrecios>();
        }

        public int Idcarrera { get; set; }
        public string CarreraClave { get; set; }
        public string CarreraNombre { get; set; }
        public bool? CarreraActiva { get; set; }
        public string CarreraRevoe { get; set; }
        public DateTime? CarreraFeRevoe { get; set; }
        public int? CarreraCreditos { get; set; }
        public bool? CarreraTipo { get; set; }
        public int? ClaveCarrera { get; set; }
        public int? CarreraMaterias { get; set; }
        public decimal? FacFacultadId { get; set; }
        public string CarreraIp { get; set; }
        public long? Usuid { get; set; }
        public DateTime? CarreraAct { get; set; }
        public int? ModModalidadId { get; set; }
        public int? PeId { get; set; }
        public int? NivelId { get; set; }
        public int? TempId { get; set; }

        public virtual Facultades FacFacultad { get; set; }
        public virtual Modalidades ModModalidad { get; set; }
        public virtual Niveles Nivel { get; set; }
        public virtual PlanesEstudio Pe { get; set; }
        public virtual Usuario Usu { get; set; }
        public virtual ICollection<Alumno> Alumno { get; set; }
        public virtual ICollection<GeneralesProspecto> GeneralesProspecto { get; set; }
        public virtual ICollection<ListaPrecios> ListaPrecios { get; set; }
    }
}
