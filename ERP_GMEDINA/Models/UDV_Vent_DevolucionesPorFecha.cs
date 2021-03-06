
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UDV_Vent_DevolucionesPorFecha
    {
        public int dev_Id { get; set; }
        public int devd_Id { get; set; }
        public int Cajero { get; set; }
        public Nullable<System.DateTime> FechaDevolucion { get; set; }
        public Nullable<System.DateTime> FechaFactura { get; set; }
        public long Numero_Factura { get; set; }
        public short factd_Id { get; set; }
        public int clte_Id { get; set; }
        public string RTN { get; set; }
        public string Nombres { get; set; }
        public decimal Total_Devolución { get; set; }
        public string Nota_Crédito { get; set; }
        public string Código_Producto { get; set; }
        public string Nombre_Producto { get; set; }
        public decimal Precio_Unitario { get; set; }
        public decimal Cantidad_Facturada { get; set; }
        public decimal Cantidad_Devuelta { get; set; }
        public decimal Monto_Devolución { get; set; }
    }
}
