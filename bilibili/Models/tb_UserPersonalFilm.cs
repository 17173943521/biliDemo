using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bilibili.Models
{
    /// <summary>
    /// 个人影片
    /// </summary>
    public class tb_UserPersonalFilm
    {
        [Key]
        public int ID { get; set; }
        public int UserId { get; set; }
        /// <summary>
        /// 路径
        /// </summary>
        public string FilmPath { get; set; }
        /// <summary>
        /// 图片
        /// </summary>
        public string FilmImage { get; set; }
        /// <summary>
        /// 影片名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Describe { get; set; }
        /// <summary>
        /// 是否为原创
        /// </summary>
        public int Original { get; set; }
        /// <summary>
        /// 时长
        /// </summary>
        public string Duration { get; set; }
        /// <summary>
        /// 上传时间
        /// </summary>
        public DateTime AddTime { get; set; }
        /// <summary>
        /// 观看数量
        /// </summary>
        public int ShowNum { get; set; }
        /// <summary>
        /// 点赞数量
        /// </summary>
        public int PraiseNum { get; set; }
        /// <summary>
        /// 投币数量
        /// </summary>
        public int InsertCoinsNum { get; set; }
        /// <summary>
        /// 收藏数量
        /// </summary>
        public int EnshrineNum { get; set; }
        /// <summary>
        /// 转发数量
        /// </summary>
        public int TransmitNum { get; set; }
        /// <summary>
        /// 删除 / 注销 状态
        /// </summary>
        public int State { get; set; }

    }
}
