﻿using System;

namespace API_Teste.Models
{
    public class Cliente
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
