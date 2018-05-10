using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Website.Models;

namespace Website.Controllers
{
    public class TodosController : Controller
    {
        private TodosDB db = new TodosDB();

        // GET: Todos
        public ActionResult Index()
        {
            return View(db.Todos.ToList());
        }
    }
}
