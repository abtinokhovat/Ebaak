using Ebaak.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;

namespace Ebaak.Controllers
{
    public class ApplicationController : Controller
    {
        static string JSONresult;

        // GET: Application
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult FillOption()
        {
            DataTable dt = ReadExcel();
            DataView dv = new DataView(dt);
            DataTable dt1 = dv.ToTable(true, "F11");
            string json = JsonConvert.SerializeObject(dt1);
            return Json(json, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetData(string search)
        {
            int k = 0;
            DataTable dt = ReadExcel();
            JSONresult = JsonConvert.SerializeObject(dt);
            Excelformat[] b = JsonConvert.DeserializeObject<Excelformat[]>(JSONresult);
            for (int i = 0; i < b.Length; i++)
            {
                string result = b[i].DocumentNo;

                if (search == result)
                {
                    k = i;
                }

            }
            return Json(b[k],JsonRequestBehavior.AllowGet);


        }

        public DataTable ReadExcel()
        {
            string path = HostingEnvironment.ApplicationPhysicalPath;
            string conn = string.Empty;
            DataTable dt = new DataTable();
            conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @"\sample.xlsx" + ";Extended Properties='Excel 12.0;HDR=NO';"; //for above excel 2007  
            using (OleDbConnection con = new OleDbConnection(conn))
            {
                try
                {
                    OleDbDataAdapter oleAdpt = new OleDbDataAdapter("select * from [Sheet1$]", con); //here we read data from sheet1  
                    oleAdpt.Fill(dt); //fill excel data into dataTable 
                }
                catch (Exception ex)
                {
                    string a = ex.Message;
                    throw;
                }
                     
                
            }
            return dt;
        }
    }
}