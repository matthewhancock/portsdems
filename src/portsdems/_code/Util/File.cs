﻿using System;
using System.IO;
using System.Threading.Tasks;

namespace Util {
    /// <summary>
    /// Summary description for File
    /// </summary>
    public static class File {
        public static async Task<string> LoadToString(string Path, string FileName) {
            string text = null;
            var f = Path + "/" + FileName;
            using (var sr = new StreamReader(f)) {
                text = await sr.ReadToEndAsync();
            }
            return text;
        }
        public static async Task<byte[]> LoadToBuffer(string Path, string FileName) {
            byte[] buffer = null;
            var f = Path + "/" + FileName;
            using (var fs = new FileStream(f, FileMode.Open, FileAccess.Read)) {
                using (var ms = new MemoryStream()) {
                    await fs.CopyToAsync(ms);
                    buffer = ms.ToArray();
                }
            }
            return buffer;
        }
    }
}