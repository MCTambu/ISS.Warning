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
    
    public partial class ClasseContaClassificacaoConta
    {
        public string IdClasseContaClassificacaoConta { get; set; }
        public string ClassificacaoContaId { get; set; }
        public string ClasseContaId { get; set; }
        public string EstadoId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string CodClasseContaClassificacaoConta { get; set; }
    
        public virtual ClasseConta ClasseConta { get; set; }
        public virtual ClassificacaoConta ClassificacaoConta { get; set; }
        public virtual Estado Estado { get; set; }
    }
}