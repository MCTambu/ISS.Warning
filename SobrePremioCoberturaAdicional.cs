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
    
    public partial class SobrePremioCoberturaAdicional
    {
        public string IdSobrePremioCoberturaAdicional { get; set; }
        public string CoberturaId { get; set; }
        public string CodSobrePremioCoberturaAdicional { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoId { get; set; }
        public Nullable<double> PorCadaCapitalSeguro { get; set; }
        public string CoberturaAdicionalId { get; set; }
        public Nullable<double> SobrePremio { get; set; }
    
        public virtual Cobertura Cobertura { get; set; }
        public virtual Cobertura Cobertura1 { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
