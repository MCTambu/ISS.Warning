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
    
    public partial class Newsletter
    {
        public string IdNewsletter { get; set; }
        public string NomeCompleto { get; set; }
        public string EnderecoID { get; set; }
        public string ContactoID { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoID { get; set; }
        public string UltModificacaoPorID { get; set; }
    
        public virtual Contacto Contacto { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
