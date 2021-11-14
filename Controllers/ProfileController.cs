using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace DiSeperduaCoffee.Controllers
{
    public class ProfileController : Controller
    {
        public async Task<IActionResult> Avatar(string fileName)
        {
            var avatarFile = Path.Combine(Directory.GetCurrentDirectory(), "Avatars", fileName);
            new FileExtensionContentTypeProvider(). TryGetContentType(avatarFile, out var contentType);
            var fileBytes = await System.IO.File.ReadAllBytesAsync(avatarFile);
            return File(fileBytes, contentType ?? "application/octet-stream");
        }
    }
}
