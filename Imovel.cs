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
    
    public partial class Imovel
    {
        public string IdImovel { get; set; }
        public string EnderecoId { get; set; }
        public string LocalizacaoHabitacaoId { get; set; }
        public Nullable<int> AnoConstrucao { get; set; }
        public Nullable<bool> IsSismica { get; set; }
        public string EstadoConservacaoId { get; set; }
        public string TipoHabitacaoId { get; set; }
        public string TipoAndar { get; set; }
        public string AreaMetrosQuadrado { get; set; }
        public string DependenciaId { get; set; }
        public string TipoConstrucaoExteriorId { get; set; }
        public string TipoCoberturaExteriorId { get; set; }
        public string EstadoConservacaoResidenciaId { get; set; }
        public string PrevencaoId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoId { get; set; }
        public string ProprietarioId { get; set; }
        public string Numero { get; set; }
    
        public virtual Dependencia Dependencia { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual EstadoConservacao EstadoConservacao { get; set; }
        public virtual EstadoConservacao EstadoConservacao1 { get; set; }
        public virtual LocalizacaoHabitacao LocalizacaoHabitacao { get; set; }
        public virtual Prevencao Prevencao { get; set; }
        public virtual TipoAndar TipoAndar1 { get; set; }
        public virtual TipoConstrucaoExterior TipoConstrucaoExterior { get; set; }
        public virtual TipoCoberturaExterior TipoCoberturaExterior { get; set; }
        public virtual TipoHabitacao TipoHabitacao { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual Pessoa Pessoa1 { get; set; }
    }
}
