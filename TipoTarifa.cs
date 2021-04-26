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
    
    public partial class TipoTarifa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoTarifa()
        {
            this.Tarifa = new HashSet<Tarifa>();
            this.TipoTarifaPlanoProduto = new HashSet<TipoTarifaPlanoProduto>();
        }
    
        public string IdTipoTarifa { get; set; }
        public string Designacao { get; set; }
        public string CodTipoTarifa { get; set; }
        public string EstadoId { get; set; }
        public string DataCriacao { get; set; }
        public string DataActualizacao { get; set; }
        public string PrecarioProdutoId { get; set; }
        public string ClassificacaoAutomovelID { get; set; }
    
        public virtual ClassificacaoAutomovel ClassificacaoAutomovel { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual PrecarioProduto PrecarioProduto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tarifa> Tarifa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoTarifaPlanoProduto> TipoTarifaPlanoProduto { get; set; }
    }
}