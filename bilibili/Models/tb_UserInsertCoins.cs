using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bilibili.Models
{
    /// <summary>
    /// 用户投币
    /// </summary>
    public class tb_UserInsertCoins
    {
        [Key]
        public int ID { get; set; }
        public int UserId { get; set; }
        public int FilmId { get; set; }
        /// <summary>
        /// 投币数
        /// </summary>
        public int CoinNum { get; set; }
    }
}
