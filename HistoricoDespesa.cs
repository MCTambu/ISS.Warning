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
    
    public partial class HistoricoDespesa
    {
        public string IdHistoricoDespesa { get; set; }
        public string IdDespesa { get; set; }
        public Nullable<double> ValorMin { get; set; }
        public string TipoDespesaID { get; set; }
        public string PlanoProdutoID { get; set; }
        public string CodDespesa { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public Nullable<double> ValorMax { get; set; }
        public string EstadoID { get; set; }
        public string UltModificacaoPorID { get; set; }
        public string PrecarioProdutoID { get; set; }
        public Nullable<bool> IsTaxa { get; set; }
    }
}
