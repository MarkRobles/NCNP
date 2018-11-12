using NCNP.DataContext;
using NCNP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NCNP.Clases
{
    public class clsPacientes : iCRUD<Pacientes>
    {

        NCNPEntities db = new NCNPEntities();
        public void CrudT(Pacientes value, ECrud Accion)
        {
            //db.CRUDPaciente(
            //    value.Id,
            //    value.Nombre,
            //    value.ApellidoPaterno,
            //    value.ApellidoMaterno,
            //    value.FechaNacimiento,
            //    value.Edad,
            //    value.Genero,
            //    value.Escolaridad,
            //    value.Correo,
            //    value.Calle,
            //    value.NumeroExterior,
            //    value.NumeroInterior,
            //    value.Colonia,
            //    value.Municipio,
            //    value.Estado,
            //    value.CodigoPostal,
            //    value.Telefono,
            //    value.Ocupacion,
            //    value.HorarioLaboral,
            //    value.Hijos,
            //    value.Notas,
            //    value.RFC, (short)Accion);
        }

        public Pacientes GetT(Pacientes value)
        {
            return db.GetPaciente(value.Id).ToList().Select(x => new Pacientes
            {
                Nombre = x.vchNombre,
                ApellidoPaterno = x.vchApellidoPaterno,
                ApellidoMaterno = x.vchApellidoPaterno,
                FechaNacimiento = x.dtmFechaNacimiento,
                Edad = x.tIntEdad,
                Genero = x.vchGenero,
                Escolaridad = x.vchEscolaridad,
                Correo = x.vchCorreo,
                Calle = x.vchCalle,
                NumeroExterior = x.intNumeroExterior,
                NumeroInterior = x.intNumeroInterior,
                Colonia = x.vchColonia,
                Municipio = x.vchMunicipio,
                Estado = x.vchEstado,
                CodigoPostal = x.vchCodigoPostal,
                Telefono = x.vchTelefono,
                Ocupacion = x.vchOcupacion,
                HorarioLaboral = x.vchHorarioLaboral,
                Hijos = x.tIntHijos,
                Notas = x.vchNotas,
                RFC = x.vchRFC
            }).ToList().First();
        }

        public List<Pacientes> GetTs()
        {
            return db.GetPaciente(null).ToList().Select(x => new Pacientes
            {
                Id = x.unqCATPacienteKey,
                Nombre = x.vchNombre,
                ApellidoPaterno = x.vchApellidoPaterno,
                ApellidoMaterno = x.vchApellidoPaterno,
                FechaNacimiento = x.dtmFechaNacimiento,
                Edad = x.tIntEdad,
                Genero = x.vchGenero,
                Escolaridad = x.vchEscolaridad,
                Correo = x.vchCorreo,
                Calle = x.vchCalle,
                NumeroExterior = x.intNumeroExterior,
                NumeroInterior = x.intNumeroInterior,
                Colonia = x.vchColonia,
                Municipio = x.vchMunicipio,
                Estado = x.vchEstado,
                CodigoPostal = x.vchCodigoPostal,
                Telefono = x.vchTelefono,
                Ocupacion = x.vchOcupacion,
                HorarioLaboral = x.vchHorarioLaboral,
                Hijos = x.tIntHijos,
                Notas = x.vchNotas
            }).ToList();
        }
    }
}