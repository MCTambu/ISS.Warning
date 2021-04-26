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
    
    public partial class CaracteristicaAtutomovel
    {
        public string IdCaracteristicaAtutomovel { get; set; }
        public Nullable<double> Altura { get; set; }
        public Nullable<double> Comprimento { get; set; }
        public string CodCaracteristicaAtutomovel { get; set; }
        public Nullable<double> CaacidadeMaxMovimento { get; set; }
        public Nullable<int> NumJanelasElectrica { get; set; }
        public Nullable<double> PesoBruto { get; set; }
        public Nullable<double> PesoBrutoReboque { get; set; }
        public Nullable<int> NumLugares { get; set; }
        public string AutomovelId { get; set; }
        public Nullable<double> Tara { get; set; }
        public Nullable<double> Potencia { get; set; }
        public Nullable<int> NumAirBags { get; set; }
        public Nullable<bool> ComputadorInstalado { get; set; }
        public Nullable<bool> SistemaAquecimentoAuxiliar { get; set; }
        public string TipoGaragemId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string TipoOucupanteId { get; set; }
        public string Versao { get; set; }
        public string ValorAltifalante { get; set; }
        public string ValorBancosPele { get; set; }
        public string ValorRadio { get; set; }
        public string ValorRadioEmCD { get; set; }
        public string ValorJantesLigaLeve { get; set; }
    
        public virtual Automovel Automovel { get; set; }
        public virtual TipoGaragem TipoGaragem { get; set; }
        public virtual TipoOucupantes TipoOucupantes { get; set; }
    }
}
