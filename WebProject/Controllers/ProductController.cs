using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebProject.Controllers
{
    [Authorize(Roles = "SysAdmin,Admin,Customer")]
    public class ProductController : Controller
    {
        ProductManager pm = new ProductManager(new EfProductDal());

        public IActionResult Index()
        {
            var values = pm.GetList();
            return View(values);
        }
    }
}
