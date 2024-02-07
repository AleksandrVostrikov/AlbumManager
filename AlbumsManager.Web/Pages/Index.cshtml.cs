using AlbumsManager.Extensions;
using AlbumsManager.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AlbumsManager.Web.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<AlbumDirectory>? Directories { get; set; }

        private readonly ILogger<IndexModel> _logger;
        private readonly IWebHostEnvironment _environment;

        public IndexModel(ILogger<IndexModel> logger, IWebHostEnvironment environment)
        {
            _logger = logger;
            _environment = environment;
        }


        public void OnGet()
        {
            var folder = Path.Combine(_environment.WebRootPath, "Images");
            _logger.LogInformation(folder);
            var manager = AlbumManagerBuilderExtensions.GetImagesFromFolderTree(folder);
            var viewer = manager.GetView();
            Directories = viewer.Items;
        }
    }
}
