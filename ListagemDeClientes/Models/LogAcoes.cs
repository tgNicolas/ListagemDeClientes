namespace ListagemDeClientes.Models
{
    public class LogAcoes
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string Acao { get; set; }
        public DateTime DataAcao { get; set; }
    }
}
