using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        public void nav(Form form, Panel panel)
        {
            form.TopLevel = false;
            form.Size = panel.Size; 
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Inicio home = new Inicio();
            nav(home, content);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public int verificaform() 
        {
            if (comboBox1.SelectedIndex == 0){ return 0; }
            else if (comboBox1.SelectedIndex == 1) { return 1; }
            return -1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro(this);
            if (verificaform() > -1) { nav(cad, content); }
            else MessageBox.Show("Insira um estado para prosseguir", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bRelatorio_Click(object sender, EventArgs e)
        {
            Relatorio rel = new Relatorio();
            nav(rel, content);
        }

        private void bInicio_Click(object sender, EventArgs e)
        {
            Inicio home = new Inicio();
            nav(home, content);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void content_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
