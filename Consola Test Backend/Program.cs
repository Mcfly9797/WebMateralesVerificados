using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
using Negocio;

namespace Consola_Test_Backend
{
    class Program
    {
        static void Main(string[] args)
        {



            //MostrarSoportistas();
            Console.WriteLine("--------------------------");
            //MostrarSalones();
            //Console.WriteLine("--------------------------");
            //CrearRecorrida();
            //Console.WriteLine("--------------------------");
            MostrarDatos();


            Console.Write("Press <Enter> to exit... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }



            void MostrarDatos()
            {
                List<DatosSeguimientoMat> datosSeguimientoConsola = new TraerDatosMaterialesMaquina().TraerDatos() ;

                using (BD_MATERIALESEntities db = new BD_MATERIALESEntities())
                {
                    //var lst = db.SP_TRAER_DATOS();

                    foreach (var Elemento in datosSeguimientoConsola)
                    {


                        Console.WriteLine("---Recorrida "+Elemento.Id+"--------");
                        Console.WriteLine(Elemento.BuildingMachine);
                        Console.WriteLine(Elemento.BuildingSize);
                        Console.WriteLine(Elemento.VerifyDateTime);
                        Console.WriteLine(Elemento.BSDateShift);
                        Console.WriteLine(Elemento.BuildingLotNo);

                        Console.WriteLine(Elemento.Builder1);
                        Console.WriteLine(Elemento.MaterialBarcodeNo);
                        Console.WriteLine(Elemento.PartIID);
                        Console.WriteLine(Elemento.PartName);
                        Console.WriteLine(Elemento.PartNumber);

                        Console.WriteLine(Elemento.DateProduced);
                        Console.WriteLine(Elemento.Remain);
                        Console.WriteLine(Elemento.MachineProduced);
                        Console.WriteLine(Elemento.MachineName);

                        Console.WriteLine("--------------------------");
                    }

                }
            }

            //void CrearRecorrida()
            //{

            //    using (BD_MATERIALESEntities db = new BD_MATERIALESEntities())
            //    {
            //        db.sp_nueva_recorrida(1, 1, "Ninguno");
            //    }
            //}



            //void MostrarSoportistas()
            //{

            //    using (BD_MATERIALESEntities db = new BD_MATERIALESEntities())
            //    {
            //        var lst = db.tb_user_it;
            //        foreach (var Elemento in lst)
            //        {
            //            Console.WriteLine(Elemento.id);
            //            Console.WriteLine(Elemento.nombre_user);
            //        }

            //    }
            //}

            //void MostrarSalones()
            //{

            //    using (BD_MATERIALESEntities db = new BD_MATERIALESEntities())
            //    {
            //        var lst = db.tb_salon;
            //        foreach (var Elemento in lst)
            //        {

            //            Console.WriteLine(Elemento.id);
            //            Console.WriteLine(Elemento.nombre_salon);
            //        }

            //    }
            //}




        }

        
        
    }
}


