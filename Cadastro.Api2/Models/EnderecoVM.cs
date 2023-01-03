namespace Cadastro.Api2.Models
{
    public class EnderecoVM
    {
        public int id { get; set; }
        public int id_usuario { get; set; }
        public string rua { get; set; }
        public int numero { get; set; }
        public string cep { get; set; }
    }
}
