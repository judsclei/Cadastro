using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Q2
{
    public partial class Cadastro : Form
    {
        Form1 fm1;
        
        public Cadastro(Form1 f1)
        {
            InitializeComponent();
            fm1 = f1;
            if (fm1.comboBox1.SelectedIndex == 1)
            {
                labelRG.Visible = false;
                TextRG.Visible = false;
            }
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
        }
        private string dataCad() 
        {
            DateTime data = DateTime.Now;
            string format = "dd'/'MM'/'yyyy' as 'HH':'mm", datecad; 
            datecad= data.ToString(format);
            return datecad;
        }
        Func<string, int> obtemAnoNas = (string dataN) =>
         {
             String dataNova = dataN;
             dataNova = dataNova.Remove(0, 6);
             int ano = int.Parse(dataNova);
             return ano;
         };
        Func<int> ObtemAnoCorrente = () =>
        {
            DateTime data = DateTime.Now;
            string format = "yyyy", date;
            date = data.ToString(format);
            int horaint = Convert.ToInt32(date);
            return horaint;
        };
        Func<int, int, int> VerificaMaior = (datanas, anoCorrente) => anoCorrente - datanas;
        
        private void button1_Click(object sender, EventArgs e)
        {
            string estado;
            if (!TextCPF.MaskCompleted)
            { MessageBox.Show("Insira um CPF valido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);}
            string cpf = TextCPF.Text;

            if (Controle.verificaCliente(cpf) == true) 
            { 
                MessageBox.Show("Cliente ja cadastrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpaCampos();
            }

            if ((textNome.Text.Length < 3) && (textSobrenome.Text.Length < 3))
            { MessageBox.Show("Insira um nome valido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            string nome = textNome.Text + " " + textSobrenome.Text;

            string dataCAD = dataCad();

            if ((!TextDataNas.MaskFull))
            {
                MessageBox.Show("Insira uma data de nascimento valida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string dataN = TextDataNas.Text;

                if (fm1.comboBox1.SelectedIndex == 1)
                {
                    int anoCorrente = ObtemAnoCorrente();
                    if (VerificaMaior(obtemAnoNas(dataN), anoCorrente) < 18)
                    {
                        MessageBox.Show("Erro no cadastro Cliente menor de idade", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        limpaCampos();
                    }
                }

                if (TextTelefone.Text.Length < 8)
                { MessageBox.Show("Insira um Telefone valido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else 
                {
                    string telefone = TextTelefone.Text;
                    string rg;

                    if (fm1.comboBox1.SelectedIndex == 0)
                    {
                        estado = "SC";
                        if (!TextRG.MaskCompleted)
                        { MessageBox.Show("Insira um RG valido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        else
                        {
                            rg = TextRG.Text;

                            Controle.clientes.Add(new Cliente(nome, cpf, dataCAD, dataN, estado, rg, telefone));
                            MessageBox.Show("Cadastro completo", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpaCampos();
                        }
                    }
                    else
                    {
                        estado = "PR";
                        rg = "";
                        Controle.clientes.Add(new Cliente(nome, cpf, dataCAD, dataN, estado, rg, telefone));
                        MessageBox.Show("Cadastro completo", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpaCampos();
                    }
                }
            }
                


            

        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {
            if (textNome.Text.Length <3) 
                errorProvider1.SetError(this.textNome, "Insira um nome valido");

            else errorProvider1.Clear();
        }
        private void textSobrenome_TextChanged(object sender, EventArgs e)
        {
            if (textSobrenome.Text.Length < 3)
                errorProvider2.SetError(this.textSobrenome, "Insira um sobrenome valido");

            else errorProvider2.Clear();
        }
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
                
        }
        private void limpaCampos() 
        {
            TextCPF.Clear();
            textNome.Clear();
            textSobrenome.Clear();
            TextDataNas.Clear();
            TextTelefone.Clear();
            TextRG.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
