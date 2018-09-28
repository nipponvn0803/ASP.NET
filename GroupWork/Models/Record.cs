using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupWork.Models
{
    public class Record
    {
        public int RecordID { get; set; }
        public int UserID { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }
        public DateTime InputDate { get; set; }

        public virtual User User { get; set; }
    }
}