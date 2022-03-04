namespace WFDotNetCoreGravarDadosMySQL {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.lst_contatos = new System.Windows.Forms.ListView();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(36, 54);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(184, 20);
            this.txt_nome.TabIndex = 3;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(36, 93);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(184, 20);
            this.txt_telefone.TabIndex = 4;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(36, 132);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(184, 20);
            this.txt_email.TabIndex = 5;
            // 
            // bt_salvar
            // 
            this.bt_salvar.Location = new System.Drawing.Point(145, 176);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(75, 23);
            this.bt_salvar.TabIndex = 6;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = true;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // lst_contatos
            // 
            this.lst_contatos.HideSelection = false;
            this.lst_contatos.Location = new System.Drawing.Point(236, 85);
            this.lst_contatos.MultiSelect = false;
            this.lst_contatos.Name = "lst_contatos";
            this.lst_contatos.Size = new System.Drawing.Size(357, 267);
            this.lst_contatos.TabIndex = 7;
            this.lst_contatos.UseCompatibleStateImageBehavior = false;
            this.lst_contatos.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lst_contatos_ItemSelectionChanged);
            this.lst_contatos.SelectedIndexChanged += new System.EventHandler(this.lst_contatos_SelectedIndexChanged);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(236, 56);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(299, 20);
            this.txt_buscar.TabIndex = 8;
            // 
            // bt_buscar
            // 
            this.bt_buscar.Location = new System.Drawing.Point(541, 56);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(52, 20);
            this.bt_buscar.TabIndex = 9;
            this.bt_buscar.Text = "Buscar";
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.bt_buscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Busca Contato:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 388);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_buscar);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.lst_contatos);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.ListView lst_contatos;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.Label label4;
    }
}

