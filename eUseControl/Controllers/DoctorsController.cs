using AutoMapper;
using eUseControl.Attribute;
using eUseControl.BusinessLogic.DBModel;
using eUseControl.BusinessLogic.Interfaces;
using eUseControl.Domain.Entities.Images;
using eUseControl.Models.Doctors;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eUseControl.Controllers
{
    public class DoctorsController : Controller
    {
        // GET: Doctors
      


            private IGalerie _galerie;

            public DoctorsController()
            {
                var bl = new BussinesLogic.BussinesLogic();
                _galerie = bl.GetGalerieBL();
            }



            public ActionResult Index()
            {
                var data = _galerie.GetGalerieData();

                PImageData new_list = new PImageData
                {
                    ImageList = new List<Image>()
                };

                foreach (var img in data)
                {
                    Mapper.Initialize(cfg => cfg.CreateMap<Image, Image>());
                    var local = Mapper.Map<Image>(img);
                    new_list.ImageList.Add(local);
                }

                return View(new_list);
            }



        [HttpPost]
        [AdminMode]
        [ValidateAntiForgeryToken]
        public ActionResult Add(PImageData model)
        {
            if (ModelState.IsValid)
            {
                if (model.ImageFile != null && model.ImageFile.ContentLength > 0)
                {
                    string fileName = Path.GetFileName(model.ImageFile.FileName);
                    string extension = Path.GetExtension(fileName);
                    string newFileName = Guid.NewGuid().ToString() + extension;
                    string fullPath = Path.Combine(Server.MapPath("~/Images/doctors/"), newFileName);
                    model.ImageFile.SaveAs(fullPath);

                    model.Image.ImagePath = "~/Images/doctors/" + newFileName;

                    // Salvare în baza de date
                    IDbTable new_img = new IDbTable();
                    Mapper.Initialize(cfg => cfg.CreateMap<Image, Image>());
                    var image = Mapper.Map<Image>(model.Image);

                    using (ImageContext db = new ImageContext())
                    {
                        new_img.ImageID = image.ImageID;
                        new_img.Title = image.Title;
                        new_img.ImagePath = image.ImagePath;

                        db.Images.Add(new_img);
                        db.SaveChanges();
                    }
                }
                return RedirectToAction("Index", "Doctors");
            }
            return View(model);
        }




        [AdminMode]
            public ActionResult ImageDelete(string ImageID)
            {
                var bl = new BussinesLogic.BussinesLogic();
                _galerie = bl.GetGalerieBL();
                int id = int.Parse(ImageID);
                _galerie.DeleteImage(id);
                return RedirectToAction("Index", "Doctors");
            }


        
    }
}