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
    
    public partial class DocumentosObrigatorioPlano
    {
        public string IdDocumentosObrigatorioPlano { get; set; }
        public string Designacao { get; set; }
        public string PlanoProdutoId { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string CodDocumentosObrigatorioPlano { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public string EstadoId { get; set; }
        public Nullable<bool> EObrigatorio { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual PlanoProduto PlanoProduto { get; set; }
    }
}