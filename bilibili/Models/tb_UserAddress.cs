using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;

namespace bilibili.Models
{
    /// <summary>
    /// 用户地址
    /// </summary>
    public class tb_UserAddress
    {
        [Key]
        public int ID { get; set; }
        public int UserId { get; set; }
        /// <summary>
        /// 国家
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// 省
        /// </summary>
        public string Province { get; set; }
        /// <summary>
        /// 市
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// 县
        /// </summary>
        public string County { get; set; }
        /// <summary>
        /// 详细地址
        /// </summary>
        public string Detail { get; set; }

    }
}
