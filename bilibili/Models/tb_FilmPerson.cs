using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bilibili.Models
{
    /// <summary>
    /// 匹配表
    /// </summary>
    public class tb_FilmPerson
    {
        [Key]
        public int ID { get; set; }
        /// <summary>
        /// 电影ID
        /// </summary>
        public int FilmId { get; set; }
        /// <summary>
        /// 人员ID
        /// </summary>
        public int PersonId { get; set; }
    }
}
