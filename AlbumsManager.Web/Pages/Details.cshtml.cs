using AlbumsManager.Extensions;
using AlbumsManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AlbumsManager.Web.Pages
{
    public class DetailsModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string? FolderName { get; set; }
        public IEnumerable<AlbumItem>? Images { get; set; }

        private readonly IWebHostEnvironment _environment;

        public DetailsModel(IWebHostEnvironment environment)
        {
            _environment = environment;
        }
        public IActionResult OnGet()
        {
            if (String.IsNullOrEmpty(FolderName))
            {
                return RedirectToPage("Error");
            }
            var folder = Path.Combine(_environment.WebRootPath, "Images", FolderName);
            var manager = AlbumManagerBuilderExtensions.GetImagesFromFolder(folder);
            var viewer = manager.GetView();
            Images = viewer.Items;
            return Page();
        }
    }
}
