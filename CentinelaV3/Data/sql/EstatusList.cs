﻿using System;
using System.Collections.Generic;

namespace CentinelaV3.Data.sql
{
    public partial class EstatusList
    {
        public EstatusList()
        {
            Alumno = new HashSet<Alumno>();
            AlumnoPagos = new HashSet<AlumnoPagos>();
            BecaAlumnoBeestatusNavigation = new HashSet<BecaAlumno>();
            BecaAlumnoBetipoNavigation = new HashSet<BecaAlumno>();
            Becaalubitacora = new HashSet<Becaalubitacora>();
            ConvenioParcialidad = new HashSet<ConvenioParcialidad>();
            Convenios = new HashSet<Convenios>();
            CuentasPorCobrar = new HashSet<CuentasPorCobrar>();
            DetalleCuentaPorCobrar = new HashSet<DetalleCuentaPorCobrar>();
            DocumentoAlumno = new HashSet<DocumentoAlumno>();
            GeneralesProspecto = new HashSet<GeneralesProspecto>();
            Referencias = new HashSet<Referencias>();
        }

        public int SlStatusId { get; set; }
        public int SlModuloId { get; set; }
        public string SlModulo { get; set; }
        public string SlNombre { get; set; }
        public string SlDescripcion { get; set; }

        public virtual ICollection<Alumno> Alumno { get; set; }
        public virtual ICollection<AlumnoPagos> AlumnoPagos { get; set; }
        public virtual ICollection<BecaAlumno> BecaAlumnoBeestatusNavigation { get; set; }
        public virtual ICollection<BecaAlumno> BecaAlumnoBetipoNavigation { get; set; }
        public virtual ICollection<Becaalubitacora> Becaalubitacora { get; set; }
        public virtual ICollection<ConvenioParcialidad> ConvenioParcialidad { get; set; }
        public virtual ICollection<Convenios> Convenios { get; set; }
        public virtual ICollection<CuentasPorCobrar> CuentasPorCobrar { get; set; }
        public virtual ICollection<DetalleCuentaPorCobrar> DetalleCuentaPorCobrar { get; set; }
        public virtual ICollection<DocumentoAlumno> DocumentoAlumno { get; set; }
        public virtual ICollection<GeneralesProspecto> GeneralesProspecto { get; set; }
        public virtual ICollection<Referencias> Referencias { get; set; }
    }
}
