using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laba_14EntityASP.Models;
using Laba_14EntityASP.Repositories;
using Laba_14EntityASP.Utils;


namespace Laba_14EntityASP.Controllers
{
    public class HomeController : Controller
    {
        IUnitOfWork unit;
        public HomeController(IUnitOfWork u)
        {
            unit = u;
        }
        public HomeController()
        {
            unit = new EFUnitOfWork();
        }
        [HttpGet]
        public ActionResult Index(string phone, int page = 1)
        {

            int pageSize = 2;
            PageInfo pageInfo = new PageInfo
            {
                PageNumber = page,
                PageSize = pageSize,
                TotalItems = phone == null ? unit.QuestRooms.GetAll().Count() :
                unit.QuestRooms.GetAll().Where(g => g.Phone.PhoneNumber == phone).Count()
            };
            IEnumerable<QuestRoom> rooms = phone == null ? unit.QuestRooms.GetAll().
                OrderBy(g => g.Id).
                Skip((page - 1) * pageSize).Take(pageSize)
                : unit.QuestRooms.GetAll().
                Where(g => g.Phone.PhoneNumber == phone).
                OrderBy(g => g.Id).
                Skip((page - 1) * pageSize).Take(pageSize);

            IndexViewModel viewModel = new IndexViewModel
            {
                QuestRooms = rooms,
                PageInfo = pageInfo,
                SelectedPhone = phone
            };
            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var room = unit.QuestRooms.GetById(id);
            if (room != null)
                return View(room);
            else
                return new HttpNotFoundResult("quest room doesn't found");
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Phones = new SelectList(unit.Phones.GetAll(), "Id", "PhoneNumber");
            return View();
        }

        [HttpPost]
        public ActionResult Create(QuestRoom room)
        {
           
            if (ModelState.IsValid)
            {

                unit.QuestRooms.Add(room);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            QuestRoom room = unit.QuestRooms.GetById(id);
            ViewBag.Phones = new SelectList(unit.Phones.GetAll(), "Id", "PhoneNumber", room.PhoneId);
            return View(room);
        }

        [HttpPost]
        public ActionResult Edit(QuestRoom room)
        {
            if (ModelState.IsValid)
            {
                unit.QuestRooms.Update(room);
                return RedirectToAction("Index");
            }
            else
                return View(room);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            QuestRoom room = unit.QuestRooms.GetById(id);
            if (room != null)
            {
                return View(room);
            }
            else return new HttpNotFoundResult("quest room doesn't found");
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            unit.QuestRooms.Delete(id);
            return RedirectToAction("Index");


        }
    }
}