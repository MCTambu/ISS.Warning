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
    
    public partial class DadosPessoaisTratadosTratamentoDados
    {
        public string IdDadosPessoaisTratadosTratamentoDados { get; set; }
        public string TratamentoDadosId { get; set; }
        public string DadosPessoaisTratadosId { get; set; }
        public string CodDadosPessoaisTratadosTratamentoDados { get; set; }
        public string EstadoId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
    
        public virtual DadosPessoaisTratados DadosPessoaisTratados { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual TratamentoDados TratamentoDados { get; set; }
    }
}