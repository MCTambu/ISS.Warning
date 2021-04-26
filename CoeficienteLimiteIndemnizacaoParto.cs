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
    
    public partial class CoeficienteLimiteIndemnizacaoParto
    {
        public string IdCoeficienteLimiteIndemnizacaoParto { get; set; }
        public Nullable<double> Valor { get; set; }
        public Nullable<double> AgravamentoOuDesconto { get; set; }
        public string CodCoeficienteLimiteIndemnizacaoParto { get; set; }
        public Nullable<System.DateTime> DataActualizacao { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public string EstadoId { get; set; }
        public string TipoPartoId { get; set; }
        public string DescontoId { get; set; }
        public string AgravamentoId { get; set; }
        public string CoberturaId { get; set; }
    
        public virtual Agravamento Agravamento { get; set; }
        public virtual Cobertura Cobertura { get; set; }
        public virtual Desconto Desconto { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual TipoParto TipoParto { get; set; }
    }
}
