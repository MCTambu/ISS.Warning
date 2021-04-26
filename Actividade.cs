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
    
    public partial class Actividade
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Actividade()
        {
            this.ActividadeProgramas = new HashSet<ActividadeProgramas>();
            this.ActividadesAgenda = new HashSet<ActividadesAgenda>();
            this.ActividadeProjecto = new HashSet<ActividadeProjecto>();
            this.ActividadePlano = new HashSet<ActividadePlano>();
            this.ContratoPrestadorEmpresa = new HashSet<ContratoPrestadorEmpresa>();
            this.HorasActividades = new HashSet<HorasActividades>();
            this.TarefasActividade = new HashSet<TarefasActividade>();
        }
    
        public string IdActividade { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataInicio { get; set; }
        public Nullable<System.DateTime> DataFim { get; set; }
        public Nullable<int> Prazo { get; set; }
        public string Designacao { get; set; }
        public string PessoaResponsavelID { get; set; }
        public string BeneficiarioID { get; set; }
        public string DonoPedidoID { get; set; }
        public string EstadoID { get; set; }
        public string TipoActividadeID { get; set; }
        public string CodActividade { get; set; }
        public string FuncaoID { get; set; }
        public string CargoFuncionarioID { get; set; }
        public string UltModificacaoPorID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActividadeProgramas> ActividadeProgramas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActividadesAgenda> ActividadesAgenda { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActividadeProjecto> ActividadeProjecto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActividadePlano> ActividadePlano { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual Pessoa Pessoa1 { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Funcao Funcao { get; set; }
        public virtual Pessoa Pessoa2 { get; set; }
        public virtual TipoActividade TipoActividade { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContratoPrestadorEmpresa> ContratoPrestadorEmpresa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HorasActividades> HorasActividades { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TarefasActividade> TarefasActividade { get; set; }
    }
}