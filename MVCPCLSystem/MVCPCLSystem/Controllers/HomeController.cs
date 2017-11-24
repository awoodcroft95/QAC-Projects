using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPCLSystem.Models;
using System.Data.SqlClient;

namespace MVCPCLSystem.Controllers
{
    public class HomeController : Controller
    {
        public SqlCommand getDB()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\Documents\\AWCSharpProjects\\MVCPCLSystem\\MVCPCLSystem\\App_Data\\PCLDatabase.mdf;Integrated Security=True";
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            return cmd;
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddNewRecord()
        {
            return View();
        }

        public ActionResult InsertRecord(Info x)
        {
            SqlCommand cmd = getDB();
            cmd.CommandText = $"insert into AccountHolder values('{x.name}', '{x.address}', '{x.phoneNo}')";
            int a = cmd.ExecuteNonQuery();
            if (a == 0)
            {
                return View("failedInsert");
            }
            else
            {
                return View("Index");
            }
        }

        public ActionResult DeleteRecord(int id)
        {
            SqlCommand cmd = getDB();
            cmd.CommandText = $"delete from AccountHolder where PID = '{id}'";
            cmd.ExecuteNonQuery();
            return View("Index");
        }

        public ActionResult EditRecordForm(int id)
        {
            Info edit = new Info();
            SqlCommand cmd = getDB();
            cmd.CommandText = $"select * from AccountHolder where PID = '{id}'";
            SqlDataReader data = cmd.ExecuteReader();
            if (data.Read())
            {
                edit.PID = Int32.Parse(data["PID"].ToString());
                edit.name = data["Name"].ToString();
                edit.address = data["Address"].ToString();
                edit.phoneNo = Int32.Parse(data["Phone"].ToString());
            }
            return View("EditRecordForm", edit);
        }

        public ActionResult EditRecord(Info x)
        {
            SqlCommand cmd = getDB();
            cmd.CommandText = $"update AccountHolder set Name = '{x.name}', Address = '{x.address}', Phone = '{x.phoneNo}' where PID = '{x.PID}'";
            cmd.ExecuteNonQuery();
            return View("Index");
        }
    }
}