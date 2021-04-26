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
    
    public partial class Animais
    {
        public string IdAnimal { get; set; }
        public string Nome { get; set; }
        public Nullable<System.DateTime> DataCompra { get; set; }
        public Nullable<int> Idade { get; set; }
        public string Observacao { get; set; }
        public string Raca { get; set; }
        public string UnidadeTempoID { get; set; }
        public string ModalidadesRCSelecionadaID { get; set; }
        public string EspecieAnimalID { get; set; }
        public string CodAnimais { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoID { get; set; }
        public string UltModificacaoPorID { get; set; }
        public string PessoaID { get; set; }
    
        public virtual EspecieAnimais EspecieAnimais { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual ModalidadesRCSelecionadas ModalidadesRCSelecionadas { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual UnidadesTempo UnidadesTempo { get; set; }
    }
}