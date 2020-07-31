using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bilibili.Models
{
    public class tb_FilmType
    {
        [Key]
        public int ID { get; set; }
        /// <summary>
        /// 电影Id
        /// </summary>
        public int FilmId { get; set; }
        /// <summary>
        /// 类型Id
        /// </summary>
        public int TypeId { get; set; }
        /// <summary>
        /// 类型名称
        /// </summary>
        public string TypeName { get; set; }

    }
}
