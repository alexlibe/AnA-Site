using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AnA_Site.Pages
{
    public class VideoModel : PageModel
    {
        public void OnGet(string name)
        {
            
        }

        public IActionResult DownloadVideo(string videoName)
        {
            return null;
        }
    }
}