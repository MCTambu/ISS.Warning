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
    
    public partial class CoberturaEspecialidadeAtosMedicos
    {
        public string IdCoberturaEspecialidadeAtosMedicos { get; set; }
        public string CoberturaEspecialidadeId { get; set; }
        public string AtosMedicosId { get; set; }
        public string EstadoId { get; set; }
        public string CodCoberturaEspecialidadeAtosMedicos { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
    
        public virtual AtosMedicos AtosMedicos { get; set; }
        public virtual CoberturaEspecialidade CoberturaEspecialidade { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
