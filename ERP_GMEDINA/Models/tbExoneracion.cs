
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbExoneracion
    {
        public int exo_Id { get; set; }
        public string exo_Documento { get; set; }
        public bool exo_ExoneracionActiva { get; set; }
        public System.DateTime exo_FechaInicialVigencia { get; set; }
        public System.DateTime exo_FechaIFinalVigencia { get; set; }
        public int clte_Id { get; set; }
        public int exo_UsuarioCrea { get; set; }
        public Nullable<System.DateTime> exo_FechaCrea { get; set; }
        public Nullable<int> exo_UsuarioModifa { get; set; }
        public Nullable<System.DateTime> exo_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbCliente tbCliente { get; set; }
    }
}
