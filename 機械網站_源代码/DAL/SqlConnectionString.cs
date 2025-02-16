using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
   public class SqlConnectionString
    {
       public static Model.SubWeb GetString(int swid)
       {
           return new DAL.SubWeb().GetModel(swid);
       }
    }
}
