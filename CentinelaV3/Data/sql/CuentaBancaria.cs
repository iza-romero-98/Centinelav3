﻿using System;
using System.Collections.Generic;

namespace CentinelaV3.Data.sql
{
    public partial class CuentaBancaria
    {
        public CuentaBancaria()
        {
            AlumnoPagos = new HashSet<AlumnoPagos>();
        }

        public int CbCuentaId { get; set; }
        public int CbBancoId { get; set; }
        public string CbCuenta { get; set; }
        public string CbNombreCuenta { get; set; }
        public string CbClabe { get; set; }
        public string CbConvenio { get; set; }
        public string CbBeneficiario { get; set; }
        public int CbEmpresa { get; set; }
        public bool? CbPagoManual { get; set; }
        public bool? CbPagoReferenciado { get; set; }
        public bool? CbPagoLinea { get; set; }
        public long CbUsuid { get; set; }
        public DateTime? CbFechaRegistro { get; set; }

        public virtual Bancos CbBanco { get; set; }
        public virtual Empresas CbEmpresaNavigation { get; set; }
        public virtual ActivoPara ActivoPara { get; set; }
        public virtual ICollection<AlumnoPagos> AlumnoPagos { get; set; }
    }
}
