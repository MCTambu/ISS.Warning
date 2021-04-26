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
    
    public partial class FormaContratacaoPlano
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FormaContratacaoPlano()
        {
            this.IntervaloIdadeFormaContratacaoPlano = new HashSet<IntervaloIdadeFormaContratacaoPlano>();
        }
    
        public string IdFormaContratacaoPlano { get; set; }
        public string PlanoProdutoId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public string FormaContratacaoId { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string PessoaId { get; set; }
        public string EstadoId { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual FormaContratacao FormaContratacao { get; set; }
        public virtual PlanoProduto PlanoProduto { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IntervaloIdadeFormaContratacaoPlano> IntervaloIdadeFormaContratacaoPlano { get; set; }
    }
}