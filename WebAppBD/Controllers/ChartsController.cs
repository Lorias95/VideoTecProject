using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace WebAppBD.Controllers
{
    public class ChartsController : Controller
    {
        public IActionResult Index()
        {
            return View();
            
        }

        public string obtenerDatos()
        {
            SqlConnection connectionSQL = new SqlConnection(
            "Data Source=DESKTOP-1CH3FMA\\SQLEXPRESS;Initial Catalog=VIDEOTEC;" +
            "User ID=Sap;Trusted_Connection=True;MultipleActiveResultSets=true");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "CantPeliPrestDevu";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = connectionSQL;
            connectionSQL.Open();


            DataTable Datos = new DataTable();
            Datos.Load(cmd.ExecuteReader());
            connectionSQL.Close();

            //Datos.Columns.Add(new DataColumn("PeliPrestada", typeof(string)));
            //Datos.Columns.Add(new DataColumn("PeliDevuelta", typeof(string)));

            //Datos.Rows.Add(new object[] { "PeliPrestadas", 11 });
            //Datos.Rows.Add(new object[] { "PeliDevuelta", 11 });

            string strDatos;

            strDatos = "[['PeliPrestada', 'PeliDevuelta']]";

            foreach(DataRow dr in Datos.Rows)
            {
                strDatos = strDatos + "[";
                strDatos = strDatos + "'" + dr[0] + "'" + "," + dr[1]  ;
                strDatos = strDatos + "]";
            }

            strDatos = strDatos + "]";
            return strDatos;
        }
    }
}
