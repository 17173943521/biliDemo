using Microsoft.AspNetCore.Identity;
using bilibili.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bilibili.BLL
{
    public class BllUser
    {
        BllHelper b = new BllHelper();
        public tb_User Login(string sql)
        {
            List<tb_User> list = b.SqlQuery<tb_User>(sql);
            if (list.Count > 0)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }
    }
}
