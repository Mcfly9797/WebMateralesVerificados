using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;


namespace Negocio
{
    public class TraerDatosMaterialesMaquina
    {


        public List<DatosSeguimientoMat> TraerDatos()
        {

            List<DatosSeguimientoMat> datosSeguimiento = new List<DatosSeguimientoMat>( new BdTraerMatMaq().TraerMatMaq());

            return datosSeguimiento;


        }

        public List<DatosSeguimientoMat> TraerDatos(DateTime DateStart, DateTime DateFinish)
        {

            List<DatosSeguimientoMat> datosSeguimiento = new List<DatosSeguimientoMat>(new BdTraerMatMaq().TraerMatMaq(DateStart, DateFinish));

            return datosSeguimiento;


        }
    }
}
