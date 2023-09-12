﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades.Comum
{
    public abstract class Pessoa : EntidadeBase
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public  string Email { get; set; }
        public string Telefone { get; set; }
    }
}
