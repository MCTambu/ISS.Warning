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
    
    public partial class CanalPerfilModulo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CanalPerfilModulo()
        {
            this.ModuloFuncionalidade = new HashSet<ModuloFuncionalidade>();
        }
    
        public string IdCanalPerfilModulo { get; set; }
        public string CanalPerfilId { get; set; }
        public string ModuloId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
    
        public virtual CanalPerfil CanalPerfil { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ModuloFuncionalidade> ModuloFuncionalidade { get; set; }
        public virtual Modulo Modulo { get; set; }
    }
}
