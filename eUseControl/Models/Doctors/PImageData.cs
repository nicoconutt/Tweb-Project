using eUseControl.Domain.Entities.Images;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eUseControl.Models.Doctors
{
    public class PImageData
    {
        public Image Image { get; set; }
        public List<Image> ImageList { get; set; }
        public HttpPostedFileBase ImageFile { get; set; }
    }
}