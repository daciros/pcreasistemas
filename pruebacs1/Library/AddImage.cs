using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace pruebacs1.Library
{
    public class AddImage
    {
        public async Task<Byte[]> ByteAvatarImageAsync(IFormFile AvatarImage, IWebHostEnvironment environment)
        {
            string image = "images/images/default.png";
            if (AvatarImage != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await AvatarImage.CopyToAsync(memoryStream);
                    return memoryStream.ToArray();
                }
            }
            else
            {
                var fileOrigin = $"{environment.ContentRootPath}/wwwroot/{image}";
                return File.ReadAllBytes(fileOrigin);
            }
        }
    }
}
