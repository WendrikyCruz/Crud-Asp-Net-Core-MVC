using Crud_Com_ASP.CORE_MVC.Database;
using Crud_Com_ASP.CORE_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_Com_ASP.CORE_MVC.Controllers
{
    public class HomeController : Controller
    {
        private DatabaseContext _db;

        public HomeController(DatabaseContext db)
        {
            _db = db;

        }

        public ActionResult Index()
        {
            var clientes = _db.Clientes.ToList();
            return View(clientes);
        }

        public ActionResult Excluir(int id)
        {
            Cliente cliente = new Cliente();
            cliente = _db.Clientes.Find(id);
            _db.Clientes.Remove(cliente);
            _db.SaveChanges();
            TempData["MensagemExcluir"] = "O registro '" + cliente.nome + "' foi excluido com sucesso!";
            return RedirectToAction("Index");
        }


    }
}
