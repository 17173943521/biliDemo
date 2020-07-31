using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

/*
 *  与官方影片公用一个
 *  标签表
 */

namespace bilibili.Models
{
    /// <summary>
    /// 标签 视频 关联表
    /// </summary>
    public class tb_UserPersonalFilmType
    {
        [Key]
        public int ID { get; set; }
        /// <summary>
        /// 影片Id
        /// </summary>
        public int FileId { get; set; }
        /// <summary>
        /// 标签Id
        /// </summary>
        public int TypeId { get; set; }
        /// <summary>
        /// 标签名称
        /// </summary>
        public string TypeName { get; set; }
        /// <summary>
        /// 删除 / 注销 状态
        /// </summary>
        public int State { get; set; }
    }
}
