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
    
    public partial class SDP_tbInventarioFisicoDetalle_Select_Result
    {
        public int invfd_Id { get; set; }
        public int invf_Id { get; set; }
        public string prod_Codigo { get; set; }
        public decimal invfd_Cantidad { get; set; }
        public decimal invfd_CantidadSistema { get; set; }
        public int uni_Id { get; set; }
        public int invfd_UsuarioCrea { get; set; }
        public System.DateTime invfd_FechaCrea { get; set; }
        public Nullable<int> invfd_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> invfd_FechaModifica { get; set; }
    }
}
