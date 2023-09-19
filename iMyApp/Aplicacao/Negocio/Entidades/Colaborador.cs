using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public class Colaborador
    {
        public Colaborador(string nome, string cpf, DateTime nascimento, string email, bool status, DateTime criadoEm, string criadoPor)
        {
            nome = Nome;
            cpf = Cpf;
            nascimento = Nascimento;
            email = Email;
            status = Status;
            criadoEm = CriadoEm;
            criadoPor = CriadoPor;
        }
    }
}
