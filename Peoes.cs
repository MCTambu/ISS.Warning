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
    
    public partial class Peoes
    {
        public string IdPeoes { get; set; }
        public string PessoaId { get; set; }
        public string Deficiencias { get; set; }
        public string EstadoFisiologicoId { get; set; }
        public string DinamicaAntesAcidenteId { get; set; }
        public string SinistroId { get; set; }
        public string DanosCorporais { get; set; }
        public string Descricao { get; set; }
        public Nullable<double> Peso { get; set; }
        public Nullable<double> Altura { get; set; }
        public string CodPeoes { get; set; }
        public string EstadoId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
    
        public virtual Dinamica Dinamica { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual EstadoFisiologico EstadoFisiologico { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual Sinistro Sinistro { get; set; }
    }
}
