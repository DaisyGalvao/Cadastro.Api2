using Cadastro.Api2.Models;
using Cadastro.Api2.Repositories;

namespace Cadastro.Api2.Services
{
    public class CadastroService
    {
        CadastroRepository CadastroRepository = new CadastroRepository();

        public Usuario_Endereco Create(Usuario_Endereco usuarioEndereco)
        {
            UsuarioVM usuario = new UsuarioVM
            {
                nome = usuarioEndereco.nome_Usuario,
                idade = usuarioEndereco.idade_Usuario,
                sexo = usuarioEndereco.sexo_Usuario
            };
            var id = CadastroRepository.CreateUsuario(usuario);

            EnderecoVM endereco = new EnderecoVM
            {
                id_usuario = id,
                rua = usuarioEndereco.rua_Endereco,
                numero = usuarioEndereco.numero_Endereco,
                cep = usuarioEndereco.cep_Endereco
            };

            CadastroRepository.CreateEndereco(endereco);

            return usuarioEndereco;
        }
    }
}

