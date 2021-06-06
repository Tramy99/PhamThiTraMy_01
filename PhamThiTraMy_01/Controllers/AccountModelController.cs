using PhamThiTraMy_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace PhamThiTraMy_01.Controllers
{
    public class AccountModelController : Controller
    {
		// GET: AccountModel
		public ViewResult Login(string returnUrl)
		{
			ViewBag.returnUrl = returnUrl;
			return View();
		}
		[HttpPost]
		[AllowAnonymous]
		[ValidateAntiForgeryToken]
		public ActionResult Login(AccountModel acc, string returnUrl)
		{
			if (ModelState.IsValid)
			{
				if (acc.Username == "Admin" && acc.Password == "123456")
				{
					FormsAuthentication.SetAuthCookie(acc.Username, true);
					return RedirectToLocal(returnUrl);
				}
			}
			return View(acc);
		}
		public ActionResult Logoff()
		{
			FormsAuthentication.SignOut();
			return RedirectToAction("Index", "Home");
		}
		private ActionResult RedirectToLocal(string returnUrl)
		{
			if (Url.IsLocalUrl(returnUrl))
			{
				return Redirect(returnUrl);
			}
			else
			{
				return RedirectToAction("Index", "Home");
			}
		}

	}
}