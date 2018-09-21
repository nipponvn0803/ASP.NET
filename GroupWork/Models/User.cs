using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupWork.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public int WeightGoal { get; set; }
        public int HeightGoal { get; set; }

        public virtual ICollection<Record> Records { get; set; }
    }
}