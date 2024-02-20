namespace AlbumsManager.Models
{
    public abstract class ItemBase
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public virtual bool CanBeWatermark => true;
        public virtual bool HasItems => false;

    }
}