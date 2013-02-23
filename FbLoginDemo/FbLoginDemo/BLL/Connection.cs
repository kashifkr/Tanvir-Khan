using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FbLoginDemo.DAL;
using System.Configuration;

namespace FbLoginDemo.BLL
{
    public static class Connection
    {
        public static friendlocalEntities db = null;
        public  static friendlocalEntities GetContext()
        {
            if (db == null)
                db = new friendlocalEntities(ConfigurationManager.ConnectionStrings["friendlocalEntities"].ConnectionString);
            return db;
        }
    }
}