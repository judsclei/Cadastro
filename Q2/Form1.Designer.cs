
namespace Q2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.content = new System.Windows.Forms.Panel();
            this.bInicio = new System.Windows.Forms.Button();
            this.bCadastro = new System.Windows.Forms.Button();
            this.bRelatorio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.Location = new System.Drawing.Point(205, 0);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(908, 518);
            this.content.TabIndex = 0;
            this.content.Paint += new System.Windows.Forms.PaintEventHandler(this.content_Paint);
            // 
            // bInicio
            // 
            this.bInicio.Location = new System.Drawing.Point(50, 184);
            this.bInicio.Name = "bInicio";
            this.bInicio.Size = new System.Drawing.Size(107, 32);
            this.bInicio.TabIndex = 1;
            this.bInicio.Text = "Inicio";
            this.bInicio.UseVisualStyleBackColor = true;
            this.bInicio.Click += new System.EventHandler(this.bInicio_Click);
            // 
            // bCadastro
            // 
            this.bCadastro.Location = new System.Drawing.Point(50, 222);
            this.bCadastro.Name = "bCadastro";
            this.bCadastro.Size = new System.Drawing.Size(107, 32);
            this.bCadastro.TabIndex = 2;
            this.bCadastro.Text = "Cadastro";
            this.bCadastro.UseVisualStyleBackColor = true;
            this.bCadastro.Click += new System.EventHandler(this.button2_Click);
            // 
            // bRelatorio
            // 
            this.bRelatorio.Location = new System.Drawing.Point(50, 260);
            this.bRelatorio.Name = "bRelatorio";
            this.bRelatorio.Size = new System.Drawing.Size(107, 34);
            this.bRelatorio.TabIndex = 3;
            this.bRelatorio.Text = "Relatorio";
            this.bRelatorio.UseVisualStyleBackColor = true;
            this.bRelatorio.Click += new System.EventHandler(this.bRelatorio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selecione o estado:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SC",
            "PR"});
            this.comboBox1.Location = new System.Drawing.Point(50, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(107, 23);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Selecione";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 514);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bRelatorio);
            this.Controls.Add(this.bCadastro);
            this.Controls.Add(this.bInicio);
            this.Controls.Add(this.content);
            this.Name = "Form1";
            this.Text = "Questão 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bInicio;
        private System.Windows.Forms.Button bCadastro;
        private System.Windows.Forms.Button bRelatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Panel content;
    }
}

