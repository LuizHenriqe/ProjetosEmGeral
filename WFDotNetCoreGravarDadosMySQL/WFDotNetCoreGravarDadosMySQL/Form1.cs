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

namespace WFDotNetCoreGravarDadosMySQL
{
    public partial class Form1 : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=962392087#Luiz;database=db_agenda";
        public Form1()
        {
            InitializeComponent();

            lst_contatos.Columns.Add("ID",30,HorizontalAlignment.Left);
            lst_contatos.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("E-mail", 150, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("Telefone", 150, HorizontalAlignment.Left);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                // criar Conexao com Mysql
                Conexao = new MySqlConnection(data_source);

                string sql = "INSERT INTO contato(nome,email,telefone) " +
                             "VALUES('" + txtNome.Text + "', '" + txtEmail.Text + "','" + txtTelefone.Text + "')";

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Inserido os dados!");
                //Executar comando Insert

                txtEmail.Clear();
                txtTelefone.Clear();
                txtNome.Clear();

            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }finally
            {
                Conexao.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);

                string querySQL = " '%" + txt_buscar.Text + "%' ";

                string sql = "SELECT * FROM contato WHERE " +
                    "nome LIKE" + querySQL + "OR email LIKE" + querySQL;

                Conexao.Open();

                // Executar comando:
                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader ler = comando.ExecuteReader();

                lst_contatos.Items.Clear();

                while (ler.Read())
                {
                    string[] row = {
                        ler.GetString(0),
                        ler.GetString(1),
                        ler.GetString(2),
                        ler.GetString(3),
                    };

                    var linha_listView = new ListViewItem(row);

                    lst_contatos.Items.Add(linha_listView);
                }

            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}
