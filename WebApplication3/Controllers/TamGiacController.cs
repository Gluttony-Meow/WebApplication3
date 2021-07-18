using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class TamGiacController : Controller
    {
        // GET: TamGiac
        public ActionResult Index()
        {
            return View();
        }
        SqlConnection con = new SqlConnection($"Data Source=DESKTOP-GBBCS2R;Initial Catalog=linhh;Integrated Security=True");

        public ActionResult Triangle(string soA,string soB, string soC) {
            int A = Convert.ToInt32(soA);
            int B = Convert.ToInt32(soB);
            int C = Convert.ToInt32(soC);

            string sql = "insert into CheckTriangle(soA,soB,soC) values (@soA,@soB,@soC)";
            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = CommandType.Text;
            com.Parameters.AddWithValue("@soA", A);
            com.Parameters.AddWithValue("@soA", B);
            com.Parameters.AddWithValue("@soC", C);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            return View();
        }
    }
}