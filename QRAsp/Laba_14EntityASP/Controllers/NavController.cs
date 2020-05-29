using Laba_14EntityASP.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Laba_14EntityASP.Controllers
{
    public class NavController : Controller
    {
        IUnitOfWork repository;
        //public NavController(IRepository<Category> repository)
        //{
        //    this.repository = repository;
        //}
        public NavController()
        {
            this.repository = new EFUnitOfWork();
        }
        public PartialViewResult Menu(string phone = null)
        {
            ViewBag.SelectedPhone = phone;
            IEnumerable<string> phones = repository.Phones.GetAll().Select(c => c.PhoneNumber);
            return PartialView(phones);
        }
    }
}