
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UDV_Inv_tbProducto
    {
        public string prod_Codigo { get; set; }
        public string prod_Descripcion { get; set; }
        public string prod_Marca { get; set; }
        public string prod_Modelo { get; set; }
        public string prod_Talla { get; set; }
        public string prod_Color { get; set; }
        public int pscat_Id { get; set; }
        public string pscat_Descripcion { get; set; }
        public int pcat_Id { get; set; }
        public string pcat_Nombre { get; set; }
        public int uni_Id { get; set; }
        public string uni_Descripcion { get; set; }
        public int prod_UsuarioCrea { get; set; }
        public System.DateTime prod_FechaCrea { get; set; }
        public Nullable<int> prod_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> prod_FechaModifica { get; set; }
        public bool prod_EsActivo { get; set; }
        public string prod_Razon_Inactivacion { get; set; }
        public string prod_CodigoBarras { get; set; }
        public Nullable<int> prod_Correlativo { get; set; }
    }
}
