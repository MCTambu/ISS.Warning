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
    
    public partial class TipoSegmentoPlano
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoSegmentoPlano()
        {
            this.ComissionamentoPlano = new HashSet<ComissionamentoPlano>();
            this.CriterioComissionamento = new HashSet<CriterioComissionamento>();
            this.CriterioPlano = new HashSet<CriterioPlano>();
            this.LimiteComissionamentoPlano = new HashSet<LimiteComissionamentoPlano>();
            this.LimiteComissionamentoProdutor = new HashSet<LimiteComissionamentoProdutor>();
        }
    
        public string IdTipoSegmentoPlano { get; set; }
        public string PlanoProdutoId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string CodTipoSegmentoPlano { get; set; }
        public string TipoSegmentoId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComissionamentoPlano> ComissionamentoPlano { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CriterioComissionamento> CriterioComissionamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CriterioPlano> CriterioPlano { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LimiteComissionamentoPlano> LimiteComissionamentoPlano { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LimiteComissionamentoProdutor> LimiteComissionamentoProdutor { get; set; }
        public virtual PlanoProduto PlanoProduto { get; set; }
        public virtual TipoSegmento TipoSegmento { get; set; }
    }
}
