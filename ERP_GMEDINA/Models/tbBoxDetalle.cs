
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbBoxDetalle
    {
        public int boxd_Id { get; set; }
        public string box_Codigo { get; set; }
        public string prod_Codigo { get; set; }
        public decimal boxd_Cantidad { get; set; }
        public int boxd_UsuarioCrea { get; set; }
        public System.DateTime boxd_FechaCrea { get; set; }
        public Nullable<int> boxd_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> boxd_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbBox tbBox { get; set; }
        public virtual tbProducto tbProducto { get; set; }
    }
}
