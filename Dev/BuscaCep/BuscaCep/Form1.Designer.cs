namespace BuscaCep
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
            if(disposing && (components != null))
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
            this.txt_busca_cep = new System.Windows.Forms.TextBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.txt_rua = new System.Windows.Forms.TextBox();
            this.bt_busca_cep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_busca_cep
            // 
            this.txt_busca_cep.Location = new System.Drawing.Point(24, 67);
            this.txt_busca_cep.Name = "txt_busca_cep";
            this.txt_busca_cep.Size = new System.Drawing.Size(204, 31);
            this.txt_busca_cep.TabIndex = 0;
            this.txt_busca_cep.TextChanged += new System.EventHandler(this.txt_busca_cep_TextChanged);
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(24, 156);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(304, 31);
            this.txt_cidade.TabIndex = 1;
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(24, 234);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(304, 31);
            this.txt_bairro.TabIndex = 2;
            // 
            // txt_rua
            // 
            this.txt_rua.Location = new System.Drawing.Point(24, 307);
            this.txt_rua.Name = "txt_rua";
            this.txt_rua.Size = new System.Drawing.Size(304, 31);
            this.txt_rua.TabIndex = 3;
            // 
            // bt_busca_cep
            // 
            this.bt_busca_cep.Location = new System.Drawing.Point(234, 67);
            this.bt_busca_cep.Name = "bt_busca_cep";
            this.bt_busca_cep.Size = new System.Drawing.Size(94, 34);
            this.bt_busca_cep.TabIndex = 4;
            this.bt_busca_cep.Text = "Buscar";
            this.bt_busca_cep.UseVisualStyleBackColor = true;
            this.bt_busca_cep.Click += new System.EventHandler(this.bt_busca_cep_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Insira o Cep";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bairro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rua";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 379);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_busca_cep);
            this.Controls.Add(this.txt_rua);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.txt_busca_cep);
            this.Name = "Form1";
            this.Text = "Busca CEP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_busca_cep;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.TextBox txt_rua;
        private System.Windows.Forms.Button bt_busca_cep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
