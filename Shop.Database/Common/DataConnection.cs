using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Database.Common
{
   public static class DataConnection
    {
        public static string ConnectionString => "Server=localhost;Database=Shop;Trusted_Connection=True;MultipleActiveResultSets=true";
    }

}
