using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJUR.Aplicacao.DTOs
{
    public class UsuarioDTO
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Escolaridade { get; set; }

        public UsuarioDTO(DateTime dataNascimento, string email)
        {
            if(dataNascimento > DateTime.Today)
                throw new InvalidOperationException("A data de nascimento não pode ser maior que hoje.");
            if (!email.Contains("@"))
                throw new InvalidOperationException("Email inválido.");
            
            DataNascimento = dataNascimento;
            Email = email;
        }
    }
}
