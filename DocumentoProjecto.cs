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
    
    public partial class DocumentoProjecto
    {
        public string IdDocumentoProjecto { get; set; }
        public string CodDocumentoProjecto { get; set; }
        public string DocumentoId { get; set; }
        public string ProjectoId { get; set; }
        public string EstadoId { get; set; }
        public Nullable<System.DateTime> DateCriacao { get; set; }
        public Nullable<System.DateTime> DateAtualizacao { get; set; }
    
        public virtual Documentos Documentos { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Projecto Projecto { get; set; }
    }
}
