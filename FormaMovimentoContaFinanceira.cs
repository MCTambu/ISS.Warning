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
    
    public partial class FormaMovimentoContaFinanceira
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FormaMovimentoContaFinanceira()
        {
            this.ContaFinanceira = new HashSet<ContaFinanceira>();
            this.ContaFinanceira1 = new HashSet<ContaFinanceira>();
        }
    
        public string IdFormaMovimentoContaFinanceira { get; set; }
        public string CodFormaMovimentoContaFinanceira { get; set; }
        public string Familia { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataActualizacao { get; set; }
        public string EstadoId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContaFinanceira> ContaFinanceira { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContaFinanceira> ContaFinanceira1 { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
