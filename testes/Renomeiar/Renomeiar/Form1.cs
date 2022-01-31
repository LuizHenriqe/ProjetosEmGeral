﻿using System;
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

                var files = Directory.GetFiles(dir, "*.xml");

                for (int i = 0; i < files.Length; i++) {

                    string oldPath = files[i];
                    // a  array separa por  \\ colocando cada parte de um caminho dentro dos indices
                    string[] partsPath = oldPath.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);

                    //pega o nome do xml completo 0001-000022-001_NFCE35211109350859000103650010000422281011211329-NFCE.XML
                    string lastPart = partsPath[partsPath.Length - 1];


                    //cria um novo caminho
                    string newPath = oldPath.Replace(lastPart, "");
                    int indexNFCE = lastPart.IndexOf(keyword);

                    if (indexNFCE > 0 ) {
                        //                             //total de 20 posiçoes no nome do arq // total de 20 posiçoes no nome do arquivo
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

        }
    }
}
