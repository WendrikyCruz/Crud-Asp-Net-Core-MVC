using Crud_Com_ASP.CORE_MVC.Database;
using Crud_Com_ASP.CORE_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_Com_ASP.CORE_MVC.Controllers
{
    public class EditarController : Controller
    {
        private DatabaseContext _db;

        public EditarController(DatabaseContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            Cliente cliente = _db.Clientes.Find(id);
            return View("Editar", cliente);
        }

        [HttpPost]
        public IActionResult Editar([FromForm] Cliente clienteUp)
        {
            if (ModelState.IsValid)
            {
                _db.Clientes.Update(clienteUp);
                _db.SaveChanges();
                TempData["CadastroFeedback"] = "Cadastro do  " + clienteUp.nome + " atualizado com sucesso! :)";
                return Redirect("\\Home\\Index");
            }

            return View("Editar", clienteUp);
        }


    }
}
