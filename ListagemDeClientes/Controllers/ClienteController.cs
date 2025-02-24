using ListagemDeClientes.DATA;
using ListagemDeClientes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Reflection.Metadata;

namespace ListagemDeClientes.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ApplicationDbContext _db;


        public ClienteController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            if (ModelState.IsValid)
            {
                TempData["MensagemAleatoria"] = "Bem-vindo de volta ao Home";
            }
            IEnumerable<Cliente> clientes = _db.Clientes;

            return View(clientes);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Cliente cliente)
        {
            if (ModelState.IsValid)
            {

                _db.Clientes.Add(cliente);
                _db.SaveChanges();

                TempData["MensagemSucesso"] = "Usuário Cadastrado com Sucesso !";

                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Editar(int? id, string nome)
        {
           

            if (id == null || id == 0)
            {
                return NotFound();
            }
            Cliente cliente = _db.Clientes.FirstOrDefault(x => x.Id == id);
            /*ar query = _db.Clientes.Where(p => p.Nome != null);*/

           

            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }

        [HttpPost]
        public IActionResult Editar(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _db.Clientes.Update(cliente);
                _db.SaveChanges();

                TempData["MensagemSucesso"] = "Usuário Editado com Sucesso !";

                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Cliente cliente = _db.Clientes.FirstOrDefault(X => X.Id == id);

            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }


        [HttpPost]
        public IActionResult Excluir(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _db.Clientes.Remove(cliente);
                _db.SaveChanges();

                TempData["MensagemSucesso"] = "Usuário Excluído com Sucesso" +
                    "!";


                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Logs()  
        {
            return View();
        }


        public IActionResult PerformAction()
        {
            // Lógica para a ação do usuário

            // Registra a ação no banco de dados
            var userAction = new UserAction
            {
                UserName = "Nome do Usuário",
                ActionDate = DateTime.Now
            };

            _db.UserActions.Add(userAction);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}
