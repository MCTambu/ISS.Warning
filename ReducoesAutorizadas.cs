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
    
    public partial class ReducoesAutorizadas
    {
        public string IdReducoesAutoridas { get; set; }
        public string CodReducoesAutoridas { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<double> TaxaTarifa { get; set; }
        public Nullable<double> TaxaReduzida { get; set; }
        public Nullable<System.DateTime> DataActualizacao { get; set; }
        public string LinhaProdutoId { get; set; }
        public string EstadoId { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual LinhaProduto LinhaProduto { get; set; }
    }
}
