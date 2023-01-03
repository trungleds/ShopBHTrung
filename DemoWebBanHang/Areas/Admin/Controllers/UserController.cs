using DemoWebBanHang.Commom;
using Model.Dao;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using System.Web.Services.Protocols;
using System.Web.Script.Serialization;
using System.Web.WebPages;
using DemoWebBanHang.Areas.Admin.Models;

namespace DemoWebBanHang.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        private OnLineShopDbContext _context;
        public UserController()
        {
            _context = new OnLineShopDbContext();
        }


        // GET: Admin/User

        /*   public ActionResult Index(string searchString, int page = 1, int pageSize = 2)
           {
               var dao = new UserDao();
               var model = dao.LisAllPaging(searchString, page, pageSize);
               ViewBag.SearchString = searchString;
               return View(model);
           }*/
        public ActionResult Index()
        {
            var user = _context.Users.ToList();
            ViewBag.Users = user;

            return View();
        }

        [HttpPost]
        public ActionResult AddUser(User users)
        {
            _context.Users.Add(users);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }



        /* [HttpPost]
         public ActionResult Create(User user)
         {
             if (ModelState.IsValid)
             {
                 var dao = new UserDao();
                 var encryptedMd5Pas = Encryptor.MD5Hash(user.Password);
                 user.Password = encryptedMd5Pas;
                 long id = dao.Insert(user);
                 if (id > 0)
                 {
                     return RedirectToAction("Index", "User");
                 }
                 else
                 {
                     ModelState.AddModelError("", "Thêm User thành công");
                 }
             }

             return View("Index");
         }

         // Update User 
         public ActionResult Edit(int id)
         {
             var user = new UserDao().ViewDetail(id);
             return View(user);
         }


         [HttpPost]
         public ActionResult Edit(User user)
         {
             if (ModelState.IsValid)
             {
                 var dao = new UserDao();
                 if (!string.IsNullOrEmpty(user.Password))
                 {
                     var encryptedMd5Pas = Encryptor.MD5Hash(user.Password);
                     user.Password = encryptedMd5Pas;
                 }

                 var result = dao.Update(user);
                 if (result)
                 {
                     return RedirectToAction("Index", "User");
                 }
                 else
                 {
                     ModelState.AddModelError("", "Cập nhật User thành công");
                 }
             }

             return View("Index");
         }
         [HttpDelete]
         public ActionResult Delete(int id) {

             new UserDao().Delete(id);
             return RedirectToAction("Index");
         }
 */


    }
    }
