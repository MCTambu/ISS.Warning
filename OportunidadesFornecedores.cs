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
    
    public partial class OportunidadesFornecedores
    {
        public string IdOportunidadesFornecedores { get; set; }
        public string OportunidadeProjectoId { get; set; }
        public string FornecedoresID { get; set; }
        public string CodOportunidadesFornecedores { get; set; }
        public string Estadoid { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual Fornecedores Fornecedores { get; set; }
        public virtual OportunidadeProjecto OportunidadeProjecto { get; set; }
    }
}