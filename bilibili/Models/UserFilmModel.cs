using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bilibili.Models
{
    public class UserFilmModel
    {

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
        /// 删除 / 注销 状态
        /// </summary>
        public int State { get; set; }
        public string uName { get; set; }
        public string uMotto { get; set; }
        public string uImage { get; set; }
    }
}
