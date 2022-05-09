﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CentinelaV3.Data.sql
{
    public partial class Alumno
    {
        public Alumno()
        {
            AlumnoPagos = new HashSet<AlumnoPagos>();
            BecaAlumno = new HashSet<BecaAlumno>();
            Becaalubitacora = new HashSet<Becaalubitacora>();
            CuentasPorCobrar = new HashSet<CuentasPorCobrar>();
            GeneralesAlumno = new HashSet<GeneralesAlumno>();
            Referencias = new HashSet<Referencias>();
        }

        public long AlId { get; set; }
        public string AlMatricula { get; set; }
        public DateTime AlFechaIngreso { get; set; }
        public string AlNombre { get; set; }
        public string AlApp { get; set; }
        public string AlApm { get; set; }
        public DateTime AlFechaNac { get; set; }
        public string AlCorreoInst { get; set; }
        public bool AlSexo { get; set; }
        public int AlStatusActual { get; set; }
        public int? AlCarrera { get; set; }
        public int AlAnoPeriodoActual { get; set; }
        public int AlEsquemaPagoActual { get; set; }
        public int AlBecaActual { get; set; }
        public int AlBecaParcialidad { get; set; }
        public bool AlDocumentos { get; set; }
        public bool AlFactura { get; set; }
        public DateTime AlFechaInicioNivel { get; set; }
        public int AlCicloActual { get; set; }
        public int AlModalidadActual { get; set; }
        public string AlCurp { get; set; }
        public int AlBecaInscripcion { get; set; }
        public int AlDescPromocion { get; set; }
        public int AlPeriodoActual { get; set; }
        public long? AlCoutaAdmin { get; set; }
        public decimal? AlMontoDesc { get; set; }
        public int? AlSemestre { get; set; }

        public virtual Carreras AlCarreraNavigation { get; set; }
        public virtual EsquemaPago AlEsquemaPagoActualNavigation { get; set; }
        public virtual EstatusList AlStatusActualNavigation { get; set; }
        public virtual ICollection<AlumnoPagos> AlumnoPagos { get; set; }
        public virtual ICollection<BecaAlumno> BecaAlumno { get; set; }
        public virtual ICollection<Becaalubitacora> Becaalubitacora { get; set; }
        public virtual ICollection<CuentasPorCobrar> CuentasPorCobrar { get; set; }
        public virtual ICollection<GeneralesAlumno> GeneralesAlumno { get; set; }
        public virtual ICollection<Referencias> Referencias { get; set; }
    }
}