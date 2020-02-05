
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbRazonSalidas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbRazonSalidas()
        {
            this.tbHistorialSalidas = new HashSet<tbHistorialSalidas>();
        }
    
        public int rsal_Id { get; set; }
        public string rsal_Descripcion { get; set; }
        public bool rsal_Estado { get; set; }
        public string rsal_RazonInactivo { get; set; }
        public int rsal_UsuarioCrea { get; set; }
        public System.DateTime rsal_FechaCrea { get; set; }
        public Nullable<int> rsal_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> rsal_FechaModifica { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHistorialSalidas> tbHistorialSalidas { get; set; }
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
    }
}
