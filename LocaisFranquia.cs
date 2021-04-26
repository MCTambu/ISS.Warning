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
    
    public partial class LocaisFranquia
    {
        public string IdLocaisFranquia { get; set; }
        public string RegiaoID { get; set; }
        public string PaisID { get; set; }
        public string ProvinciaID { get; set; }
        public string MunicipioID { get; set; }
        public string DistritoID { get; set; }
        public string NivelAbrangenciaID { get; set; }
        public string FranquiaID { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoID { get; set; }
    
        public virtual Distrito Distrito { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Franquia Franquia { get; set; }
        public virtual Municipio Municipio { get; set; }
        public virtual NivelAbrangencia NivelAbrangencia { get; set; }
        public virtual Pais Pais { get; set; }
        public virtual Provincia Provincia { get; set; }
        public virtual Regiao Regiao { get; set; }
    }
}
