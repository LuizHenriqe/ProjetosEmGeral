namespace RenomeiaCompleto {
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
            this.bt_renomeiaMaquina = new System.Windows.Forms.Button();
            this.bt_renomeiaSevidor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_renomeiaMaquina
            // 
            this.bt_renomeiaMaquina.Location = new System.Drawing.Point(36, 28);
            this.bt_renomeiaMaquina.Name = "bt_renomeiaMaquina";
            this.bt_renomeiaMaquina.Size = new System.Drawing.Size(151, 34);
            this.bt_renomeiaMaquina.TabIndex = 0;
            this.bt_renomeiaMaquina.Text = "Renomeia p/ Loja";
            this.bt_renomeiaMaquina.UseVisualStyleBackColor = true;
            this.bt_renomeiaMaquina.Click += new System.EventHandler(this.bt_renomeiaMaquina_Click);
            // 
            // bt_renomeiaSevidor
            // 
            this.bt_renomeiaSevidor.Location = new System.Drawing.Point(36, 92);
            this.bt_renomeiaSevidor.Name = "bt_renomeiaSevidor";
            this.bt_renomeiaSevidor.Size = new System.Drawing.Size(151, 34);
            this.bt_renomeiaSevidor.TabIndex = 1;
            this.bt_renomeiaSevidor.Text = "Renomeia p/ Servidor";
            this.bt_renomeiaSevidor.UseVisualStyleBackColor = true;
            this.bt_renomeiaSevidor.Click += new System.EventHandler(this.bt_renomeiaServidor_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 157);
            this.Controls.Add(this.bt_renomeiaSevidor);
            this.Controls.Add(this.bt_renomeiaMaquina);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_renomeiaMaquina;
        private System.Windows.Forms.Button bt_renomeiaSevidor;
    }
}