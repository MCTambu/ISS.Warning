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
    
    public partial class InformacaoBancariaContrato
    {
        public string IdInformacaoBancariaContrato { get; set; }
        public string InformacaoBancariaId { get; set; }
        public string ContratoId { get; set; }
        public string CodInformacaoBancariaContrato { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
    
        public virtual Contrato Contrato { get; set; }
        public virtual InformacaoBancaria InformacaoBancaria { get; set; }
    }
}
