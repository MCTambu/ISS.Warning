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
    
    public partial class PapelModuloPessoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PapelModuloPessoa()
        {
            this.PapelModuloFuncionalidade = new HashSet<PapelModuloFuncionalidade>();
        }
    
        public string IdPapelModuloPessoa { get; set; }
        public string ModuloCoreId { get; set; }
        public string CodPapelModuloPessoa { get; set; }
        public string PapelPessoaId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoId { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual ModuloCore ModuloCore { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PapelModuloFuncionalidade> PapelModuloFuncionalidade { get; set; }
        public virtual PapelPessoa PapelPessoa { get; set; }
    }
}
