
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbTechosDeducciones
    {
        public int tddu_IdTechosDeducciones { get; set; }
        public decimal tddu_PorcentajeColaboradores { get; set; }
        public decimal tddu_PorcentajeEmpresa { get; set; }
        public decimal tddu_Techo { get; set; }
        public int cde_IdDeducciones { get; set; }
        public bool tddu_Activo { get; set; }
        public int tddu_UsuarioCrea { get; set; }
        public System.DateTime tddu_FechaCrea { get; set; }
        public Nullable<int> tddu_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> tddu_FechaModifica { get; set; }
    
        public virtual tbCatalogoDeDeducciones tbCatalogoDeDeducciones { get; set; }
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
    }
}
