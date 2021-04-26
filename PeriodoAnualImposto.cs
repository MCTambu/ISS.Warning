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
    
    public partial class PeriodoAnualImposto
    {
        public string IdPeriodoAnualImposto { get; set; }
        public string MesId { get; set; }
        public string TipoImpostoId { get; set; }
        public string CodPeriodoAnualImposto { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoId { get; set; }
        public string Descricao { get; set; }
        public string GrupoImpostoId { get; set; }
        public string SessaoImpostoId { get; set; }
        public string Obs { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual GrupoImposto GrupoImposto { get; set; }
        public virtual Meses Meses { get; set; }
        public virtual SessaoImposto SessaoImposto { get; set; }
        public virtual TipoImposto TipoImposto { get; set; }
    }
}
