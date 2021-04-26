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
    
    public partial class Cor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cor()
        {
            this.Automovel = new HashSet<Automovel>();
            this.CategoriaTarefa = new HashSet<CategoriaTarefa>();
            this.Automovel_Teste = new HashSet<Automovel_Teste>();
            this.DestaquesPagina = new HashSet<DestaquesPagina>();
            this.DestaquesPagina1 = new HashSet<DestaquesPagina>();
            this.TipoRedeSociais = new HashSet<TipoRedeSociais>();
        }
    
        public string IdCor { get; set; }
        public string Nome { get; set; }
        public string TripletoHex { get; set; }
        public Nullable<int> R { get; set; }
        public Nullable<int> G { get; set; }
        public Nullable<int> B { get; set; }
        public string H { get; set; }
        public string S { get; set; }
        public string V { get; set; }
        public string NomeWeb { get; set; }
        public string CodCor { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoID { get; set; }
        public string UltModificacaoPorID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Automovel> Automovel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CategoriaTarefa> CategoriaTarefa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Automovel_Teste> Automovel_Teste { get; set; }
        public virtual Estado Estado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DestaquesPagina> DestaquesPagina { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DestaquesPagina> DestaquesPagina1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoRedeSociais> TipoRedeSociais { get; set; }
    }
}
