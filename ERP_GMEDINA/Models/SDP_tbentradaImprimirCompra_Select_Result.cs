
namespace ERP_GMEDINA.Models
{
    using System;
    
    public partial class SDP_tbentradaImprimirCompra_Select_Result
    {
        public string ent_NumeroFormato { get; set; }
        public string bod_Nombre { get; set; }
        public System.DateTime ent_FechaElaboracion { get; set; }
        public string prov_Nombre { get; set; }
        public string estm_Descripcion { get; set; }
        public string tent_Descripcion { get; set; }
        public string ent_FacturaCompra { get; set; }
        public Nullable<System.DateTime> ent_FechaCompra { get; set; }
        public string tdev_descripcion { get; set; }
        public string fact_Id { get; set; }
        public Nullable<int> ent_BodegaDestino { get; set; }
    }
}
