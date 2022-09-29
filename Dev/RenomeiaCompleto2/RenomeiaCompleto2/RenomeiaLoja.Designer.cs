namespace RenomeiaCompleto2 {
    partial class RenomeiaLoja {
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
            this.bt_voltar_loja = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_caminho = new System.Windows.Forms.TextBox();
            this.bt_RenomeiaLoja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_voltar_loja
            // 
            this.bt_voltar_loja.Location = new System.Drawing.Point(26, 73);
            this.bt_voltar_loja.Name = "bt_voltar_loja";
            this.bt_voltar_loja.Size = new System.Drawing.Size(56, 24);
            this.bt_voltar_loja.TabIndex = 10;
            this.bt_voltar_loja.Text = "Voltar";
            this.bt_voltar_loja.UseVisualStyleBackColor = true;
            this.bt_voltar_loja.Click += new System.EventHandler(this.bt_voltar_loja_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Digite o caminho dos XMLs:";
            // 
            // txt_caminho
            // 
            this.txt_caminho.Location = new System.Drawing.Point(26, 38);
            this.txt_caminho.Name = "txt_caminho";
            this.txt_caminho.Size = new System.Drawing.Size(241, 20);
            this.txt_caminho.TabIndex = 8;
            this.txt_caminho.TextChanged += new System.EventHandler(this.txt_caminho_TextChanged);
            // 
            // bt_RenomeiaLoja
            // 
            this.bt_RenomeiaLoja.Location = new System.Drawing.Point(121, 64);
            this.bt_RenomeiaLoja.Name = "bt_RenomeiaLoja";
            this.bt_RenomeiaLoja.Size = new System.Drawing.Size(146, 33);
            this.bt_RenomeiaLoja.TabIndex = 7;
            this.bt_RenomeiaLoja.Text = "Renomeiar XMLS";
            this.bt_RenomeiaLoja.UseVisualStyleBackColor = true;
            this.bt_RenomeiaLoja.Click += new System.EventHandler(this.bt_RenomeiaLoja_Click);
            // 
            // RenomeiaLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 111);
            this.Controls.Add(this.bt_voltar_loja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_caminho);
            this.Controls.Add(this.bt_RenomeiaLoja);
            this.Name = "RenomeiaLoja";
            this.Text = "RenomeiaLoja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_voltar_loja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_caminho;
        private System.Windows.Forms.Button bt_RenomeiaLoja;
    }
}