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
    
    public partial class TarifasAutomovel
    {
        public string IdTarifa { get; set; }
        public Nullable<int> Valor { get; set; }
        public string AnosID { get; set; }
        public string MesesID { get; set; }
        public string ProdutoID { get; set; }
        public string SubContaID { get; set; }
        public string CodTarifasAutomovel { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string LinhaProdutoID { get; set; }
        public string EstadoID { get; set; }
        public string NaturezaMovimentoId { get; set; }
        public bool Contabiliza { get; set; }
        public string CodInformacoesAdicionaisProduto { get; set; }
    
        public virtual Anos Anos { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual LinhaProduto LinhaProduto { get; set; }
        public virtual Meses Meses { get; set; }
        public virtual NaturezaMovimento NaturezaMovimento { get; set; }
        public virtual PlanoContas PlanoContas { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
