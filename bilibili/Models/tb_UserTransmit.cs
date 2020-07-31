using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bilibili.Models
{
    /// <summary>
    /// 用户转发
    /// </summary>
    public class tb_UserTransmit
    {
        [Key]
        public int ID { get; set; }
        public int UserId { get; set; }
        public int FilmId { get; set; }
        /// <summary>
        /// 转发平台
        /// </summary>
        public int ToWhere { get; set; }
    }
}
