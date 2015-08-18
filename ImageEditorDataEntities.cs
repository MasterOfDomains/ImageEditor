using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ImageEditor.Editing;

namespace ImageEditor
{
    class ImageEditorDataEntities : DbContext
    {
        public DbSet<CropProfile> CropProfiles { get; set; }
    }
}
