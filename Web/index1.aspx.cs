﻿using System;
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


namespace Web
{
    public partial class index : System.Web.UI.Page
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
        public static object getUsers()
        {
            List<DatosSeguimientoMat> lista = new TraerDatosMaterialesMaquina().TraerDatos();

            object json = new { data = lista };

            return json;
        }




        protected void BtnNuevaRecorrida_Click(object sender, System.EventArgs e)
        {
            //agregar verificacion de los campos seleccionados
        }


    }
}