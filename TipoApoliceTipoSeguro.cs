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
    
    public partial class TipoApoliceTipoSeguro
    {
        public string IdTipoApoliceTipoSeguro { get; set; }
        public string TipoApoliceId { get; set; }
        public string TipoSeguroId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
    
        public virtual TipoApolice TipoApolice { get; set; }
        public virtual TipoSeguro TipoSeguro { get; set; }
    }
}