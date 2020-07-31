using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bilibili.Models
{
    /// <summary>
    /// 电影详情表
    /// </summary>
    public class tb_FilmInfo
    {
        [Key]
        public int ID { get; set; }
        /// <summary>
        /// 电影Id
        /// </summary>
        public int FilmId { get; set; }
        /// <summary>
        /// 签约公司
        /// </summary>
        public string Company { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime ActionTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime { get; set; }
        /// <summary>
        /// 版权类型
        /// 1   独家播放权
        /// 2   播放权
        /// </summary>
        public int CopyrightType { get; set; }
        /// <summary>
        /// 签约文件
        /// </summary>
        public string File { get; set; }
        /// <summary>
        /// 所需金额
        /// </summary>
        public double Money { get; set; }
        /// <summary>
        /// 员工Id
        /// </summary>
        public  int  EmpId { get; set; }
        /// <summary>
        /// 上传时间
        /// </summary>
        public DateTime AddTime { get; set; }
    }
}
