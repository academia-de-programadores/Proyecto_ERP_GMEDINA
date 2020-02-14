
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbBanco
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbBanco()
        {
            this.tbCuentasBanco = new HashSet<tbCuentasBanco>();
        }
    
        public short ban_Id { get; set; }
        public string ban_Nombre { get; set; }
        public string ban_NombreContacto { get; set; }
        public string ban_TelefonoContacto { get; set; }
        public int ban_UsuarioCrea { get; set; }
        public System.DateTime ban_FechaCrea { get; set; }
        public Nullable<int> ban_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> ban_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCuentasBanco> tbCuentasBanco { get; set; }
    }
}
