using ListagemDeClientes.DATA;
using ListagemDeClientes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using System;

namespace ListagemDeClientes.Controllers
{
    public class UserController : Controller
    {

        private readonly ApplicationDbContext _db;


        public UserController(ApplicationDbContext db)
            {
                _db = db;
            }
          



    }
}
