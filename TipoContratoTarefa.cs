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
    
    public partial class TipoContratoTarefa
    {
        public string IdTipoContratoTarefa { get; set; }
        public string TarefaId { get; set; }
        public string TipoContratoId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public Nullable<bool> IsAlteravel { get; set; }
        public string ResponsavelId { get; set; }
    
        public virtual Pessoa Pessoa { get; set; }
        public virtual Tarefa Tarefa { get; set; }
        public virtual TipoContrato TipoContrato { get; set; }
    }
}