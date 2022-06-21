using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_escola_2.Models
{
    public class Escola
    {
        public int Id { get; set; }

        public string NomeFantasia { get; set; }

        public string Razao { get; set; }

        public string Cnpj { get; set; }

        public string Inscricao_est { get; set; }

        public string Tipo { get; set; }

        public DateTime? Data_criacao { get; set; }

        public string Responsavel { get; set; }

        public string Telefone_res { get; set; }

        public string Email { get; set; }

        public string Telefone_esc { get; set; }

        public string Rua { get; set; }

        public string Numero { get; set; }

        public string Bairro { get; set; }

        public string Complemento { get; set; }

        public string Cep { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }
    }
}
