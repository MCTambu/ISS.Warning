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
    
    public partial class EnderecoPlano
    {
        public string IdEnderencoPlano { get; set; }
        public string EnderencoId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataActualizacao { get; set; }
        public string EstadoId { get; set; }
        public string PessoaId { get; set; }
        public string PlanoProdutoId { get; set; }
    
        public virtual Endereco Endereco { get; set; }
        public virtual PlanoProduto PlanoProduto { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
