﻿using System;
using System.Collections.Generic;

namespace CentinelaV3.Data.sql
{
    public partial class Niveles
    {
        public Niveles()
        {
            Carreras = new HashSet<Carreras>();
            ConfiguracionCorreo = new HashSet<ConfiguracionCorreo>();
            DocumentoBitacora = new HashSet<DocumentoBitacora>();
            DocumentosNivel = new HashSet<DocumentosNivel>();
            Grupos = new HashSet<Grupos>();
            ListaPrecios = new HashSet<ListaPrecios>();
            MoodleKey = new HashSet<MoodleKey>();
            Reglamentos = new HashSet<Reglamentos>();
        }

        public int NivelId { get; set; }
        public string NivelNombre { get; set; }
        public string NivelDescripcion { get; set; }

        public virtual ICollection<Carreras> Carreras { get; set; }
        public virtual ICollection<ConfiguracionCorreo> ConfiguracionCorreo { get; set; }
        public virtual ICollection<DocumentoBitacora> DocumentoBitacora { get; set; }
        public virtual ICollection<DocumentosNivel> DocumentosNivel { get; set; }
        public virtual ICollection<Grupos> Grupos { get; set; }
        public virtual ICollection<ListaPrecios> ListaPrecios { get; set; }
        public virtual ICollection<MoodleKey> MoodleKey { get; set; }
        public virtual ICollection<Reglamentos> Reglamentos { get; set; }
    }
}
