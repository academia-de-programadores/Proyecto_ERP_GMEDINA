//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbEmpresas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbEmpresas()
        {
            this.tbSucursales = new HashSet<tbSucursales>();
        }
    
        public int empr_Id { get; set; }
        public string empr_Nombre { get; set; }
        public Nullable<int> per_Id { get; set; }
        public string empr_RTN { get; set; }
        public string empr_Logo { get; set; }
        public bool empr_Estado { get; set; }
        public string empr_RazonInactivo { get; set; }
        public int empr_UsuarioCrea { get; set; }
        public System.DateTime empr_FechaCrea { get; set; }
        public Nullable<int> empr_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> empr_FechaModifica { get; set; }
        public Nullable<decimal> empr_SalarioMinimo { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSucursales> tbSucursales { get; set; }
        public virtual tbPersonas tbPersonas { get; set; }
    }
}
