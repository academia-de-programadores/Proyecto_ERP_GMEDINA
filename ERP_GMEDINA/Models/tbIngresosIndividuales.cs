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
    
    public partial class tbIngresosIndividuales
    {
        public int ini_IdIngresosIndividuales { get; set; }
        public string ini_Motivo { get; set; }
        public int emp_Id { get; set; }
        public Nullable<decimal> ini_Monto { get; set; }
        public Nullable<bool> ini_PagaSiempre { get; set; }
        public bool ini_Pagado { get; set; }
        public int ini_UsuarioCrea { get; set; }
        public System.DateTime ini_FechaCrea { get; set; }
        public Nullable<int> ini_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> ini_FechaModifica { get; set; }
        public bool ini_Activo { get; set; }
        public string ini_comentario { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbEmpleados tbEmpleados { get; set; }
    }
}
