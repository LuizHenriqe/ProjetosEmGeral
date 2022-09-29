using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaixaJsonTxt
{
    public partial class Form1 : Form
    {
        string url = "";
        DateTime dataIni;
        DateTime dataFim;

        string dtIni;
        string dtFim;

        string arqDestino;
        string pathDestino;

        string retorno = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Deseja encerrar a aplicação?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            this.Dispose();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRetorno.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mskDtIni.Text = DateTime.Now.ToString("yyyy-MM-dd");
            mskDtFim.Text = DateTime.Now.AddDays(6).ToString("yyyy-MM-dd")+6;
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            txtRetorno.Text = "";

            dataIni = Convert.ToDateTime(mskDtIni.Text);
            dataFim = Convert.ToDateTime(mskDtFim.Text);

            dtIni = dataIni.ToString("yyyy-MM-dd");
            dtFim = dataFim.ToString("yyyy-MM-dd");

            ChamaUrlAsync();
            btnProcessar.Enabled = false;
        }

        public async Task<string> ChamaUrlAsync()
        {
            try
            {
                //var client = new RestClient("https://wwwint.updinet.com.br/APIs_UPDI/ApiDataExport/Revenue?initialDate=2019-05-06&finalDate=2019-05-06");

                txtRetorno.Text = "Em processamento";

                string urlConstr = "https://wwwint.updinet.com.br/APIs_UPDI/ApiDataExport/Revenue?initialDate=" + dtIni + "&finalDate=" + dtFim;

                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(urlConstr);
                httpClient.Timeout = TimeSpan.FromMinutes(100);
                httpClient.DefaultRequestHeaders.Add("token", "5Sgz5oWR9z42IukQHAJ3OOPxN5j22KDN");
                httpClient.DefaultRequestHeaders.Add("clid", "ce8e3df5-6229-49d1-937f-571a7022d20d");
                HttpResponseMessage response = await httpClient.GetAsync(urlConstr);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                //request.AddParameter("text/plain", body, ParameterType.RequestBody);

                const string quote = "\"";
                var retJson = ((responseBody).Replace("\\u0022", quote));

                System.IO.File.WriteAllText(pathDestino, retJson);
                retorno = $"Code: {Convert.ToString(response.StatusCode)} - detalhe: {Convert.ToString(response.RequestMessage)}";
                txtRetorno.Text = retorno;

                btnProcessar.Enabled = true;

                return null;



            }

            catch (Exception ex)
            {
                return null;
            }

        }

        private void mskDtIni_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskDtIni_Leave(object sender, EventArgs e)
        {
            PreparaDados();
        }

        private void mskDtFim_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskDtIni_MaskChanged(object sender, EventArgs e)
        {
         
        }

        public void PreparaDados()
        {
            dataIni = Convert.ToDateTime(mskDtIni.Text);
            dtIni = dataIni.ToString("yyyy-MM-dd");

            mskDtFim.Text = dataIni.AddDays(6).ToString("yyyy-MM-dd") + 6;
            dataFim = Convert.ToDateTime(mskDtFim.Text);
            dtFim = dataFim.ToString("yyyy-MM-dd");

            arqDestino = $"AF {dtIni} a {dtFim}.json";
            pathDestino = $@"C:\temp\{arqDestino}";
            txtPathDest.Text = pathDestino;

        }

        private void mskDtFim_Leave(object sender, EventArgs e)
        {
            dataIni = Convert.ToDateTime(mskDtIni.Text);
            dtIni = dataIni.ToString("yyyy-MM-dd");

            dataFim = Convert.ToDateTime(mskDtFim.Text);
            dtFim = dataFim.ToString("yyyy-MM-dd");

            arqDestino = $"AF {dtIni} a {dtFim}.json";
            pathDestino = $@"C:\temp\{arqDestino}";
            txtPathDest.Text = pathDestino;
        }
    }
}
