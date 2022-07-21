using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace DAL
{
    public static class SQLiteHelper
    {
        public static readonly string connString="Data Source=data.db;Pooling=true;FailIfMissing=false";
        /// <summary>
        /// 数据的增删改方法，返回受影响的行数
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="param">参数数组,如果没有参数请传入Null</param>
        /// <returns></returns>
        public static int Update(string sql,SQLiteParameter[] param)
        {
            SQLiteConnection cn = new SQLiteConnection(connString);
            SQLiteCommand cmd = new SQLiteCommand(sql, cn);
            if (param !=null)
            {
                cmd.Parameters.AddRange(param);
            }
            try
            {
                cn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("数据库连接失败，具体原因：" + ex.Message);
            }
            finally
            {
                if (cn.State==ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        /// <summary>
        /// 返回数据库单一结果
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public  static object GetSingleResult(string sql,SQLiteParameter[] param)
        {            
            SQLiteConnection cn = new SQLiteConnection(connString);
            SQLiteCommand cmd = new SQLiteCommand(sql, cn);
            if (param != null)
            {
                cmd.Parameters.AddRange(param);
            }
            try
            {
                cn.Open();
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("数据库连接失败，具体原因：" + ex.Message);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        /// <summary>
        /// 返回DataSet数据集
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql,SQLiteParameter[] param)
        {
            SQLiteConnection cn = new SQLiteConnection(connString);
            SQLiteCommand cmd = new SQLiteCommand(sql, cn);            
            if (param != null)
            {
                cmd.Parameters.AddRange(param);
            }
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                cn.Open();                
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("数据库连接失败，具体原因：" + ex.Message);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }               
            }
        }

        public  static SQLiteDataReader GetSQLiteDataReader(string sql,SQLiteParameter[] param)
        {
            SQLiteConnection cn = new SQLiteConnection(connString);
            SQLiteCommand cmd = new SQLiteCommand(sql, cn);
            if (param != null)
            {
                cmd.Parameters.AddRange(param);
            }
            try
            {
                cn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                throw new Exception("数据库连接失败，具体原因：" + ex.Message);
            }            
        }

        /// <summary>
        /// 基于事务批量提交数据
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        public static int InsertPhoneList(string sql,List<SQLiteParameter[]> list)
        {
            SQLiteConnection cn = new SQLiteConnection(connString);
            SQLiteCommand cmd = new SQLiteCommand(sql, cn);
            int count = 0;
            try
            {
                cn.Open();
                cmd.Transaction = cn.BeginTransaction();
                foreach (SQLiteParameter[] item in list)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddRange(item);
                    count += cmd.ExecuteNonQuery();
                }
                cmd.Transaction.Commit();
                return count;
            }
            catch (Exception ex)
            {
                cmd.Transaction.Rollback();
                throw new Exception("向数据库批量插入数据出错，原因:" + ex.Message);          
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
