using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;
using Negocio;
using Entidades;
using System.Web.Services;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text;
using System.Globalization;

namespace Web
{
    public partial class index1 : System.Web.UI.Page
    {
        [System.ComponentModel.Browsable(false)]
        public bool IsPostback { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //Si no hay postback
            if (!IsPostback)
            {

                /*
                LlenarSoportistas();
                LlenarSalones();
                */

                Validate();
            }
        }






        [WebMethod]
        public static object getMateriales()
        {
            List<DatosSeguimientoMat> lista = new TraerDatosMaterialesMaquina().TraerDatos();

            object json = new { data = lista };

            return json;
        }


        //Objeto que uso para las fechas
       

        [WebMethod]
        public static object getMaterialesFecha(Fechas objFechas)
        {
            try
            {
                    List<DatosSeguimientoMat> lista = new TraerDatosMaterialesMaquina().TraerDatos(Convert.ToDateTime(objFechas.inicio), Convert.ToDateTime(objFechas.fin));


                    object json = new { data = lista };

                    return json;
            }
            catch (Exception)
            {


                throw;
            }
            
        }



        [WebMethod]
        public static object getUltimoJob()
        {
            string respuesta = new TraerUltimoJobNegocio().TraerUltimoJob();


            object json = new { data = respuesta };

            return json;

            //return respuesta;
        }






    }
}