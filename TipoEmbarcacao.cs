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
    
    public partial class TipoEmbarcacao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoEmbarcacao()
        {
            this.Embarcacao = new HashSet<Embarcacao>();
        }
    
        public string IdTipoEmbarcacao { get; set; }
        public string CodTipoEmbarcacao { get; set; }
        public string Designacao { get; set; }
        public string Criterio { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataActualizacao { get; set; }
        public string EstadoId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Embarcacao> Embarcacao { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
