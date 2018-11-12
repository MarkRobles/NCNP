using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NCNP.Clases
{

    //La interfaz es para darle el mismo estandar a nuestras clases
    interface iCRUD<T>where T:class
    {

        //Devuelve un valor
        T GetT(T value);

        //Devuelve la lista
        List<T> GetTs();

        //Mantenimiento
        void CrudT(T value, ECrud Accion);
    }
}