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
    
    public partial class TabuaAngv2020P
    {
        public string IdTabua { get; set; }
        public Nullable<byte> Idade { get; set; }
        public Nullable<double> M_x { get; set; }
        public Nullable<double> Q_x { get; set; }
        public Nullable<double> D_x { get; set; }
        public Nullable<double> P_x { get; set; }
        public Nullable<double> I_x { get; set; }
        public Nullable<double> L_x { get; set; }
        public Nullable<double> T_x { get; set; }
        public Nullable<double> E_x { get; set; }
        public Nullable<double> U_x { get; set; }
        public string CodTabuaAngv2020P { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoID { get; set; }
    
        public virtual Estado Estado { get; set; }
    }
}
