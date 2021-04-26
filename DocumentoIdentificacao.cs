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
    
    public partial class DocumentoIdentificacao
    {
        public string IdDocumentoIdentificacao { get; set; }
        public string NumeroDoc { get; set; }
        public Nullable<System.DateTime> DataEmissao { get; set; }
        public Nullable<System.DateTime> DataValidade { get; set; }
        public string CaminhoFicheiro { get; set; }
        public string TipoDocumentacaoIdentificacaoID { get; set; }
        public string EstadoID { get; set; }
        public Nullable<bool> Principal { get; set; }
        public string PessoaId { get; set; }
        public string CodDocumentoIdentificacao { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EntidadeEmissoraID { get; set; }
        public string UltModificacaoPorID { get; set; }
        public Nullable<bool> Eobrigatorio { get; set; }
        public string AreDestinoId { get; set; }
    
        public virtual Area Area { get; set; }
        public virtual EmissoraDocumentos EmissoraDocumentos { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual TipoDocumentoIdentificacao TipoDocumentoIdentificacao { get; set; }
    }
}