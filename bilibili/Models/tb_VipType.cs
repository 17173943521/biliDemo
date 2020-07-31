using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bilibili.Models
{
    public class tb_VipType
    {
        [Key]
        public int ID { get; set; }
        /// <summary>
        /// 类别
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 类别名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 钱
        /// </summary>
        public double Money { get; set; }
        /// <summary>
        /// 折扣
        /// </summary>
        public double Discount { get; set; }
        /// <summary>
        /// 折扣金额
        /// </summary>
        public double DiscountMoney { get; set; }
        /// <summary>
        /// 活动开始时间
        /// </summary>
        public DateTime ActionTime { get; set; }
        /// <summary>
        /// 活动结束时间
        /// </summary>
        public DateTime EndTime { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
