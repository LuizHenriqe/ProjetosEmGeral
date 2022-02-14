using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WFDotNetCoreGravarDadosMySQL {
    public partial class Form1 : Form {

        private MySqlConnection conexao;
        private string data_source = "datasource=127.0.0.1;username=root;password=962392087#Luiz;database=db_agenda;";


        public Form1() {
            InitializeComponent();

            lst_contatos.View = View.Details;
            //lst_contatos.LabelEdit = true;
            //lst_contatos.AllowColumnReorder = true;
            //lst_contatos.FullRowSelect = true;
            //lst_contatos.GridLines = true;

            lst_contatos.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("Nome", 100, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("E-mail", 100, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("Telefone", 100, HorizontalAlignment.Left);
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                //Cria conexao com MySQL  e instancia o mesmo.
                conexao = new MySqlConnection(data_source);

                string sql = "INSERT INTO contato(nome, telefone, email) " +
                "VALUES('" + txt_nome.Text + "','" + txt_telefone.Text + "','" + txt_email.Text + "'); ";

                conexao.Open();

                // Executa comando INSERT
                MySqlCommand comando = new MySqlCommand(sql,conexao);

                comando.ExecuteReader();

                MessageBox.Show("Comando inserido com sucesso " + sql);

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
                conexao = new MySqlConnection(data_source);

                string q = " '%"+txt_buscar.Text+"%' ";
                string sql = "SELECT * FROM contato WHERE nome LIKE"+q+"OR email LIKE"+q;

                conexao.Open();

                //vincular comando.
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                lst_contatos.Items.Clear();

                while (reader.Read()) {
                    string[] row = {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                    };

                    var linha_listview = new ListViewItem(row);

                    lst_contatos.Items.Add(linha_listview);
                }
                

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
