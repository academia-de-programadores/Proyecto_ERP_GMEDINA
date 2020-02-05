
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbHabilidades
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbHabilidades()
        {
            this.tbHabilidadesPersona = new HashSet<tbHabilidadesPersona>();
            this.tbHabilidadesRequisicion = new HashSet<tbHabilidadesRequisicion>();
        }
    
        public int habi_Id { get; set; }
        public string habi_Descripcion { get; set; }
        public bool habi_Estado { get; set; }
        public string habi_RazonInactivo { get; set; }
        public int habi_UsuarioCrea { get; set; }
        public System.DateTime habi_FechaCrea { get; set; }
        public Nullable<int> habi_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> habi_FechaModifica { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHabilidadesPersona> tbHabilidadesPersona { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHabilidadesRequisicion> tbHabilidadesRequisicion { get; set; }
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
    }
}
