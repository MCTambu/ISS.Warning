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
    
    public partial class SubClasseModalidadeSeguro
    {
        public string IdSubClasseModalidadeSeguro { get; set; }
        public string CodSubClasseModalidadeSeguro { get; set; }
        public string Descricao { get; set; }
        public string ClasseModalidadeSeguroId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataActualizacao { get; set; }
        public string EstadoId { get; set; }
    
        public virtual ClasseModalidadeSeguro ClasseModalidadeSeguro { get; set; }
        public virtual Estado Estado { get; set; }
    }
}