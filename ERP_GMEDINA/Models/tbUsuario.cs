
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbUsuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbUsuario()
        {
            this.tbAccesoRol = new HashSet<tbAccesoRol>();
            this.tbAccesoRol1 = new HashSet<tbAccesoRol>();
            this.tbObjeto = new HashSet<tbObjeto>();
            this.tbObjeto1 = new HashSet<tbObjeto>();
            this.tbRol = new HashSet<tbRol>();
            this.tbRol1 = new HashSet<tbRol>();
            this.tbRolesUsuario = new HashSet<tbRolesUsuario>();
            this.tbRolesUsuario1 = new HashSet<tbRolesUsuario>();
            this.tbRolesUsuario2 = new HashSet<tbRolesUsuario>();
            this.tbDeduccionImpuestoVecinal = new HashSet<tbDeduccionImpuestoVecinal>();
            this.tbDeduccionImpuestoVecinal1 = new HashSet<tbDeduccionImpuestoVecinal>();
            this.tbPagoDeCesantiaDetalle = new HashSet<tbPagoDeCesantiaDetalle>();
            this.tbPagoDeCesantiaDetalle1 = new HashSet<tbPagoDeCesantiaDetalle>();
            this.tbPagoDeCesantiaEncabezado = new HashSet<tbPagoDeCesantiaEncabezado>();
            this.tbPagoDeCesantiaEncabezado1 = new HashSet<tbPagoDeCesantiaEncabezado>();
            this.tbTechoImpuestoVecinal = new HashSet<tbTechoImpuestoVecinal>();
            this.tbTechoImpuestoVecinal1 = new HashSet<tbTechoImpuestoVecinal>();
            this.tbTechosComisiones = new HashSet<tbTechosComisiones>();
            this.tbTechosComisiones1 = new HashSet<tbTechosComisiones>();
            this.tbAcumuladosISR = new HashSet<tbAcumuladosISR>();
            this.tbAcumuladosISR1 = new HashSet<tbAcumuladosISR>();
            this.tbAdelantoSueldo = new HashSet<tbAdelantoSueldo>();
            this.tbAdelantoSueldo1 = new HashSet<tbAdelantoSueldo>();
            this.tbAFP = new HashSet<tbAFP>();
            this.tbAFP1 = new HashSet<tbAFP>();
            this.tbAuxilioDeCesantias = new HashSet<tbAuxilioDeCesantias>();
            this.tbAuxilioDeCesantias1 = new HashSet<tbAuxilioDeCesantias>();
            this.tbCatalogoDeDeducciones = new HashSet<tbCatalogoDeDeducciones>();
            this.tbCatalogoDeDeducciones1 = new HashSet<tbCatalogoDeDeducciones>();
            this.tbCatalogoDeIngresos = new HashSet<tbCatalogoDeIngresos>();
            this.tbCatalogoDeIngresos1 = new HashSet<tbCatalogoDeIngresos>();
            this.tbCatalogoDePlanillas = new HashSet<tbCatalogoDePlanillas>();
            this.tbCatalogoDePlanillas1 = new HashSet<tbCatalogoDePlanillas>();
            this.tbDecimoCuartoMes = new HashSet<tbDecimoCuartoMes>();
            this.tbDecimoCuartoMes1 = new HashSet<tbDecimoCuartoMes>();
            this.tbDecimoTercerMes = new HashSet<tbDecimoTercerMes>();
            this.tbDecimoTercerMes1 = new HashSet<tbDecimoTercerMes>();
            this.tbDeduccionAFP = new HashSet<tbDeduccionAFP>();
            this.tbDeduccionAFP1 = new HashSet<tbDeduccionAFP>();
            this.tbDeduccionesExtraordinarias = new HashSet<tbDeduccionesExtraordinarias>();
            this.tbDeduccionesExtraordinarias1 = new HashSet<tbDeduccionesExtraordinarias>();
            this.tbDeduccionesIndividuales = new HashSet<tbDeduccionesIndividuales>();
            this.tbDeduccionesIndividuales1 = new HashSet<tbDeduccionesIndividuales>();
            this.tbDeduccionInstitucionFinanciera = new HashSet<tbDeduccionInstitucionFinanciera>();
            this.tbDeduccionInstitucionFinanciera1 = new HashSet<tbDeduccionInstitucionFinanciera>();
            this.tbEmpleadoBonos = new HashSet<tbEmpleadoBonos>();
            this.tbEmpleadoBonos1 = new HashSet<tbEmpleadoBonos>();
            this.tbEmpleadoComisiones = new HashSet<tbEmpleadoComisiones>();
            this.tbEmpleadoComisiones1 = new HashSet<tbEmpleadoComisiones>();
            this.tbFormaPago = new HashSet<tbFormaPago>();
            this.tbFormaPago1 = new HashSet<tbFormaPago>();
            this.tbHistorialDeduccionPago = new HashSet<tbHistorialDeduccionPago>();
            this.tbHistorialDeduccionPago1 = new HashSet<tbHistorialDeduccionPago>();
            this.tbHistorialDeIngresosPago = new HashSet<tbHistorialDeIngresosPago>();
            this.tbHistorialDeIngresosPago1 = new HashSet<tbHistorialDeIngresosPago>();
            this.tbHistorialDePago = new HashSet<tbHistorialDePago>();
            this.tbHistorialDePago1 = new HashSet<tbHistorialDePago>();
            this.tbIngresosIndividuales = new HashSet<tbIngresosIndividuales>();
            this.tbIngresosIndividuales1 = new HashSet<tbIngresosIndividuales>();
            this.tbInstitucionesFinancieras = new HashSet<tbInstitucionesFinancieras>();
            this.tbInstitucionesFinancieras1 = new HashSet<tbInstitucionesFinancieras>();
            this.tbISR = new HashSet<tbISR>();
            this.tbISR1 = new HashSet<tbISR>();
            this.tbLiquidacionVacaciones = new HashSet<tbLiquidacionVacaciones>();
            this.tbLiquidacionVacaciones1 = new HashSet<tbLiquidacionVacaciones>();
            this.tbPeriodos = new HashSet<tbPeriodos>();
            this.tbPeriodos1 = new HashSet<tbPeriodos>();
            this.tbPreaviso = new HashSet<tbPreaviso>();
            this.tbPreaviso1 = new HashSet<tbPreaviso>();
            this.tbTechosDeducciones = new HashSet<tbTechosDeducciones>();
            this.tbTechosDeducciones1 = new HashSet<tbTechosDeducciones>();
            this.tbTipoDeduccion = new HashSet<tbTipoDeduccion>();
            this.tbTipoDeduccion1 = new HashSet<tbTipoDeduccion>();
            this.tbTipoPlanillaDetalleDeduccion = new HashSet<tbTipoPlanillaDetalleDeduccion>();
            this.tbTipoPlanillaDetalleDeduccion1 = new HashSet<tbTipoPlanillaDetalleDeduccion>();
            this.tbTipoPlanillaDetalleIngreso = new HashSet<tbTipoPlanillaDetalleIngreso>();
            this.tbTipoPlanillaDetalleIngreso1 = new HashSet<tbTipoPlanillaDetalleIngreso>();
            this.tbAreas = new HashSet<tbAreas>();
            this.tbAreas1 = new HashSet<tbAreas>();
            this.tbCargos = new HashSet<tbCargos>();
            this.tbCargos1 = new HashSet<tbCargos>();
            this.tbCompetencias = new HashSet<tbCompetencias>();
            this.tbCompetencias1 = new HashSet<tbCompetencias>();
            this.tbCompetenciasPersona = new HashSet<tbCompetenciasPersona>();
            this.tbCompetenciasPersona1 = new HashSet<tbCompetenciasPersona>();
            this.tbCompetenciasRequisicion = new HashSet<tbCompetenciasRequisicion>();
            this.tbCompetenciasRequisicion1 = new HashSet<tbCompetenciasRequisicion>();
            this.tbDepartamentos = new HashSet<tbDepartamentos>();
            this.tbDepartamentos1 = new HashSet<tbDepartamentos>();
            this.tbDirectoriosEmpleados = new HashSet<tbDirectoriosEmpleados>();
            this.tbDirectoriosEmpleados1 = new HashSet<tbDirectoriosEmpleados>();
            this.tbEmpleados = new HashSet<tbEmpleados>();
            this.tbEmpleados1 = new HashSet<tbEmpleados>();
            this.tbEmpresas = new HashSet<tbEmpresas>();
            this.tbEmpresas1 = new HashSet<tbEmpresas>();
            this.tbEquipoEmpleados = new HashSet<tbEquipoEmpleados>();
            this.tbEquipoEmpleados1 = new HashSet<tbEquipoEmpleados>();
            this.tbEquipoTrabajo = new HashSet<tbEquipoTrabajo>();
            this.tbEquipoTrabajo1 = new HashSet<tbEquipoTrabajo>();
            this.tbFaseSeleccion = new HashSet<tbFaseSeleccion>();
            this.tbFaseSeleccion1 = new HashSet<tbFaseSeleccion>();
            this.tbFasesReclutamiento = new HashSet<tbFasesReclutamiento>();
            this.tbFasesReclutamiento1 = new HashSet<tbFasesReclutamiento>();
            this.tbHabilidades = new HashSet<tbHabilidades>();
            this.tbHabilidades1 = new HashSet<tbHabilidades>();
            this.tbHabilidadesPersona = new HashSet<tbHabilidadesPersona>();
            this.tbHabilidadesPersona1 = new HashSet<tbHabilidadesPersona>();
            this.tbHabilidadesRequisicion = new HashSet<tbHabilidadesRequisicion>();
            this.tbHabilidadesRequisicion1 = new HashSet<tbHabilidadesRequisicion>();
            this.tbHistorialAmonestaciones = new HashSet<tbHistorialAmonestaciones>();
            this.tbHistorialAmonestaciones1 = new HashSet<tbHistorialAmonestaciones>();
            this.tbHistorialAudienciaDescargo = new HashSet<tbHistorialAudienciaDescargo>();
            this.tbHistorialAudienciaDescargo1 = new HashSet<tbHistorialAudienciaDescargo>();
            this.tbHistorialCargos = new HashSet<tbHistorialCargos>();
            this.tbHistorialCargos1 = new HashSet<tbHistorialCargos>();
            this.tbHistorialContrataciones = new HashSet<tbHistorialContrataciones>();
            this.tbHistorialContrataciones1 = new HashSet<tbHistorialContrataciones>();
            this.tbHistorialHorasTrabajadas = new HashSet<tbHistorialHorasTrabajadas>();
            this.tbHistorialHorasTrabajadas1 = new HashSet<tbHistorialHorasTrabajadas>();
            this.tbHistorialIncapacidades = new HashSet<tbHistorialIncapacidades>();
            this.tbHistorialIncapacidades1 = new HashSet<tbHistorialIncapacidades>();
            this.tbHistorialPermisos = new HashSet<tbHistorialPermisos>();
            this.tbHistorialPermisos1 = new HashSet<tbHistorialPermisos>();
            this.tbHistorialRefrendamientos = new HashSet<tbHistorialRefrendamientos>();
            this.tbHistorialRefrendamientos1 = new HashSet<tbHistorialRefrendamientos>();
            this.tbHistorialSalidas = new HashSet<tbHistorialSalidas>();
            this.tbHistorialSalidas1 = new HashSet<tbHistorialSalidas>();
            this.tbHistorialVacaciones = new HashSet<tbHistorialVacaciones>();
            this.tbHistorialVacaciones1 = new HashSet<tbHistorialVacaciones>();
            this.tbHorarios = new HashSet<tbHorarios>();
            this.tbHorarios1 = new HashSet<tbHorarios>();
            this.tbIdiomaPersona = new HashSet<tbIdiomaPersona>();
            this.tbIdiomaPersona1 = new HashSet<tbIdiomaPersona>();
            this.tbIdiomas = new HashSet<tbIdiomas>();
            this.tbIdiomas1 = new HashSet<tbIdiomas>();
            this.tbIdiomasRequisicion = new HashSet<tbIdiomasRequisicion>();
            this.tbIdiomasRequisicion1 = new HashSet<tbIdiomasRequisicion>();
            this.tbJornadas = new HashSet<tbJornadas>();
            this.tbJornadas1 = new HashSet<tbJornadas>();
            this.tbNacionalidades = new HashSet<tbNacionalidades>();
            this.tbNacionalidades1 = new HashSet<tbNacionalidades>();
            this.tbPersonas = new HashSet<tbPersonas>();
            this.tbPersonas1 = new HashSet<tbPersonas>();
            this.tbRazonSalidas = new HashSet<tbRazonSalidas>();
            this.tbRazonSalidas1 = new HashSet<tbRazonSalidas>();
            this.tbRequerimientosEspeciales = new HashSet<tbRequerimientosEspeciales>();
            this.tbRequerimientosEspeciales1 = new HashSet<tbRequerimientosEspeciales>();
            this.tbRequerimientosEspecialesPersona = new HashSet<tbRequerimientosEspecialesPersona>();
            this.tbRequerimientosEspecialesPersona1 = new HashSet<tbRequerimientosEspecialesPersona>();
            this.tbRequerimientosEspecialesRequisicion = new HashSet<tbRequerimientosEspecialesRequisicion>();
            this.tbRequerimientosEspecialesRequisicion1 = new HashSet<tbRequerimientosEspecialesRequisicion>();
            this.tbRequisiciones = new HashSet<tbRequisiciones>();
            this.tbRequisiciones1 = new HashSet<tbRequisiciones>();
            this.tbSeleccionCandidatos = new HashSet<tbSeleccionCandidatos>();
            this.tbSeleccionCandidatos1 = new HashSet<tbSeleccionCandidatos>();
            this.tbSucursales = new HashSet<tbSucursales>();
            this.tbSucursales1 = new HashSet<tbSucursales>();
            this.tbSueldos = new HashSet<tbSueldos>();
            this.tbSueldos1 = new HashSet<tbSueldos>();
            this.tbTipoAmonestaciones = new HashSet<tbTipoAmonestaciones>();
            this.tbTipoAmonestaciones1 = new HashSet<tbTipoAmonestaciones>();
            this.tbTipoHoras = new HashSet<tbTipoHoras>();
            this.tbTipoHoras1 = new HashSet<tbTipoHoras>();
            this.tbTipoIncapacidades = new HashSet<tbTipoIncapacidades>();
            this.tbTipoIncapacidades1 = new HashSet<tbTipoIncapacidades>();
            this.tbTipoMonedas = new HashSet<tbTipoMonedas>();
            this.tbTipoMonedas1 = new HashSet<tbTipoMonedas>();
            this.tbTipoPermisos = new HashSet<tbTipoPermisos>();
            this.tbTipoPermisos1 = new HashSet<tbTipoPermisos>();
            this.tbTipoSalidas = new HashSet<tbTipoSalidas>();
            this.tbTipoSalidas1 = new HashSet<tbTipoSalidas>();
            this.tbTitulos = new HashSet<tbTitulos>();
            this.tbTitulos1 = new HashSet<tbTitulos>();
            this.tbTitulosPersona = new HashSet<tbTitulosPersona>();
            this.tbTitulosPersona1 = new HashSet<tbTitulosPersona>();
            this.tbTitulosRequisicion = new HashSet<tbTitulosRequisicion>();
            this.tbTitulosRequisicion1 = new HashSet<tbTitulosRequisicion>();
            this.tbDepartamento = new HashSet<tbDepartamento>();
            this.tbDepartamento1 = new HashSet<tbDepartamento>();
            this.tbMunicipio = new HashSet<tbMunicipio>();
            this.tbMunicipio1 = new HashSet<tbMunicipio>();
            this.tbMotivoLiquidacion = new HashSet<tbMotivoLiquidacion>();
            this.tbMotivoLiquidacion1 = new HashSet<tbMotivoLiquidacion>();
            this.tbPorcentajeMotivoLiquidacion = new HashSet<tbPorcentajeMotivoLiquidacion>();
            this.tbPorcentajeMotivoLiquidacion1 = new HashSet<tbPorcentajeMotivoLiquidacion>();
        }
    
        public int usu_Id { get; set; }
        public string usu_NombreUsuario { get; set; }
        public byte[] usu_Password { get; set; }
        public string usu_Nombres { get; set; }
        public string usu_Apellidos { get; set; }
        public string usu_Correo { get; set; }
        public bool usu_EsActivo { get; set; }
        public string usu_RazonInactivo { get; set; }
        public bool usu_EsAdministrador { get; set; }
        public Nullable<byte> usu_SesionesValidas { get; set; }
        public Nullable<int> suc_Id { get; set; }
        public Nullable<short> emp_Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbAccesoRol> tbAccesoRol { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbAccesoRol> tbAccesoRol1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbObjeto> tbObjeto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbObjeto> tbObjeto1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbRol> tbRol { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbRol> tbRol1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbRolesUsuario> tbRolesUsuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbRolesUsuario> tbRolesUsuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbRolesUsuario> tbRolesUsuario2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDeduccionImpuestoVecinal> tbDeduccionImpuestoVecinal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDeduccionImpuestoVecinal> tbDeduccionImpuestoVecinal1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPagoDeCesantiaDetalle> tbPagoDeCesantiaDetalle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPagoDeCesantiaDetalle> tbPagoDeCesantiaDetalle1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPagoDeCesantiaEncabezado> tbPagoDeCesantiaEncabezado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPagoDeCesantiaEncabezado> tbPagoDeCesantiaEncabezado1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTechoImpuestoVecinal> tbTechoImpuestoVecinal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTechoImpuestoVecinal> tbTechoImpuestoVecinal1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTechosComisiones> tbTechosComisiones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTechosComisiones> tbTechosComisiones1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbAcumuladosISR> tbAcumuladosISR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbAcumuladosISR> tbAcumuladosISR1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbAdelantoSueldo> tbAdelantoSueldo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbAdelantoSueldo> tbAdelantoSueldo1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbAFP> tbAFP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbAFP> tbAFP1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbAuxilioDeCesantias> tbAuxilioDeCesantias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbAuxilioDeCesantias> tbAuxilioDeCesantias1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCatalogoDeDeducciones> tbCatalogoDeDeducciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCatalogoDeDeducciones> tbCatalogoDeDeducciones1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCatalogoDeIngresos> tbCatalogoDeIngresos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCatalogoDeIngresos> tbCatalogoDeIngresos1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCatalogoDePlanillas> tbCatalogoDePlanillas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCatalogoDePlanillas> tbCatalogoDePlanillas1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDecimoCuartoMes> tbDecimoCuartoMes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDecimoCuartoMes> tbDecimoCuartoMes1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDecimoTercerMes> tbDecimoTercerMes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDecimoTercerMes> tbDecimoTercerMes1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDeduccionAFP> tbDeduccionAFP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDeduccionAFP> tbDeduccionAFP1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDeduccionesExtraordinarias> tbDeduccionesExtraordinarias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDeduccionesExtraordinarias> tbDeduccionesExtraordinarias1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDeduccionesIndividuales> tbDeduccionesIndividuales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDeduccionesIndividuales> tbDeduccionesIndividuales1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDeduccionInstitucionFinanciera> tbDeduccionInstitucionFinanciera { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDeduccionInstitucionFinanciera> tbDeduccionInstitucionFinanciera1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEmpleadoBonos> tbEmpleadoBonos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEmpleadoBonos> tbEmpleadoBonos1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEmpleadoComisiones> tbEmpleadoComisiones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEmpleadoComisiones> tbEmpleadoComisiones1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbFormaPago> tbFormaPago { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbFormaPago> tbFormaPago1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHistorialDeduccionPago> tbHistorialDeduccionPago { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHistorialDeduccionPago> tbHistorialDeduccionPago1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHistorialDeIngresosPago> tbHistorialDeIngresosPago { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHistorialDeIngresosPago> tbHistorialDeIngresosPago1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHistorialDePago> tbHistorialDePago { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHistorialDePago> tbHistorialDePago1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbIngresosIndividuales> tbIngresosIndividuales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbIngresosIndividuales> tbIngresosIndividuales1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbInstitucionesFinancieras> tbInstitucionesFinancieras { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbInstitucionesFinancieras> tbInstitucionesFinancieras1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbISR> tbISR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbISR> tbISR1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbLiquidacionVacaciones> tbLiquidacionVacaciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbLiquidacionVacaciones> tbLiquidacionVacaciones1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPeriodos> tbPeriodos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPeriodos> tbPeriodos1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPreaviso> tbPreaviso { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPreaviso> tbPreaviso1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTechosDeducciones> tbTechosDeducciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTechosDeducciones> tbTechosDeducciones1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTipoDeduccion> tbTipoDeduccion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTipoDeduccion> tbTipoDeduccion1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTipoPlanillaDetalleDeduccion> tbTipoPlanillaDetalleDeduccion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTipoPlanillaDetalleDeduccion> tbTipoPlanillaDetalleDeduccion1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTipoPlanillaDetalleIngreso> tbTipoPlanillaDetalleIngreso { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTipoPlanillaDetalleIngreso> tbTipoPlanillaDetalleIngreso1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbAreas> tbAreas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbAreas> tbAreas1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCargos> tbCargos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCargos> tbCargos1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCompetencias> tbCompetencias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCompetencias> tbCompetencias1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCompetenciasPersona> tbCompetenciasPersona { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCompetenciasPersona> tbCompetenciasPersona1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCompetenciasRequisicion> tbCompetenciasRequisicion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCompetenciasRequisicion> tbCompetenciasRequisicion1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDepartamentos> tbDepartamentos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDepartamentos> tbDepartamentos1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDirectoriosEmpleados> tbDirectoriosEmpleados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDirectoriosEmpleados> tbDirectoriosEmpleados1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEmpleados> tbEmpleados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEmpleados> tbEmpleados1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEmpresas> tbEmpresas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEmpresas> tbEmpresas1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEquipoEmpleados> tbEquipoEmpleados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEquipoEmpleados> tbEquipoEmpleados1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEquipoTrabajo> tbEquipoTrabajo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEquipoTrabajo> tbEquipoTrabajo1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbFaseSeleccion> tbFaseSeleccion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbFaseSeleccion> tbFaseSeleccion1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbFasesReclutamiento> tbFasesReclutamiento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbFasesReclutamiento> tbFasesReclutamiento1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHabilidades> tbHabilidades { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHabilidades> tbHabilidades1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHabilidadesPersona> tbHabilidadesPersona { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHabilidadesPersona> tbHabilidadesPersona1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHabilidadesRequisicion> tbHabilidadesRequisicion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHabilidadesRequisicion> tbHabilidadesRequisicion1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHistorialAmonestaciones> tbHistorialAmonestaciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHistorialAmonestaciones> tbHistorialAmonestaciones1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHistorialAudienciaDescargo> tbHistorialAudienciaDescargo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHistorialAudienciaDescargo> tbHistorialAudienciaDescargo1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHistorialCargos> tbHistorialCargos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHistorialCargos> tbHistorialCargos1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHistorialContrataciones> tbHistorialContrataciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHistorialContrataciones> tbHistorialContrataciones1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHistorialHorasTrabajadas> tbHistorialHorasTrabajadas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHistorialHorasTrabajadas> tbHistorialHorasTrabajadas1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHistorialIncapacidades> tbHistorialIncapacidades { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHistorialIncapacidades> tbHistorialIncapacidades1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHistorialPermisos> tbHistorialPermisos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHistorialPermisos> tbHistorialPermisos1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHistorialRefrendamientos> tbHistorialRefrendamientos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHistorialRefrendamientos> tbHistorialRefrendamientos1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHistorialSalidas> tbHistorialSalidas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHistorialSalidas> tbHistorialSalidas1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHistorialVacaciones> tbHistorialVacaciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHistorialVacaciones> tbHistorialVacaciones1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHorarios> tbHorarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHorarios> tbHorarios1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbIdiomaPersona> tbIdiomaPersona { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbIdiomaPersona> tbIdiomaPersona1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbIdiomas> tbIdiomas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbIdiomas> tbIdiomas1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbIdiomasRequisicion> tbIdiomasRequisicion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbIdiomasRequisicion> tbIdiomasRequisicion1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbJornadas> tbJornadas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbJornadas> tbJornadas1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbNacionalidades> tbNacionalidades { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbNacionalidades> tbNacionalidades1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPersonas> tbPersonas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPersonas> tbPersonas1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbRazonSalidas> tbRazonSalidas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbRazonSalidas> tbRazonSalidas1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbRequerimientosEspeciales> tbRequerimientosEspeciales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbRequerimientosEspeciales> tbRequerimientosEspeciales1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbRequerimientosEspecialesPersona> tbRequerimientosEspecialesPersona { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbRequerimientosEspecialesPersona> tbRequerimientosEspecialesPersona1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbRequerimientosEspecialesRequisicion> tbRequerimientosEspecialesRequisicion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbRequerimientosEspecialesRequisicion> tbRequerimientosEspecialesRequisicion1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbRequisiciones> tbRequisiciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbRequisiciones> tbRequisiciones1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSeleccionCandidatos> tbSeleccionCandidatos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSeleccionCandidatos> tbSeleccionCandidatos1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSucursales> tbSucursales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSucursales> tbSucursales1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSueldos> tbSueldos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSueldos> tbSueldos1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTipoAmonestaciones> tbTipoAmonestaciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTipoAmonestaciones> tbTipoAmonestaciones1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTipoHoras> tbTipoHoras { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTipoHoras> tbTipoHoras1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTipoIncapacidades> tbTipoIncapacidades { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTipoIncapacidades> tbTipoIncapacidades1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTipoMonedas> tbTipoMonedas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTipoMonedas> tbTipoMonedas1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTipoPermisos> tbTipoPermisos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTipoPermisos> tbTipoPermisos1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTipoSalidas> tbTipoSalidas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTipoSalidas> tbTipoSalidas1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTitulos> tbTitulos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTitulos> tbTitulos1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTitulosPersona> tbTitulosPersona { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTitulosPersona> tbTitulosPersona1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTitulosRequisicion> tbTitulosRequisicion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTitulosRequisicion> tbTitulosRequisicion1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDepartamento> tbDepartamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDepartamento> tbDepartamento1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbMunicipio> tbMunicipio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbMunicipio> tbMunicipio1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbMotivoLiquidacion> tbMotivoLiquidacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbMotivoLiquidacion> tbMotivoLiquidacion1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPorcentajeMotivoLiquidacion> tbPorcentajeMotivoLiquidacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPorcentajeMotivoLiquidacion> tbPorcentajeMotivoLiquidacion1 { get; set; }
    }
}
