using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos
{
    public class BdUltimoJob
    {
        public string EjecutarSp_UltimoJob()
        {
            string fecha = "Contacte con personal IT";
            try
            {
                using (BD_MATERIALESEntities db = new BD_MATERIALESEntities())
                {
                    ObjectResult<string> respuesta = db.SP_HORA_ULT_JOB_CORRECTO();
                    if (respuesta != null)
                    {
                        fecha = respuesta.SingleOrDefault();
                    }
                }
            }
            catch (Exception)
            {
                //throw;
            }
            return fecha;
        }
    }
}