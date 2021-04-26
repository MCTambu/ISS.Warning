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
    
    public partial class ObjectivosSector
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ObjectivosSector()
        {
            this.ObjectivosSeccao = new HashSet<ObjectivosSeccao>();
        }
    
        public string IdObjectivosSector { get; set; }
        public string SectorId { get; set; }
        public string EstadoId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string ObjectivosDepartamentoId { get; set; }
        public Nullable<double> Ponderacao { get; set; }
        public string PlanoObjectivoComercialId { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual ObjectivosDepartamento ObjectivosDepartamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ObjectivosSeccao> ObjectivosSeccao { get; set; }
        public virtual PlanoObjectivoComercial PlanoObjectivoComercial { get; set; }
        public virtual Sector Sector { get; set; }
    }
}
