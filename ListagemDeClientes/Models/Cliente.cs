using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ListagemDeClientes.Models
{
    public class Cliente
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        
        [Required(ErrorMessage = "Digite o Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o Email")]
        public string Email { get; set; }   

        [Required(ErrorMessage = "Digite o Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Digite o Cargo")]
        public string Cargo { get; set; }
    }
}
