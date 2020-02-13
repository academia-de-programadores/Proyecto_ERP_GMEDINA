
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbUnidadMedida
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbUnidadMedida()
        {
            this.tbInventarioFisicoDetalle = new HashSet<tbInventarioFisicoDetalle>();
            this.tbProducto = new HashSet<tbProducto>();
        }
    
        public int uni_Id { get; set; }
        public string uni_Descripcion { get; set; }
        public string uni_Abreviatura { get; set; }
        public int uni_UsuarioCrea { get; set; }
        public System.DateTime uni_FechaCrea { get; set; }
        public Nullable<int> uni_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> uni_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbInventarioFisicoDetalle> tbInventarioFisicoDetalle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbProducto> tbProducto { get; set; }
    }
}