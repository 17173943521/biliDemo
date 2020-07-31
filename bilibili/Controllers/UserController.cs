using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace bilibili.Controllers
{
    public class UserController : Controller
    {

        /// <summary>
        /// 首页
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 动态
        /// publish 出版，发布
        /// </summary>
        /// <returns></returns>
        public IActionResult Publish()
        {
            return View();
        }
        /// <summary>
        /// 投稿
        /// upload  上传
        /// </summary>
        /// <returns></returns>
        public IActionResult Upload()
        {
            return View();
        }
        /// <summary>
        /// 频道
        /// channel 电视台，频道
        /// </summary>
        /// <returns></returns>
        public IActionResult Channel()
        {
            return View();
        }
        /// <summary>
        /// 收藏
        /// collect 收集，募捐
        /// </summary>
        /// <returns></returns>
        public IActionResult Collect()
        {
            return View();
        }
        /// <summary>
        /// 订阅
        /// subscribe   订阅，捐款，签数
        /// </summary>
        /// <returns></returns>
        public IActionResult Subscribe()
        {
            return View();
        }
        /// <summary>
        /// 设置
        /// amend   修改，改善
        /// </summary>
        /// <returns></returns>
        public IActionResult Amend()
        {
            return View();
        }
        /// <summary>
        /// 关注 & 粉丝
        /// CareFor 关心，喜欢
        /// </summary>
        /// <returns></returns>
        public IActionResult Carefor()
        {
            return View();
        }





        /// <summary>
        /// 历史记录
        /// </summary>
        /// <returns></returns>
        public IActionResult WatchRecord()
        {
            return View();
        }

        /// <summary>
        /// 登录页面
        /// </summary>
        /// <returns></returns>
        public IActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// 注册
        /// </summary>
        /// <returns></returns>
        public IActionResult Register()
        {
            return View();
        }


        public IActionResult Like()
        {
            return View();
        }
        


    }
}
