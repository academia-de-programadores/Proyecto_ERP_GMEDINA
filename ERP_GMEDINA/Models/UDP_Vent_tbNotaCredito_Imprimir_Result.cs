
namespace ERP_GMEDINA.Models
{
    using System;
    
    public partial class UDP_Vent_tbNotaCredito_Imprimir_Result
    {
        public System.DateTime nocre_FechaEmision { get; set; }
        public short nocre_Id { get; set; }
        public string nocre_Codigo { get; set; }
        public string nocre_MotivoEmision { get; set; }
        public Nullable<decimal> nocre_Monto { get; set; }
        public Nullable<int> dev_Id { get; set; }
        public Nullable<decimal> devd_Monto { get; set; }
        public string clte_Identificacion { get; set; }
        public string clte_Nombres { get; set; }
        public string clte_Apellidos { get; set; }
        public string clte_NombreComercial { get; set; }
        public string suc_Descripcion { get; set; }
        public string suc_Correo { get; set; }
        public string suc_Direccion { get; set; }
        public string suc_Telefono { get; set; }
    }
}
