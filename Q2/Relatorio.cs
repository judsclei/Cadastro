using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Q2
{
    public partial class Relatorio : Form
    {
        
        public Relatorio()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
            dataGridViewDadosCliente.DataSource = Controle.clientes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pesquisar pqAvancada = new Pesquisar();
            pqAvancada.ShowDialog();
        }
    }
}
