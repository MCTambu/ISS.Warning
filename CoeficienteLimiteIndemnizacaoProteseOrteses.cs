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
    
    public partial class CoeficienteLimiteIndemnizacaoProteseOrteses
    {
        public string IdCoeficienteLimiteIndemnizacaoProteseOrteses { get; set; }
        public Nullable<double> Valor { get; set; }
        public Nullable<double> AgravamentoOuDesconto { get; set; }
        public string CodCoeficienteLimiteIndemnizacaoOrteses { get; set; }
        public Nullable<System.DateTime> DataActualizacao { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public string EstadoId { get; set; }
        public string TipoOrtesesProteses { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual TipoOrtesesProteses TipoOrtesesProteses1 { get; set; }
    }
}