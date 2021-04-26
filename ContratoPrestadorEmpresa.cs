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
    
    public partial class ContratoPrestadorEmpresa
    {
        public string IdContratoPrestadorEmpresa { get; set; }
        public Nullable<System.DateTime> DataInicio { get; set; }
        public Nullable<System.DateTime> DataFim { get; set; }
        public Nullable<bool> Renovavel { get; set; }
        public Nullable<bool> Exclusivo { get; set; }
        public string MoedaId { get; set; }
        public Nullable<double> Valor { get; set; }
        public string FormaPagamentoId { get; set; }
        public string PessoaResponsavelFuncionarioId { get; set; }
        public string PessoaResponsavelPrestador { get; set; }
        public string InformacaoBancaria { get; set; }
        public string Ambito { get; set; }
        public string Objectivo { get; set; }
        public Nullable<int> PrazoContrato { get; set; }
        public Nullable<int> PeriodicidadePaga { get; set; }
        public string Clausulas { get; set; }
        public Nullable<double> TaxaJuros { get; set; }
        public string NaturezaMovimento { get; set; }
        public string CodTransacao { get; set; }
        public Nullable<int> NumeroContrato { get; set; }
        public Nullable<int> Referencia { get; set; }
        public string ContratanteId { get; set; }
        public string ContratadoId { get; set; }
        public Nullable<System.DateTime> DataAssinatura { get; set; }
        public Nullable<System.DateTime> DataVencimento { get; set; }
        public string MoradaCobrancaContrato { get; set; }
        public string MoradaAssinatura { get; set; }
        public Nullable<int> NumeroPrestacoesPagas { get; set; }
        public Nullable<int> NumeroPrestacoesAPagar { get; set; }
        public Nullable<double> TotalValorPago { get; set; }
        public Nullable<double> TotalValorAPagar { get; set; }
        public string EstadoId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataActualizacao { get; set; }
        public string ContaContabilistica { get; set; }
        public string ReclamacaoId { get; set; }
        public string NotaId { get; set; }
        public string ActividadeId { get; set; }
        public string Objecto { get; set; }
        public string PessoaResponsavelFuncionario { get; set; }
        public string LocalEmissaoId { get; set; }
        public string TipoPagamentoId { get; set; }
        public string ClausulasAlteradasId { get; set; }
    
        public virtual Actividade Actividade { get; set; }
        public virtual Clausula Clausula { get; set; }
        public virtual ClausulasAlteradas ClausulasAlteradas { get; set; }
        public virtual PlanoContas PlanoContas { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual Pessoa Pessoa1 { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }
        public virtual InformacaoBancaria InformacaoBancaria1 { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual Moeda Moeda { get; set; }
        public virtual Endereco Endereco1 { get; set; }
        public virtual Endereco Endereco2 { get; set; }
        public virtual NaturezaMovimento NaturezaMovimento1 { get; set; }
        public virtual Notas Notas { get; set; }
        public virtual Funcionario Funcionario { get; set; }
        public virtual Pessoa Pessoa2 { get; set; }
        public virtual Pessoa Pessoa3 { get; set; }
        public virtual Reclamacao Reclamacao { get; set; }
        public virtual TipoPagamento TipoPagamento { get; set; }
    }
}
