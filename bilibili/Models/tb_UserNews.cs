using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bilibili.Models
{
    /// <summary>
    /// 私信表
    /// </summary>
    public class tb_UserNews
    {
        [Key]
        public int ID { get; set; }
        /// <summary>
        /// 发送信息者
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// 接受信息者
        /// </summary>
        public int NewsUserId { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 数据添加时间
        /// </summary>
        public DateTime AddTime { get; set; }
    }
}
