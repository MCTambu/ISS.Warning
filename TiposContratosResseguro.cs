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
    
    public partial class TiposContratosResseguro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TiposContratosResseguro()
        {
            this.TiposContratosResseguroInformacoesTiposContratosResseguro = new HashSet<TiposContratosResseguroInformacoesTiposContratosResseguro>();
        }
    
        public string IdTiposContratosResseguro { get; set; }
        public string Designacao { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string CodTiposContratosResseguro { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TiposContratosResseguroInformacoesTiposContratosResseguro> TiposContratosResseguroInformacoesTiposContratosResseguro { get; set; }
    }
}
