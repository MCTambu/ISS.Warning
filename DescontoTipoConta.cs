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
    
    public partial class DescontoTipoConta
    {
        public string IdDescontoTipoConta { get; set; }
        public string DescontoId { get; set; }
        public string CodDescontoTipoConta { get; set; }
        public string TipoContaId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
    
        public virtual Desconto Desconto { get; set; }
        public virtual TipoConta TipoConta { get; set; }
    }
}