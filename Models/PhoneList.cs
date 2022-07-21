using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class PhoneList
    {
        public DateTime StartTime { get; set; }  //开始时间
        public string Type { get; set; } //主被叫标志
        public string UserPhone { get; set; } //用户号码
        public string IMSI { get; set; } //IMSI
        public string IMEI { get; set; } //IMEI
        public string OtherPhone { get; set; }  //对端号码
        public string OtherAddress  { get; set; }  //对端归属地
        public int TalkTime { get; set; }   //通话时长
        public string ActivityAddress { get; set; } //活动地区
        public string LAC { get; set; }   //LAC
        public string CI { get; set; }   //CI
        public string GuiShu { get; set; }  //归属地
        public string JiZhanAddress { get; set; }  //基站地址
    }
}
