using eUseControl.BusinessLogic.Interfaces;
using eUseControl.BusinessLogic.LoginBL;
using eUseControl.BussinesLogic.Interfaces;

namespace eUseControl.BussinesLogic
{
    public class BussinesLogic
    {
        public ISession GetSessionBL()
        {
            return new SessionBL();
        }
        public IGalerie GetGalerieBL()
        {
            return new GalerieBL();
        }

       

    }
}
