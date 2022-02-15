using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WFDotNetCoreGravarDadosMySQL {
    public partial class Form1 : Form {

        private MySqlConnection Conexao;
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
            lst_contatos.Columns.Add("Telefone", 100, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("E-mail", 100, HorizontalAlignment.Left);
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                
                Conexao= new MySqlConnection(data_source);

                Conexao.Open();
                
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao;

                cmd.Parameters.AddWithValue("@nome",txt_nome.Text);
                cmd.Parameters.AddWithValue("@telefone", txt_telefone.Text);
                cmd.Parameters.AddWithValue("@email", txt_email.Text);

                cmd.CommandText = "INSERT INTO contato (nome, telefone, email) " +
                                  "VALUES (@nome,@telefone,@email)";
                cmd.Prepare();


                cmd.ExecuteNonQuery();

                MessageBox.Show("Contato inserido com sucesso!","Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex) {
                MessageBox.Show("Erros "+ ex.Number +" socorreu: "+ ex.Message,
                                "Erro ", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception ex) {
                MessageBox.Show("ocorreu: " + ex.Message,
                                "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                Conexao.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            try {
                Conexao = new MySqlConnection(data_source);

                string q = " '%"+txt_buscar.Text+"%' ";
                string sql = "SELECT * FROM contato WHERE nome LIKE"+q+"OR email LIKE"+q;

                Conexao.Open();

                //vincular comando.
                MySqlCommand comando = new MySqlCommand(sql, Conexao);

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
                Conexao.Close();
                Conexao.Dispose();
            }

        }
    }
}
