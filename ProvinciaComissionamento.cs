//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ISS.Warning
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProvinciaComissionamento
    {
        public string IdCriterioComissionamento { get; set; }
        public string ComissionamentoId { get; set; }
        public string ProvinciaId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public string CriterioComissionamentoId { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoId { get; set; }
        public string CodCriterioComissionamento { get; set; }
    
        public virtual Comissionamento Comissionamento { get; set; }
        public virtual CriterioComissionamento CriterioComissionamento { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Provincia Provincia { get; set; }
    }
}
