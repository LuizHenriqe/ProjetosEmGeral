namespace RenomeiaCompleto2 {
    partial class RenomeiaServidor {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.bt_voltar_serv = new System.Windows.Forms.Button();
            this.ls_rede = new System.Windows.Forms.ListBox();
            this.bt_renomeiaServidor = new System.Windows.Forms.Button();
            this.txt_caixa = new System.Windows.Forms.TextBox();
            this.txt_loja = new System.Windows.Forms.TextBox();
            this.txt_dir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_voltar_serv
            // 
            this.bt_voltar_serv.Location = new System.Drawing.Point(25, 212);
            this.bt_voltar_serv.Name = "bt_voltar_serv";
            this.bt_voltar_serv.Size = new System.Drawing.Size(49, 21);
            this.bt_voltar_serv.TabIndex = 29;
            this.bt_voltar_serv.Text = "Voltar";
            this.bt_voltar_serv.UseVisualStyleBackColor = true;
            this.bt_voltar_serv.Click += new System.EventHandler(this.bt_voltar_serv_Click);
            // 
            // ls_rede
            // 
            this.ls_rede.FormattingEnabled = true;
            this.ls_rede.Items.AddRange(new object[] {
            "0001",
            "0005",
            "0007",
            "0011",
            "0032",
            "0033",
            "0035",
            "0036",
            "0039"});
            this.ls_rede.Location = new System.Drawing.Point(25, 86);
            this.ls_rede.Name = "ls_rede";
            this.ls_rede.Size = new System.Drawing.Size(88, 108);
            this.ls_rede.TabIndex = 28;
            // 
            // bt_renomeiaServidor
            // 
            this.bt_renomeiaServidor.Location = new System.Drawing.Point(130, 180);
            this.bt_renomeiaServidor.Name = "bt_renomeiaServidor";
            this.bt_renomeiaServidor.Size = new System.Drawing.Size(143, 53);
            this.bt_renomeiaServidor.TabIndex = 27;
            this.bt_renomeiaServidor.Text = "Renomeiar p/ Servidor";
            this.bt_renomeiaServidor.UseVisualStyleBackColor = true;
            this.bt_renomeiaServidor.Click += new System.EventHandler(this.bt_renomeiaServidor_Click);
            // 
            // txt_caixa
            // 
            this.txt_caixa.Location = new System.Drawing.Point(130, 139);
            this.txt_caixa.Name = "txt_caixa";
            this.txt_caixa.Size = new System.Drawing.Size(143, 20);
            this.txt_caixa.TabIndex = 26;
            // 
            // txt_loja
            // 
            this.txt_loja.Location = new System.Drawing.Point(130, 86);
            this.txt_loja.Name = "txt_loja";
            this.txt_loja.Size = new System.Drawing.Size(143, 20);
            this.txt_loja.TabIndex = 25;
            // 
            // txt_dir
            // 
            this.txt_dir.Location = new System.Drawing.Point(25, 38);
            this.txt_dir.Name = "txt_dir";
            this.txt_dir.Size = new System.Drawing.Size(248, 20);
            this.txt_dir.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Caixa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Loja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Rede:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Caminho p/ renomeiar:";
            // 
            // RenomeiaServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 254);
            this.Controls.Add(this.bt_voltar_serv);
            this.Controls.Add(this.ls_rede);
            this.Controls.Add(this.bt_renomeiaServidor);
            this.Controls.Add(this.txt_caixa);
            this.Controls.Add(this.txt_loja);
            this.Controls.Add(this.txt_dir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RenomeiaServidor";
            this.Text = "RenomeiaServidor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_voltar_serv;
        private System.Windows.Forms.ListBox ls_rede;
        private System.Windows.Forms.Button bt_renomeiaServidor;
        private System.Windows.Forms.TextBox txt_caixa;
        private System.Windows.Forms.TextBox txt_loja;
        private System.Windows.Forms.TextBox txt_dir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}