namespace Cadastro.Api2.Models
{
    public class Usuario_Endereco
    {
        //Usuario
        public int id_Usuario { get; set; }
        public string nome_Usuario { get; set; }
        public int idade_Usuario { get; set; }
        public string sexo_Usuario { get; set; }

        //Endereco
        public int id_Endereco { get; set; }
        public int id_usuario_Endereco { get; set; }
        public string rua_Endereco { get; set; }
        public int numero_Endereco { get; set; }
        public string cep_Endereco { get; set; }
    }
}
