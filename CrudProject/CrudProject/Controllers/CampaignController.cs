using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrudProject.Models;

namespace CrudProject.Controllers
{
    public class CampaignController : Controller
    {
        // GET: Campaign
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetData()
        {
            using (DBModel db = new DBModel())
            {
                List<Campaigns> empList = db.Campaigns.ToList<Campaigns>();
                return Json(new { date = empList }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}