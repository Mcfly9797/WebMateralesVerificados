using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;



namespace Datos
{
    public class BdTraerMatMaq
    {
        public List<DatosSeguimientoMat> TraerMatMaq()
        {
           List<DatosSeguimientoMat> listadatos = new List<DatosSeguimientoMat>();
            using (BD_MATERIALESEntities db = new BD_MATERIALESEntities())
            {
                DateTime auxfecha;
                var lst = db.SP_TRAER_DATOS();
                foreach (var Elemento in lst)
                {
                    DatosSeguimientoMat datos = new DatosSeguimientoMat();
                    datos.Id = Elemento.ID;
                    datos.BuildingMachine = Elemento.BUILDINGMACHINE;
                    datos.BuildingSize = Elemento.BUILDINGSIZE;
                    //convierto datetime to string recortando la hora
                    datos.VerifyDateTime = Elemento.VERIFYDATETIME.ToString()/*.Substring(0,10)*/;
                    datos.BSDateShift = Elemento.BSDATESHIFT;
                    datos.BuildingLotNo = Elemento.BUILDINGLOTNO;
                    datos.Builder1 = Elemento.BUILDER1;
                    datos.MaterialBarcodeNo = Elemento.MATERIALBARCODENO;
                    datos.PartIID = Elemento.PARTIID;
                    datos.PartName = Elemento.PARTNAME;
                    datos.PartNumber = Elemento.PARTNUMBER;
                    //convierto datetime to string recortando la hora
                    datos.DateProduced = Elemento.DATEPRODUCED.ToString()/*.Substring(0,10)*/;
                    datos.Remain = Elemento.REMAIN;
                    datos.MachineProduced = Elemento.MACHINEPRODUCED;
                    datos.MachineName = Elemento.MACHINENAME;

                    listadatos.Add(datos);
                }
            }
            return listadatos;
        }


        public List<DatosSeguimientoMat> TraerMatMaq(DateTime DateStart, DateTime DateFinish)
        {
            List<DatosSeguimientoMat> listadatos = new List<DatosSeguimientoMat>();
            using (BD_MATERIALESEntities db = new BD_MATERIALESEntities())
            {
                DateTime auxfecha;
                var lst = db.SP_TRAER_DATOS_FECHAS(DateStart, DateFinish);
                foreach (var Elemento in lst)
                {
                    DatosSeguimientoMat datos = new DatosSeguimientoMat();
                    datos.Id = Elemento.ID;
                    datos.BuildingMachine = Elemento.BUILDINGMACHINE;
                    datos.BuildingSize = Elemento.BUILDINGSIZE;
                    //convierto datetime to string recortando la hora
                    datos.VerifyDateTime = Elemento.VERIFYDATETIME.ToString()/*.Substring(0,10)*/;
                    datos.BSDateShift = Elemento.BSDATESHIFT;
                    datos.BuildingLotNo = Elemento.BUILDINGLOTNO;
                    datos.Builder1 = Elemento.BUILDER1;
                    datos.MaterialBarcodeNo = Elemento.MATERIALBARCODENO;
                    datos.PartIID = Elemento.PARTIID;
                    datos.PartName = Elemento.PARTNAME;
                    datos.PartNumber = Elemento.PARTNUMBER;
                    //convierto datetime to string recortando la hora
                    datos.DateProduced = Elemento.DATEPRODUCED.ToString()/*.Substring(0,10)*/;
                    datos.Remain = Elemento.REMAIN;
                    datos.MachineProduced = Elemento.MACHINEPRODUCED;
                    datos.MachineName = Elemento.MACHINENAME;

                    listadatos.Add(datos);
                }
            }
            return listadatos;
        }
    }
}
