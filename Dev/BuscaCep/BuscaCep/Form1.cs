using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaCep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_busca_cep_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_busca_cep_Click(object sender, EventArgs e)
        {
            using( var ws = new WSCorreios.AtendeClienteClient())
            {
                var resultado = ws.consultaCEPAsync(txt_busca_cep.Text);
                txt_cidade.Text = resultado.Result.@return.uf;
                txt_bairro.Text = resultado.Result.@return.bairro;
                txt_rua.Text = resultado.Result.@return.end;
            }
        }
    }
}
