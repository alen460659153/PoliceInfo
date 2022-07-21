using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Models
{
    /// <summary>
    /// 犯罪人员实体类
    /// </summary>
    public class PersonInfo
    {
        public string PicImage { get; set; }  
        public string PersonName { get; set; } //not null
        public DateTime LGTime { get; set; }
        public string Gender { get; set; } //not null
        public int Age { get; set; }  //not null
        public string CardNo { get; set; }  //
        public string Address { get; set; } //not null
        public string SType { get; set; }
        public string AnQing { get; set; }
        public string GuanKong { get; set; }
        public string ActionType { get; set; } //
        public string StatusNow { get; set; }
        public string PhoneNumber { get; set; }
        
    }
}
