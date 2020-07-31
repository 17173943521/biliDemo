using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bilibili.Models
{
    /// <summary>
    /// 图片表
    /// </summary>
    public class tb_Image
    {

        [Key]
        public int ID { get; set; }
        /// <summary>
        /// 图片路径
        /// </summary>
        public string ImagePath { get; set; }
        /// <summary>
        /// 所属Id
        /// </summary>
        public int BelongId { get; set; }
        ///需要添加 id所属类型字段
    }
}
