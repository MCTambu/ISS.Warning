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
    
    public partial class ComponenteSalarialPessoa
    {
        public string IdComponenteSalarialPessoa { get; set; }
        public Nullable<double> ValorSubsidio { get; set; }
        public string TipoSubsidioSalarialID { get; set; }
        public string EstadoID { get; set; }
        public string IdSalarioPessoa { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual RendimentoPessoa RendimentoPessoa { get; set; }
        public virtual TipoSubsidioSalarial TipoSubsidioSalarial { get; set; }
    }
}
