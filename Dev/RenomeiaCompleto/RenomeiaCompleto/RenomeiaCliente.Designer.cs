namespace RenomeiaCompleto {
    partial class RenomeiaCliente {
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_caminho = new System.Windows.Forms.TextBox();
            this.bt_RenomeiaXmlLoja = new System.Windows.Forms.Button();
            this.bt_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite o caminho dos XMLs:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_caminho
            // 
            this.txt_caminho.Location = new System.Drawing.Point(27, 49);
            this.txt_caminho.Name = "txt_caminho";
            this.txt_caminho.Size = new System.Drawing.Size(241, 20);
            this.txt_caminho.TabIndex = 4;
            this.txt_caminho.TextChanged += new System.EventHandler(this.txt_caminho_TextChanged);
            // 
            // bt_RenomeiaXmlLoja
            // 
            this.bt_RenomeiaXmlLoja.Location = new System.Drawing.Point(70, 75);
            this.bt_RenomeiaXmlLoja.Name = "bt_RenomeiaXmlLoja";
            this.bt_RenomeiaXmlLoja.Size = new System.Drawing.Size(146, 33);
            this.bt_RenomeiaXmlLoja.TabIndex = 3;
            this.bt_RenomeiaXmlLoja.Text = "Renomeiar XMLS";
            this.bt_RenomeiaXmlLoja.UseVisualStyleBackColor = true;
            this.bt_RenomeiaXmlLoja.Click += new System.EventHandler(this.bt_RenomeiaXmlLoja_Click);
            // 
            // bt_voltar
            // 
            this.bt_voltar.Location = new System.Drawing.Point(12, 105);
            this.bt_voltar.Name = "bt_voltar";
            this.bt_voltar.Size = new System.Drawing.Size(56, 24);
            this.bt_voltar.TabIndex = 6;
            this.bt_voltar.Text = "Voltar";
            this.bt_voltar.UseVisualStyleBackColor = true;
            this.bt_voltar.Click += new System.EventHandler(this.bt_voltar_Click);
            // 
            // RenomeiaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 141);
            this.Controls.Add(this.bt_voltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_caminho);
            this.Controls.Add(this.bt_RenomeiaXmlLoja);
            this.Name = "RenomeiaCliente";
            this.Text = "Renomeia Arq. XML p/ Loja";
            this.Load += new System.EventHandler(this.RenomeiaCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_caminho;
        private System.Windows.Forms.Button bt_RenomeiaXmlLoja;
        private System.Windows.Forms.Button bt_voltar;
    }
}