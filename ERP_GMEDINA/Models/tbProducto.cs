
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbProducto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbProducto()
        {
            this.tbBodegaDetalle = new HashSet<tbBodegaDetalle>();
            this.tbBoxDetalle = new HashSet<tbBoxDetalle>();
            this.tbEntradaDetalle = new HashSet<tbEntradaDetalle>();
            this.tbInventarioFisicoDetalle = new HashSet<tbInventarioFisicoDetalle>();
            this.tbDevolucionDetalle = new HashSet<tbDevolucionDetalle>();
            this.tbSalidaDetalle = new HashSet<tbSalidaDetalle>();
            this.tbFacturaDetalle = new HashSet<tbFacturaDetalle>();
            this.tbListadoPrecioDetalle = new HashSet<tbListadoPrecioDetalle>();
            this.tbPedidoDetalle = new HashSet<tbPedidoDetalle>();
        }
    
        public string prod_Codigo { get; set; }
        public string prod_Descripcion { get; set; }
        public string prod_Marca { get; set; }
        public string prod_Modelo { get; set; }
        public string prod_Talla { get; set; }
        public string prod_Color { get; set; }
        public int pscat_Id { get; set; }
        public int uni_Id { get; set; }
        public int prod_UsuarioCrea { get; set; }
        public System.DateTime prod_FechaCrea { get; set; }
        public Nullable<int> prod_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> prod_FechaModifica { get; set; }
        public bool prod_EsActivo { get; set; }
        public string prod_Razon_Inactivacion { get; set; }
        public string prod_CodigoBarras { get; set; }
        public Nullable<int> prod_Correlativo { get; set; }
        public int prov_Id { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbUnidadMedida tbUnidadMedida { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbBodegaDetalle> tbBodegaDetalle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbBoxDetalle> tbBoxDetalle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEntradaDetalle> tbEntradaDetalle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbInventarioFisicoDetalle> tbInventarioFisicoDetalle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDevolucionDetalle> tbDevolucionDetalle { get; set; }
        public virtual tbProveedor tbProveedor { get; set; }
        public virtual tbProductoSubcategoria tbProductoSubcategoria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSalidaDetalle> tbSalidaDetalle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbFacturaDetalle> tbFacturaDetalle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbListadoPrecioDetalle> tbListadoPrecioDetalle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPedidoDetalle> tbPedidoDetalle { get; set; }
    }
}
