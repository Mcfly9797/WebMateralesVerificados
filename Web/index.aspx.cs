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


        public class fechas
        {

            public string inicio { get; set; }
            public string fin { get; set; }

        }






        [WebMethod]
        public static object getMaterialesFecha(fechas objFechas)
        {
            try
            {

                //if (objFechas.inicio != null & objFechas.fin != null)
                //{
                    

                    //fechas objFechasAux = objFechas;

                    ////DateTime auxd, auxe = new DateTime();
                    //string timeaux = objFechasAux.inicio;
                    //string timeaux1 = objFechasAux.fin;


                    DateTime DD = Convert.ToDateTime(objFechas.inicio);
                    DateTime DE = Convert.ToDateTime(objFechas.fin);


                    List<DatosSeguimientoMat> lista = new TraerDatosMaterialesMaquina().TraerDatos(Convert.ToDateTime(objFechas.inicio), Convert.ToDateTime(objFechas.fin));


                    object json = new { data = lista };

                    return json;


                  
                //}
              
            }
            catch (Exception)
            {


                throw;
            }
            
        }



    }
}