using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private IMongoCollection<Employee> collection;
        public HomeController()
        {
            var client = new MongoClient("mongodb+srv://admin:admin@cluster0.cnzt7.mongodb.net/MongoDbTest?retryWrites=true&w=majority");
            IMongoDatabase db = client.GetDatabase("MongoDbTest");
            this.collection = db.GetCollection<Employee>("Employees");
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}