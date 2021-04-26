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
    
    public partial class ValorCobertura
    {
        public string IdValorCobertura { get; set; }
        public Nullable<double> PremioRisco { get; set; }
        public Nullable<double> PremioSimples { get; set; }
        public Nullable<double> SinistroEsperado { get; set; }
        public Nullable<double> MargemComnercial { get; set; }
        public Nullable<double> PremioComercial { get; set; }
        public Nullable<double> TaxaComercial { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public Nullable<double> PremioBruto { get; set; }
        public Nullable<double> PremioCobrado { get; set; }
        public string CodValorCobertura { get; set; }
        public string CoberturaApoliceId { get; set; }
        public string EstadoId { get; set; }
        public string ClassificacaoAutomovelId { get; set; }
    
        public virtual ClassificacaoAutomovel ClassificacaoAutomovel { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
