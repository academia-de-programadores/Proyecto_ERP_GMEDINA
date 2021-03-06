
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbTipoEntrada
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbTipoEntrada()
        {
            this.tbEntrada = new HashSet<tbEntrada>();
        }
    
        public byte tent_Id { get; set; }
        public string tent_Descripcion { get; set; }
        public int tent_UsuarioCrea { get; set; }
        public System.DateTime tent_FechaCrea { get; set; }
        public Nullable<int> tent_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> tent_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEntrada> tbEntrada { get; set; }
    }
}
