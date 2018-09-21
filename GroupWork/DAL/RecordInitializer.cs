using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using GroupWork.Models;

namespace GroupWork.DAL
{
    public class RecordInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<RecordContext>
    {
        protected override void Seed(RecordContext context)
        {
            var users = new List<User>
            {
            new User{UserName="Carson"},
            new User{UserName="Meredith"},
            new User{UserName="Arturo"},
            new User{UserName="Gytis"},
            new User{UserName="Yan"},
            new User{UserName="Peggy"},
            new User{UserName="Laura"},
            new User{UserName="Nino"}
            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

            var records = new List<Record>
            {
            new Record{UserID=1,Weight=50,Height=150,InputDate=DateTime.Parse("2005-09-01")},
            new Record{UserID=2,Weight=60,Height=160,InputDate=DateTime.Parse("2005-09-01")},
            new Record{UserID=3,Weight=70,Height=170,InputDate=DateTime.Parse("2005-09-01")},
            new Record{UserID=2,Weight=80,Height=180,InputDate=DateTime.Parse("2005-09-01")},
            new Record{UserID=5,Weight=90,Height=190,InputDate=DateTime.Parse("2005-09-01")},
            new Record{UserID=1,Weight=80,Height=180,InputDate=DateTime.Parse("2005-09-01")},
            new Record{UserID=2,Weight=70,Height=170,InputDate=DateTime.Parse("2005-09-01")}
            };
            records.ForEach(s => context.Records.Add(s));
            context.SaveChanges();

        }
    }
}