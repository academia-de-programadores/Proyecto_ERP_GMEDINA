
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbActividadEconomica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbActividadEconomica()
        {
            this.tbProveedor = new HashSet<tbProveedor>();
        }
    
        public short acte_Id { get; set; }
        public string acte_Descripcion { get; set; }
        public int acte_UsuarioCrea { get; set; }
        public System.DateTime acte_FechaCrea { get; set; }
        public Nullable<int> acte_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> acte_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbProveedor> tbProveedor { get; set; }
    }
}
