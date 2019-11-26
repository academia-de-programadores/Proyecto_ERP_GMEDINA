﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_GMEDINA.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ERP_GMEDINAEntities1 : DbContext
    {
        public ERP_GMEDINAEntities1()
            : base("name=ERP_GMEDINAEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbUsuario> tbUsuario { get; set; }
        public virtual DbSet<tbRazonSalidas> tbRazonSalidas { get; set; }
    
        public virtual ObjectResult<UDP_RRHH_tbRazonSalida_Update_Result> UDP_RRHH_tbRazonSalida_Update(Nullable<int> rsal_Id, string rsal_Descripcion, Nullable<int> rsal_UsuarioModifica, Nullable<System.DateTime> rsal_FechaModifica)
        {
            var rsal_IdParameter = rsal_Id.HasValue ?
                new ObjectParameter("rsal_Id", rsal_Id) :
                new ObjectParameter("rsal_Id", typeof(int));
    
            var rsal_DescripcionParameter = rsal_Descripcion != null ?
                new ObjectParameter("rsal_Descripcion", rsal_Descripcion) :
                new ObjectParameter("rsal_Descripcion", typeof(string));
    
            var rsal_UsuarioModificaParameter = rsal_UsuarioModifica.HasValue ?
                new ObjectParameter("rsal_UsuarioModifica", rsal_UsuarioModifica) :
                new ObjectParameter("rsal_UsuarioModifica", typeof(int));
    
            var rsal_FechaModificaParameter = rsal_FechaModifica.HasValue ?
                new ObjectParameter("rsal_FechaModifica", rsal_FechaModifica) :
                new ObjectParameter("rsal_FechaModifica", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UDP_RRHH_tbRazonSalida_Update_Result>("UDP_RRHH_tbRazonSalida_Update", rsal_IdParameter, rsal_DescripcionParameter, rsal_UsuarioModificaParameter, rsal_FechaModificaParameter);
        }
    
        public virtual ObjectResult<UDP_RRHH_tbRazonSalidas_Delete_Result> UDP_RRHH_tbRazonSalidas_Delete(Nullable<int> rsal_Id, string rsal_razon_Inactivo, Nullable<int> rsal_UsuarioModifica, Nullable<System.DateTime> rsal_FechaModifica)
        {
            var rsal_IdParameter = rsal_Id.HasValue ?
                new ObjectParameter("rsal_Id", rsal_Id) :
                new ObjectParameter("rsal_Id", typeof(int));
    
            var rsal_razon_InactivoParameter = rsal_razon_Inactivo != null ?
                new ObjectParameter("rsal_razon_Inactivo", rsal_razon_Inactivo) :
                new ObjectParameter("rsal_razon_Inactivo", typeof(string));
    
            var rsal_UsuarioModificaParameter = rsal_UsuarioModifica.HasValue ?
                new ObjectParameter("rsal_UsuarioModifica", rsal_UsuarioModifica) :
                new ObjectParameter("rsal_UsuarioModifica", typeof(int));
    
            var rsal_FechaModificaParameter = rsal_FechaModifica.HasValue ?
                new ObjectParameter("rsal_FechaModifica", rsal_FechaModifica) :
                new ObjectParameter("rsal_FechaModifica", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UDP_RRHH_tbRazonSalidas_Delete_Result>("UDP_RRHH_tbRazonSalidas_Delete", rsal_IdParameter, rsal_razon_InactivoParameter, rsal_UsuarioModificaParameter, rsal_FechaModificaParameter);
        }
    
        public virtual ObjectResult<UDP_RRHH_tbRazonSalidas_Insert_Result> UDP_RRHH_tbRazonSalidas_Insert(string rsal_Descripcion, Nullable<int> rsal_Usuariocrea, Nullable<System.DateTime> rsal_FechaCrea)
        {
            var rsal_DescripcionParameter = rsal_Descripcion != null ?
                new ObjectParameter("rsal_Descripcion", rsal_Descripcion) :
                new ObjectParameter("rsal_Descripcion", typeof(string));
    
            var rsal_UsuariocreaParameter = rsal_Usuariocrea.HasValue ?
                new ObjectParameter("rsal_Usuariocrea", rsal_Usuariocrea) :
                new ObjectParameter("rsal_Usuariocrea", typeof(int));
    
            var rsal_FechaCreaParameter = rsal_FechaCrea.HasValue ?
                new ObjectParameter("rsal_FechaCrea", rsal_FechaCrea) :
                new ObjectParameter("rsal_FechaCrea", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UDP_RRHH_tbRazonSalidas_Insert_Result>("UDP_RRHH_tbRazonSalidas_Insert", rsal_DescripcionParameter, rsal_UsuariocreaParameter, rsal_FechaCreaParameter);
        }
    
        public virtual ObjectResult<UDP_RRHH_tbRazonSalidas_Restore_Result> UDP_RRHH_tbRazonSalidas_Restore(Nullable<int> rsal_Id, Nullable<int> rsal_UsuarioModifica, Nullable<System.DateTime> rsal_FechaModifica)
        {
            var rsal_IdParameter = rsal_Id.HasValue ?
                new ObjectParameter("rsal_Id", rsal_Id) :
                new ObjectParameter("rsal_Id", typeof(int));
    
            var rsal_UsuarioModificaParameter = rsal_UsuarioModifica.HasValue ?
                new ObjectParameter("rsal_UsuarioModifica", rsal_UsuarioModifica) :
                new ObjectParameter("rsal_UsuarioModifica", typeof(int));
    
            var rsal_FechaModificaParameter = rsal_FechaModifica.HasValue ?
                new ObjectParameter("rsal_FechaModifica", rsal_FechaModifica) :
                new ObjectParameter("rsal_FechaModifica", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UDP_RRHH_tbRazonSalidas_Restore_Result>("UDP_RRHH_tbRazonSalidas_Restore", rsal_IdParameter, rsal_UsuarioModificaParameter, rsal_FechaModificaParameter);
        }
    }
}
