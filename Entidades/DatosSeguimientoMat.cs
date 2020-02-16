using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DatosSeguimientoMat
    {




        public DatosSeguimientoMat()
        {
        }

        public DatosSeguimientoMat(int id, string buildingmachine, string buildingsize, DateTime verifydatetime,
                                   int bsdateshift, int buildinglotno, int builder1, string materialbarcodeno,
                                   int partiid, string partname, string partnumber, DateTime dateproduced,
                                   decimal remain, string machineproduced, string machinename)
        {
            this.Id = id;
            this.BuildingMachine = buildingmachine;
            this.BuildingSize = buildingsize;
            this.VerifyDateTime = verifydatetime.ToString("MM/dd/yyyy");
            this.BSDateShift = bsdateshift;
            this.BuildingLotNo = buildinglotno;
            this.Builder1 = builder1;
            this.MaterialBarcodeNo = materialbarcodeno;
            this.PartIID = partiid;
            this.PartName = partname;
            this.PartNumber = partnumber;
            this.DateProduced = dateproduced.ToString("MM/dd/yyyy");
            this.Remain = remain;
            this.MachineProduced = machineproduced;
            this.MachineName = machinename;
         }

        public int Id { get; set; }
        public string BuildingMachine { get; set; }
        public string BuildingSize { get; set; }
        public string VerifyDateTime { get; set; }
        public int? BSDateShift { get; set; }
        public int? BuildingLotNo { get; set; }
        public int? Builder1 { get; set; }
        public string MaterialBarcodeNo { get; set; }
        public int? PartIID { get; set; }
        public string PartName { get; set; }
        public string PartNumber { get; set; }
        public string DateProduced { get; set; }
        public Nullable<decimal> Remain { get; set; }
        public string MachineProduced { get; set; }
        public string MachineName { get; set; }

    }
}
