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
    
    public partial class Cobertura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cobertura()
        {
            this.BeneficioCobertura = new HashSet<BeneficioCobertura>();
            this.CoberturaServico = new HashSet<CoberturaServico>();
            this.CoberturaCosseguro = new HashSet<CoberturaCosseguro>();
            this.CoberturaResseguro = new HashSet<CoberturaResseguro>();
            this.CoberturaLinhaProduto = new HashSet<CoberturaLinhaProduto>();
            this.CoberturaTipoContrato = new HashSet<CoberturaTipoContrato>();
            this.CoeficientePremioAdesao = new HashSet<CoeficientePremioAdesao>();
            this.CoeficientePremioAdesaoCobertura = new HashSet<CoeficientePremioAdesaoCobertura>();
            this.CoeficientePremioDoencasPreExistentes = new HashSet<CoeficientePremioDoencasPreExistentes>();
            this.CoeficientePremioLimiteIndemnizacao = new HashSet<CoeficientePremioLimiteIndemnizacao>();
            this.CoeficientePremioAdesaoCobertura1 = new HashSet<CoeficientePremioAdesaoCobertura>();
            this.CoeficientePremioDoencasPreExistentes1 = new HashSet<CoeficientePremioDoencasPreExistentes>();
            this.CoeficientePremioPessoas = new HashSet<CoeficientePremioPessoas>();
            this.CoeficientePremioAdesao1 = new HashSet<CoeficientePremioAdesao>();
            this.CoeficientePremioLimiteIndemnizacao1 = new HashSet<CoeficientePremioLimiteIndemnizacao>();
            this.CoeficienteLimiteIndemnizacaoParto = new HashSet<CoeficienteLimiteIndemnizacaoParto>();
            this.ComparticipacaoCobertura = new HashSet<ComparticipacaoCobertura>();
            this.ComparticipacaoCobertura1 = new HashSet<ComparticipacaoCobertura>();
            this.Despesa = new HashSet<Despesa>();
            this.DespesaPlano = new HashSet<DespesaPlano>();
            this.DocumentosCoberturas = new HashSet<DocumentosCoberturas>();
            this.EncargoCobertura = new HashSet<EncargoCobertura>();
            this.ExclusoesCobertura = new HashSet<ExclusoesCobertura>();
            this.Franquia = new HashSet<Franquia>();
            this.GarantiasCobertura = new HashSet<GarantiasCobertura>();
            this.LimiteCobertura = new HashSet<LimiteCobertura>();
            this.LimiteResponsabilidade = new HashSet<LimiteResponsabilidade>();
            this.ListaValoresCobertura = new HashSet<ListaValoresCobertura>();
            this.ListaValoresCobertura1 = new HashSet<ListaValoresCobertura>();
            this.MembroAsseguradoCoberturas = new HashSet<MembroAsseguradoCoberturas>();
            this.RiscosExcluidos = new HashSet<RiscosExcluidos>();
            this.ServicosAdicionais = new HashSet<ServicosAdicionais>();
            this.ServicosBase = new HashSet<ServicosBase>();
            this.SobrePremioCoberturaAdicional = new HashSet<SobrePremioCoberturaAdicional>();
            this.SobrePremioCoberturaAdicional1 = new HashSet<SobrePremioCoberturaAdicional>();
            this.CoberturaEspecialidade = new HashSet<CoberturaEspecialidade>();
            this.CoberturaPlano = new HashSet<CoberturaPlano>();
            this.NivelRiscoCobertura = new HashSet<NivelRiscoCobertura>();
        }
    
        public string IdCobertura { get; set; }
        public string Designacao { get; set; }
        public Nullable<System.DateTime> DataEfectividadeCobertura { get; set; }
        public Nullable<System.DateTime> DataTerminoCobertura { get; set; }
        public Nullable<double> ValorMin { get; set; }
        public Nullable<double> ValorMax { get; set; }
        public Nullable<double> CooPagamentoMin { get; set; }
        public Nullable<double> CooPagamentoMax { get; set; }
        public double TaxaCooPagamento { get; set; }
        public Nullable<bool> CoberturaAdicional { get; set; }
        public Nullable<bool> CoberturaRenovavel { get; set; }
        public Nullable<bool> CustoCoberturaQualificado { get; set; }
        public Nullable<int> NumReivindicacoesPermitidas { get; set; }
        public Nullable<bool> CoberturaSujeitaCoSeguro { get; set; }
        public Nullable<bool> CoberturaDeveEstarRenovacao { get; set; }
        public Nullable<bool> CoberturaSolicitada { get; set; }
        public Nullable<bool> ForneceValorResgateEmDinheiro { get; set; }
        public Nullable<bool> SubContratentesCobertos { get; set; }
        public string EstadoID { get; set; }
        public Nullable<double> PercentagemDentroRede { get; set; }
        public Nullable<double> PercentagemForaRede { get; set; }
        public string MoedaId { get; set; }
        public string CodCoberturaProduto { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string Obs { get; set; }
        public Nullable<double> LimiteIndemnizacao { get; set; }
        public bool IsTaxa { get; set; }
        public string SubContaID { get; set; }
        public string NaturezaMovimentoID { get; set; }
        public bool Contabiliza { get; set; }
        public Nullable<bool> IsPadrao { get; set; }
        public string LinhaProdutoID { get; set; }
        public string CodDesconto { get; set; }
        public Nullable<double> Capital { get; set; }
        public Nullable<double> PercentagemMinimaForaRede { get; set; }
        public Nullable<double> PercentagemMaximaForaRede { get; set; }
        public string TipoCoberturaId { get; set; }
        public string FormaReparacaoId { get; set; }
        public Nullable<bool> Selecionavel { get; set; }
        public string Descricao { get; set; }
        public Nullable<double> Preco { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BeneficioCobertura> BeneficioCobertura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoberturaServico> CoberturaServico { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoberturaCosseguro> CoberturaCosseguro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoberturaResseguro> CoberturaResseguro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoberturaLinhaProduto> CoberturaLinhaProduto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoberturaTipoContrato> CoberturaTipoContrato { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual FormaReparacao FormaReparacao { get; set; }
        public virtual LinhaProduto LinhaProduto { get; set; }
        public virtual Moeda Moeda { get; set; }
        public virtual NaturezaMovimento NaturezaMovimento { get; set; }
        public virtual PlanoContas PlanoContas { get; set; }
        public virtual TipoCobertura TipoCobertura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoeficientePremioAdesao> CoeficientePremioAdesao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoeficientePremioAdesaoCobertura> CoeficientePremioAdesaoCobertura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoeficientePremioDoencasPreExistentes> CoeficientePremioDoencasPreExistentes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoeficientePremioLimiteIndemnizacao> CoeficientePremioLimiteIndemnizacao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoeficientePremioAdesaoCobertura> CoeficientePremioAdesaoCobertura1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoeficientePremioDoencasPreExistentes> CoeficientePremioDoencasPreExistentes1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoeficientePremioPessoas> CoeficientePremioPessoas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoeficientePremioAdesao> CoeficientePremioAdesao1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoeficientePremioLimiteIndemnizacao> CoeficientePremioLimiteIndemnizacao1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoeficienteLimiteIndemnizacaoParto> CoeficienteLimiteIndemnizacaoParto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComparticipacaoCobertura> ComparticipacaoCobertura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComparticipacaoCobertura> ComparticipacaoCobertura1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Despesa> Despesa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DespesaPlano> DespesaPlano { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentosCoberturas> DocumentosCoberturas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncargoCobertura> EncargoCobertura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExclusoesCobertura> ExclusoesCobertura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Franquia> Franquia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GarantiasCobertura> GarantiasCobertura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LimiteCobertura> LimiteCobertura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LimiteResponsabilidade> LimiteResponsabilidade { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ListaValoresCobertura> ListaValoresCobertura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ListaValoresCobertura> ListaValoresCobertura1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MembroAsseguradoCoberturas> MembroAsseguradoCoberturas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RiscosExcluidos> RiscosExcluidos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServicosAdicionais> ServicosAdicionais { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServicosBase> ServicosBase { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SobrePremioCoberturaAdicional> SobrePremioCoberturaAdicional { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SobrePremioCoberturaAdicional> SobrePremioCoberturaAdicional1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoberturaEspecialidade> CoberturaEspecialidade { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoberturaPlano> CoberturaPlano { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NivelRiscoCobertura> NivelRiscoCobertura { get; set; }
    }
}
