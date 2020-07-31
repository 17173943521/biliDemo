

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Net.Http.Headers;
using System.IO;
using System.Threading.Tasks;

namespace bilibili.Controllers
{
    [Route("api/[controller]")]
    public class FileController : Controller
    {
        private readonly string _targetFilePath = "E:\\__bilibili\\bilibili\\bilibili\\wwwroot\\uploads";
        /// <summary>
        /// 流式文件上传
        /// </summary>
        /// <returns></returns>
        [HttpPost("UploadingStream")]
        public async Task<IActionResult> UploadingStream()
        {

            //获取boundary
            var boundary = HeaderUtilities.RemoveQuotes(MediaTypeHeaderValue.Parse(Request.ContentType).Boundary).Value;
            //得到reader
            var reader = new MultipartReader(boundary, HttpContext.Request.Body);
            //{ BodyLengthLimit = 2000 };//
            var section = await reader.ReadNextSectionAsync();

            //读取section
            while (section != null)
            {
                var hasContentDispositionHeader = ContentDispositionHeaderValue.TryParse(section.ContentDisposition, out var contentDisposition);
                if (hasContentDispositionHeader)
                {
                    var trustedFileNameForFileStorage = Path.GetRandomFileName();
                    await WriteFileAsync(section.Body, Path.Combine(_targetFilePath, trustedFileNameForFileStorage));
                }
                section = await reader.ReadNextSectionAsync();
            }
            return Created(nameof(FileController), null);
        }

        /// <summary>
        /// 缓存式文件上传
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        [HttpPost("UploadingFormFile")]
        public async Task<IActionResult> UploadingFormFile(IFormFile file)
        {
            using (var stream = file.OpenReadStream())
            {
                var trustedFileNameForFileStorage = Path.GetRandomFileName();
                await WriteFileAsync(stream, Path.Combine(_targetFilePath, trustedFileNameForFileStorage));
            }
            return Created(nameof(FileController), null);
        }


        /// <summary>
        /// 写文件导到磁盘
        /// </summary>
        /// <param name="stream">流</param>
        /// <param name="path">文件保存路径</param>
        /// <returns></returns>
        public static async Task<int> WriteFileAsync(System.IO.Stream stream, string path)
        {
            const int FILE_WRITE_SIZE = 84975;//写出缓冲区大小
            int writeCount = 0;
            using (FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write, FILE_WRITE_SIZE, true))
            {
                byte[] byteArr = new byte[FILE_WRITE_SIZE];
                int readCount = 0;
                while ((readCount = await stream.ReadAsync(byteArr, 0, byteArr.Length)) > 0)
                {
                    await fileStream.WriteAsync(byteArr, 0, readCount);
                    writeCount += readCount;
                }
            }
            return writeCount;
        }

    }
}