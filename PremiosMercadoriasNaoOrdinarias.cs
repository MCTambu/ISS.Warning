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
    
    public partial class PremiosMercadoriasNaoOrdinarias
    {
        public string IdPremiosMercadoriasNaoOrdinarias { get; set; }
        public string Categoria { get; set; }
        public string Localidade { get; set; }
        public Nullable<double> Risco1 { get; set; }
        public Nullable<double> Risco2 { get; set; }
        public Nullable<double> Risco3 { get; set; }
        public string ClassificacaoObjecto { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoId { get; set; }
        public string CodPremiosMercadoriasNaoOrdinarias { get; set; }
    
        public virtual Estado Estado { get; set; }
    }
}
