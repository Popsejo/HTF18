using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DAL.EF
{
    class HTFDbInitializer : DropCreateDatabaseAlways<HTFContext>
    {
        protected override void Seed(HTFContext context)
        {
            base.Seed(context);

            //Fill the database with initial models ....
        }
    }
}
