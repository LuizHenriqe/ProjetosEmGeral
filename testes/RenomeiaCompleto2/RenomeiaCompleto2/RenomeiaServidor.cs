using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RenomeiaCompleto2 {
    public partial class RenomeiaServidor : Form {
        public RenomeiaServidor() {
            InitializeComponent();
        }

        private void bt_renomeiaServidor_Click(object sender, EventArgs e) {
            try {
                string dir = txt_dir.Text;

                string keyword = ls_rede.Text + "-" + txt_loja.Text + "-" + txt_caixa.Text + "_NFCE";

                string[] files = Directory.GetFiles(dir);

                for (int i = 0; i < files.Length; i++) {

                    string caminhoAntigo = files[i];

                    string[] partesCaminhoAntigo = caminhoAntigo.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);

                    string ultimaParte = partesCaminhoAntigo[partesCaminhoAntigo.Length - 1];

                    string newName = keyword + ultimaParte;

                    string newPath = caminhoAntigo.Replace(ultimaParte, "");

                    newPath += newName;

                    File.Move(files[i], newPath);

                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {

                MessageBox.Show("Concluido!!");

            }
        }

        private void bt_voltar_serv_Click(object sender, EventArgs e) {
            
            this.Close();
            Menu menu = new Menu(); 
            menu.Show();
        }
    }
}
