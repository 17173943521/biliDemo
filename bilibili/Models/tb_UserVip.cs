using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bilibili.Models
{
    public class tb_UserVip
    {
        [Key]
        public int ID { get; set; }
        public int UserId { get; set; }
        public DateTime ActionTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Type { get; set; }
        public double Money { get; set; }
    }
}
