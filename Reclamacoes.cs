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
    
    public partial class Reclamacoes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reclamacoes()
        {
            this.ReclamacaoApolice = new HashSet<ReclamacaoApolice>();
            this.RelacaoReclamacoes = new HashSet<RelacaoReclamacoes>();
            this.RelacaoReclamacoes1 = new HashSet<RelacaoReclamacoes>();
            this.RelatanteReclamacao = new HashSet<RelatanteReclamacao>();
        }
    
        public string IdReclamacoes { get; set; }
        public string Assunto { get; set; }
        public string Descricao { get; set; }
        public string AgenciaId { get; set; }
        public string DepartamentoId { get; set; }
        public Nullable<System.DateTime> DataOcorrido { get; set; }
        public string CaminhoFicheiro { get; set; }
        public string GrauSatisfacaoId { get; set; }
        public string MotivoClassificacaoId { get; set; }
        public string EstadoId { get; set; }
        public string CodReclamacoes { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public Nullable<bool> IsAnonimo { get; set; }
        public string TipoReclamacaoId { get; set; }
    
        public virtual Agencia Agencia { get; set; }
        public virtual Departamento Departamento { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual GrauSatisfacao GrauSatisfacao { get; set; }
        public virtual MotivoClassificacao MotivoClassificacao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReclamacaoApolice> ReclamacaoApolice { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RelacaoReclamacoes> RelacaoReclamacoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RelacaoReclamacoes> RelacaoReclamacoes1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RelatanteReclamacao> RelatanteReclamacao { get; set; }
    }
}
