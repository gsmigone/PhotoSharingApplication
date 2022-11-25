using PhotoSharingApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace PhotoSharingApplication.Data
{
    public class PhotoSharingContext : DbContext
    {
        public PhotoSharingContext() : base("keyPhotoSharingDB")
        { }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}