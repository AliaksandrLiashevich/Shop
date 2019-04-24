using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.Interfaces.Services;

namespace Shop.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService _service;

        public CartController(ICartService service)
        {
            _service = service;
        }

        public ActionResult AddCart(string userName)
        {
            _service.AddCartAsync(userName);

            return RedirectToAction("../Home/About");
        }
    }
}