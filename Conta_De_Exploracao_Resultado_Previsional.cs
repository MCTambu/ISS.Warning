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
    
    public partial class Conta_De_Exploracao_Resultado_Previsional
    {
        public string Entidade { get; set; }
        public string IdSubClasse { get; set; }
        public string Rubrica { get; set; }
        public Nullable<System.DateTime> DataHoraMovimento { get; set; }
        public Nullable<double> Valor { get; set; }
        public Nullable<double> ValorOutraMoeda { get; set; }
        public string SimboloMoeda { get; set; }
        public string Moeda { get; set; }
        public Nullable<double> TotalComissao { get; set; }
        public Nullable<double> TotalProvisao { get; set; }
        public Nullable<double> ValorTotalApolice { get; set; }
        public Nullable<double> ImpostosTaxa { get; set; }
        public Nullable<double> EncargosAdministrativos { get; set; }
    }
}
