using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoginReg.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace LoginReg.Controllers
{
    public class DashboardController : Controller
    {
        private LoginRegContext dbContext;

        public DashboardController(LoginRegContext context)
        {
            dbContext = context;
        }

        [Route("dashboard")]
        [HttpGet]
        public IActionResult Dashboard()
        {
            int? userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
                return RedirectToAction("Index", "Home");
            List<Wedding> AllWeddings = dbContext.Weddings
            .Include(w => w.Guests)
            .OrderBy(w => w.WeddingDate)
            .ToList();
            ViewBag.UserId = userId;

            return View("Dashboard", AllWeddings);
        }
        [Route("add/activity")]
        [HttpGet]
        public IActionResult AddWedding()
        {
            int? userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
                return RedirectToAction("Index", "Home");

            return View("AddWedding");
        }
        [Route("create/wedding")]
        [HttpPost]
        public IActionResult CreateWedding(Wedding newWedding)
        {
            int? userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
                return RedirectToAction("Index", "Home");

            if (ModelState.IsValid)
            {
                var oneUser = dbContext.Users.FirstOrDefault(w => w.UserId == userId);
                newWedding.CreatorName = oneUser.FirstName;
                newWedding.UserId = (int)userId;
                dbContext.Add(newWedding);
                dbContext.SaveChanges();
                return RedirectToAction("Dashboard");
            }

            return View("AddWedding");
        }
        [Route("join/wedding/{weddingId}")]
        [HttpGet]
        public IActionResult JoinWedding(int weddingId)
        {
            int? userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
                return RedirectToAction("Index", "Home");
            var oneWedding = dbContext.Weddings.FirstOrDefault(w => w.WeddingId == weddingId);

            Association newAssociation = new Association()
            {
                UserId = (int)userId,
                WeddingId = weddingId
            };

            dbContext.Associations.Add(newAssociation);
            oneWedding.Guests.Add(newAssociation);
            dbContext.SaveChanges();

            return RedirectToAction("Dashboard");
        }
        [Route("leave/wedding/{weddingId}")]
        [HttpGet]
        public IActionResult LeaveWedding(int weddingId)
        {
            int? userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
                return RedirectToAction("Index", "Home");

            var oneAssociation = dbContext.Associations
            .FirstOrDefault(a => a.WeddingId == weddingId && a.UserId == userId);

            dbContext.Associations.Remove(oneAssociation);
            dbContext.SaveChanges();

            return RedirectToAction("Dashboard");
        }
        [Route("view/{weddingId}")]
        [HttpGet]
        public IActionResult ViewWedding(int weddingId)
        {
            int? userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
                return RedirectToAction("Index", "Home");

            Wedding oneWedding = dbContext.Weddings
            .Include(w => w.Guests)
            .ThenInclude(a => a.User)
            .FirstOrDefault(w => w.WeddingId == weddingId);
            ViewBag.UserId = userId;
            return View("ViewWedding", oneWedding);
        }
                [Route("/delete/{weddingId}")]
        [HttpGet]
        public IActionResult DeleteWedding(int weddingId)
        {
            Wedding oneWedding = dbContext.Weddings.FirstOrDefault(w => w.WeddingId == weddingId);
            dbContext.Remove(oneWedding);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

    }
}
