
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbTipoDevolucion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbTipoDevolucion()
        {
            this.tbEntrada = new HashSet<tbEntrada>();
            this.tbSalida = new HashSet<tbSalida>();
        }
    
        public int tdev_Id { get; set; }
        public string tdev_Descripcion { get; set; }
        public int tdev_UsuarioCrea { get; set; }
        public System.DateTime tdev_FechaCrea { get; set; }
        public Nullable<int> tdev_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> tdev_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEntrada> tbEntrada { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSalida> tbSalida { get; set; }
    }
}
