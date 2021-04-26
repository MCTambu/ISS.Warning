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
    
    public partial class TipoDocumentoIdentificacao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoDocumentoIdentificacao()
        {
            this.DocumentoIdentificacao = new HashSet<DocumentoIdentificacao>();
            this.DocumentoMembroAssegurado = new HashSet<DocumentoMembroAssegurado>();
            this.TipoDocumentoIdentificacao1 = new HashSet<TipoDocumentoIdentificacao>();
        }
    
        public string IdTipoDocumento { get; set; }
        public string Designacao { get; set; }
        public string CodTipoDocumentoIdentificacao { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoID { get; set; }
        public string CaminhoIcone { get; set; }
        public string TipoPessoaId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentoIdentificacao> DocumentoIdentificacao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentoMembroAssegurado> DocumentoMembroAssegurado { get; set; }
        public virtual Estado Estado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoDocumentoIdentificacao> TipoDocumentoIdentificacao1 { get; set; }
        public virtual TipoDocumentoIdentificacao TipoDocumentoIdentificacao2 { get; set; }
    }
}