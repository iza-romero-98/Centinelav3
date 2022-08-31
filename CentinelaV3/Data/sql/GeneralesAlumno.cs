﻿using System;
using System.Collections.Generic;

namespace CentinelaV3.Data.sql
{
    public partial class GeneralesAlumno
    {
        public long GaAlumnoId { get; set; }
        public string GaNombreTutor { get; set; }
        public string GaApptutor { get; set; }
        public string GaApmtutor { get; set; }
        public string GaCalle { get; set; }
        public string GaNueroExt { get; set; }
        public string GaNumeroInterior { get; set; }
        public int GaEstado { get; set; }
        public int GaMunicipio { get; set; }
        public string GaTelefonoTutor { get; set; }
        public string GaTelefonoAlumno { get; set; }
        public string GaCorreoAlternativo { get; set; }
        public DateTime? GaFechaNac { get; set; }
        public long? AlId { get; set; }
        public string GaTelefonoCasa { get; set; }

        public virtual Alumno Al { get; set; }
        public virtual Estados GaEstadoNavigation { get; set; }
        public virtual Municipios GaMunicipioNavigation { get; set; }
    }
}
