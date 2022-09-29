namespace RenomeiaCompleto2 {
    partial class Menu {
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
            this.bt_renomeiaSevidor = new System.Windows.Forms.Button();
            this.bt_renomeiaLoja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_renomeiaSevidor
            // 
            this.bt_renomeiaSevidor.Location = new System.Drawing.Point(22, 76);
            this.bt_renomeiaSevidor.Name = "bt_renomeiaSevidor";
            this.bt_renomeiaSevidor.Size = new System.Drawing.Size(151, 34);
            this.bt_renomeiaSevidor.TabIndex = 3;
            this.bt_renomeiaSevidor.Text = "Renomeia p/ Servidor";
            this.bt_renomeiaSevidor.UseVisualStyleBackColor = true;
            this.bt_renomeiaSevidor.Click += new System.EventHandler(this.bt_renomeiaSevidor_Click);
            // 
            // bt_renomeiaLoja
            // 
            this.bt_renomeiaLoja.Location = new System.Drawing.Point(22, 21);
            this.bt_renomeiaLoja.Name = "bt_renomeiaLoja";
            this.bt_renomeiaLoja.Size = new System.Drawing.Size(151, 34);
            this.bt_renomeiaLoja.TabIndex = 2;
            this.bt_renomeiaLoja.Text = "Renomeia p/ Loja";
            this.bt_renomeiaLoja.UseVisualStyleBackColor = true;
            this.bt_renomeiaLoja.Click += new System.EventHandler(this.bt_renomeiaLoja_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 136);
            this.Controls.Add(this.bt_renomeiaSevidor);
            this.Controls.Add(this.bt_renomeiaLoja);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_renomeiaSevidor;
        private System.Windows.Forms.Button bt_renomeiaLoja;
    }
}