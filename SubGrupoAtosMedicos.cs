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
    
    public partial class SubGrupoAtosMedicos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SubGrupoAtosMedicos()
        {
            this.AtosMedicos = new HashSet<AtosMedicos>();
        }
    
        public string IdSubGrupoAtosMedicos { get; set; }
        public string Designacao { get; set; }
        public string GrupoAtosMedicosId { get; set; }
        public string EstadoId { get; set; }
        public string CodSubGrupoAtosMedicos { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AtosMedicos> AtosMedicos { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual GrupoAtosMedicos GrupoAtosMedicos { get; set; }
    }
}
