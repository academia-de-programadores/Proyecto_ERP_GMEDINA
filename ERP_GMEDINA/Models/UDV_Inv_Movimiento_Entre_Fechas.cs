
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UDV_Inv_Movimiento_Entre_Fechas
    {
        public int bod_Id { get; set; }
        public string bod_Nombre { get; set; }
        public string bod_ResponsableBodega { get; set; }
        public string bod_Telefono { get; set; }
        public string prod_CodigoBarras { get; set; }
        public string prod_Descripcion { get; set; }
        public string pscat_Descripcion { get; set; }
        public string prod_Modelo { get; set; }
        public string prod_Talla { get; set; }
        public string uni_Descripcion { get; set; }
        public Nullable<int> Cantidad_Salidas_Entradas { get; set; }
        public Nullable<long> Row_ { get; set; }
        public string TIPO { get; set; }
    }
}
