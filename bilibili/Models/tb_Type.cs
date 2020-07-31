using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bilibili.Models
{
    public class tb_Type
    {
        [Key]

        /// <summary>
        /// 标签ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 标签名称
        /// </summary>
        public string Name { get; set; }
        public string TypeUrl { get; set; }
        /// <summary>
        /// 标签上级
        /// </summary>
        public int Parent { get; set; }
        /// <summary>
        /// 标签类型
        /// </summary>
        public int Type { get; set; }
    }

}
