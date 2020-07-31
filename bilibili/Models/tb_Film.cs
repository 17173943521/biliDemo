using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bilibili.Models
{
    /// <summary>
    /// 电影表
    /// </summary>
    public class tb_Film
    {
        [Key]
        public int ID { get; set; }
        /// <summary>
        /// 电影名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Describe { get; set; }
        /// <summary>
        /// 时长
        /// </summary>
        public int Duration { get; set; }
        /// <summary>
        /// 评分
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// 电影路径
        /// </summary>
        public string FilmPath { get; set; }
        /// <summary>
        /// 电影图片路径
        /// </summary>
        public string FilmImage { get; set; }
        /// <summary>
        /// 观看量
        /// </summary>
        public int ViewCount { get; set; }
        /// <summary>
        /// 是否是VIP观看
        /// </summary>
        public int Vip { get; set; }
        /// <summary>
        /// 数据添加时间
        /// </summary>
        public DateTime AddTime { get; set; }
        /// <summary>
        /// 删除 / 注销 状态
        /// </summary>
        public int State { get; set; }
    }
}
