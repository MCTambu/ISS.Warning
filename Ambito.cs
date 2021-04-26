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
    
    public partial class Ambito
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ambito()
        {
            this.SubPontoAmbito = new HashSet<SubPontoAmbito>();
        }
    
        public string IdAmbito { get; set; }
        public string Designacao { get; set; }
        public string CodAmbito { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoId { get; set; }
        public Nullable<int> NumOrdem { get; set; }
        public string PlanoProdutoId { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual PlanoProduto PlanoProduto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubPontoAmbito> SubPontoAmbito { get; set; }
    }
}
