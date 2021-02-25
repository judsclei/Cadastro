
namespace Q2
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textSobrenome = new System.Windows.Forms.TextBox();
            this.labelCPF = new System.Windows.Forms.Label();
            this.TextCPF = new System.Windows.Forms.MaskedTextBox();
            this.labelRG = new System.Windows.Forms.Label();
            this.TextRG = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextDataNas = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(252, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Area de cadastro do cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(103, 115);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(233, 23);
            this.textNome.TabIndex = 2;
            this.textNome.TextChanged += new System.EventHandler(this.textNome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sobrenome:";
            // 
            // textSobrenome
            // 
            this.textSobrenome.Location = new System.Drawing.Point(444, 115);
            this.textSobrenome.Name = "textSobrenome";
            this.textSobrenome.Size = new System.Drawing.Size(248, 23);
            this.textSobrenome.TabIndex = 4;
            this.textSobrenome.TextChanged += new System.EventHandler(this.textSobrenome_TextChanged);
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(54, 166);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(31, 15);
            this.labelCPF.TabIndex = 5;
            this.labelCPF.Text = "CPF:";
            // 
            // TextCPF
            // 
            this.TextCPF.Location = new System.Drawing.Point(103, 163);
            this.TextCPF.Mask = "000.000.000-00";
            this.TextCPF.Name = "TextCPF";
            this.TextCPF.Size = new System.Drawing.Size(174, 23);
            this.TextCPF.TabIndex = 6;
            this.TextCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // labelRG
            // 
            this.labelRG.AutoSize = true;
            this.labelRG.Location = new System.Drawing.Point(413, 211);
            this.labelRG.Name = "labelRG";
            this.labelRG.Size = new System.Drawing.Size(25, 15);
            this.labelRG.TabIndex = 7;
            this.labelRG.Text = "RG:";
            // 
            // TextRG
            // 
            this.TextRG.Location = new System.Drawing.Point(444, 208);
            this.TextRG.Mask = "00.000.000";
            this.TextRG.Name = "TextRG";
            this.TextRG.Size = new System.Drawing.Size(145, 23);
            this.TextRG.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefone: ";
            // 
            // TextTelefone
            // 
            this.TextTelefone.Location = new System.Drawing.Point(117, 208);
            this.TextTelefone.Mask = "(00) 00000-0000";
            this.TextTelefone.Name = "TextTelefone";
            this.TextTelefone.Size = new System.Drawing.Size(160, 23);
            this.TextTelefone.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data de nascimento:";
            // 
            // TextDataNas
            // 
            this.TextDataNas.Location = new System.Drawing.Point(444, 163);
            this.TextDataNas.Mask = "00/00/0000";
            this.TextDataNas.Name = "TextDataNas";
            this.TextDataNas.Size = new System.Drawing.Size(100, 23);
            this.TextDataNas.TabIndex = 12;
            this.TextDataNas.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(398, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 14;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextDataNas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextTelefone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextRG);
            this.Controls.Add(this.labelRG);
            this.Controls.Add(this.TextCPF);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.textSobrenome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSobrenome;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.MaskedTextBox TextCPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox TextTelefone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox TextDataNas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelRG;
        private System.Windows.Forms.MaskedTextBox TextRG;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}