﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NCNP.DataContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class NCNPEntities : DbContext
    {
        public NCNPEntities()
            : base("name=NCNPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Paciente> Paciente { get; set; }
    
        public virtual int CRUDPaciente(Nullable<System.Guid> unqCATPacienteKey, string vchNombre, string vchApellidoPaterno, string vchApellidoMaterno, Nullable<System.DateTime> dtmFechaNacimiento, Nullable<byte> tintEdad, string vchGenero, string vchEscolaridad, string vchCorreo, string vchCalle, Nullable<int> intNumeroExterior, Nullable<int> intNumeroInterior, string vchColonia, string vchMunicipio, string vchEstado, string vchCodigoPostal, string vchTelefono, string vchOcupacion, string vchHorarioLaboral, Nullable<byte> tintHijos, string vchNotas, string vchRFC, Nullable<bool> bitActivo, Nullable<short> accion)
        {
            var unqCATPacienteKeyParameter = unqCATPacienteKey.HasValue ?
                new ObjectParameter("unqCATPacienteKey", unqCATPacienteKey) :
                new ObjectParameter("unqCATPacienteKey", typeof(System.Guid));
    
            var vchNombreParameter = vchNombre != null ?
                new ObjectParameter("vchNombre", vchNombre) :
                new ObjectParameter("vchNombre", typeof(string));
    
            var vchApellidoPaternoParameter = vchApellidoPaterno != null ?
                new ObjectParameter("vchApellidoPaterno", vchApellidoPaterno) :
                new ObjectParameter("vchApellidoPaterno", typeof(string));
    
            var vchApellidoMaternoParameter = vchApellidoMaterno != null ?
                new ObjectParameter("vchApellidoMaterno", vchApellidoMaterno) :
                new ObjectParameter("vchApellidoMaterno", typeof(string));
    
            var dtmFechaNacimientoParameter = dtmFechaNacimiento.HasValue ?
                new ObjectParameter("dtmFechaNacimiento", dtmFechaNacimiento) :
                new ObjectParameter("dtmFechaNacimiento", typeof(System.DateTime));
    
            var tintEdadParameter = tintEdad.HasValue ?
                new ObjectParameter("tintEdad", tintEdad) :
                new ObjectParameter("tintEdad", typeof(byte));
    
            var vchGeneroParameter = vchGenero != null ?
                new ObjectParameter("vchGenero", vchGenero) :
                new ObjectParameter("vchGenero", typeof(string));
    
            var vchEscolaridadParameter = vchEscolaridad != null ?
                new ObjectParameter("vchEscolaridad", vchEscolaridad) :
                new ObjectParameter("vchEscolaridad", typeof(string));
    
            var vchCorreoParameter = vchCorreo != null ?
                new ObjectParameter("vchCorreo", vchCorreo) :
                new ObjectParameter("vchCorreo", typeof(string));
    
            var vchCalleParameter = vchCalle != null ?
                new ObjectParameter("vchCalle", vchCalle) :
                new ObjectParameter("vchCalle", typeof(string));
    
            var intNumeroExteriorParameter = intNumeroExterior.HasValue ?
                new ObjectParameter("intNumeroExterior", intNumeroExterior) :
                new ObjectParameter("intNumeroExterior", typeof(int));
    
            var intNumeroInteriorParameter = intNumeroInterior.HasValue ?
                new ObjectParameter("intNumeroInterior", intNumeroInterior) :
                new ObjectParameter("intNumeroInterior", typeof(int));
    
            var vchColoniaParameter = vchColonia != null ?
                new ObjectParameter("vchColonia", vchColonia) :
                new ObjectParameter("vchColonia", typeof(string));
    
            var vchMunicipioParameter = vchMunicipio != null ?
                new ObjectParameter("vchMunicipio", vchMunicipio) :
                new ObjectParameter("vchMunicipio", typeof(string));
    
            var vchEstadoParameter = vchEstado != null ?
                new ObjectParameter("vchEstado", vchEstado) :
                new ObjectParameter("vchEstado", typeof(string));
    
            var vchCodigoPostalParameter = vchCodigoPostal != null ?
                new ObjectParameter("vchCodigoPostal", vchCodigoPostal) :
                new ObjectParameter("vchCodigoPostal", typeof(string));
    
            var vchTelefonoParameter = vchTelefono != null ?
                new ObjectParameter("vchTelefono", vchTelefono) :
                new ObjectParameter("vchTelefono", typeof(string));
    
            var vchOcupacionParameter = vchOcupacion != null ?
                new ObjectParameter("vchOcupacion", vchOcupacion) :
                new ObjectParameter("vchOcupacion", typeof(string));
    
            var vchHorarioLaboralParameter = vchHorarioLaboral != null ?
                new ObjectParameter("vchHorarioLaboral", vchHorarioLaboral) :
                new ObjectParameter("vchHorarioLaboral", typeof(string));
    
            var tintHijosParameter = tintHijos.HasValue ?
                new ObjectParameter("tintHijos", tintHijos) :
                new ObjectParameter("tintHijos", typeof(byte));
    
            var vchNotasParameter = vchNotas != null ?
                new ObjectParameter("vchNotas", vchNotas) :
                new ObjectParameter("vchNotas", typeof(string));
    
            var vchRFCParameter = vchRFC != null ?
                new ObjectParameter("vchRFC", vchRFC) :
                new ObjectParameter("vchRFC", typeof(string));
    
            var bitActivoParameter = bitActivo.HasValue ?
                new ObjectParameter("bitActivo", bitActivo) :
                new ObjectParameter("bitActivo", typeof(bool));
    
            var accionParameter = accion.HasValue ?
                new ObjectParameter("Accion", accion) :
                new ObjectParameter("Accion", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CRUDPaciente", unqCATPacienteKeyParameter, vchNombreParameter, vchApellidoPaternoParameter, vchApellidoMaternoParameter, dtmFechaNacimientoParameter, tintEdadParameter, vchGeneroParameter, vchEscolaridadParameter, vchCorreoParameter, vchCalleParameter, intNumeroExteriorParameter, intNumeroInteriorParameter, vchColoniaParameter, vchMunicipioParameter, vchEstadoParameter, vchCodigoPostalParameter, vchTelefonoParameter, vchOcupacionParameter, vchHorarioLaboralParameter, tintHijosParameter, vchNotasParameter, vchRFCParameter, bitActivoParameter, accionParameter);
        }
    
        public virtual ObjectResult<GetPaciente_Result> GetPaciente(Nullable<System.Guid> unqCATPacienteKey)
        {
            var unqCATPacienteKeyParameter = unqCATPacienteKey.HasValue ?
                new ObjectParameter("unqCATPacienteKey", unqCATPacienteKey) :
                new ObjectParameter("unqCATPacienteKey", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetPaciente_Result>("GetPaciente", unqCATPacienteKeyParameter);
        }
    }
}
