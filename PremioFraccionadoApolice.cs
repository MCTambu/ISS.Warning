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
    
    public partial class PremioFraccionadoApolice
    {
        public string IdPremioFraccionadoApolice { get; set; }
        public string ApoliceId { get; set; }
        public string DescricaoPrestacao { get; set; }
        public Nullable<double> ValorDescricaoPrestacao { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public Nullable<bool> IsPago { get; set; }
        public string CotacaoId { get; set; }
        public string ReciboId { get; set; }
        public Nullable<double> IVA { get; set; }
        public Nullable<double> ARSEG { get; set; }
        public Nullable<double> PremioSimples { get; set; }
        public Nullable<double> EncargosAdministrativos { get; set; }
        public Nullable<double> JurosFraccionamento { get; set; }
        public Nullable<double> PremioComercial { get; set; }
        public Nullable<double> Comissoes { get; set; }
        public Nullable<double> PremioTotal { get; set; }
        public Nullable<double> CapitalSeguro { get; set; }
        public Nullable<double> PremioCobrado { get; set; }
        public Nullable<double> PremioRisco { get; set; }
        public Nullable<double> Impostos { get; set; }
        public Nullable<double> Despesas { get; set; }
        public Nullable<double> FGA { get; set; }
        public Nullable<double> Descontos { get; set; }
        public Nullable<double> Encargos { get; set; }
        public string NumeroLote { get; set; }
        public Nullable<double> PercentagemPaga { get; set; }
        public Nullable<System.DateTime> DataPagamentoParecela { get; set; }
    
        public virtual Apolice Apolice { get; set; }
        public virtual Cotacao Cotacao { get; set; }
        public virtual Recibo Recibo { get; set; }
    }
}