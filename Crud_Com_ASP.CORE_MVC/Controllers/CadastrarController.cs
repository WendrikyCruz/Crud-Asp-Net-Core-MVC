using Crud_Com_ASP.CORE_MVC.Database;
using Crud_Com_ASP.CORE_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_Com_ASP.CORE_MVC.Controllers
{
    public class CadastrarController : Controller
    {
        private DatabaseContext _db;

        public CadastrarController(DatabaseContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View("Index", new Cliente());
        }

        [HttpPost]
        public ActionResult Cadastrar([FromForm] Cliente cliente)
        {

            if (ModelState.IsValid)
            {
                _db.Clientes.Add(cliente);
                _db.SaveChanges();
                TempData["CadastroFeedback"] = "Cliente " + cliente.nome + " cadastrado com sucesso! :)";
                return Redirect("\\Home\\Index");
            }


            return View("Index", cliente);
        }

    }
}
