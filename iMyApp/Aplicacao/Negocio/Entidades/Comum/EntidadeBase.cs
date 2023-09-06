﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades.Comum
{
    public abstract class EntidadeBase
    {
        public int Id { get; set; }
        public DateTime CriadoEm { get; set; }
        public string CriadoPor { get; set; }
        public DateTime AlteradoEm { get; set; }
        public string AlteradoPor { get; set; }
    }
}
