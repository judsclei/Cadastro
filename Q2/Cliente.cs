using System;
using System.Collections.Generic;
using System.Text;

namespace Q2
{
    class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Data_Cadastro { get; set; }
        public string Data_Nascimento { get; set; }
        public string Estado { get; set; }
        public string RG { get; set; }
        public string Telefone { get; set; }
        public Cliente(string nome, string cpf, string datacad, string datanas, string estado, string rg, string telefone)
        {
            Nome = nome;
            CPF = cpf;
            Data_Cadastro = datacad;
            Data_Nascimento = datanas;
            Estado = estado;
            RG = rg;
            Telefone = telefone;
        }
    }
}
