using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Q2
{
    public partial class Pesquisar : Form
    {
        public Pesquisar()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FiltroAvanc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Pesquisar_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = Controle.clientes;
        }

        private void barraPesquisa_TextChanged(object sender, EventArgs e)
        {
            string dado;
            if (FiltroAvanc.SelectedIndex == 0)
            {
                dado = barraPesquisa.Text;
                dataGridView.DataSource = Controle.clientes.Where(c => c.Nome.StartsWith(dado)).ToList();
            }
            if (FiltroAvanc.SelectedIndex == 1)
            {
                dado = barraPesquisa.Text;
                dataGridView.DataSource = Controle.clientes.Where(c => c.Data_Cadastro.StartsWith(dado)).ToList();
            }
            if (FiltroAvanc.SelectedIndex == 2)
            {
                dado = barraPesquisa.Text;
                dataGridView.DataSource = Controle.clientes.Where(c => c.Data_Nascimento.StartsWith(dado)).ToList();
            }

        }
    }
}
