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
    
    public partial class TipoCartao
    {
        public string IdTipoCartao { get; set; }
        public string Designacao { get; set; }
        public string FormaPagamentoId { get; set; }
        public string CodTipoCartao { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoId { get; set; }
        public string TipoConta { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }
        public virtual TipoConta TipoConta1 { get; set; }
    }
}
