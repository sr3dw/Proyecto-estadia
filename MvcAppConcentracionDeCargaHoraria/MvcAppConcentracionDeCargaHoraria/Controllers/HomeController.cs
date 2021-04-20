using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcAppConcentracionDeCargaHoraria.Models;
using MvcAppConcentracionDeCargaHoraria;
namespace MvcAppConcentracionDeCargaHoraria.Controllers
{
    public class HomeController : Controller
    {
        clsUsuarios model = new clsUsuarios();
        public ActionResult Index()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Página de descripción de la aplicación.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Página de contacto.";

            return View();
        }
        public ActionResult Login() {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(tblUsuarios objuser)
        {
            if (ModelState.IsValid)
            {
                using (BDDistribucionDeCargasHorariasEntities db = new BDDistribucionDeCargasHorariasEntities())
                {
                    var obj = db.tblUsuarios.Where(a => a.vchEmail.Equals(objuser.vchEmail) && a.vchPass.Equals(objuser.vchPass)).FirstOrDefault();
                    if (obj!=null)
                    {
                        Session["idUsuario"] = obj.idUsuario.ToString();
                        Session["vchEmail"] = obj.vchEmail.ToString();
                        return RedirectToAction("UserDashBoard");
                    }
                }
            }
            return View(objuser);
        }
        public ActionResult UserDashBoard() {
            if (Session["idUsuario"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        public ActionResult Registrar() {
            return View();
        }
        [HttpPost]
        public ActionResult Registrar(tblUsuarios objUser)
        {
            try
            {
                if (model.Registrar(objUser).Equals("ok"))
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    return RedirectToAction("Registrar");
                }
            }
            catch (Exception)
            {
                return View();
                throw;
            }
        }
    }
}
