using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using MySql.Data.MySqlClient;
using UtilityControllers.Models;

namespace UtilityControllers.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api")]
    public class UtilityController : ApiController
    {
        [Route("UtilityData/ZipCodeData/{zipcode}")]
        [HttpGet]
        public IHttpActionResult getZipCodeData(string zipcode)
        {
            List<zipcodedata> result = new List<zipcodedata>();
            DBConnector.DBConnector conn = new DBConnector.DBConnector();
            string SQLString;
            if (conn.OpenConnection())
            {

                if (!string.IsNullOrEmpty(zipcode))
                {
                    MySqlCommand qExe = new MySqlCommand();
                    qExe.Connection = conn.connection;
                    SQLString = @"select * from zip_data where zipcode = '" + zipcode + "'";
                    qExe.CommandText = SQLString;
                    MySqlDataReader dataReader = qExe.ExecuteReader();
                    while (dataReader.Read())
                    {
                        zipcodedata detail = new zipcodedata();
                        detail.province = dataReader["province"].ToString();
                        detail.amphur = dataReader["amphur"].ToString();
                        detail.tambon = dataReader["tambon"].ToString();
                        detail.zipcode = dataReader["zipcode"].ToString();
                        result.Add(detail);
                    }
                }
                return Json(result);
            }
            else
            {
                return BadRequest("Database connect fail!");
            }
        }
        [Route("UtilityData/ProvinceData")]
        [HttpGet]
        public IHttpActionResult getProvinceData()
        {
            List<zipcodedata> result = new List<zipcodedata>();
            DBConnector.DBConnector conn = new DBConnector.DBConnector();
            string SQLString;
            if (conn.OpenConnection())
            {
                MySqlCommand qExe = new MySqlCommand();
                qExe.Connection = conn.connection;
                SQLString = @"select distinct province from zip_data order by province";
                qExe.CommandText = SQLString;
                MySqlDataReader dataReader = qExe.ExecuteReader();
                while (dataReader.Read())
                {
                    zipcodedata detail = new zipcodedata();
                    detail.province = dataReader["province"].ToString();
                    detail.amphur = "";
                    detail.tambon = "";
                    detail.zipcode = "";
                    result.Add(detail);
                }
                return Json(result);
            }
            else
            {
                return BadRequest("Database connect fail!");
            }
        }
        [Route("UtilityData/AmphurData/{province}")]
        [HttpGet]
        public IHttpActionResult getAmphurData(string province)
        {
            List<zipcodedata> result = new List<zipcodedata>();
            DBConnector.DBConnector conn = new DBConnector.DBConnector();
            string SQLString;
            if (conn.OpenConnection())
            {
                MySqlCommand qExe = new MySqlCommand();
                qExe.Connection = conn.connection;
                SQLString = @"select distinct province, amphur from zip_data where province = '" + province + @"' order by amphur";
                qExe.CommandText = SQLString;
                MySqlDataReader dataReader = qExe.ExecuteReader();
                while (dataReader.Read())
                {
                    zipcodedata detail = new zipcodedata();
                    detail.province = dataReader["province"].ToString();
                    detail.amphur = dataReader["amphur"].ToString();
                    detail.tambon = "";
                    detail.zipcode = "";
                    result.Add(detail);
                }
                return Json(result);
            }
            else
            {
                return BadRequest("Database connect fail!");
            }
        }
        [Route("UtilityData/TambonData/{province}/{amphur}")]
        [HttpGet]
        public IHttpActionResult getTambonData(string province, string amphur)
        {
            List<zipcodedata> result = new List<zipcodedata>();
            DBConnector.DBConnector conn = new DBConnector.DBConnector();
            string SQLString;
            if (conn.OpenConnection())
            {
                MySqlCommand qExe = new MySqlCommand();
                qExe.Connection = conn.connection;
                SQLString = @"select province, amphur, tambon, zipcode from zip_data 
                              where province = '" + province + @"' 
                              and amphur = '" + amphur + @"'
                              order by tambon";
                qExe.CommandText = SQLString;
                MySqlDataReader dataReader = qExe.ExecuteReader();
                while (dataReader.Read())
                {
                    zipcodedata detail = new zipcodedata();
                    detail.province = dataReader["province"].ToString();
                    detail.amphur = dataReader["amphur"].ToString();
                    detail.tambon = dataReader["tambon"].ToString();
                    detail.zipcode = dataReader["zipcode"].ToString();
                    result.Add(detail);
                }
                conn.CloseConnection();
                return Json(result);
            }
            else
            {
                return BadRequest("Database connect fail!");
            }
        }

        
    }
}
