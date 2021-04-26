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
    
    public partial class Premios
    {
        public string IdPremio { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public Nullable<double> Risco1 { get; set; }
        public Nullable<double> Risco2 { get; set; }
        public Nullable<double> Risco3 { get; set; }
        public string SubContaID { get; set; }
        public string NivelRiscoID { get; set; }
        public string CodPremios { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoID { get; set; }
        public string UltModificacaoPorID { get; set; }
        public string NaturezaMovimentoId { get; set; }
        public bool Contabiliza { get; set; }
        public string Localidade { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual NaturezaMovimento NaturezaMovimento { get; set; }
        public virtual NivelRisco NivelRisco { get; set; }
        public virtual PlanoContas PlanoContas { get; set; }
    }
}
