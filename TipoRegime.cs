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
    
    public partial class TipoRegime
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoRegime()
        {
            this.DimensaoEmpresa = new HashSet<DimensaoEmpresa>();
            this.Pessoa = new HashSet<Pessoa>();
            this.Provincia = new HashSet<Provincia>();
            this.SectorAtividadeEconomica = new HashSet<SectorAtividadeEconomica>();
        }
    
        public string IdTipoRegime { get; set; }
        public string Designacao { get; set; }
        public Nullable<double> PercentagemIva { get; set; }
        public string TipoPessoaId { get; set; }
        public string EnderecoId { get; set; }
        public string EstadoId { get; set; }
        public Nullable<double> ValorMin { get; set; }
        public Nullable<double> ValorMax { get; set; }
        public string MoedaId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> AtualizacaoCriacao { get; set; }
        public string CodTipoRegime { get; set; }
        public Nullable<double> TaxaRegime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DimensaoEmpresa> DimensaoEmpresa { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Moeda Moeda { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pessoa> Pessoa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Provincia> Provincia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SectorAtividadeEconomica> SectorAtividadeEconomica { get; set; }
        public virtual TipoPessoa TipoPessoa { get; set; }
    }
}