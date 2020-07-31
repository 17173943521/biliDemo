using bilibili.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace bilibili.BLL
{
    public class BllDefault
    {
        DAL.MyDbContext db = new DAL.MyDbContext();
        public List<tb_Type> GetTypeHead()
        {
            return null;
        }
    }
}
