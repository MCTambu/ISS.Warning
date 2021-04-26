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
    
    public partial class TarefaRecorrente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TarefaRecorrente()
        {
            this.TipoTarefa = new HashSet<TipoTarefa>();
        }
    
        public string IdTarefaRecorrente { get; set; }
        public string Descricao { get; set; }
        public Nullable<System.DateTime> DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public string EstadoId { get; set; }
        public string PadraoRecorrenciaId { get; set; }
        public string TarefasAgendamentoID { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual PadraoRecorrencia PadraoRecorrencia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoTarefa> TipoTarefa { get; set; }
        public virtual TarefasAgendamento TarefasAgendamento { get; set; }
    }
}
