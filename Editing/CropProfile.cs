using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ImageEditor.Editing
{
    public class CropProfile
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [DisplayName("Profile Name")]
        [StringLength(64)]
        [Required(ErrorMessage = "Profile Name is required")]
        public string Name { get; set; }
        [DisplayName("Default Width")]
        [Required(ErrorMessage = "Width is required")]
        public int Width { get; set; }
        [DisplayName("Default Height")]
        [Required(ErrorMessage = "Height is required")]
        public int Height { get; set; }
        [DisplayName("Crop Color")]
        [Required(ErrorMessage = "Color is required")]
        public int CropColor { get; set; }
        [DisplayName("Default Image Directory")]
        [Required(ErrorMessage = "Default Directory is required")]
        public string ImageDirectory { get; set; }

        public CropProfile Copy()
        {
            return (CropProfile)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return "Profile Name: " + Name + ", " +
                "Width: " + Width + ", " +
                "Height: " + Height + ", " +
                "Color: " + CropColor + ", " +
                "Dir: " + ImageDirectory;
        }
    }
}

