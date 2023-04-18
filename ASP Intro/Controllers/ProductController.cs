using Microsoft.AspNetCore.Mvc;

namespace AspIntro.Controllers
{
  
        public class ProductController : Controller
        {


            public ViewResult Detail()
            {
                ViewResult result = new ViewResult();
                result.ViewName = "Detail";
                return result;
            }

        

        public ContentResult Index(int id)
        {
            return Content(id.ToString());
        }

    }
}

