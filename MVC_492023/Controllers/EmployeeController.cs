using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;

namespace MVC_492023.Controllers
{
    public class EmployeeController : Controller
    {
        SqlConnection con = new SqlConnection("data source=DESKTOP-IOJE25P\\SQLEXPRESS;initial catalog=MVC_492023;integrated security=true");
        public ActionResult EmployeeForm()
        {
            return View();
        }


        public void EmployeeData(string A, int B, int C)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("employeeInsert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name",A);
            cmd.Parameters.AddWithValue("@salary",B);
            cmd.Parameters.AddWithValue("@age",C);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}