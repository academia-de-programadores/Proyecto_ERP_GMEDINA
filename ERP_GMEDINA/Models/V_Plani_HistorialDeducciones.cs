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
    
    public partial class V_Plani_HistorialDeducciones
    {
        public int emp_Id { get; set; }
        public int hipa_IdHistorialDePago { get; set; }
        public int hidp_IdHistorialdeDeduPago { get; set; }
        public decimal hipa_TotalISR { get; set; }
        public decimal hipa_AFP { get; set; }
        public string cde_DescripcionDeduccion { get; set; }
        public Nullable<decimal> hidp_Total { get; set; }
        public Nullable<int> TotalDeducciones { get; set; }
    }
}
