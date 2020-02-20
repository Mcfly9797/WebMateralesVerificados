using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;


namespace Negocio
{
    public class TraerUltimoJobNegocio
    {


        public string TraerUltimoJob()
        {
            try
            {
                return new BdUltimoJob().EjecutarSp_UltimoJob();
            }
            catch (Exception)
            {
                return "Consulte personal IT";
                throw;
            }
            
        }
    }
}
