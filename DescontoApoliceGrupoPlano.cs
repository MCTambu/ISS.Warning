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
    
    public partial class DescontoApoliceGrupoPlano
    {
        public string IdDescontoApoliceGrupoPlano { get; set; }
        public string CodDescontoApoliceGrupoPlano { get; set; }
        public string PlanoProdutoId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoId { get; set; }
        public string DescontoApoliceGrupoId { get; set; }
    
        public virtual DescontoApoliceGrupo DescontoApoliceGrupo { get; set; }
        public virtual PlanoProduto PlanoProduto { get; set; }
    }
}
