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
    
    public partial class ReivindicacoesFeitasApolice
    {
        public string IdReivindicacoesFeitasApolice { get; set; }
        public Nullable<System.DateTime> DataHoraEmissao { get; set; }
        public double PercentagemDescobertura { get; set; }
        public Nullable<double> MontanteDescoberta { get; set; }
        public string ApoliceID { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public bool IsTaxa { get; set; }
        public string EstadoID { get; set; }
    
        public virtual Apolice Apolice { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
