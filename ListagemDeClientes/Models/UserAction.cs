using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ListagemDeClientes.Models
{
    public class UserAction
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public DateTime ActionDate { get; set; }
    }
}
