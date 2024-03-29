﻿using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WFDotNetCoreGravarDadosMySQL {
    public partial class Form1 : Form {

        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=1234;database=db_agenda";

        private int? id_contato_selecionado = null;

        public Form1() {
            InitializeComponent();

            lst_contatos.View = View.Details;
            lst_contatos.LabelEdit = true;
            lst_contatos.AllowColumnReorder = true;
            lst_contatos.GridLines = true;
            lst_contatos.MultiSelect = false;
           

            lst_contatos.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("Nome", 100, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("E-mail", 100, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("Telefone", 100, HorizontalAlignment.Left);

            carregar_contatos();
        }

        private void bt_salvar_Click(object sender, EventArgs e) {
            try {
                
                Conexao = new MySqlConnection(data_source);

                Conexao.Open();
                
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao;


                if(id_contato_selecionado == null)
                {
                    cmd.CommandText = "INSERT INTO contato (nome, telefone, email) " +
                                      "VALUES (@nome,@telefone,@email)";

                    // Add valores...
                    cmd.Parameters.AddWithValue("@nome", txt_nome.Text);
                    cmd.Parameters.AddWithValue("@telefone", txt_telefone.Text);
                    cmd.Parameters.AddWithValue("@email", txt_email.Text);

                    cmd.Prepare();


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Contato inserido com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cmd.CommandText = "UPDATE contato SET nome=@nome, telefone=@telefone, email=@email WHERE id=@id";

                    // Add valores...
                    cmd.Parameters.AddWithValue("@nome", txt_nome.Text);
                    cmd.Parameters.AddWithValue("@telefone", txt_telefone.Text);
                    cmd.Parameters.AddWithValue("@email", txt_email.Text);
                    cmd.Parameters.AddWithValue("@id", id_contato_selecionado);


                    cmd.Prepare();


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Contato Atualizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

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

            txt_email.Text = String.Empty;
            txt_nome.Text = String.Empty;
            txt_telefone.Text = String.Empty;


            carregar_contatos();
        }

        private void carregar_contatos()
        {

            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;
                cmd.CommandText = "SELECT * FROM contato ORDER BY id DESC";
                cmd.Prepare();


                MySqlDataReader reader = cmd.ExecuteReader();

                lst_contatos.Items.Clear();

                while (reader.Read())
                {
                    string[] row = {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3)
                    };

                    lst_contatos.Items.Add(new ListViewItem(row));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
                Conexao.Dispose();
            }

        }

        private void bt_buscar_Click(object sender, EventArgs e) {
            try {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open() ;

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection=Conexao;

                cmd.Parameters.AddWithValue("@q","%" + txt_buscar.Text+"%");

                cmd.CommandText = "SELECT * FROM contato WHERE nome LIKE @q OR email LIKE @q";

                cmd.Prepare();


                MySqlDataReader reader = cmd.ExecuteReader();

                lst_contatos.Items.Clear();

                while (reader.Read())
                {
                    string[] row = {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3)
                    };
                    
                    lst_contatos.Items.Add(new ListViewItem(row));    
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

        private void lst_contatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lst_contatos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) 
        {
            ListView.SelectedListViewItemCollection itens_selecionados = lst_contatos.SelectedItems;

            foreach (ListViewItem item in itens_selecionados)
            {
                id_contato_selecionado = Convert.ToInt32(item.SubItems[0].Text);

                txt_nome.Text = item.SubItems[1].Text;
                txt_telefone.Text = item.SubItems[2].Text;
                txt_email.Text = item.SubItems[3].Text;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
