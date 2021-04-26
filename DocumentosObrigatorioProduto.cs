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
    
    public partial class DocumentosObrigatorioProduto
    {
        public string IdDocumento { get; set; }
        public string TiposDocumentoProdutoID { get; set; }
        public string ProdutoID { get; set; }
        public string TipoCoberturaID { get; set; }
        public string FaseID { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string LinhaProdutoID { get; set; }
        public string EstadoID { get; set; }
        public string CodDocumentosObrigatorioProduto { get; set; }
        public string CaminhoFicheiro { get; set; }
        public string Designacao { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual FaseDocumentosObrigatorio FaseDocumentosObrigatorio { get; set; }
        public virtual LinhaProduto LinhaProduto { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual TipoCobertura TipoCobertura { get; set; }
        public virtual TiposDocumentoProduto TiposDocumentoProduto { get; set; }
    }
}
