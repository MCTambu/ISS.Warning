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
    
    public partial class LesaoLesado
    {
        public string IdLesaoLesado { get; set; }
        public string DescricaoLesao { get; set; }
        public string IncapacidadetemporariaID { get; set; }
        public string LesadoID { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoID { get; set; }
        public string UltModificacaoPorID { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual IncapacidadeTemporaria IncapacidadeTemporaria { get; set; }
        public virtual Lesado Lesado { get; set; }
    }
}
