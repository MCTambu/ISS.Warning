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
    
    public partial class ComunicacaoDadosTerceiros
    {
        public string IdComunicacaoDadosTerceiros { get; set; }
        public string EntidadeId { get; set; }
        public string TratamentoDadosId { get; set; }
        public string CondicoesComunicacaoId { get; set; }
        public string DadosTransferidosId { get; set; }
        public string CodComunicacaoDadosTerceiros { get; set; }
        public string EstadoId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
    
        public virtual CondicoesComunicacao CondicoesComunicacao { get; set; }
        public virtual DadosTransferidos DadosTransferidos { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual TratamentoDados TratamentoDados { get; set; }
    }
}