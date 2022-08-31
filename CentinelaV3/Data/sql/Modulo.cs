﻿using System;
using System.Collections.Generic;

namespace CentinelaV3.Data.sql
{
    public partial class Modulo
    {
        public Modulo()
        {
            ConfiguracionCorreo = new HashSet<ConfiguracionCorreo>();
            Pantalla = new HashSet<Pantalla>();
            Tbusuario = new HashSet<Tbusuario>();
            TiposDocumentos = new HashSet<TiposDocumentos>();
            Tpermisos = new HashSet<Tpermisos>();
        }

        public int ModuloId { get; set; }
        public string ModuloNombre { get; set; }
        public string ModuloDescripcion { get; set; }
        public long? Usuid { get; set; }
        public DateTime? ModuloFecha { get; set; }
        public bool ModuloActivo { get; set; }
        public string ModuloSimbolo { get; set; }

        public virtual Usuario Usu { get; set; }
        public virtual ICollection<ConfiguracionCorreo> ConfiguracionCorreo { get; set; }
        public virtual ICollection<Pantalla> Pantalla { get; set; }
        public virtual ICollection<Tbusuario> Tbusuario { get; set; }
        public virtual ICollection<TiposDocumentos> TiposDocumentos { get; set; }
        public virtual ICollection<Tpermisos> Tpermisos { get; set; }
    }
}
