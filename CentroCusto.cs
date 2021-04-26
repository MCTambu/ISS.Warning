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
    
    public partial class CentroCusto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CentroCusto()
        {
            this.Agravamento = new HashSet<Agravamento>();
            this.Apolice = new HashSet<Apolice>();
            this.ComissaoPlano = new HashSet<ComissaoPlano>();
            this.Contrato = new HashSet<Contrato>();
            this.Cotacao = new HashSet<Cotacao>();
            this.Despesa = new HashSet<Despesa>();
            this.MargemVendaProduto = new HashSet<MargemVendaProduto>();
            this.Operacao = new HashSet<Operacao>();
            this.PlanoProduto = new HashSet<PlanoProduto>();
            this.Tarifa = new HashSet<Tarifa>();
        }
    
        public string IdCentroCusto { get; set; }
        public string Designacao { get; set; }
        public string PessoaId { get; set; }
        public string DireccaoId { get; set; }
        public string DepartamentoId { get; set; }
        public string SeccaoId { get; set; }
        public string SectorId { get; set; }
        public string AreaId { get; set; }
        public string SubContaID { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoId { get; set; }
        public bool Contabiliza { get; set; }
        public string CodCentroCusto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Agravamento> Agravamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Apolice> Apolice { get; set; }
        public virtual Area Area { get; set; }
        public virtual Direccao Direccao { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual Seccao Seccao { get; set; }
        public virtual Sector Sector { get; set; }
        public virtual PlanoContas PlanoContas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComissaoPlano> ComissaoPlano { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contrato> Contrato { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cotacao> Cotacao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Despesa> Despesa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MargemVendaProduto> MargemVendaProduto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operacao> Operacao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanoProduto> PlanoProduto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tarifa> Tarifa { get; set; }
    }
}
