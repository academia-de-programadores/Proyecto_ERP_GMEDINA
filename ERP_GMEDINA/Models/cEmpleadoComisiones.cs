﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;

namespace ERP_GMEDINA.Models
{

    [MetadataType(typeof(cEmpleadoComisiones))]
    public partial class tbEmpleadoComisiones
    {

    }

    public class cEmpleadoComisiones
    {

        [Display(Name = "Número")]
        public int cc_Id { get; set; }


        [Display(Name = "Empleado")]
        [Required(ErrorMessage = "No puede dejar campos vacios.")]
        public int emp_Id { get; set; }

        [Display(Name = "Ingreso")]
        public int cin_IdIngreso { get; set; }


        [Display(Name = "Fecha Registro")]
        public System.DateTime cc_FechaRegistro { get; set; }

        [Display(Name = "Pagado")]
        public bool cc_Pagado { get; set; }

        [Display(Name = "Creado por")]
        public int cc_UsuarioCrea { get; set; }

        [Display(Name = "Fecha de Creacion")]
        public System.DateTime cc_FechaCrea { get; set; }

        [Display(Name = "Modificado por")]
        public Nullable<int> cc_UsuarioModifica { get; set; }

        [Display(Name = "Fecha Modificacion")]
        public Nullable<System.DateTime> cc_FechaModifica { get; set; }

        [Display(Name = "Estado")]
        public bool cc_Activo { get; set; }


        [Display(Name = "Porcentaje Comision")]
        [Required(ErrorMessage = "Campo Porcentaje Comision Requerido")]
        [Range(0, 999999.99, ErrorMessage = "El monto {0} debe estar entre {1} y {2}.")]
        public decimal cc_PorcentajeComision { get; set; }


        [Display(Name = "Total Venta")]
        [Required(ErrorMessage = "Campo Total Venta Requerido")]
        [Range(0, 999999.99, ErrorMessage = "El monto {0} debe estar entre {1} y {2}.")]   
        public decimal cc_TotalVenta { get; set; }

        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbCatalogoDeIngresos tbCatalogoDeIngresos { get; set; }
        public virtual tbEmpleados tbEmpleados { get; set; }
    }
}