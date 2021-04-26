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
    
    public partial class NaturezaMovimento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NaturezaMovimento()
        {
            this.Canal = new HashSet<Canal>();
            this.Cobertura = new HashSet<Cobertura>();
            this.ContratoPrestadorEmpresa = new HashSet<ContratoPrestadorEmpresa>();
            this.Moeda = new HashSet<Moeda>();
            this.Papel = new HashSet<Papel>();
            this.Perda = new HashSet<Perda>();
            this.PortfolioProduto = new HashSet<PortfolioProduto>();
            this.Premios = new HashSet<Premios>();
            this.Produto = new HashSet<Produto>();
            this.SegmentoProduto = new HashSet<SegmentoProduto>();
            this.TarifasAutomovel = new HashSet<TarifasAutomovel>();
            this.TarifasDanosProprios = new HashSet<TarifasDanosProprios>();
            this.TarifasPremioAutoAcidentesTrabalho = new HashSet<TarifasPremioAutoAcidentesTrabalho>();
            this.TarifasPremioAutoAT2 = new HashSet<TarifasPremioAutoAT2>();
            this.TarifasResponsabilidadeCivil = new HashSet<TarifasResponsabilidadeCivil>();
            this.TipoComissao = new HashSet<TipoComissao>();
            this.TipoConta = new HashSet<TipoConta>();
        }
    
        public string IdNaturezaMovimento { get; set; }
        public string Designacao { get; set; }
        public string CodNaturezaMovimento { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoID { get; set; }
        public string TipoNaturezaId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Canal> Canal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cobertura> Cobertura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContratoPrestadorEmpresa> ContratoPrestadorEmpresa { get; set; }
        public virtual Estado Estado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Moeda> Moeda { get; set; }
        public virtual TipoNatureza TipoNatureza { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Papel> Papel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Perda> Perda { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PortfolioProduto> PortfolioProduto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Premios> Premios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Produto> Produto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SegmentoProduto> SegmentoProduto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TarifasAutomovel> TarifasAutomovel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TarifasDanosProprios> TarifasDanosProprios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TarifasPremioAutoAcidentesTrabalho> TarifasPremioAutoAcidentesTrabalho { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TarifasPremioAutoAT2> TarifasPremioAutoAT2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TarifasResponsabilidadeCivil> TarifasResponsabilidadeCivil { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoComissao> TipoComissao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoConta> TipoConta { get; set; }
    }
}
