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
    
    public partial class PremiosExploracaoRural
    {
        public string IdPremiosExploracaoRural { get; set; }
        public string TipoObjecto { get; set; }
        public string Objecto { get; set; }
        public Nullable<double> Risco1 { get; set; }
        public Nullable<double> Risco2 { get; set; }
        public Nullable<double> Risco3 { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoId { get; set; }
    
        public virtual Estado Estado { get; set; }
    }
}
