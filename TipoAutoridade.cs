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
    
    public partial class TipoAutoridade
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoAutoridade()
        {
            this.PostosAutoridade = new HashSet<PostosAutoridade>();
            this.RelatorioPolicia = new HashSet<RelatorioPolicia>();
        }
    
        public string IdTipo { get; set; }
        public string Designacao { get; set; }
        public string CodTipoAutoridade { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoID { get; set; }
        public string CaminhoIcone { get; set; }
    
        public virtual Estado Estado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PostosAutoridade> PostosAutoridade { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RelatorioPolicia> RelatorioPolicia { get; set; }
    }
}
