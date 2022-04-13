
using System;
using System.Windows.Forms;


namespace WFDotNetCoreGravarDadosMySQL {
    public partial class Form1 : Form {
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
            // instanciando variaveis
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            cmd = new MySql.Data.MySqlClient.MySqlCommand();

            conn.ConnectionString= data_source;

            try {
                // open connection.
                conn.Open();
                cmd.Connection = conn;

                cmd.Parameters.AddWithValue("@nome", txt_nome.Text);
                cmd.Parameters.AddWithValue("@telefone", txt_telefone.Text);
                cmd.Parameters.AddWithValue("@email", txt_email.Text);


                cmd.CommandText = "INSERT INTO contato (nome, telefone, email)" +
                    " VALUES(@nome, @telefone, @email)";
                cmd.Prepare();


                cmd.ExecuteNonQuery();

                txt_nome.Clear();
                txt_telefone.Clear();
                txt_email.Clear();

                MessageBox.Show("Concluido!");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally{
                conn.Close();
                conn.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            try {
                

            }
            
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
  
            }
            

        }
        private string data_source = "datasource=127.0.0.1;username=root;password=962392087#Luiz;database=db_agenda;";

        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlCommand cmd;
    }
}
