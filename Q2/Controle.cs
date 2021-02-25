using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Linq;
namespace Q2
{
    class Controle
    {
        public static List<Cliente> clientes = new List<Cliente>();

        public static bool verificaCliente(string cpf)
        {
            var query = from c in clientes
                        where c.CPF.StartsWith(cpf)
                        select c;
            int nregistros = query.Count();
            if (nregistros > 0) { return true; }
            return false;
        }
    }
}
