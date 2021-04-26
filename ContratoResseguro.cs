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
    
    public partial class ContratoResseguro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContratoResseguro()
        {
            this.AssinantesResseguro = new HashSet<AssinantesResseguro>();
        }
    
        public string IdContratoResseguro { get; set; }
        public string ContratoId { get; set; }
        public string ResseguroId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public Nullable<double> Retencao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssinantesResseguro> AssinantesResseguro { get; set; }
        public virtual Contrato Contrato { get; set; }
        public virtual Resseguro Resseguro { get; set; }
    }
}