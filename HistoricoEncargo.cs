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
    
    public partial class HistoricoEncargo
    {
        public string IdHistoricoEncargo { get; set; }
        public string IdEncargo { get; set; }
        public Nullable<double> TaxaMinEncargo { get; set; }
        public string TipoEncargoID { get; set; }
        public string EstadoId { get; set; }
        public string PlanoProdutoID { get; set; }
        public string CodEncargo { get; set; }
        public Nullable<double> ValorMinPremioSimples { get; set; }
        public Nullable<double> ValorMaxPremioSimples { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public Nullable<double> TaxaMaxEncargo { get; set; }
        public Nullable<double> ValorMinEncargo { get; set; }
        public Nullable<double> ValorMaxEncargo { get; set; }
        public Nullable<bool> IsTaxa { get; set; }
        public string UltModificacaoPorID { get; set; }
        public string PrecarioProdutoID { get; set; }
    }
}