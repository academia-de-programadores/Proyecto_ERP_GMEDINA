
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbProductoCategoria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbProductoCategoria()
        {
            this.tbProductoSubcategoria = new HashSet<tbProductoSubcategoria>();
        }
    
        public int pcat_Id { get; set; }
        public string pcat_Nombre { get; set; }
        public int pcat_UsuarioCrea { get; set; }
        public System.DateTime pcat_FechaCrea { get; set; }
        public Nullable<int> pcat_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> pcat_FechaModifica { get; set; }
        public byte pcat_EsActivo { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbUsuario tbUsuario2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbProductoSubcategoria> tbProductoSubcategoria { get; set; }
    }
}
