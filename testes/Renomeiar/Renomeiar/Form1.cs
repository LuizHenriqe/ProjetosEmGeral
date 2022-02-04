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

namespace Renomeiar {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            {
                Renomear();
            }
        }
        public void Renomear() {
            try {
                string dir = txt_caminho.Text;
                string keyword = "NFCE";

                //Pega todos arquivos.
                var files = Directory.GetFiles(dir, "*.xml");

                for (int i = 0; i < files.Length; i++) {

                    // divide arquivo por arquivo 
                    string oldPath = files[i];

                     // a array separa o caminho todo a cada -> "\\" colocando cada 
                    // parte de um caminho dentro dos indices na variavel
                    string[] partsPath = oldPath.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);

                     // pega o ultimo item do caminho que seria o nome do xml completo por exemplo
                    // 0001-000022-001_NFCE35211109350859000103650010000422281011211329-NFCE.XML
                    string lastPart = partsPath[partsPath.Length - 1];


                     // cria um novo caminho
                    //
                    string newPath = oldPath.Replace(lastPart, "");

                    //
                    int indexNFCE = lastPart.IndexOf(keyword);

                    if (indexNFCE > 0 ) {
                        //começa na posição 20 no nome do arquivo, apo isso ele escreve ate posição 53 posiçoes no nome do arquivo
                        string newName = lastPart.Substring(indexNFCE+keyword.Length,lastPart.Length-indexNFCE - keyword.Length);

                        newPath += newName;
                        File.Move(files[i], newPath);

                    }
                    else {

                    }
                }
            }
            catch(Exception ex) {

                MessageBox.Show(ex.Message);
            }
            finally {
                MessageBox.Show("Concluido!!");
            }

        }

        private void txt_caminho_TextChanged(object sender, EventArgs e) {

        }
    }
}
