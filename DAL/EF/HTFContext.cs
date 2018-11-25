using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DAL.EF
{
    class HTFContext : DbContext
    {
        public HTFContext() : base("htfConnString")
        {
            Database.SetInitializer<HTFContext>(new HTFDbInitializer());
            this.Database.Initialize(false);
        }
    }
}
