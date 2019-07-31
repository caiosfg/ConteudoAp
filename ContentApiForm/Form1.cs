using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using System.Threading;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;
using ContentApiForm.Control;

namespace ContentApiForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ImportaConteudo_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();

            timer1.Start();
            progressBar.Increment(100);

            //Endereco do JSON
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string endereco = client.DownloadString("https://api-content.ingresso.com/v0/templates/highlights/1/partnership/home");

            //Deserialize JSON
            dynamic contbody = JsonConvert.DeserializeObject<dynamic>(endereco);
            timer1.Stop();

            //Cria Pasta do Diretorio
            System.IO.Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory), "CsvFolder"));

            //Inseri CSV e Dados
            string strPath = Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory), @"CsvFolder", "testedata.csv");
            StreamWriter sw = new StreamWriter(strPath, true);
            
            sw.WriteLine(contbody);
            sw.Close();
           
            //Exibe no TextBox e Caixa
            txtConteudo.Text = endereco;

            MessageBox.Show("Excel Salvo com Sucesso !");

           
        }
   
        private void Compactar_Click(object sender, EventArgs e)
        {
            //Abre Editor de Seleção e Envia Dados
            using (var folderBrowser = new FolderBrowserDialog())
            {
                folderBrowser.Description = "Selecione a Pasta do Arquivo";

                if (folderBrowser.ShowDialog()== DialogResult.OK)
                {
                    ZipDir(folderBrowser.SelectedPath);

                }
            }

        }

        public static void ZipDir(string dir)
        {
            //Cria um arquivo Zip que contem o Arquivo
            string diretorio = Path.GetDirectoryName(dir);
            Process.Start(diretorio);
            string nome = Path.GetFileName(dir);
            string nomeArquivo = Path.Combine(diretorio, nome + ".zip");
            try
            {
                ZipFile.CreateFromDirectory(dir, nomeArquivo, CompressionLevel.Fastest, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Sender_Click(object sender, EventArgs e)
        {

          Mail m = new Mail();
            //Chama o metodo com o arquivo selecionado
            using (var fileBrowser = new OpenFileDialog())
            {
                fileBrowser.Title = "Informe o Arquivo para anexo";

                if (fileBrowser.ShowDialog() == DialogResult.OK)
                {
                    m.Envia(fileBrowser.FileName);

                }
            }
            

        }
    }

}
