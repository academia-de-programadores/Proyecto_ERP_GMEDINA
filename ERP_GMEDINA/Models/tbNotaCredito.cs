
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbNotaCredito
    {
        public short nocre_Id { get; set; }
        public string nocre_Codigo { get; set; }
        public Nullable<int> dev_Id { get; set; }
        public int clte_Id { get; set; }
        public Nullable<int> suc_Id { get; set; }
        public Nullable<short> cja_Id { get; set; }
        public Nullable<bool> nocre_Anulado { get; set; }
        public string nocre_RazonAnulado { get; set; }
        public System.DateTime nocre_FechaEmision { get; set; }
        public string nocre_MotivoEmision { get; set; }
        public Nullable<decimal> nocre_Monto { get; set; }
        public bool nocre_Redimido { get; set; }
        public Nullable<System.DateTime> nocre_FechaRedimido { get; set; }
        public bool nocre_EsImpreso { get; set; }
        public int nocre_UsuarioCrea { get; set; }
        public System.DateTime nocre_FechaCrea { get; set; }
        public Nullable<int> nocre_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> nocre_FechaModifica { get; set; }
        public Nullable<int> emp_Id { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbEmpleados tbEmpleados { get; set; }
        public virtual tbSucursales tbSucursales { get; set; }
        public virtual tbCaja tbCaja { get; set; }
        public virtual tbCliente tbCliente { get; set; }
        public virtual tbDevolucion tbDevolucion { get; set; }
    }
}
