﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageUploadController : ControllerBase
    {
        public static IWebHostEnvironment _webHostEnvironment;
        public ImageUploadController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public class FileUpload
        {
            public IFormFile Files { get; set; }
        }

        [HttpPost, DisableRequestSizeLimit]
        public async Task<string> PostFileUpload([FromForm]FileUpload fileUpload)
        {
            try
            {
                if (fileUpload.Files.Length > 0)
                {
                    if (!Directory.Exists(_webHostEnvironment.WebRootPath + "\\Upload\\"))
                    {
                        Directory.CreateDirectory(_webHostEnvironment.WebRootPath + "\\Upload\\");
                    }
                    using (FileStream fileStream = System.IO.File.Create(_webHostEnvironment.WebRootPath + "\\Upload\\" + fileUpload.Files.FileName))
                    {
                        fileUpload.Files.CopyTo(fileStream);
                        fileStream.Flush();
                        return "\\Upload\\" + fileUpload.Files.FileName;
                    }
                }
                else
                {
                    return "Failed";
                }
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }
        }
    }
}
