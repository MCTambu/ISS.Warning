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
    
    public partial class ClassificacaoTipoCaso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClassificacaoTipoCaso()
        {
            this.CasoClassificacao = new HashSet<CasoClassificacao>();
            this.Denuncias = new HashSet<Denuncias>();
            this.Sugestoes = new HashSet<Sugestoes>();
        }
    
        public string IdClassificacaoTipoCaso { get; set; }
        public string Designacao { get; set; }
        public string CodClassificacaoTipoCaso { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public string TipoCasoId { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CasoClassificacao> CasoClassificacao { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual TipoCaso TipoCaso { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Denuncias> Denuncias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sugestoes> Sugestoes { get; set; }
    }
}