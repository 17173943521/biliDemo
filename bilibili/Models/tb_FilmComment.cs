using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bilibili.Models
{
    /// <summary>
    /// 评论
    /// </summary>
    public class tb_FilmComment
    {
        [Key]
        public int ID { get; set; }
        public int FilmId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        /// <summary>
        /// 上级ID
        /// </summary>
        public int Parent { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 点赞
        /// </summary>
        public int Praise { get; set; }
        /// <summary>
        /// 数据添加时间
        /// </summary>
        public DateTime AddTime { get; set; }
    }
}
