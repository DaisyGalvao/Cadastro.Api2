using Cadastro.Api2.Models;
using Dapper;
using System.Data.SqlClient;
using System.Linq;

namespace Cadastro.Api2.Repositories
{
    public class CadastroRepository
    {
        public int CreateUsuario(UsuarioVM usuario)
        {
            var query = @"insert into usuario values
	                      (
                            @Nome,
                            @Idade,
	                        @Sexo
	                      ) 
	                      SELECT SCOPE_IDENTITY()";

            using (var conn = new SqlConnection("Server=DAISY\\SQLEXPRESS; Database=Cadastro; User Id=sa; Password=anonimo;"))
            {
                var id = conn.Query<int>(query, new
                {
                    Nome = usuario.nome,
                    Idade = usuario.idade,
                    Sexo = usuario.sexo
                }).FirstOrDefault();

                return id;
            }
        }

        public int CreateEndereco(EnderecoVM endereco)
        {
            var query = @"insert into endereco values
	                      (
                            @Id_usuario,
                            @Rua,
	                        @Numero,
	                        @Cep
	                      ) 
	                      SELECT SCOPE_IDENTITY()";

            using (var conn = new SqlConnection("Server=DAISY\\SQLEXPRESS; Database=Cadastro; User Id=sa; Password=anonimo;"))
            {
                var id = conn.Query<int>(query, new
                {
                    Id_usuario = endereco.id_usuario,
                    Rua = endereco.rua,
                    Numero = endereco.numero,
                    Cep = endereco.cep
                }).FirstOrDefault();

                return id;
            }
        }
    }
}
