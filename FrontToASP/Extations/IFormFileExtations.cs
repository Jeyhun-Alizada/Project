using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace FrontToASP.Extations
{
    public static class IFormFileExtations
    {
        public static async Task<string> SaveFileAsync(this IFormFile file, string WebRootPath)
        {
            string uniqId = Guid.NewGuid().ToString();
            string newFileName = uniqId + file.FileName;
            string path = WebRootPath + "/IMG" + "/" + newFileName;
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(fs);
            }
            return newFileName;
        }
    }
}

