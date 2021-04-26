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
    
    public partial class DespesaSeleccionada
    {
        public string IdDespesaSeleccionada { get; set; }
        public Nullable<double> Valor { get; set; }
        public string CotacaoID { get; set; }
        public string PessoaId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string ApoliceID { get; set; }
        public string EstadoID { get; set; }
        public string DespesaID { get; set; }
        public string CodDespesaSeleccionada { get; set; }
    
        public virtual Apolice Apolice { get; set; }
        public virtual Cotacao Cotacao { get; set; }
        public virtual Despesa Despesa { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
