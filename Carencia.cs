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
    
    public partial class Carencia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Carencia()
        {
            this.ModalidadeAssegurar = new HashSet<ModalidadeAssegurar>();
        }
    
        public string IdCarencia { get; set; }
        public Nullable<int> NumDias { get; set; }
        public Nullable<double> Taxa { get; set; }
        public string Designacao { get; set; }
        public string PlanoId { get; set; }
    
        public virtual PlanoProduto PlanoProduto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ModalidadeAssegurar> ModalidadeAssegurar { get; set; }
    }
}