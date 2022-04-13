using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenomeiaCompleto2 {
    public partial class Menu : Form {
        public Menu() {
            InitializeComponent();
        }

        private void bt_renomeiaLoja_Click(object sender, EventArgs e) {
            try {
                RenomeiaLoja renomeiaLoja = new RenomeiaLoja();
                
                renomeiaLoja.Show();
                this.Hide();
            }
            catch (Exception ex) { 
            MessageBox.Show(ex.Message);
            }
        }

        private void bt_renomeiaSevidor_Click(object sender, EventArgs e) {
            try { 
            RenomeiaServidor renomeiaServidor = new RenomeiaServidor();
            
            renomeiaServidor.Show();
                this.Hide();
            }
            catch (Exception ex) { 
            MessageBox.Show(ex.Message);
            }
        }
    }
}
