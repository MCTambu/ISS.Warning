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
    
    public partial class Processo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Processo()
        {
            this.ProcessoFuncionalidade = new HashSet<ProcessoFuncionalidade>();
            this.ProcessosDireccao = new HashSet<ProcessosDireccao>();
            this.ProcessosDepartamento = new HashSet<ProcessosDepartamento>();
            this.ProcessosSector = new HashSet<ProcessosSector>();
            this.ProcessosSeccao = new HashSet<ProcessosSeccao>();
            this.ProcessosPerfil = new HashSet<ProcessosPerfil>();
            this.RiscosProcesso = new HashSet<RiscosProcesso>();
        }
    
        public string IdProcesso { get; set; }
        public string Designacao { get; set; }
        public string CodProcesso { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoId { get; set; }
        public string TipoProcessoId { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual TipoProcesso TipoProcesso { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcessoFuncionalidade> ProcessoFuncionalidade { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcessosDireccao> ProcessosDireccao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcessosDepartamento> ProcessosDepartamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcessosSector> ProcessosSector { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcessosSeccao> ProcessosSeccao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcessosPerfil> ProcessosPerfil { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RiscosProcesso> RiscosProcesso { get; set; }
    }
}
