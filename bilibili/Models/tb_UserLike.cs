using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bilibili.Models
{
    /// <summary>
    /// 用户 关注 粉丝 连接表
    /// </summary>
    public class tb_UserLike
    {
        [Key]
        public int ID { get; set; }
        public int UserId { get; set; }
        public int LikeUserId { get; set; }
        /// <summary>
        /// 关注 - 所属分组
        /// </summary>
        public int LikeType { get; set; }
        /// <summary>
        /// 删除 / 注销 状态
        /// </summary>
        public int State { get; set; }
    }
}
