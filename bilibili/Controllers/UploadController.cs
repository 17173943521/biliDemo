
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace bilibili.Controllers
{
    public class UploadController : ControllerBase
    {

        #region One

        private readonly IWebHostEnvironment _hostingEnvironment;
        public UploadController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }


        /// <summary>
        /// 上传图片
        /// </summary>
        /// <returns></returns>
        public async Task<int> Upload()
        {
            try
            {
                IFormFileCollection files = Request.Form.Files;
                foreach (var file in files)
                {

                    //获取文件名后缀
                    string extName = Path.GetExtension(file.FileName).ToLower();
                    //获取保存目录的物理路径
                    if (System.IO.Directory.Exists(_hostingEnvironment.WebRootPath + "/upload/") == false)//如果不存在就创建images文件夹
                    {
                        System.IO.Directory.CreateDirectory(_hostingEnvironment.WebRootPath + "/upload/");
                    }
                    string path = _hostingEnvironment.WebRootPath + "/upload/"; //path为某个文件夹的绝对路径，不要直接保存到数据库
                                                                                //    string path = "F:\\TgeoSmart\\Image\\";
                                                                                //生成新文件的名称，guid保证某一时刻内图片名唯一（文件不会被覆盖）
                    string fileNewName = Guid.NewGuid().ToString();
                    string ImageUrl = path + fileNewName + extName;
                    //SaveAs将文件保存到指定文件夹中
                    using (var stream = new FileStream(ImageUrl, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    //此路径为相对路径，只有把相对路径保存到数据库中图片才能正确显示（不加~为相对路径）
                    string url = "\\upload\\" + fileNewName + extName;
                }
                //var file = files[0];

                return 1;
                //return Json(new
                //{
                //    Result = true,
                //    Data = url
                //});
            }
            catch (Exception exception)
            {
                return -1;
                //return Json(new
                //{
                //    Result = false,
                //    exception.Message
                //});
            }
        }




        #endregion

    }
}