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
    
    public partial class Pneu
    {
        public string IdPneu { get; set; }
        public string TipoConstrucaoPneusID { get; set; }
        public string IndiceVelocidadePneuID { get; set; }
        public string IndiceCargaPneuID { get; set; }
        public string LocalizacaoPneuID { get; set; }
        public string AutomovelId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoID { get; set; }
        public string UltModificacaoPorID { get; set; }
    
        public virtual Automovel Automovel { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual IndiceCargaPneu IndiceCargaPneu { get; set; }
        public virtual IndiceVelocidadePneu IndiceVelocidadePneu { get; set; }
        public virtual LocalizacaoPneu LocalizacaoPneu { get; set; }
        public virtual TipoConstrucaoPneus TipoConstrucaoPneus { get; set; }
    }
}
