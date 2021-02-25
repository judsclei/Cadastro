
namespace Q2
{
    partial class Pesquisar
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
            this.FiltroAvanc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.barraPesquisa = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltroAvanc
            // 
            this.FiltroAvanc.FormattingEnabled = true;
            this.FiltroAvanc.Items.AddRange(new object[] {
            "Nome",
            "Data Cadastro",
            "Data de nascimento"});
            this.FiltroAvanc.Location = new System.Drawing.Point(110, 79);
            this.FiltroAvanc.Name = "FiltroAvanc";
            this.FiltroAvanc.Size = new System.Drawing.Size(121, 23);
            this.FiltroAvanc.TabIndex = 0;
            this.FiltroAvanc.Text = "Selecione";
            this.FiltroAvanc.SelectedIndexChanged += new System.EventHandler(this.FiltroAvanc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(260, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insira o filtro a ser pesquisado ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pesquisar por:";
            // 
            // barraPesquisa
            // 
            this.barraPesquisa.Location = new System.Drawing.Point(260, 79);
            this.barraPesquisa.Name = "barraPesquisa";
            this.barraPesquisa.Size = new System.Drawing.Size(503, 23);
            this.barraPesquisa.TabIndex = 3;
            this.barraPesquisa.TextChanged += new System.EventHandler(this.barraPesquisa_TextChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(32, 138);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(731, 235);
            this.dataGridView.TabIndex = 5;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(351, 401);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(80, 27);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Voltar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Pesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.barraPesquisa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FiltroAvanc);
            this.Name = "Pesquisar";
            this.Text = "Pesquisar";
            this.Load += new System.EventHandler(this.Pesquisar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FiltroAvanc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox barraPesquisa;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnSair;
    }
}