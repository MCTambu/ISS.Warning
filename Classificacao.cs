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
    
    public partial class Classificacao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Classificacao()
        {
            this.CaracteristicaClassificacao = new HashSet<CaracteristicaClassificacao>();
            this.ComponenteClassificacao = new HashSet<ComponenteClassificacao>();
            this.ComponenteClassificacao1 = new HashSet<ComponenteClassificacao>();
            this.ObjectoSegurado = new HashSet<ObjectoSegurado>();
            this.Classificacao11 = new HashSet<Classificacao>();
        }
    
        public string IdClassificacao { get; set; }
        public string Classificacao1 { get; set; }
        public string Descricao { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoId { get; set; }
        public string CodClassificacao { get; set; }
        public string TipoClassificaocao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CaracteristicaClassificacao> CaracteristicaClassificacao { get; set; }
        public virtual Estado Estado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComponenteClassificacao> ComponenteClassificacao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComponenteClassificacao> ComponenteClassificacao1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ObjectoSegurado> ObjectoSegurado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Classificacao> Classificacao11 { get; set; }
        public virtual Classificacao Classificacao2 { get; set; }
    }
}