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
    
    public partial class MetricasProduto
    {
        public string IdMetricasProduto { get; set; }
        public string MetricaKpiID { get; set; }
        public string ProdutoID { get; set; }
        public string CodMetricasProduto { get; set; }
    
        public virtual MetricaKPI MetricaKPI { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
