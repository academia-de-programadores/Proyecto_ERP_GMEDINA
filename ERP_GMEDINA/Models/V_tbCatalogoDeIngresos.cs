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
    
    public partial class V_tbCatalogoDeIngresos
    {
        public int cin_IdIngreso { get; set; }
        public string cin_DescripcionIngreso { get; set; }
        public int cin_UsuarioCrea { get; set; }
        public System.DateTime cin_FechaCrea { get; set; }
        public Nullable<int> cin_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> cin_FechaModifica { get; set; }
        public bool cin_Activo { get; set; }
    }
}
