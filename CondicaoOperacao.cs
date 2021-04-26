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
    
    public partial class CondicaoOperacao
    {
        public string IdCondicaoOperacao { get; set; }
        public string Designacao { get; set; }
        public string OperacaoId { get; set; }
        public string CodCondicaoOperacao { get; set; }
        public string NivelAbrangenciaId { get; set; }
        public Nullable<double> ValorMaxPremioSimples { get; set; }
        public Nullable<double> ValorMinPremioSimples { get; set; }
        public Nullable<double> Taxa { get; set; }
        public Nullable<int> NumDias { get; set; }
        public string PapelId { get; set; }
        public Nullable<double> LimiteMax { get; set; }
        public Nullable<double> LimiteMin { get; set; }
        public Nullable<int> NumDiasMax { get; set; }
        public Nullable<int> NumDiasMin { get; set; }
        public string LocalAplicacaoId { get; set; }
        public string CanalId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataActualizacao { get; set; }
        public string EstadoId { get; set; }
    
        public virtual Canal Canal { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual NivelAbrangencia NivelAbrangencia { get; set; }
        public virtual Operacao Operacao { get; set; }
        public virtual Papel Papel { get; set; }
    }
}
