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
    
    public partial class ObjectoTrabalhoPessoa
    {
        public string IdObjectoTrabalhoPessoa { get; set; }
        public string ObjectoTrabalhoID { get; set; }
        public string PessoaId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoID { get; set; }
        public string CodObjectoTrabalhoPessoa { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual ObjectoTrabalho ObjectoTrabalho { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
