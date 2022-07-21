using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Data.SQLite;
using System.Data;

namespace DAL
{
    /// <summary>
    /// 人员信息类
    /// </summary>
    public class ServicesPersonInfo
    {
        public int AddPersonInfo(PersonInfo person)
        {
            string sql = "insert into PersonInfo(PicImage,PersonName,LGTime,Gender,Age,CardNo,Address,SType,AnQing,GuanKong,ActionType,StatusNow,PhoneNumber) values (";
            sql += "@PicImage,@PersonName,@LGTime,@Gender,@Age,@CardNo,@Address,@SType,@AnQing,@GuanKong,@ActionType,@StatusNow,@PhoneNumber)";
            SQLiteParameter[] param = new SQLiteParameter[13];
            param[0] = new SQLiteParameter("@PicImage", person.PicImage);
            param[1] = new SQLiteParameter("@PersonName", person.PersonName);
            param[2] = new SQLiteParameter("@LGTime", person.LGTime);
            param[3] = new SQLiteParameter("@Gender", person.Gender);
            param[4] = new SQLiteParameter("@Age", person.Age);
            param[5] = new SQLiteParameter("@CardNo", person.CardNo);
            param[6] = new SQLiteParameter("@Address", person.Address);
            param[7] = new SQLiteParameter("@SType", person.SType);
            param[8] = new SQLiteParameter("@AnQing", person.AnQing);
            param[9] = new SQLiteParameter("@GuanKong", person.GuanKong);
            param[10] = new SQLiteParameter("@ActionType", person.ActionType);
            param[11] = new SQLiteParameter("@StatusNow", person.StatusNow);
            param[12] = new SQLiteParameter("@PhoneNumber", person.PhoneNumber);
            try
            {
                return SQLiteHelper.Update(sql, param);               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 修改人员信息
        /// </summary>
        /// <param name="person"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int UpdtePersonInfoById(PersonInfo person,string id)
        {
            string sql = "Update  PersonInfo set PicImage=@PicImage,PersonName=@PersonName,LGTime=@LGTime,Gender=@Gender,Age=@Age,";
            sql += "CardNo=@CardNo,Address=@Address,SType=@SType,AnQing=@AnQing,GuanKong=@GuanKong,ActionType=@ActionType,StatusNow=@StatusNow,PhoneNumber=@PhoneNumber";             
            sql += " where Id="+id;
            SQLiteParameter[] param = new SQLiteParameter[13];
            param[0] = new SQLiteParameter("@PicImage", person.PicImage);
            param[1] = new SQLiteParameter("@PersonName", person.PersonName);
            param[2] = new SQLiteParameter("@LGTime", person.LGTime);
            param[3] = new SQLiteParameter("@Gender", person.Gender);
            param[4] = new SQLiteParameter("@Age", person.Age);
            param[5] = new SQLiteParameter("@CardNo", person.CardNo);
            param[6] = new SQLiteParameter("@Address", person.Address);
            param[7] = new SQLiteParameter("@SType", person.SType);
            param[8] = new SQLiteParameter("@AnQing", person.AnQing);
            param[9] = new SQLiteParameter("@GuanKong", person.GuanKong);
            param[10] = new SQLiteParameter("@ActionType", person.ActionType);
            param[11] = new SQLiteParameter("@StatusNow", person.StatusNow);
            param[12] = new SQLiteParameter("@PhoneNumber", person.PhoneNumber);
            try
            {
                return SQLiteHelper.Update(sql, param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public  DataTable GetDataTableByCondition(string condition)
        {
            string sql = "Select Id,PicImage,PersonName,LGTime,Gender,Age,CardNo,Address,SType,AnQing,GuanKong,ActionType,StatusNow,PhoneNumber from PersonInfo";
            sql += " where PersonName||Gender||cast(Age as text)||CardNo||Address||SType||AnQing||GuanKong||ActionType||StatusNow||PhoneNumber like '%" + condition + "%'";
            DataSet ds = SQLiteHelper.GetDataSet(sql, null);
            return ds.Tables[0];
        }

        public DataTable GetDataTableByCondition(string dtpStart,string dtpEnd)
        {
            string sql = "Select Id,PicImage,PersonName,LGTime,Gender,Age,CardNo,Address,SType,AnQing,GuanKong,ActionType,StatusNow,PhoneNumber from PersonInfo";
            sql += " where LGTime between '{0}' and '{1}'";
            sql = string.Format(sql, dtpStart, dtpEnd);
            DataSet ds = SQLiteHelper.GetDataSet(sql, null);
            return ds.Tables[0];
        }

        public int DeletePersonById(string id)
        {
            string sql = "delete from PersonInfo where id=" + id;
            return SQLiteHelper.Update(sql, null);
        }

        /// <summary>
        /// 判断数据库是否存在指定Id的人员信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns>如果存在返回True,不存在返回False</returns>
        public bool ExstsId(string id)
        {
            string sql = "select count(*) from PersonInfo where Id=";
            if (id=="")
            {
                sql += "-1";
            }
            else
            {
                sql += id;
            }            
            object result = SQLiteHelper.GetSingleResult(sql, null);
            if (Convert.ToInt32(result)==0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
