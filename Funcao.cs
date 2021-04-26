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
    
    public partial class Funcao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Funcao()
        {
            this.Actividade = new HashSet<Actividade>();
            this.EstatutoOrganicoDepartamento = new HashSet<EstatutoOrganicoDepartamento>();
            this.EstatutoOrganicoDireccao = new HashSet<EstatutoOrganicoDireccao>();
            this.EstatutoOrganicoSeccao = new HashSet<EstatutoOrganicoSeccao>();
            this.EstatutoOrganicoSector = new HashSet<EstatutoOrganicoSector>();
            this.FuncaoDependente = new HashSet<FuncaoDependente>();
            this.FuncaoDependente1 = new HashSet<FuncaoDependente>();
            this.Funcionario = new HashSet<Funcionario>();
            this.LimiteCompetencia = new HashSet<LimiteCompetencia>();
            this.OperacoesCRUDPessoa = new HashSet<OperacoesCRUDPessoa>();
            this.PessoaProfissao = new HashSet<PessoaProfissao>();
            this.Posicao = new HashSet<Posicao>();
            this.Seccao = new HashSet<Seccao>();
        }
    
        public string IdFuncao { get; set; }
        public string Designacao { get; set; }
        public string CodFuncao { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string NivelAcessoID { get; set; }
        public string EstadoID { get; set; }
        public string UltModificacaoPorID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Actividade> Actividade { get; set; }
        public virtual Estado Estado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EstatutoOrganicoDepartamento> EstatutoOrganicoDepartamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EstatutoOrganicoDireccao> EstatutoOrganicoDireccao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EstatutoOrganicoSeccao> EstatutoOrganicoSeccao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EstatutoOrganicoSector> EstatutoOrganicoSector { get; set; }
        public virtual NivelAcesso NivelAcesso { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FuncaoDependente> FuncaoDependente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FuncaoDependente> FuncaoDependente1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Funcionario> Funcionario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LimiteCompetencia> LimiteCompetencia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperacoesCRUDPessoa> OperacoesCRUDPessoa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PessoaProfissao> PessoaProfissao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Posicao> Posicao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Seccao> Seccao { get; set; }
    }
}
