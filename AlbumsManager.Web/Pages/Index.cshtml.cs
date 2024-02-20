using AlbumsManager.Configurations.FolderAlbum;
using AlbumsManager.Creators.FolderTreeAlbum;
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
        
        public AlbumManager<AlbumDirectory> Manager { get; protected set; }

        public IndexModel(ILogger<IndexModel> logger, IWebHostEnvironment environment)
        {
            _logger = logger;
            _environment = environment;
        }


        public async Task OnGet()
        {
            var folder = Path.Combine(_environment.WebRootPath, "Images");
            _logger.LogInformation(folder);
            Manager = await AlbumManagerBuilderExtensions.GetImagesFromFolderTreesAsync(folder, false);
            Directories = await Manager.GetViewAsync(); 
        }
    }
}
