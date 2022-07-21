using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Data.SQLite;
using System.Data;

namespace DAL
{
    public class ServicesLogin
    {
        public Login CheckLogin(Login obj)
        {
            string sql = "Select LoginShow from Login where LoginName=@LoginName and LoginPassword=@LoginPassword";
            SQLiteParameter[] param = new SQLiteParameter[]
            {
                new SQLiteParameter("@LoginName",obj.LoginName),
                new SQLiteParameter("@LoginPassword",obj.LoginPassword),
            };           
            try
            {
                object result = SQLiteHelper.GetSingleResult(sql, param);
                if (result !=DBNull.Value && result !=null)
                {
                    obj.LoginShow = result.ToString();
                    return obj;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool IsExists(string loginName)
        {
            string sql = "select case when exists(select * from Login where LoginName='" + loginName + "') then 1 else 0 end";
            object result = SQLiteHelper.GetSingleResult(sql,null);
            if (result.ToString()=="1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 修改显示的用户名
        /// </summary>
        /// <param name="loginName"></param>
        /// <returns></returns>
        public int EditLoginShowByLoginName(Login login)
        {
            string sql = "Update Login set LoginShow=@LoginShow";
            SQLiteParameter[] param = new SQLiteParameter[]
            {
                new SQLiteParameter("@LoginShow",login.LoginShow)                
            };
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
        /// 修改密码
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public int EditLoginPassword(Login login)
        {
            string sql = "Update Login set LoginPassword=@LoginPassword where LoginName=@LoginName";
            SQLiteParameter[] param = new SQLiteParameter[]
            {
                new SQLiteParameter("@LoginPassword",login.LoginPassword),
                new SQLiteParameter("@LoginName",login.LoginName)
            };
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
        /// 注册用户名
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public int AddLoginName(Login login)
        {
            string sql = "Insert into Login(LoginName,LoginPassword,LoginShow) Values (@LoginName,@LoginPassword,@LoginShow)";
            SQLiteParameter[] param = new SQLiteParameter[]
            {
                new SQLiteParameter("@LoginName",login.LoginName),
                new SQLiteParameter("@LoginPassword",login.LoginPassword),
                new SQLiteParameter("@LoginShow",login.LoginShow)
            };
            try
            {
                return SQLiteHelper.Update(sql, param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string GetLoginShow()
        {
            string sql = "Select LoginShow from Login where LoginName='admin'";
            object result = SQLiteHelper.GetSingleResult(sql,null);
            return result.ToString();
        }

        public List<string> GetLoginNameList()
        {
            string sql = "Select LoginName from Login where LoginName<>'admin'";
            SQLiteDataReader sr = SQLiteHelper.GetSQLiteDataReader(sql, null);
            List<string> list = new List<string>();
            while (sr.Read())
            {
                string result = sr["LoginName"].ToString();
                list.Add(result);
            }
            sr.Close();
            return list;
        }

        public int DeleteLoginName(string loginName)
        {
            string sql = "Delete from Login where LoginName='" + loginName + "'";
            return SQLiteHelper.Update(sql, null);
        }
    }
}
