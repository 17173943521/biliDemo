using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bilibili.Models
{
    /// <summary>
    /// 用户观影记录表
    /// </summary>
    public class tb_UserWatchRecord
    {
        [Key]
        public int ID { get; set; }
        /// <summary>
        /// 用户Id
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// 电影Id
        /// </summary>
        public int FilmId { get; set; }
        /// <summary>
        /// 电影名称
        /// </summary>
        public string FilmName { get; set; }
        /// <summary>
        /// 电影图片
        /// </summary>
        public string FilmImage { get; set; }
        /// <summary>
        /// 电影时长
        /// </summary>
        public int Duration { get; set; }
        /// <summary>
        /// 进度
        /// </summary>
        public double Rate { get; set; }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 删除 / 注销 状态
        /// </summary>
        public int State { get; set; }

    }
}
