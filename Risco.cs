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
    
    public partial class Risco
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Risco()
        {
            this.ActividadeEmpresaRiscos = new HashSet<ActividadeEmpresaRiscos>();
            this.Exclusoes = new HashSet<Exclusoes>();
            this.ImpactoRisco = new HashSet<ImpactoRisco>();
            this.PlanoMitigacaoRisco = new HashSet<PlanoMitigacaoRisco>();
            this.ProjectoRiscos = new HashSet<ProjectoRiscos>();
            this.Risco1 = new HashSet<Risco>();
            this.RiscoOutraSeguradoraContrato = new HashSet<RiscoOutraSeguradoraContrato>();
            this.RiscoPortfolio = new HashSet<RiscoPortfolio>();
            this.RiscosProcesso = new HashSet<RiscosProcesso>();
            this.RiscosTarefa = new HashSet<RiscosTarefa>();
            this.SubRisco = new HashSet<SubRisco>();
        }
    
        public string IdRisco { get; set; }
        public string Designacao { get; set; }
        public string LinhaProdutoID { get; set; }
        public string CodRisco { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string ProdutoID { get; set; }
        public string EstadoID { get; set; }
        public string UltModificacaoPorID { get; set; }
        public Nullable<double> ValorMin { get; set; }
        public Nullable<double> ValorMax { get; set; }
        public Nullable<double> Agravamento { get; set; }
        public string Descricao { get; set; }
        public string RiscoPaiId { get; set; }
        public string TipoRiscoId { get; set; }
        public string Nota { get; set; }
        public string PlanoProdutoId { get; set; }
        public string CategoriaRiscoId { get; set; }
        public string GravidadeRiscoId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActividadeEmpresaRiscos> ActividadeEmpresaRiscos { get; set; }
        public virtual CategoriaRisco CategoriaRisco { get; set; }
        public virtual Estado Estado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exclusoes> Exclusoes { get; set; }
        public virtual GravidadeRisco GravidadeRisco { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImpactoRisco> ImpactoRisco { get; set; }
        public virtual LinhaProduto LinhaProduto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanoMitigacaoRisco> PlanoMitigacaoRisco { get; set; }
        public virtual PlanoProduto PlanoProduto { get; set; }
        public virtual Produto Produto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectoRiscos> ProjectoRiscos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Risco> Risco1 { get; set; }
        public virtual Risco Risco2 { get; set; }
        public virtual TipoRisco TipoRisco { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RiscoOutraSeguradoraContrato> RiscoOutraSeguradoraContrato { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RiscoPortfolio> RiscoPortfolio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RiscosProcesso> RiscosProcesso { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RiscosTarefa> RiscosTarefa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubRisco> SubRisco { get; set; }
    }
}
