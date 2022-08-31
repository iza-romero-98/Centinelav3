﻿using System;
using System.Collections.Generic;

namespace CentinelaV3.Data.sql
{
    public partial class Becas
    {
        public Becas()
        {
            BecaAlumno = new HashSet<BecaAlumno>();
            Becaalubitacora = new HashSet<Becaalubitacora>();
        }

        public int BecasId { get; set; }
        public string BecasClave { get; set; }
        public string BecasNombre { get; set; }
        public string BecasDescripcion { get; set; }
        public bool BecasActiva { get; set; }
        public long Usuid { get; set; }
        public string BecasResponsable { get; set; }
        public int? CategoriaId { get; set; }
        public int? ConId { get; set; }
        public bool BecasProm { get; set; }

        public virtual Categoriabeca Categoria { get; set; }
        public virtual CatalogoConceptos Con { get; set; }
        public virtual ICollection<BecaAlumno> BecaAlumno { get; set; }
        public virtual ICollection<Becaalubitacora> Becaalubitacora { get; set; }
    }
}
