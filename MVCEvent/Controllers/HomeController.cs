using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEvent.Controllers
{
    
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
      

        
        [HttpPost]
        public ActionResult Index(Models.User inloggning)
        
        {
            ServiceReference1.LogginClient client = new ServiceReference1.LogginClient();

            string answer = client.GetLoginData(inloggning.Username, inloggning.Password, "KodEven");

          

            if (inloggning.Username == null)
            {
                ModelState.AddModelError("", "Du måste fylla i ett användarnamn");
                return View();
            }
            if (inloggning.Password == null)
            {
                ModelState.AddModelError("", "Du måste fylla i ett lösenord");
                return View();
            }


            bool validUser = false;
            if (answer!= "")
            {
                validUser = true;
                System.Web.Security.FormsAuthentication.RedirectFromLoginPage(inloggning.Username, false);
            }
            ModelState.AddModelError("", "Inloggingen är ej godkänd");


            return View();
            
        }
    
    }
}