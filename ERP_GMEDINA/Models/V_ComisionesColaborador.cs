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
    
    public partial class V_ComisionesColaborador
    {
        public int cc_Id { get; set; }
        public int emp_Id { get; set; }
        public Nullable<decimal> cc_Monto { get; set; }
        public System.DateTime cc_FechaRegistro { get; set; }
        public bool cc_Pagado { get; set; }
        public int cc_UsuarioCrea { get; set; }
        public System.DateTime cc_FechaCrea { get; set; }
        public Nullable<int> cc_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> cc_FechaModifica { get; set; }
        public bool cc_Activo { get; set; }
        public int cin_IdIngreso { get; set; }
        public string cin_DescripcionIngreso { get; set; }
    }
}
