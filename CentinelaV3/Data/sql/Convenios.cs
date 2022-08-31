﻿using System;
using System.Collections.Generic;

namespace CentinelaV3.Data.sql
{
    public partial class Convenios
    {
        public Convenios()
        {
            ConvenioHistorico = new HashSet<ConvenioHistorico>();
            ConvenioParcialidad = new HashSet<ConvenioParcialidad>();
            DetalleConvenio = new HashSet<DetalleConvenio>();
            InverseConReferenciaConvenioNavigation = new HashSet<Convenios>();
        }

        public int ConId { get; set; }
        public long ConAlid { get; set; }
        public int ConTipoConvenio { get; set; }
        public DateTime ConFechaCreacion { get; set; }
        public DateTime ConFechaInicio { get; set; }
        public DateTime ConFechaFin { get; set; }
        public DateTime? ConFechaCierre { get; set; }
        public string ConComentario { get; set; }
        public long? ConDocumentoId { get; set; }
        public int? ConReferenciaConvenio { get; set; }
        public int ConEstatus { get; set; }
        public int? ConNumeroExtension { get; set; }
        public bool? ConExtension { get; set; }
        public long ConUsuid { get; set; }
        public DateTime ConFechaRegistro { get; set; }
        public int? ConEstutor { get; set; }
        public string ConNombreSub { get; set; }
        public string ConDireccionSub { get; set; }
        public int? EstadosId { get; set; }
        public string ConTelefnoSub { get; set; }
        public string ConCelSub { get; set; }
        public string ConEmailSub { get; set; }
        public string ConFaceSub { get; set; }

        public virtual Alumno ConAl { get; set; }
        public virtual DocumentosGenerales ConDocumento { get; set; }
        public virtual EstatusList ConEstatusNavigation { get; set; }
        public virtual Convenios ConReferenciaConvenioNavigation { get; set; }
        public virtual CatalogoConvenios ConTipoConvenioNavigation { get; set; }
        public virtual Estados Estados { get; set; }
        public virtual ICollection<ConvenioHistorico> ConvenioHistorico { get; set; }
        public virtual ICollection<ConvenioParcialidad> ConvenioParcialidad { get; set; }
        public virtual ICollection<DetalleConvenio> DetalleConvenio { get; set; }
        public virtual ICollection<Convenios> InverseConReferenciaConvenioNavigation { get; set; }
    }
}
