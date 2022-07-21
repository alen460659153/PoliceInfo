using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Data.SQLite;
using System.Data;

namespace DAL
{
    public class ServicesPhoneList
    {
        public int AddPhoneList(List<PhoneList> list)
        {
            string sql = "Insert into PhoneList(StartTime,Type,UserPhone,IMSI,IMEI,OtherPhone,OtherAddress,TalkTime,ActivityAddress,LAC,CI,GuiShu,JiZhanAddress) values (";
            sql += "@StartTime,@Type,@UserPhone,@IMSI,@IMEI,@OtherPhone,@OtherAddress,@TalkTime,@ActivityAddress,@LAC,@CI,@GuiShu,@JiZhanAddress)";
            List<SQLiteParameter[]> paramList = new List<SQLiteParameter[]>();
            foreach (PhoneList item in list)
            {
                SQLiteParameter[] param = new SQLiteParameter[] 
                {
                    new SQLiteParameter("@StartTime",item.StartTime),
                    new SQLiteParameter("@Type",item.Type),
                    new SQLiteParameter("@UserPhone",item.UserPhone),
                    new SQLiteParameter("@IMSI",item.IMSI),
                    new SQLiteParameter("@IMEI",item.IMEI),
                    new SQLiteParameter("@OtherPhone",item.OtherPhone),
                    new SQLiteParameter("@OtherAddress",item.OtherAddress),
                    new SQLiteParameter("@TalkTime",item.TalkTime),
                    new SQLiteParameter("@ActivityAddress",item.ActivityAddress),
                    new SQLiteParameter("@LAC",item.LAC),
                    new SQLiteParameter("@CI",item.CI),
                    new SQLiteParameter("@GuiShu",item.GuiShu),
                     new SQLiteParameter("@JiZhanAddress",item.JiZhanAddress),
                };
                paramList.Add(param);
            }
            try
            {
                int result = SQLiteHelper.InsertPhoneList(sql, paramList);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SelectPhoneListByNum(string phoneNumber)
        {
            string sql = "Select Id,StartTime,Type,UserPhone,IMSI,IMEI,OtherPhone,OtherAddress,TalkTime,ActivityAddress,LAC,CI,GuiShu,JiZhanAddress";
            sql += " from PhoneList where UserPhone||OtherPhone like '%"+phoneNumber+"%'";
            DataSet ds = SQLiteHelper.GetDataSet(sql, null);
            return ds.Tables[0];
        }
        
        public List<DataTable> GetDataTableByNum(string phoneNum)
        {
            string sql = "Select OtherPhone as UserPhone,count(*) as Count,sum(TalkTime) as TalkTime from PhoneList where UserPhone='{0}' and Type='主叫' group by OtherPhone order by Count desc;";
            sql += "Select OtherPhone as UserPhone2,count(*) as Count2,sum(TalkTime) as TalkTime2 from PhoneList where UserPhone='{1}' and Type='被叫' group by OtherPhone order by Count2 desc";
            sql = string.Format(sql,phoneNum, phoneNum);
            DataSet ds = SQLiteHelper.GetDataSet(sql, null);
            List<DataTable> list = new List<DataTable>();
            list.Add(ds.Tables[0]);
            list.Add(ds.Tables[1]);
            return list;
        }
    }
}
