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
    
    public partial class RedeSocialPessoa
    {
        public string IdRedeSocialPessoa { get; set; }
        public string CodRedeSocialPessoa { get; set; }
        public string RedeSocialId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public string PessoaId { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
    
        public virtual Pessoa Pessoa { get; set; }
        public virtual RedeSociais RedeSociais { get; set; }
    }
}
