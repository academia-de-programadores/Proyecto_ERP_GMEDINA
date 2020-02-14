
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbParametro
    {
        public byte par_Id { get; set; }
        public string par_NombreEmpresa { get; set; }
        public string par_TelefonoEmpresa { get; set; }
        public string par_CorreoEmpresa { get; set; }
        public string par_PathLogo { get; set; }
        public short mnda_Id { get; set; }
        public int par_RolGerenteTienda { get; set; }
        public int par_RolCreditoCobranza { get; set; }
        public int par_RolSupervisorCaja { get; set; }
        public int par_RolCajero { get; set; }
        public int par_RolAuditor { get; set; }
        public int par_SucursalPrincipal { get; set; }
        public int par_UsuarioCrea { get; set; }
        public System.DateTime par_FechaCrea { get; set; }
        public Nullable<int> par_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> par_FechaModifica { get; set; }
        public Nullable<decimal> par_PorcentajeDescuentoTE { get; set; }
        public Nullable<int> par_IdConsumidorFinal { get; set; }
    
        public virtual tbRol tbRol { get; set; }
        public virtual tbRol tbRol1 { get; set; }
        public virtual tbRol tbRol2 { get; set; }
        public virtual tbRol tbRol3 { get; set; }
        public virtual tbRol tbRol4 { get; set; }
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbMoneda tbMoneda { get; set; }
        public virtual tbCliente tbCliente { get; set; }
        public virtual tbSucursales tbSucursales { get; set; }
    }
}
