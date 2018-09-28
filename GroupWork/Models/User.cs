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
        public float WeightGoal { get; set; }
        public float HeightGoal { get; set; }

        public virtual ICollection<Record> Records { get; set; }
    }
}