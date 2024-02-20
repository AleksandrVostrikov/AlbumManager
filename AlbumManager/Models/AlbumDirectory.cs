namespace AlbumsManager.Models
{
    public class AlbumDirectory : ItemBase
    {
        public IEnumerable<AlbumItem>? Items { get; set; }
        public override bool CanBeWatermark => false;
        public override bool HasItems => true;
    }
}
