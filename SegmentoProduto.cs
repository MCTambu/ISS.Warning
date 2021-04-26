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
    
    public partial class SegmentoProduto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SegmentoProduto()
        {
            this.Comissionamento = new HashSet<Comissionamento>();
            this.SegmentoProdutoPlano = new HashSet<SegmentoProdutoPlano>();
        }
    
        public string IdSegmentoProduto { get; set; }
        public Nullable<int> IdadeMin { get; set; }
        public Nullable<int> IdadeMax { get; set; }
        public string SexoId { get; set; }
        public string BalcaoID { get; set; }
        public string FidelizacaoID { get; set; }
        public string TipoSegmentoID { get; set; }
        public string CAEid { get; set; }
        public string PessoaID { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoID { get; set; }
        public string CodSegmentoProduto { get; set; }
        public string NaturezaMovimentoId { get; set; }
        public string SubContaId { get; set; }
        public string PlanoProdutoID { get; set; }
    
        public virtual Agencia Agencia { get; set; }
        public virtual CAE CAE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comissionamento> Comissionamento { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Fidelizacao Fidelizacao { get; set; }
        public virtual NaturezaMovimento NaturezaMovimento { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual PlanoContas PlanoContas { get; set; }
        public virtual PlanoProduto PlanoProduto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SegmentoProdutoPlano> SegmentoProdutoPlano { get; set; }
        public virtual Sexo Sexo { get; set; }
        public virtual TipoSegmento TipoSegmento { get; set; }
    }
}