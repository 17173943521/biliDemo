using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bilibili.Models
{
    /// <summary>
    /// 用户点赞
    /// </summary>
    public class tb_UserPraise
    {
        [Key]
        public int ID { get; set; }
        public int UserId { get; set; }
        public int FilmId { get; set; }
        /// <summary>
        /// 是否取消
        /// </summary>
        public int State { get; set; }
    }
}
