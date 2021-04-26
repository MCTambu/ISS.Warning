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
    
    public partial class MetricaKPI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MetricaKPI()
        {
            this.MetricasProduto = new HashSet<MetricasProduto>();
        }
    
        public string IdMetricaKPI { get; set; }
        public string PCFID { get; set; }
        public string HierarquiaID { get; set; }
        public string Nome { get; set; }
        public string IndiceDiferenca { get; set; }
        public string DetalheMudanca { get; set; }
        public string MetricaDisponivel { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoId { get; set; }
        public string CategoriaMetricaKPID { get; set; }
    
        public virtual CategoriaMetricaKPI CategoriaMetricaKPI { get; set; }
        public virtual Estado Estado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MetricasProduto> MetricasProduto { get; set; }
    }
}
