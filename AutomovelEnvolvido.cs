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
    
    public partial class AutomovelEnvolvido
    {
        public string IdAutomovelEnvolvido { get; set; }
        public string AutomovelId { get; set; }
        public string ObjectoEnvolvidoId { get; set; }
        public string CodAutomovelEnvolvido { get; set; }
        public string EstadoId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
    
        public virtual Automovel Automovel { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual ObjectoEnvolvido ObjectoEnvolvido { get; set; }
    }
}
