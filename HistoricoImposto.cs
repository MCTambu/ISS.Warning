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
    
    public partial class HistoricoImposto
    {
        public string IdHistoricoImposto { get; set; }
        public string IdImposto { get; set; }
        public Nullable<double> TaxaImposto { get; set; }
        public string TipoImpostoID { get; set; }
        public string EstadoId { get; set; }
        public string PlanoProdutoID { get; set; }
        public string CodImposto { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public Nullable<bool> IsIndirecto { get; set; }
        public Nullable<bool> IsTaxa { get; set; }
        public string UltModificacaoPorID { get; set; }
        public string PrecarioProdutoID { get; set; }
    }
}
