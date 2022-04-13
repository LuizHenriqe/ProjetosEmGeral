
namespace BaixaJsonTxt
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
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtPathDest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.mskDtIni = new System.Windows.Forms.MaskedTextBox();
            this.mskDtFim = new System.Windows.Forms.MaskedTextBox();
            this.txtRetorno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(13, 48);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(695, 23);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.Text = "https://wwwint.updinet.com.br/APIs_UPDI/ApiDataExport/Revenue?initialDate=AAAI-MI" +
    "-DI&finalDate=AAAF-MF-DF";
            // 
            // txtPathDest
            // 
            this.txtPathDest.Location = new System.Drawing.Point(13, 245);
            this.txtPathDest.Name = "txtPathDest";
            this.txtPathDest.Size = new System.Drawing.Size(396, 23);
            this.txtPathDest.TabIndex = 3;
            this.txtPathDest.Text = "C:\\TEMP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "DATA INICIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "DATA FIM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "DESTINO JSON";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(596, 395);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(112, 36);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(602, 104);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(106, 84);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnProcessar
            // 
            this.btnProcessar.Location = new System.Drawing.Point(602, 237);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(106, 36);
            this.btnProcessar.TabIndex = 10;
            this.btnProcessar.Text = "PROCESSAR";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // mskDtIni
            // 
            this.mskDtIni.Location = new System.Drawing.Point(13, 111);
            this.mskDtIni.Mask = "0000-00-00";
            this.mskDtIni.Name = "mskDtIni";
            this.mskDtIni.Size = new System.Drawing.Size(161, 23);
            this.mskDtIni.TabIndex = 11;
            this.mskDtIni.ValidatingType = typeof(System.DateTime);
            this.mskDtIni.MaskChanged += new System.EventHandler(this.mskDtIni_MaskChanged);
            this.mskDtIni.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskDtIni_MaskInputRejected);
            this.mskDtIni.Leave += new System.EventHandler(this.mskDtIni_Leave);
            // 
            // mskDtFim
            // 
            this.mskDtFim.Location = new System.Drawing.Point(13, 165);
            this.mskDtFim.Mask = "0000-00-00";
            this.mskDtFim.Name = "mskDtFim";
            this.mskDtFim.Size = new System.Drawing.Size(161, 23);
            this.mskDtFim.TabIndex = 12;
            this.mskDtFim.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskDtFim_MaskInputRejected);
            this.mskDtFim.Leave += new System.EventHandler(this.mskDtFim_Leave);
            // 
            // txtRetorno
            // 
            this.txtRetorno.Location = new System.Drawing.Point(16, 305);
            this.txtRetorno.Multiline = true;
            this.txtRetorno.Name = "txtRetorno";
            this.txtRetorno.Size = new System.Drawing.Size(545, 125);
            this.txtRetorno.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.txtRetorno);
            this.Controls.Add(this.mskDtFim);
            this.Controls.Add(this.mskDtIni);
            this.Controls.Add(this.btnProcessar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPathDest);
            this.Controls.Add(this.txtUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtPathDest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.MaskedTextBox mskDtIni;
        private System.Windows.Forms.MaskedTextBox mskDtFim;
        private System.Windows.Forms.TextBox txtRetorno;
    }
}

