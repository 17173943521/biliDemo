

using bilibili.BLL;
using bilibili.Models;
//using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;





namespace bilibili.Controllers
{
    [Controller]
    public class AllFunctionController : ControllerBase
    {
        BllHelper bllHelper = new BllHelper();
        BllUser bUser = new BllUser();

        private readonly ILogger<AllFunctionController> _logger;

        public AllFunctionController(ILogger<AllFunctionController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="account"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public tb_User Login(string account, string password)
        {
            tb_User m = bUser.Login("select * from tb_User where Account='" + account + "'");
            if (m == null)
            {
                return null;
            }
            else if (m.Password != password)
            {
                m = new tb_User();
            }
            return m;

        }

        /// <summary>
        /// 获取所有标签
        /// </summary>
        /// <returns></returns>
        [System.Web.Http.HttpGet]
        public List<tb_Type> GetTypeAll()
        {
            return bllHelper.Select<tb_Type>();
        }

        /// <summary>
        /// 获取一个电影
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public tb_UserPersonalFilm GetFilmOne(int id)
        {
            return bllHelper.SqlQuery<tb_UserPersonalFilm>("select * from tb_UserPersonalFilm where ID = " + id)[0];

        }

        /// <summary>
        /// 获取部分电影
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public OkObjectResult GetFilm(int id)
        {
            return Ok(bllHelper.SqlQuery<UserFilmModel>("select top 12 uf.*,u.Name uName ,u.Motto uMotto,u.Image uImage from tb_UserPersonalFilm uf join tb_UserPersonalFilmType ut on uf.id = ut.FileId join tb_User u on u.ID = uf.UserId where ut.TypeId=" + id).Take(10));

        }

        /// <summary>
        /// 获取用户观看历史
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<tb_UserWatchRecord> GetUserWatchRecord(int id)
        {
            return bllHelper.SqlQuery<tb_UserWatchRecord>("select * from tb_UserWatchRecord where UserId=" + id);
        }


        //[System.Web.Http.HttpPost]
        public int AddUserImage()
        {
            return 1;
        }


    }
}







