﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JPGame.Controllers
{
    public class GameController : Controller
    {
        private DBEntities db = new DBEntities();
        // GET: Game
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Detail(string slug,int id)
        {
            
            return View(db.Games.Find(id));
        }
        [HttpGet]
        public JsonResult Game(int page,int pageSize)
        {
            try
            {
                var data = db.Games.Select(a => new
                {
                    a.Id,
                    a.Name,
                    a.Des,
                    a.Slug,
                    a.Image,
                    a.Title,
                    a.ModifyDate,
                    a.ModifyBy,
                    a.PointReview
                }).OrderByDescending(x => x.ModifyDate).ToList();
                var pages = data.Count() % pageSize == 0 ? data.Count() / pageSize : data.Count() / pageSize + 1;
                data = data.Skip((page - 1) * pageSize).Take(pageSize).ToList();
                return Json(new { code = 200, data }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(new { code = 500, msg = "Thất Bại" + e.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}