﻿//https://github.com/Azure-Samples/dotnetcore-sqldb-tutorial

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bitcoin_TCC.Models
{
    public class ContatoKB
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Mensagem { get; set; }

    }
}


