﻿using AlbumsManager.Base;
using AlbumsManager.Configurations.FolderAlbum;
using AlbumsManager.Models;

namespace AlbumsManager.Creators.FolderAlbum
{
    public sealed class FolderAlbumManagerCreator : AlbumManagerCreatorBase<CreatorConfiguration, AlbumItem>
    {
        public FolderAlbumManagerCreator(CreatorConfiguration configuration) : base(configuration) { }


        public override List<AlbumItem> GetItems()
        {
            if (!Path.Exists(Config.SourcePath))
            {
                return new List<AlbumItem>();
            }

            var directory = new DirectoryInfo(Config.SourcePath);
            var files = directory.GetFiles();

            if (!files.Any())
            {
                return new List<AlbumItem>();
            }

            // TODO: Description 

            return files.Select(f => new AlbumItem
            {
                FileName = f.Name,
                Description = f.DirectoryName,
                FileSize = f.Length
            }).ToList();
        }
    }
}
