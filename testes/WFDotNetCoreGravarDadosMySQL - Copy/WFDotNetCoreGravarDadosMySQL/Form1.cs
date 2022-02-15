using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WFDotNetCoreGravarDadosMySQL {
    public partial class Form1 : Form {

        private MySqlConnection conexao;
        private string data_source = "datasource=127.0.0.1;username=root;password=962392087#Luiz;database=db_agenda;";


        public Form1() {
            InitializeComponent();

            lst_contatos.View = View.Details;
            lst_contatos.LabelEdit = true;
            lst_contatos.AllowColumnReorder = true;
            lst_contatos.FullRowSelect = true;
            lst_contatos.GridLines = true;

            lst_contatos.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("Nome", 100, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("E-mail", 100, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("Telefone", 100, HorizontalAlignment.Left);
        }

        private void button1_Click(object sender, EventArgs e) {
            try {


            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally{
                conexao.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            try {
                

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                conexao.Close();
                conexao.Dispose();
            }

        }
    }
}
