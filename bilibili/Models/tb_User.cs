using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bilibili.Models
{
    /// <summary>
    /// 用户信息表
    /// </summary>
    public class tb_User
    {
        /// <summary>
        /// 主键  ID
        /// </summary>
        [Key]
        public int ID { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 座右铭
        /// </summary>
        public string Motto { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        public string Image { get; set; }
        /// <summary>
        /// 生日
        /// </summary>
        public DateTime Birth { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// 是否是会员
        /// </summary>
        public int Member { get; set; }
        /// <summary>
        /// 等级
        /// </summary>
        public int Grade { get; set; }
        /// <summary>
        /// 经验值
        /// </summary>
        public int GradeScore { get; set; }
        /// <summary>
        /// 粉丝总数
        /// </summary>
        public int FansNum { get; set; }
        /// <summary>
        /// 关注总数
        /// </summary>
        public int LikeNum { get; set; }
        /// <summary>
        /// 收藏总数
        /// </summary>
        public int EnshrineNum { get; set; }
        /// <summary>
        /// 硬币数量
        /// </summary>
        public int CoinNum { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 删除 / 注销 状态
        /// </summary>
        public int State { get; set; }
    }
}
