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
    
    public partial class CoberturaSelecionada
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CoberturaSelecionada()
        {
            this.ConsumoPlafond = new HashSet<ConsumoPlafond>();
            this.Indeminizacao = new HashSet<Indeminizacao>();
        }
    
        public string IdCoberturaSelecionada { get; set; }
        public string CotacaoID { get; set; }
        public Nullable<double> PorAnuidade { get; set; }
        public Nullable<double> PorCadaSinistro { get; set; }
        public Nullable<double> PorCadaPessoaSinistrada { get; set; }
        public Nullable<double> PorDanosCoisasAnimais { get; set; }
        public Nullable<double> Personalizado { get; set; }
        public Nullable<double> ValorPersonalizado { get; set; }
        public Nullable<double> CoPagamento { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoID { get; set; }
        public string CoberturaPlanoId { get; set; }
        public string NaturezaRisco { get; set; }
        public string ObjectoSeguradoId { get; set; }
        public string PessoaId { get; set; }
        public Nullable<double> PremioCobertura { get; set; }
        public Nullable<double> TaxaFranquiaCobertura { get; set; }
        public Nullable<System.DateTime> DataInicio { get; set; }
        public Nullable<System.DateTime> DataFim { get; set; }
        public string MembroAsseguradoId { get; set; }
    
        public virtual CoberturaPlano CoberturaPlano { get; set; }
        public virtual Cotacao Cotacao { get; set; }
        public virtual MembroAssegurado MembroAssegurado { get; set; }
        public virtual ObjectoSegurado ObjectoSegurado { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConsumoPlafond> ConsumoPlafond { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Indeminizacao> Indeminizacao { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
