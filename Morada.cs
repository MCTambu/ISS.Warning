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
    
    public partial class Morada
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Morada()
        {
            this.GeoLocalizacaoTransacao = new HashSet<GeoLocalizacaoTransacao>();
        }
    
        public string IdMorada { get; set; }
        public string CodMorada { get; set; }
        public string NumCasa { get; set; }
        public string CaixaPostal { get; set; }
        public string NumAndar { get; set; }
        public Nullable<double> Latitude { get; set; }
        public string PontoReferencia { get; set; }
        public string EnderecoId { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoId { get; set; }
        public Nullable<int> NumPorta { get; set; }
    
        public virtual Endereco Endereco { get; set; }
        public virtual Estado Estado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GeoLocalizacaoTransacao> GeoLocalizacaoTransacao { get; set; }
    }
}