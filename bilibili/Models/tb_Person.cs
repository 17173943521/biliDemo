using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bilibili.Models
{
    /// <summary>
    /// 人员表
    /// </summary>
    public class tb_Person
    {
        [Key]
        public int ID { get; set; }
        /// <summary>
        /// 人员姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 图片
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// 介绍
        /// </summary>
        public string Describe { get; set; }
        /// <summary>
        /// 数据添加时间
        /// </summary>
        public DateTime AddTime { get; set; }
    }
}
