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
    
    public partial class ActividadeEmpresaRiscos
    {
        public string IdActividadeEmpresaRiscos { get; set; }
        public string ActividadeEmpresaId { get; set; }
        public string RiscoId { get; set; }
        public string CodActividadeEmpresaRiscos { get; set; }
        public string EstadoId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
    
        public virtual ActividadeEmpresa ActividadeEmpresa { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Risco Risco { get; set; }
    }
}
