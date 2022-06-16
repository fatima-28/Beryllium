﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Helpers;

namespace Beryllium.Helpers
{
    public static class Extension
    {

        public static bool CheckFileType(this IFormFile file, string type)
        {
            return file.ContentType.Contains(type);
        }
        public static bool CheckFileSize(this IFormFile file,int size)
        {
            return file.Length / 1024 <= size;
        }
        public async static Task<string> SaveFileAsync(this IFormFile file, string root, params string[] folders)
        {
            var filename = Guid.NewGuid().ToString() + file.FileName;

            var resultPath = Path.Combine(Helper.GetPath(root, folders), filename);
            using (FileStream filestream =
                new FileStream(resultPath, FileMode.Create)
            )
            {
                await file.CopyToAsync(filestream);

            }
            return filename;
        }

    }
}
