using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUseControl.BusinessLogic.Interfaces;
using eUseControl.BussinesLogic.Core;
using eUseControl.Domain.Entities.Images;

namespace eUseControl.BusinessLogic.LoginBL
{
    public class GalerieBL : UserApi, IGalerie
    {
        public List<Image> GetGalerieData()
        {
            return GetGalerieDataApi();
        }

        public void DeleteImage(int ImageId)
        {
            DeleteImageAction(ImageId);
        }
    }
}
