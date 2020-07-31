using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bilibili.Models
{
    /// <summary>
    /// 用户文件夹
    /// </summary>
    public class tb_UserType
    {
        [Key]
        public int ID { get; set; }
        /// <summary>
        /// 文件夹名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 属于什么
        /// 1   关注
        /// 2   收藏
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// 删除 / 注销 状态
        /// </summary>
        public int State { get; set; }
    }
}
