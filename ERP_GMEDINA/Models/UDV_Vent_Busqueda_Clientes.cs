
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UDV_Vent_Busqueda_Clientes
    {
        public int clte_Id { get; set; }
        public byte tpi_Id { get; set; }
        public string tpi_Descripcion { get; set; }
        public string clte_Identificacion { get; set; }
        public bool clte_EsPersonaNatural { get; set; }
        public string clte_Nombres { get; set; }
        public string clte_Apellidos { get; set; }
        public Nullable<System.DateTime> clte_FechaNacimiento { get; set; }
        public string clte_Nacionalidad { get; set; }
        public string clte_Sexo { get; set; }
        public string clte_Telefono { get; set; }
        public string clte_NombreComercial { get; set; }
        public string clte_RazonSocial { get; set; }
        public string clte_ContactoNombre { get; set; }
        public string clte_ContactoEmail { get; set; }
        public string clte_ContactoTelefono { get; set; }
        public Nullable<System.DateTime> clte_FechaConstitucion { get; set; }
        public string mun_Codigo { get; set; }
        public string clte_Direccion { get; set; }
        public string clte_CorreoElectronico { get; set; }
        public bool clte_EsActivo { get; set; }
        public string clte_RazonInactivo { get; set; }
        public bool clte_ConCredito { get; set; }
        public bool clte_EsMinorista { get; set; }
        public string clte_Observaciones { get; set; }
        public int clte_UsuarioCrea { get; set; }
        public System.DateTime clte_FechaCrea { get; set; }
        public Nullable<int> clte_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> clte_FechaModifica { get; set; }
    }
}
