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

namespace RenomeiaCompleto {
    public partial class Menu : Form {
        
        
        public Menu() {
            InitializeComponent();
        }

        private void bt_renomeiaMaquina_Click(object sender, EventArgs e) {
            RenomeiaCliente abriRenomeiaCliente = new RenomeiaCliente();
            abriRenomeiaCliente.Show();

        }

        private void bt_renomeiaServidor_Click(object sender, EventArgs e) {
            RenomeiaServidor abriRenomeiaServidor = new RenomeiaServidor();
            abriRenomeiaServidor.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e) {
            
        }

    }
}
