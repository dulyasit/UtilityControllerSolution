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
        [Route("Country/ZipCodeData/Add")]
        [HttpPost]
        public IHttpActionResult ZipcodeDataAdd([FromBody] zipcodedata item)
        {
            DBConnector.DBConnector conn = new DBConnector.DBConnector();
            string SQLString;
            if (conn.OpenConnection())
            {
                try
                {
                    SQLString = @"INSERT INTO zip_data (province, amphur, tambon, zipcode,
                                  Blank1, Blank2, Blank3, Blank4, Blank5, Blank6)
                                  VALUES (@province, @amphur, @tambon, @zipcode, @Blank1,
                                  @Blank2, @Blank3, @Blank4, @Blank5, @Blank6)";
                    MySqlCommand qExe = new MySqlCommand
                    {
                        Connection = conn.connection,
                        CommandText = SQLString
                    };
                    qExe.Parameters.AddWithValue("@province", item.province);
                    qExe.Parameters.AddWithValue("@amphur", item.amphur);
                    qExe.Parameters.AddWithValue("@tambon", item.tambon);
                    qExe.Parameters.AddWithValue("@zipcode", item.zipcode);
                    qExe.Parameters.AddWithValue("@Blank1", item.Blank1);
                    qExe.Parameters.AddWithValue("@Blank2", item.Blank2);
                    qExe.Parameters.AddWithValue("@Blank3", item.Blank3);
                    qExe.Parameters.AddWithValue("@Blank4", item.Blank4);
                    qExe.Parameters.AddWithValue("@Blank5", item.Blank5);
                    qExe.Parameters.AddWithValue("@Blank6", item.Blank6);
                    qExe.ExecuteNonQuery();
                    long returnid = qExe.LastInsertedId;
                    conn.CloseConnection();
                    return Json(new ResultDataModel { success = true, errorMessage = "", returnRunno = returnid.ToString() });
                }
                catch (Exception e)
                {
                    return Json(new ResultDataModel { success = false, errorMessage = e.Message, returnRunno = "" });
                }
            }
            else
            {
                return Json(new ResultDataModel { success = false, errorMessage = "Database connect fail!", returnRunno = "" });
            }
        }
        [Route("Country/ZipCodeData/Edit")]
        [HttpPost]
        public IHttpActionResult ZipcodeDataEdit([FromBody] zipcodedata item)
        {
            DBConnector.DBConnector conn = new DBConnector.DBConnector();
            string SQLString;
            if (conn.OpenConnection())
            {
                try
                {
                    SQLString = @"UPDATE zip_data SET province = @province, amphur = @amphur, tambon = @tambon,
                                  zipcode = @zipcode, Blank1 = @Blank1, Blank2 = @Blank2, Blank3 = @Blank3,
                                  Blank4 = @Blank4, Blank5 = @Blank5, Blank6 = @Blank6 WHERE ZipcodeRunno = @ZipcodeRunno";
                    MySqlCommand qExe = new MySqlCommand
                    {
                        Connection = conn.connection,
                        CommandText = SQLString
                    };
                    qExe.Parameters.AddWithValue("@ZipcodeRunno", item.ZipcodeRunno);
                    qExe.Parameters.AddWithValue("@province", item.province);
                    qExe.Parameters.AddWithValue("@amphur", item.amphur);
                    qExe.Parameters.AddWithValue("@tambon", item.tambon);
                    qExe.Parameters.AddWithValue("@zipcode", item.zipcode);
                    qExe.Parameters.AddWithValue("@Blank1", item.Blank1);
                    qExe.Parameters.AddWithValue("@Blank2", item.Blank2);
                    qExe.Parameters.AddWithValue("@Blank3", item.Blank3);
                    qExe.Parameters.AddWithValue("@Blank4", item.Blank4);
                    qExe.Parameters.AddWithValue("@Blank5", item.Blank5);
                    qExe.Parameters.AddWithValue("@Blank6", item.Blank6);
                    qExe.ExecuteNonQuery();
                    conn.CloseConnection();
                    return Json(new ResultDataModel { success = true, errorMessage = "", returnRunno = "" });
                }
                catch (Exception e)
                {
                    return Json(new ResultDataModel { success = false, errorMessage = e.Message, returnRunno = "" });
                }
            }
            else
            {
                return Json(new ResultDataModel { success = false, errorMessage = "Database connect fail!", returnRunno = "" });
            }
        }
        [Route("Country/ZipCodeData/Delete/{id}")]
        [HttpPost]
        public IHttpActionResult PreNameDelete(string id)
        {
            DBConnector.DBConnector conn = new DBConnector.DBConnector();
            if (conn.OpenConnection())
            {
                try
                {
                    string sqlString = @"DELETE FROM zip_data WHERE ZipcodeRunno = @ZipcodeRunno";
                    MySqlCommand qExe = new MySqlCommand
                    {
                        Connection = conn.connection,
                        CommandText = sqlString
                    };
                    if (string.IsNullOrEmpty(id))
                        return Json(new ResultDataModel { success = false, errorMessage = "Key is null!", returnRunno = "" });
                    qExe.Parameters.AddWithValue("@ZipcodeRunno", id);
                    qExe.ExecuteNonQuery();
                    conn.CloseConnection();
                    return Json(new ResultDataModel { success = true, errorMessage = "", returnRunno = "" });
                }
                catch (Exception e)
                {
                    return Json(new ResultDataModel { success = false, errorMessage = e.Message, returnRunno = "" });
                }
            }
            else
            {
                return Json(new ResultDataModel { success = false, errorMessage = "Database connect fail!", returnRunno = "" });
            }
        }

        [Route("Country/ZipCodeData/ListAll")]
        [HttpGet]
        public IHttpActionResult zipcodeListall()
        {
            List<zipcodedata> result = new List<zipcodedata>();
            DBConnector.DBConnector conn = new DBConnector.DBConnector();
            string SQLString;
            if (conn.OpenConnection())
            {
                MySqlCommand qExe = new MySqlCommand();
                qExe.Connection = conn.connection;
                SQLString = @"select * from zip_data order by province, amphur, tambon, zipcode";
                qExe.CommandText = SQLString;
                MySqlDataReader dataReader = qExe.ExecuteReader();
                while (dataReader.Read())
                {
                    zipcodedata detail = new zipcodedata();
                    detail.ZipcodeRunno = int.Parse(dataReader["ZipcodeRunno"].ToString());
                    detail.province = dataReader["province"].ToString();
                    detail.amphur = dataReader["amphur"].ToString();
                    detail.tambon = dataReader["tambon"].ToString();
                    detail.zipcode = dataReader["zipcode"].ToString();
                    detail.Blank1 = dataReader["Blank1"].ToString();
                    detail.Blank2 = dataReader["Blank2"].ToString();
                    detail.Blank3 = dataReader["Blank3"].ToString();
                    detail.Blank4 = dataReader["Blank4"].ToString();
                    detail.Blank5 = dataReader["Blank5"].ToString();
                    detail.Blank6 = dataReader["Blank6"].ToString();
                    result.Add(detail);
                }
                return Json(result);
            }
            else
            {
                return BadRequest("Database connect fail!");
            }
        }

        [Route("Country/ZipCodeData/{zipcode}")]
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
        [Route("Country/ProvinceData")]
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
        [Route("Country/AmphurData/{province}")]
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
        [Route("Country/TambonData/{province}/{amphur}")]
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
