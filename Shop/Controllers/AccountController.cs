using System.Web.Mvc;
using System.Web.Security;
using AutoMapper;
using BLL.Interfaces.Models;
using BLL.Interfaces.Services;
using Shop.Models;

namespace Shop.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _service;

        public AccountController(IUserService service)
        {
            _service = service;
        }
        public ActionResult Login() //????
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                FormsAuthentication.SetAuthCookie(model.Name, true);
            }

            return View(model);
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                var user = Mapper.Map<User>(model);

                _service.AddUserAsync(user);

                FormsAuthentication.SetAuthCookie(model.Name, true);

                return RedirectToAction("../Action/Index");
            }
            else
            {
                ModelState.AddModelError("", "Пользователь с таким логином уже существует"); //??
            }

            return View(model);
        }
        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}
