using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FbLoginDemo.DAL;

namespace FbLoginDemo.BLL
{
    public class UserRepository : GenericRepository<basicinfo>
    {
        public basicinfo Get(string userName, string password)
        {
            return ObjectSet.FirstOrDefault(p => p.username == userName && p.password == password);

        }
    }
}