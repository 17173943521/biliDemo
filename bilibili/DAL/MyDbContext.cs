using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using bilibili.Models;

namespace bilibili.DAL
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("Data Source=.;Initial Catalog=db_bilibili;User ID=sa;pwd=123456") { }
        public DbSet<tb_Film> film { get; set; }
        public DbSet<tb_FilmComment> filmComment { get; set; }
        public DbSet<tb_FilmInfo> filmInfo { get; set; }
        public DbSet<tb_FilmPerson> filmPeople { get; set; }
        public DbSet<tb_FilmType> filmType { get; set; }
        public DbSet<tb_Image> image { get; set; }
        public DbSet<tb_Person> people { get; set; }
        public DbSet<tb_Type> type { get; set; }
        public DbSet<tb_User> user { get; set; }
        public DbSet<tb_UserAddress> userAddress { get; set; }
        public DbSet<tb_UserEnshrine> userEnshrine { get; set; }
        public DbSet<tb_UserLike> userLike { get; set; }
        public DbSet<tb_UserNews> userNews { get; set; }
        public DbSet<tb_UserPersonalFilm> userPersonalFilm { get; set; }
        public DbSet<tb_UserPersonalFilmType> userPersonalFilmType { get; set; }
        public DbSet<tb_UserPraise> userPraise { get; set; }
        public DbSet<tb_UserInsertCoins> userInsertCoin { get; set; }
        public DbSet<tb_UserTransmit> userTransmit { get; set; }
        public DbSet<tb_UserType> userType { get; set; }
        public DbSet<tb_UserVip> userVips { get; set; }
        public DbSet<tb_UserWatchRecord> userWatchRecord { get; set; }
        public DbSet<tb_VipType> vipType { get; set; }
    }
}
